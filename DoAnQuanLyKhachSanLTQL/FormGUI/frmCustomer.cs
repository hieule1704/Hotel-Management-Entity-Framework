using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyKhachSanLTQL.Data;
using ClosedXML.Excel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    public partial class frmCustomer : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa) 
        BindingSource bindingSource = new BindingSource(); // Tạo một BindingSource để trung gian giữa dữ liệu và UI.



        public frmCustomer()
        {
            InitializeComponent();
            this.AllowDrop = true; // Enable drag-and-drop
            this.DragEnter += frmCustomer_DragEnter;
            this.DragDrop += frmCustomer_DragDrop;
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
            txtCreditCard.Enabled = giaTri;
            txtIdProof.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
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

            txtCreditCard.DataBindings.Clear();
            txtCreditCard.DataBindings.Add("Text", bindingSource, "CreditCard", false, DataSourceUpdateMode.Never);

            txtIdProof.DataBindings.Clear();
            txtIdProof.DataBindings.Add("Text", bindingSource, "IdProof", false, DataSourceUpdateMode.Never);

            comGender.DataBindings.Clear();
            //  với ComboBox, cách phổ biến hơn và tốt hơn là dùng binding với "SelectedValue" hoặc "SelectedItem" thay vì "Text".
            comGender.DataBindings.Add("SelectedItem", bindingSource, "Gender", false, DataSourceUpdateMode.Never);

        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Tạo danh sách giới tính
            List<string> dsGioiTinh = new List<string> { "Nam", "Nữ", "Giới tính thứ 3" };
            // Gán danh sách làm DataSource của ComboBox
            comGender.DataSource = dsGioiTinh;

            List<Customer> kh = new List<Customer>();
            kh = context.Customers.ToList();

            bindingSource.DataSource = kh;

            BindControls(bindingSource); // Đổ dữ liệu lên các field nhập

            dgvCustomer.DataSource = bindingSource; // Gán bindingSource làm nguồn dữ liệu cho dgvCustomer (DataGridView).
            // Khi người dùng chọn một dòng trên dgvCustomer, các textbox/combobox sẽ hiển thị thông tin tương ứng nhờ data binding.
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtFullName.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtCreditCard.Clear();
            txtIdProof.Clear();
            // comGender.Items.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["CustomerId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtFullName.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["CustomerId"].Value.ToString());
                Customer kh = context.Customers.Find(id);
                if (kh != null)
                {
                    context.Customers.Remove(kh);
                }
                context.SaveChanges();

                frmCustomer_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Customer kh = new Customer();
                    kh.FullName = txtFullName.Text;
                    kh.ContactNumber = txtContactNumber.Text;
                    kh.Address = txtAddress.Text;
                    kh.Email = txtEmail.Text;
                    kh.CreditCard = txtCreditCard.Text;
                    kh.IdProof = txtIdProof.Text;
                    kh.Gender = comGender.SelectedItem.ToString();

                    context.Customers.Add(kh);

                    context.SaveChanges();
                }
                else // Xử lý sửa
                {
                    Customer kh = context.Customers.Find(id);
                    if (kh != null)
                    {
                        kh.FullName = txtFullName.Text;
                        kh.ContactNumber = txtContactNumber.Text;
                        kh.Address = txtAddress.Text;
                        kh.Email = txtEmail.Text;
                        kh.CreditCard = txtCreditCard.Text;
                        kh.IdProof = txtIdProof.Text;
                        kh.Gender = comGender.SelectedItem.ToString();
                        context.Customers.Update(kh);

                        context.SaveChanges();
                    }
                }

                frmCustomer_Load(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmCustomer_Load(sender, e);
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
                                Customer kh = new Customer();
                                kh.FullName = r["FullName"].ToString();
                                kh.ContactNumber = r["ContactNumber"].ToString();
                                kh.Email = r["Email"].ToString();
                                kh.Address = r["Address"].ToString();
                                kh.CreditCard = r["CreditCard"].ToString();
                                kh.IdProof = r["IdProof"].ToString();
                                kh.Gender = r["Gender"].ToString();

                                context.Customers.Add(kh);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmCustomer_Load(sender, e);
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

                    table.Columns.AddRange(new DataColumn[8] { // Đại diện cho 8 trường dữ liệu trong db
                        new DataColumn("CustomerId", typeof(int)),
                        new DataColumn("FullName", typeof(string)),
                        new DataColumn("ContactNumber", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("Address", typeof(string)),
                        new DataColumn("Gender", typeof(string)),
                        new DataColumn("CreditCard", typeof(string)),
                        new DataColumn("IdProof", typeof(string)),
                    });

                    var khachHang = context.Customers.ToList();
                    if (khachHang != null)
                    {
                        foreach (var p in khachHang)
                            table.Rows.Add(p.CustomerId, p.FullName, p.ContactNumber, p.Email, p.Address, p.Gender, p.CreditCard, p.IdProof);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Customer");
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

            var customers = context.Customers
                .Where(r => (r.FullName != null && r.FullName.ToLower().Contains(tuKhoa)) ||
                            (r.IdProof != null && r.IdProof.ToLower().Contains(tuKhoa)))
                .Select(r => new Customer
                {
                    CustomerId = r.CustomerId,
                    FullName = r.FullName,
                    ContactNumber = r.ContactNumber,
                    Address = r.Address,
                    Email = r.Email,
                    CreditCard = r.CreditCard,
                    IdProof = r.IdProof,
                    Gender = r.Gender
                })
                .ToList();

            bindingSource.DataSource = customers;

            BindControls(bindingSource); // Update lại dữ liệu cho các field
        }

        // Handle the DragEnter event
        private void frmCustomer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && (files[0].EndsWith(".xls") || files[0].EndsWith(".xlsx")))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        // Handle the DragDrop event
        private void frmCustomer_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    ImportExcelToDatabase(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Modify the ImportExcelToDatabase method to ensure it doesn't import duplicate data
        private void ImportExcelToDatabase(string filePath)
        {
            try
            {
                DataTable table = new DataTable();
                using (XLWorkbook workbook = new XLWorkbook(filePath))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);
                    bool firstRow = true;
                    string readRange = "1:1";
                    foreach (IXLRow row in worksheet.RowsUsed())
                    {
                        if (firstRow)
                        {
                            readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                            foreach (IXLCell cell in row.Cells(readRange))
                                table.Columns.Add(cell.Value.ToString());
                            firstRow = false;
                        }
                        else
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
                            string idProof = r["IdProof"].ToString();
                            // Check if the customer already exists in the database
                            if (!context.Customers.Any(c => c.IdProof == idProof))
                            {
                                Customer kh = new Customer
                                {
                                    FullName = r["FullName"].ToString(),
                                    ContactNumber = r["ContactNumber"].ToString(),
                                    Email = r["Email"].ToString(),
                                    Address = r["Address"].ToString(),
                                    CreditCard = r["CreditCard"].ToString(),
                                    IdProof = idProof,
                                    Gender = r["Gender"].ToString()
                                };

                                context.Customers.Add(kh);
                            }
                        }
                        context.SaveChanges();

                        MessageBox.Show($"Successfully imported {table.Rows.Count} rows.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmCustomer_Load(this, EventArgs.Empty); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("The Excel file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcessExcelFile(string filePath)
        {
            try
            {
                DataTable table = new DataTable();
                using (XLWorkbook workbook = new XLWorkbook(filePath))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);
                    bool firstRow = true;
                    string readRange = "1:1";
                    foreach (IXLRow row in worksheet.RowsUsed())
                    {
                        if (firstRow)
                        {
                            readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                            foreach (IXLCell cell in row.Cells(readRange))
                                table.Columns.Add(cell.Value.ToString());
                            firstRow = false;
                        }
                        else
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
                            Customer kh = new Customer
                            {
                                FullName = r["FullName"].ToString(),
                                ContactNumber = r["ContactNumber"].ToString(),
                                Email = r["Email"].ToString(),
                                Address = r["Address"].ToString(),
                                CreditCard = r["CreditCard"].ToString(),
                                IdProof = r["IdProof"].ToString(),
                                Gender = r["Gender"].ToString()
                            };

                            context.Customers.Add(kh);
                        }
                        context.SaveChanges();

                        MessageBox.Show($"Successfully imported {table.Rows.Count} rows.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmCustomer_Load(null, null); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("The Excel file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
