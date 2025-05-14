using ClosedXML.Excel;
using DoAnQuanLyKhachSanLTQL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    public partial class frmStaff : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa) 
        BindingSource bindingSource = new BindingSource(); // Tạo một BindingSource để trung gian giữa dữ liệu và UI.

        public frmStaff()
        {
            InitializeComponent();
        }

        private void BindControls(BindingSource bindingSource)
        {
            //Text là thuộc tính của text box
            txtFullName.DataBindings.Clear();
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", false, DataSourceUpdateMode.Never);

            // Tương tự cho các txt còn lại
            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add("Text", bindingSource, "Address", false, DataSourceUpdateMode.Never);

            txtContactNumber.DataBindings.Clear();
            txtContactNumber.DataBindings.Add("Text", bindingSource, "ContactNumber", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtPosition.DataBindings.Clear();
            txtPosition.DataBindings.Add("Text", bindingSource, "Position", false, DataSourceUpdateMode.Never);

            numSalary.DataBindings.Clear();
            numSalary.DataBindings.Add("Value", bindingSource, "Salary", false, DataSourceUpdateMode.Never);

            comGender.DataBindings.Clear();
            //  với ComboBox, cách phổ biến hơn và tốt hơn là dùng binding với "SelectedValue" hoặc "SelectedItem" thay vì "Text".
            comGender.DataBindings.Add("SelectedItem", bindingSource, "Gender", false, DataSourceUpdateMode.Never);

            // Kiểm tra null cho kiểu dữ liệu datetime trước khi gáng cho control


            dtpBirthday.DataBindings.Clear();
            dtpBirthday.DataBindings.Add("Value", bindingSource, "Birthday", false, DataSourceUpdateMode.Never, DateTime.Now); // Thêm dòng DateTime.Now để phòng trường hợp giá trị Null không bị lỗi DateTimePicker
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvStaff.AutoGenerateColumns = false;

            List<Staff> nv = context.Staffs.ToList();
            bindingSource.DataSource = nv;

            if (nv.Any())
            {
                BindControls(bindingSource);
            }
            else
            {
                ClearControls(); // Không có nhân viên nào thì clear giao diện
            }

            dgvStaff.DataSource = bindingSource;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;
            txtFullName.Enabled = giaTri;
            txtContactNumber.Enabled = giaTri;
            txtAddress.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            comGender.Enabled = giaTri;
            txtPosition.Enabled = giaTri;
            numSalary.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            ClearControls(); // Xóa dữ liệu trong các control
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["StaffId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtFullName.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvStaff.CurrentRow.Cells["StaffId"].Value.ToString());
                Staff nv = context.Staffs.Find(id);
                if (nv != null)
                {
                    context.Staffs.Remove(nv);
                }
                context.SaveChanges();

                frmStaff_Load(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmStaff_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Staff nv = new Staff();
                    nv.FullName = txtFullName.Text;
                    nv.ContactNumber = txtContactNumber.Text;
                    nv.Address = txtAddress.Text;
                    nv.Email = txtEmail.Text;
                    nv.Position = txtPosition.Text;
                    nv.Salary = numSalary.Value;
                    nv.Gender = comGender.SelectedItem.ToString();
                    nv.Birthday = dtpBirthday.Value;

                    context.Staffs.Add(nv);

                    context.SaveChanges();
                }
                else // Xử lý sửa
                {
                    Staff nv = context.Staffs.Find(id);
                    if (nv != null)
                    {
                        nv.FullName = txtFullName.Text;
                        nv.ContactNumber = txtContactNumber.Text;
                        nv.Address = txtAddress.Text;
                        nv.Email = txtEmail.Text;
                        nv.Position = txtPosition.Text;
                        nv.Salary = numSalary.Value;
                        nv.Gender = comGender.SelectedItem.ToString();
                        nv.Birthday = dtpBirthday.Value;

                        context.Staffs.Update(nv);

                        context.SaveChanges();
                    }
                }

                frmStaff_Load(sender, e);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên) 
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo) 
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                Staff nv = new Staff();

                                nv.FullName = r["FullName"].ToString();
                                nv.ContactNumber = r["ContactNumber"].ToString();
                                nv.Address = r["Address"].ToString();
                                nv.Email = r["Email"].ToString();
                                nv.Position = r["Position"].ToString();

                                // Kiểm tra và ép kiểu Salary
                                if (decimal.TryParse(r["Salary"]?.ToString(), out decimal salary))
                                {
                                    nv.Salary = salary;
                                }
                                else
                                {
                                    nv.Salary = 0; // hoặc gán giá trị mặc định phù hợp
                                }

                                nv.Gender = r["Gender"].ToString();

                                // Kiểm tra và ép kiểu Birthday
                                if (DateTime.TryParse(r["Birthday"]?.ToString(), out DateTime birthday))
                                {
                                    nv.Birthday = birthday;
                                }
                                else
                                {
                                    nv.Birthday = new DateTime(2000, 1, 1); // hoặc gán giá trị mặc định phù hợp
                                }

                                context.Staffs.Add(nv);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmStaff_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "LoaiSanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[9] { // Đại diện cho 9 trường dữ liệu trong db
                        new DataColumn("StaffId", typeof(int)),
                        new DataColumn("FullName", typeof(string)),
                        new DataColumn("Position", typeof(string)),
                        new DataColumn("ContactNumber", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("Address", typeof(string)),
                        new DataColumn("Birthday", typeof(DateTime)),
                        new DataColumn("Gender", typeof(string)),
                        new DataColumn("Salary", typeof(decimal)),

                    });

                    var nhanVien = context.Staffs.ToList();
                    if (nhanVien != null)
                    {
                        foreach (var nv in nhanVien)
                            table.Rows.Add(nv.StaffId, nv.FullName, nv.Position, nv.ContactNumber, nv.Email, nv.Address, nv.Birthday, nv.Gender, nv.Salary);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Staff");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower();

            var staffs = context.Staffs
                .Where(r => (r.FullName != null && r.FullName.ToLower().Contains(tuKhoa)) ||
                            (r.Position != null && r.Position.ToLower().Contains(tuKhoa)))
                .Select(r => new Staff
                {
                    StaffId = r.StaffId,
                    FullName = r.FullName,
                    Position = r.Position,
                    ContactNumber = r.ContactNumber,
                    Address = r.Address,
                    Email = r.Email,
                    Salary = r.Salary,
                    Gender = r.Gender,
                    Birthday = (r.Birthday != null && r.Birthday >= dtpBirthday.MinDate && r.Birthday <= dtpBirthday.MaxDate)
                        ? r.Birthday
                        : dtpBirthday.MinDate
                })
                .ToList();

            // Skip binding and update DataGridView to empty if no results are found
            if (staffs.Count == 0)
            {
                ClearControls(); // Clear the UI controls
                dgvStaff.DataSource = null; // Clear the DataGridView
                return;
            }

            bindingSource.DataSource = staffs;
            dgvStaff.DataSource = bindingSource; // Ensure DataGridView is updated, phải giữ dòng này không thôi sau khi text thay đổi nó vẫn giữ datagridview null
            BindControls(bindingSource);
        }



        private void ClearControls()
        {
            txtFullName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPosition.Text = string.Empty;
            numSalary.Value = numSalary.Minimum;
            comGender.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Now; // hoặc một giá trị mặc định hợp lệ
        }

        private void tSbtnNhap_Click(object sender, EventArgs e)
        {
            btnNhap_Click(sender, e);
        }

        private void tSbtnXuat_Click(object sender, EventArgs e)
        {
            btnXuat_Click(sender, e);
        }
    }
}
