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
    public partial class frmRoom : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)

        public frmRoom()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;
            txtRoomNumber.Enabled = giaTri;
            txtNotes.Enabled = giaTri;
            cboRoomTypeName.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayTenLoaiPhongVaoComboBox();

            dgvRoom.AutoGenerateColumns = false;

            List<RoomList> r = new List<RoomList>();
            r = context.Rooms.Select(row => new RoomList
            {
                RoomId = row.RoomId,
                RoomNumber = row.RoomNumber,
                Notes = row.Notes,
                RoomTypeId = row.RoomTypeId,
                RoomTypeName = row.RoomType.RoomTypeName

            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = r;

            cboRoomTypeName.DataBindings.Clear();
            cboRoomTypeName.DataBindings.Add("SelectedValue", bindingSource, "RoomTypeId", false, DataSourceUpdateMode.Never);

            txtRoomNumber.DataBindings.Clear();
            txtRoomNumber.DataBindings.Add("Text", bindingSource, "RoomNumber", false, DataSourceUpdateMode.Never);

            txtNotes.DataBindings.Clear();
            txtNotes.DataBindings.Add("Text", bindingSource, "Notes", false, DataSourceUpdateMode.Never);

            dgvRoom.DataSource = bindingSource;
        }

        public void LayTenLoaiPhongVaoComboBox()
        {
            cboRoomTypeName.DataSource = context.RoomTypes.ToList();
            cboRoomTypeName.ValueMember = "RoomTypeId";
            cboRoomTypeName.DisplayMember = "RoomTypeName";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtRoomNumber.Clear();
            txtNotes.Clear();
            cboRoomTypeName.SelectedValue = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
                MessageBox.Show("Vui lòng nhập số phòng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Room r = new Room();
                    r.RoomNumber = txtRoomNumber.Text;
                    r.RoomTypeId = (int)cboRoomTypeName.SelectedValue;
                    r.Notes = txtNotes.Text;

                    context.Rooms.Add(r);

                    context.SaveChanges();
                }
                else // Xử lý sửa
                {
                    Room r = context.Rooms.Find(id);
                    if (r != null)
                    {
                        r.RoomNumber = txtRoomNumber.Text;
                        r.RoomTypeId = (int)cboRoomTypeName.SelectedValue;
                        r.Notes = txtNotes.Text;

                        context.Rooms.Update(r);

                        context.SaveChanges();
                    }
                }

                frmRoom_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvRoom.CurrentRow.Cells["RoomId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa phòng " + txtRoomNumber.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvRoom.CurrentRow.Cells["RoomId"].Value.ToString());
                Room dv = context.Rooms.Find(id);
                if (dv != null)
                {
                    context.Rooms.Remove(dv);
                }
                context.SaveChanges();

                frmRoom_Load(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmRoom_Load(sender, e);    
        }
    }
}
