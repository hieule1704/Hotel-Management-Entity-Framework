using DoAnQuanLyKhachSanLTQL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using DoAnQuanLyKhachSanLTQL.Report; // Thư viện mã hóa mật khẩu

namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    public partial class frmMDI : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL  
        frmCustomer khachHang = null;
        frmRoomType loaiPhong = null;
        frmRoom phong = null;
        frmBieuDoDoanhThuTheoThang bieuDoDoanhThu = null; // Biểu đồ doanh thu theo tháng
        frmStaff nhanVien = null;
        frmService dichVu = null;
        frmAccount taiKhoang = null;
        frmBooking datPhong = null;
        frmServiceUse dichVuSuDung = null;
        frmInvoice hoaDon = null;
        frmThongKeDoanhThu thongKeDoanhThu = null;
        frmHelp troGiup = null;
        frmBackUpStore backUpStore = null; // Khai báo biến sao lưu dữ liệu
        frmLogin dangNhap = null; // Khai báo biến đăng nhập để kiểm tra quyền truy cập của người dùng.

        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status.
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
            ChuaDangNhap();
            DangNhap();
            //QuyenQuanLy();
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmLogin();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtUserName.Text;
                string matKhau = dangNhap.txtPassword.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtUserName.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtPassword.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.Accounts
                        .Include(a => a.Staff) // Nạp luôn thông tin Staff liên quan ~ mối Account sẽ truy vấn thêm thông tin của Staff tương ứng
                        .Where(r => r.Username == tenDangNhap)
                        .SingleOrDefault();


                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtUserName.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.Password))
                        {
                            hoVaTenNhanVien = nhanVien.Staff.FullName; // Lấy họ tên từ bảng Staffs

                            if (nhanVien.Status == true)
                                QuyenQuanLy();
                            else if (nhanVien.Status == false)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtPassword.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        public void ChuaDangNhap()
        {
            // Sáng đăng nhập 
            mnuDangNhap.Enabled = true;

            // Mờ tất cả 
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuManagement.Enabled = false;
            mnuDatPhong.Enabled = false;
            mnuReport.Enabled = false;


            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenQuanLy()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng quản lý không được phép 


            // Sáng đăng xuất và các chức năng quản lý được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuManagement.Enabled = true;
            mnuDatPhong.Enabled = true;
            mnuReport.Enabled = true;

            mnuCustomer.Enabled = true;
            mnuRoomType.Enabled = true;
            mnuRoom.Enabled = true;
            mnuStaff.Enabled = true;
            mnuInvoice.Enabled = true;
            mnuAccount.Enabled = true;
            mnuService.Enabled = true;



            mnuThongKePhong.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng nhân viên không được phép 
            mnuThongKeDoanhThu.Enabled = false;
            mnuAccount.Enabled = false;
            mnuStaff.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            // Sáng đăng xuất và các chức năng nhân viên được phép 
            mnuDangXuat.Enabled = true;

            mnuManagement.Enabled = true;
            mnuDatPhong.Enabled = true;
            mnuReport.Enabled = true;

            mnuCustomer.Enabled = true;
            mnuRoomType.Enabled = true;
            mnuRoom.Enabled = true;
            mnuInvoice.Enabled = true;
            mnuService.Enabled = true;

            mnuThongKePhong.Enabled = true;


            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmCustomer();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
            {
                khachHang.Activate();
            }
        }

        private void mnuRoomType_Click(object sender, EventArgs e)
        {
            if (loaiPhong == null || loaiPhong.IsDisposed)
            {
                loaiPhong = new frmRoomType();
                loaiPhong.MdiParent = this;
                loaiPhong.Show();
            }
            else
            {
                loaiPhong.Activate();
            }
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://www.instagram.com/chihieu04/";
            Process.Start(info);
        }

        private void mnuRoom_Click(object sender, EventArgs e)
        {
            if (phong == null || phong.IsDisposed)
            {
                phong = new frmRoom();
                phong.MdiParent = this;
                phong.Show();
            }
            else
            {
                phong.Activate();
            }
        }

        private void mnuStaff_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmStaff();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
            {
                nhanVien.Activate();
            }
        }

        private void mnuService_Click(object sender, EventArgs e)
        {
            if (dichVu == null || dichVu.IsDisposed)
            {
                dichVu = new frmService();
                dichVu.MdiParent = this;
                dichVu.Show();
            }
            else
            {
                dichVu.Activate();
            }
        }

        private void mnuAccount_Click(object sender, EventArgs e)
        {
            if (taiKhoang == null || taiKhoang.IsDisposed)
            {
                taiKhoang = new frmAccount();
                taiKhoang.MdiParent = this;
                taiKhoang.Show();
            }
            else
            {
                taiKhoang.Activate();
            }
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (taiKhoang == null || taiKhoang.IsDisposed)
            {
                taiKhoang = new frmAccount();
                taiKhoang.MdiParent = this;
                taiKhoang.Show();
            }
            else
            {
                taiKhoang.Activate();
            }
        }

        private void mnuInvoice_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmInvoice();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
            {
                hoaDon.Activate();
            }
        }

        private void mnuDatPhong_Click(object sender, EventArgs e)
        {
            if (datPhong == null || datPhong.IsDisposed)
            {
                datPhong = new frmBooking();
                datPhong.MdiParent = this;
                datPhong.Show();
            }
            else
            {
                datPhong.Activate();
            }
        }

        private void btnAddServiceUse_Click(object sender, EventArgs e)
        {
            if (dichVuSuDung == null || dichVuSuDung.IsDisposed)
            {
                dichVuSuDung = new frmServiceUse();
                dichVuSuDung.MdiParent = this;
                dichVuSuDung.Show();
            }
            else
            {
                dichVuSuDung.Activate();
            }
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new frmThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
            {
                thongKeDoanhThu.Activate();
            }
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            if (troGiup == null || troGiup.IsDisposed)
            {
                troGiup = new frmHelp();
                troGiup.MdiParent = this;
                troGiup.Show();
            }
            else
            {
                troGiup.Activate();
            }
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            if (troGiup == null || troGiup.IsDisposed)
            {
                troGiup = new frmHelp();
                troGiup.MdiParent = this;
                troGiup.Show();
            }
            else
            {
                troGiup.Activate();
            }
        }

        private void mnuBackUp_Click(object sender, EventArgs e)
        {
            if (backUpStore == null || backUpStore.IsDisposed)
            {
                backUpStore = new frmBackUpStore();
                backUpStore.MdiParent = this;
                backUpStore.Show();
            }
            else
            {
                backUpStore.Activate();
            }
        }

        private void mnuThongKePhong_Click(object sender, EventArgs e)
        {
            if (bieuDoDoanhThu == null || bieuDoDoanhThu.IsDisposed)
            {
                bieuDoDoanhThu = new frmBieuDoDoanhThuTheoThang();
                bieuDoDoanhThu.MdiParent = this;
                bieuDoDoanhThu.Show();
            }
            else
            {
                bieuDoDoanhThu.Activate();
            }
        }

        private void picRoom_Click(object sender, EventArgs e)
        {
            mnuRoom_Click(sender, e);
        }

        private void picRoomType_Click(object sender, EventArgs e)
        {
            mnuRoomType_Click(sender, e);
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {
            mnuCustomer_Click(sender, e);
        }

        private void picService_Click(object sender, EventArgs e)
        {
            mnuService_Click(sender, e);
        }
    }
}
