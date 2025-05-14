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
    public partial class frmService : Form
    {
        HotelDbContext context = new HotelDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false;                          // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;                                         // Lấy mã sản phẩm (dùng cho Sửa và Xóa)

        public frmService()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;
            txtServiceName.Enabled = giaTri;
            txtServiceType.Enabled = giaTri;
            numServicePrice.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<Service> dv = new List<Service>();
            dv = context.Services.ToList();

            BindingSource bindingSource = new BindingSource(); // Tạo một BindingSource để trung gian giữa dữ liệu và UI.
            bindingSource.DataSource = dv;

            txtServiceName.DataBindings.Clear();
            txtServiceName.DataBindings.Add("Text", bindingSource, "ServiceName", false, DataSourceUpdateMode.Never);

            txtServiceType.DataBindings.Clear();
            txtServiceType.DataBindings.Add("Text", bindingSource, "ServiceType", false, DataSourceUpdateMode.Never);

            // num sài value
            numServicePrice.DataBindings.Clear();
            numServicePrice.DataBindings.Add("Value", bindingSource, "ServicePrice", false, DataSourceUpdateMode.Never);

            dgvService.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtServiceName.Clear();
            txtServiceType.Clear();
            numServicePrice.Value = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvService.CurrentRow.Cells["ServiceId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtServiceName.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvService.CurrentRow.Cells["ServiceId"].Value.ToString());
                Service dv = context.Services.Find(id);
                if (dv != null)
                {
                    context.Services.Remove(dv);
                }
                context.SaveChanges();

                frmService_Load(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmService_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Service dv = new Service();
                    dv.ServiceName = txtServiceName.Text;
                    dv.ServicePrice = numServicePrice.Value;
                    dv.ServiceType = txtServiceType.Text;
                 
                    context.Services.Add(dv);

                    context.SaveChanges();
                }
                else // Xử lý sửa
                {
                    Service dv = context.Services.Find(id);
                    if (dv != null)
                    {
                        dv.ServiceName = txtServiceName.Text;
                        dv.ServicePrice = numServicePrice.Value;
                        dv.ServiceType = txtServiceType.Text;

                        context.Services.Update(dv);

                        context.SaveChanges();
                    }
                }

                frmService_Load(sender, e);
            }
        }
    }
}
