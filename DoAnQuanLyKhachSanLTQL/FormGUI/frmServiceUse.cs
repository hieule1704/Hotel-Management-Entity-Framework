using DoAnQuanLyKhachSanLTQL.Data;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class frmServiceUse : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int serviceId;
        int invoiceId;
        BindingSource bindingSource = new BindingSource(); // Tạo một BindingSource để trung gian giữa dữ liệu và UI.

        public frmServiceUse()
        {
            InitializeComponent();
        }

        private void txtInvoiceId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmServiceUse_Load(object sender, EventArgs e)
        {
            LoadComboboxData(); // Load dữ liệu cho combobox
            BatTatChucNang(false); // Tắt các nút chức năng

            dgvServiceUse.AutoGenerateColumns = false; // Tắt tự động sinh cột

            List<ServiceUse> list = context.ServiceUses
                .Include(su => su.Invoice)
                .Include(su => su.Service)
                .ToList();

            bindingSource.DataSource = list; // Gán dữ liệu vào BindingSource

            cboInvoiceId.DataBindings.Clear();
            cboServiceName.DataBindings.Clear();
            numQuantity.DataBindings.Clear();
            txtTotalAmount.DataBindings.Clear();

            cboInvoiceId.DataBindings.Add("SelectedValue", bindingSource, "InvoiceId", false, DataSourceUpdateMode.Never);
            cboServiceName.DataBindings.Add("SelectedValue", bindingSource, "ServiceId", false, DataSourceUpdateMode.Never);
            numQuantity.DataBindings.Add("Value", bindingSource, "ServiceQuantity", false, DataSourceUpdateMode.Never);
            txtTotalAmount.DataBindings.Add("Text", bindingSource, "TotalAmount", false, DataSourceUpdateMode.Never);

            dgvServiceUse.DataSource = bindingSource; // Gán BindingSource vào DataGridView
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;
            cboInvoiceId.Enabled = giaTri;
            cboServiceName.Enabled = giaTri;
            numQuantity.Enabled = giaTri;
            txtTotalAmount.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void LoadComboboxData()
        {
            cboInvoiceId.DataSource = context.Invoices.ToList();
            cboInvoiceId.DisplayMember = "InvoiceId"; // hoặc thông tin khách
            cboInvoiceId.ValueMember = "InvoiceId";

            cboServiceName.DataSource = context.Services.ToList();
            cboServiceName.DisplayMember = "ServiceName";
            cboServiceName.ValueMember = "ServiceId";
        }

        private void CalculateTotalAmount()
        {
            if (cboServiceName.SelectedValue != null && numQuantity.Value > 0)
            {
                int serviceId = (int)cboServiceName.SelectedValue;
                var service = context.Services.FirstOrDefault(s => s.ServiceId == serviceId);
                if (service != null)
                {
                    decimal total = service.ServicePrice * numQuantity.Value;
                    txtTotalAmount.Text = total.ToString("N0");
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true; // Đặt biến xuLyThem thành true để chỉ định rằng đang thêm dữ liệu
            BatTatChucNang(true); // Bật các nút chức năng
            cboInvoiceId.Focus(); // Đưa con trỏ vào combobox InvoiceId
            cboInvoiceId.SelectedIndex = -1; // Đặt giá trị mặc định cho combobox InvoiceId
            cboServiceName.SelectedIndex = -1; // Đặt giá trị mặc định cho combobox ServiceName
            numQuantity.Value = 0; // Đặt giá trị mặc định cho số lượng
            txtTotalAmount.Text = ""; // Đặt giá trị mặc định cho tổng tiền
        }

        private void LoadServiceUses()
        {
            var list = context.ServiceUses
                .Include(su => su.Invoice)
                .Include(su => su.Service)
                .Select(su => new
                {
                    su.InvoiceId,
                    Service = su.Service.ServiceName,
                    su.ServiceQuantity,
                    su.TotalAmount
                }).ToList();

            dgvServiceUse.DataSource = list;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboInvoiceId.SelectedValue == null)
                MessageBox.Show("Vui lòng chọn hóa đơn?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboServiceName.SelectedValue == null)
                MessageBox.Show("Vui lòng chọn dịch vụ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numQuantity.Value <= 0)
                MessageBox.Show("Vui lòng nhập số lượng dịch vụ hợp lệ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int selectedServiceId = (int)cboServiceName.SelectedValue;
                int selectedInvoiceId = (int)cboInvoiceId.SelectedValue;
                var service = context.Services.FirstOrDefault(s => s.ServiceId == selectedServiceId);

                if (service == null)
                {
                    MessageBox.Show("Dịch vụ không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalAmount = service.ServicePrice * numQuantity.Value;

                if (xuLyThem)
                {
                    var newServiceUse = new ServiceUse
                    {
                        InvoiceId = selectedInvoiceId,
                        ServiceId = selectedServiceId,
                        ServiceQuantity = (int)numQuantity.Value,
                        TotalAmount = totalAmount
                    };

                    context.ServiceUses.Add(newServiceUse);

                    // Update Invoice.TotalAmount
                    var invoice = context.Invoices.FirstOrDefault(i => i.InvoiceId == selectedInvoiceId);
                    if (invoice != null)
                    {
                        invoice.TotalAmount = (invoice.TotalAmount ?? 0) + totalAmount;
                        context.Invoices.Update(invoice);
                    }
                }
                else
                {
                    var existingServiceUse = context.ServiceUses
                        .FirstOrDefault(su => su.InvoiceId == invoiceId && su.ServiceId == serviceId);

                    if (existingServiceUse != null)
                    {
                        // Calculate the difference in TotalAmount
                        decimal oldTotalAmount = existingServiceUse.TotalAmount ?? 0;
                        decimal difference = totalAmount - oldTotalAmount;

                        existingServiceUse.ServiceQuantity = (int)numQuantity.Value;
                        existingServiceUse.TotalAmount = totalAmount;
                        context.ServiceUses.Update(existingServiceUse);

                        // Update Invoice.TotalAmount
                        var invoice = context.Invoices.FirstOrDefault(i => i.InvoiceId == invoiceId);
                        if (invoice != null)
                        {
                            invoice.TotalAmount = (invoice.TotalAmount ?? 0) + difference;
                            context.Invoices.Update(invoice);
                        }
                    }
                }

                context.SaveChanges();
                LoadServiceUses(); // Refresh the data
                BatTatChucNang(false); // Disable input controls
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false; // Đặt biến xuLyThem thành false để chỉ định rằng đang sửa dữ liệu
            BatTatChucNang(true); // Bật các nút chức năng
            serviceId = Convert.ToInt32(dgvServiceUse.CurrentRow.Cells["ServiceId"].Value);
            invoiceId = Convert.ToInt32(dgvServiceUse.CurrentRow.Cells["InvoiceId"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                serviceId = Convert.ToInt32(dgvServiceUse.CurrentRow.Cells["ServiceId"].Value);
                invoiceId = Convert.ToInt32(dgvServiceUse.CurrentRow.Cells["InvoiceId"].Value);

                var serviceUse = context.ServiceUses
                    .FirstOrDefault(su => su.ServiceId == serviceId && su.InvoiceId == invoiceId);

                if (serviceUse != null)
                {
                    context.ServiceUses.Remove(serviceUse);
                    context.SaveChanges();
                    LoadServiceUses(); // Refresh the data
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmServiceUse_Load(sender, e); // Gọi lại hàm Load để làm mới dữ liệu
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
