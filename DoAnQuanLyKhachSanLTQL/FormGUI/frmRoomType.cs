using DoAnQuanLyKhachSanLTQL.Data;
using Slugify;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    public partial class frmRoomType : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa) 
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");

        public frmRoomType()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;
            txtRoomTypeName.Enabled = giaTri;
            txtRoomTypeDesc.Enabled = giaTri;
            numBedAmount.Enabled = giaTri;
            numCapacity.Enabled = giaTri;
            numRoomPrice.Enabled = giaTri;
            picRoomTypeImg.Enabled = giaTri;


            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
        }

        private void frmRoomType_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<RoomType> lp = new List<RoomType>();
            lp = context.RoomTypes.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lp;

            txtRoomTypeName.DataBindings.Clear();
            txtRoomTypeName.DataBindings.Add("Text", bindingSource, "RoomTypeName", false, DataSourceUpdateMode.Never);

            txtRoomTypeDesc.DataBindings.Clear();
            txtRoomTypeDesc.DataBindings.Add("Text", bindingSource, "RoomTypeDesc", false, DataSourceUpdateMode.Never);

            numBedAmount.DataBindings.Clear();
            numBedAmount.DataBindings.Add("Value", bindingSource, "BedAmount", false, DataSourceUpdateMode.Never);

            numCapacity.DataBindings.Clear();
            numCapacity.DataBindings.Add("Value", bindingSource, "Capacity", false, DataSourceUpdateMode.Never);

            numRoomPrice.DataBindings.Clear();
            numRoomPrice.DataBindings.Add("Value", bindingSource, "RoomPrice", false, DataSourceUpdateMode.Never);

            // Các kết nối ảnh
            picRoomTypeImg.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "RoomTypeImg", false, DataSourceUpdateMode.Never);
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

            picRoomTypeImg.DataBindings.Add(hinhAnh);

            dgvRoomType.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtRoomTypeName.Clear();
            txtRoomTypeDesc.Clear();
            numBedAmount.Value = 0;
            numCapacity.Value = 0;
            numRoomPrice.Value = 0;
            picRoomTypeImg.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvRoomType.CurrentRow.Cells["RoomTypeId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại phòng " + txtRoomTypeName.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvRoomType.CurrentRow.Cells["RoomTypeId"].Value.ToString());
                RoomType lp = context.RoomTypes.Find(id);
                if (lp != null)
                {
                    context.RoomTypes.Remove(lp);
                }
                context.SaveChanges();

                frmRoomType_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomTypeName.Text))
                MessageBox.Show("Vui lòng nhập tên loại phòng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    RoomType lp = new RoomType();
                    lp.RoomTypeName = txtRoomTypeName.Text;
                    lp.RoomTypeDesc = txtRoomTypeDesc.Text;
                    lp.Capacity = (int)numCapacity.Value;
                    lp.BedAmount = (int)numBedAmount.Value;
                    lp.RoomPrice = numRoomPrice.Value;
                    // lp.RoomTypeImg = picRoomTypeImg.Image;

                    context.RoomTypes.Add(lp);

                    context.SaveChanges();
                }
                else
                {
                    RoomType lp = context.RoomTypes.Find(id);
                    if (lp != null)
                    {
                        lp.RoomTypeName = txtRoomTypeName.Text;
                        lp.RoomTypeDesc = txtRoomTypeDesc.Text;
                        lp.Capacity = (int)numCapacity.Value;
                        lp.BedAmount = (int)numBedAmount.Value;
                        lp.RoomPrice = numRoomPrice.Value;
                        //lp.RoomTypeImg = picRoomTypeImg.Image;

                        context.SaveChanges();
                    }
                }

                frmRoomType_Load(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmRoomType_Load(sender, e);
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
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

                id = Convert.ToInt32(dgvRoomType.CurrentRow.Cells["RoomTypeId"].Value.ToString());
                RoomType lp = context.RoomTypes.Find(id);
                lp.RoomTypeImg = slug.GenerateSlug(fileName) + ext;
                context.RoomTypes.Update(lp);

                context.SaveChanges();

                //Tải lại form
                frmRoomType_Load(sender, e);
            }
        }

        private void dgvRoomType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRoomType.Columns[e.ColumnIndex].Name == "RoomTypeImg")
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


    }
}
