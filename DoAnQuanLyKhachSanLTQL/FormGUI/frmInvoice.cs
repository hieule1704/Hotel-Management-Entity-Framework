using ClosedXML.Excel;
using DoAnQuanLyKhachSanLTQL.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmInvoice : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa) .

        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            dgvInvoice.AutoGenerateColumns = false;

            List<InvoiceList> hd = new List<InvoiceList>();

            hd = context.Invoices
            .Include(i => i.Customer)
            .Include(i => i.Staff)
            .Include(i => i.Bookings)
            .Include(i => i.ServiceUses)
            .Select(i => new InvoiceList
            {
                InvoiceId = i.InvoiceId,
                CustomerId = i.CustomerId,
                CustomerName = i.Customer.FullName,
                StaffId = i.StaffId,
                StaffName = i.Staff.FullName,
                InvoiceDate = i.InvoiceDate,
                PaymentType = i.PaymentType,
                TotalAmount = i.Bookings.Sum(b => b.TotalAmount) + i.ServiceUses.Sum(s => s.TotalAmount),
                InvoiceDetail = "Xem chi tiết"
            })
            .ToList();

            dgvInvoice.DataSource = hd; // Lưu ý tên dataproperty trong InvoiceList phải giống với tên cột trong DataGridView thì mới load đúng dữ liệu
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
