using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    public partial class frmBackUpStore : Form
    {
        private readonly string connectionString = @"Server=ETHAN_LEE\SQLEXPRESS;Database=DAQLKS;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
        private readonly string databaseName = "DAQLKS";

        public frmBackUpStore()
        {
            InitializeComponent();
        }

        private async void btnSaoLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "SQL Server Backup (*.bak)|*.bak",
                FileName = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string backupFilePath = saveFile.FileName;

                    // Check if the directory is accessible
                    string directoryPath = Path.GetDirectoryName(backupFilePath);
                    if (!Directory.Exists(directoryPath))
                    {
                        MessageBox.Show("The selected directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Ensure SQL Server has write permissions
                    if (!HasWritePermission(directoryPath))
                    {
                        MessageBox.Show("SQL Server does not have write permissions to the selected directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (File.Exists(backupFilePath))
                    {
                        var result = MessageBox.Show("File already exists. Overwrite?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result != DialogResult.Yes) return;
                    }

                    await Task.Run(() =>
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string backupQuery = $@"
                        BACKUP DATABASE [{databaseName}]
                        TO DISK = @FilePath
                        WITH FORMAT, INIT, NAME = @BackupName;";

                            using (SqlCommand cmd = new SqlCommand(backupQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@FilePath", backupFilePath);
                                cmd.Parameters.AddWithValue("@BackupName", $"{databaseName}-Full Backup");
                                cmd.ExecuteNonQuery();
                            }
                        }
                    });

                    MessageBox.Show("✅ Sao lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Lỗi sao lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool HasWritePermission(string directoryPath)
        {
            try
            {
                // Attempt to create a temporary file to check write permissions
                string tempFilePath = Path.Combine(directoryPath, Path.GetRandomFileName());
                using (FileStream fs = File.Create(tempFilePath, 1, FileOptions.DeleteOnClose)) { }
                return true;
            }
            catch
            {
                return false;
            }
        }


        private async void btnPhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "SQL Server Backup (*.bak)|*.bak",
                Title = "Chọn file sao lưu (.bak) để phục hồi"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!File.Exists(openFile.FileName))
                    {
                        MessageBox.Show("File không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    await Task.Run(() =>
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            string setSingleUser = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                            string restoreQuery = $@"
                                RESTORE DATABASE [{databaseName}]
                                FROM DISK = @FilePath
                                WITH REPLACE;";
                            string setMultiUser = $"ALTER DATABASE [{databaseName}] SET MULTI_USER;";

                            using (SqlCommand cmd = new SqlCommand(setSingleUser + restoreQuery + setMultiUser, conn))
                            {
                                cmd.Parameters.AddWithValue("@FilePath", openFile.FileName);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    });

                    MessageBox.Show("✅ Phục hồi thành công! Ứng dụng sẽ khởi động lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Lỗi phục hồi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
