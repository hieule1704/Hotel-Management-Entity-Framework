using DoAnQuanLyKhachSanLTQL.Data;
using Slugify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    public partial class frmAccount : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        string id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa) 
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");

        public frmAccount()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;
            txtUsername.Enabled = giaTri;
            txtPassword.Enabled = giaTri;
            cboStaffId.Enabled = giaTri;
            cboStatus.Enabled = giaTri;
            picProfilePicture.Enabled = giaTri;


            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LayTenNhanVienVaoComboBox();
            DoTenQuyenHanVaoCombobox();
            BatTatChucNang(false);

            List<Account> lp = new List<Account>();
            lp = context.Accounts.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lp;

            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", bindingSource, "Username", false, DataSourceUpdateMode.Never);

            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", bindingSource, "Password", false, DataSourceUpdateMode.Never);

            cboStaffId.DataBindings.Clear();
            cboStaffId.DataBindings.Add("SelectedValue", bindingSource, "StaffId", false, DataSourceUpdateMode.Never);

            cboStatus.DataBindings.Clear();
            cboStatus.DataBindings.Add("SelectedValue", bindingSource, "Status", false, DataSourceUpdateMode.Never);

            // Các kết nối ảnh
            picProfilePicture.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "ProfilePicture", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                string fileName = e.Value?.ToString();
                if (string.IsNullOrEmpty(fileName))
                {
                    // Dùng ảnh mặc định khi không có ảnh
                    e.Value = Path.Combine(imagesFolder, "no-image.jpg");
                }
                else
                {
                    e.Value = Path.Combine(imagesFolder, fileName);
                }
            };

            picProfilePicture.DataBindings.Add(hinhAnh);

            dgvAccount.DataSource = bindingSource;
        }

        public void LayTenNhanVienVaoComboBox()
        {
            cboStaffId.DataSource = context.Staffs.ToList();
            cboStaffId.ValueMember = "StaffId";
            cboStaffId.DisplayMember = "FullName";
        }

        public void DoTenQuyenHanVaoCombobox()
        {
            // Khởi tạo danh sách hiển thị
            var listStatus = new List<object>
            {
                new { Text = "Quản lý", Value = true },
                new { Text = "Nhân viên", Value = false }
            };

            cboStatus.DataSource = listStatus;
            cboStatus.DisplayMember = "Text";
            cboStatus.ValueMember = "Value";
        }

        private void dgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAccount.Columns[e.ColumnIndex].Name == "ProfilePicture")
            {
                string fileName = e.Value?.ToString();
                string fullPath;

                if (string.IsNullOrEmpty(fileName))
                {
                    fullPath = Path.Combine(imagesFolder, "no-image.jpg");
                }
                else
                {
                    fullPath = Path.Combine(imagesFolder, fileName);
                    if (!File.Exists(fullPath))
                    {
                        fullPath = Path.Combine(imagesFolder, "no-image.jpg");
                    }
                }

                try
                {
                    using (var tempImg = Image.FromFile(fullPath))
                    {
                        e.Value = new Bitmap(tempImg, 24, 24);
                    }
                }
                catch
                {
                    // Trong trường hợp ảnh bị lỗi, dùng ảnh mặc định
                    e.Value = new Bitmap(24, 24); // ảnh trống
                }
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            //Chọn tập tin hình ảnh cần đổi cho sản phẩm đang chọn
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jgp;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            SlugHelper slug = new SlugHelper();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, slug.GenerateSlug(fileName) + ext); //Đường dẫn lưu file
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                id = dgvAccount.CurrentRow.Cells["Username"].Value.ToString(); // dùng username khóa chính thay cho id
                Account lp = context.Accounts.Find(id);
                lp.ProfilePicture = slug.GenerateSlug(fileName) + ext;
                context.Accounts.Update(lp);

                context.SaveChanges();

                //Tải lại form
                frmAccount_Load(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtPassword.Clear();
            txtUsername.Clear();
            cboStaffId.SelectedValue = -1;
            cboStatus.SelectedValue = -1;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = dgvAccount.CurrentRow.Cells["Username"].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmAccount_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tài khoảng " + txtUsername.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = dgvAccount.CurrentRow.Cells["Username"].Value.ToString();
                Account lp = context.Accounts.Find(id);
                if (lp != null)
                {
                    context.Accounts.Remove(lp);
                }
                context.SaveChanges();

                frmAccount_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                MessageBox.Show("Vui lòng nhập tên tài khoảng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(cboStatus.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboStaffId.Text))
                MessageBox.Show("Vui lòng chọn mã nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Account lp = new Account();
                    lp.Username = txtUsername.Text;
                    lp.Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text); // Mã hóa mật khẩu
                    lp.StaffId = (int)cboStaffId.SelectedValue;
                    lp.Status = (bool)cboStatus.SelectedValue;


                    context.Accounts.Add(lp);

                    context.SaveChanges();
                }
                else
                {
                    Account lp = context.Accounts.Find(id);
                    if (lp != null)
                    {
                        lp.Username = txtUsername.Text;

                        if (string.IsNullOrEmpty(txtPassword.Text))
                            context.Entry(lp).Property(x => x.Password).IsModified = false; // Giữ nguyên mật khẩu cũ 
                        else
                            lp.Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text); // Cập nhật mật khẩu mới 

                        
                        lp.StaffId = (int)cboStaffId.SelectedValue;
                        lp.Status = (bool)cboStatus.SelectedValue;

                        context.SaveChanges();
                    }
                }

                frmAccount_Load(sender, e);
            }
        }
    }
}
