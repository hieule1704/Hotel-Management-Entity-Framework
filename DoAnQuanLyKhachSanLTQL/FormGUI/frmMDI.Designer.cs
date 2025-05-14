
namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            mnuTongQuat = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuManagement = new ToolStripMenuItem();
            mnuCustomer = new ToolStripMenuItem();
            mnuRoomType = new ToolStripMenuItem();
            mnuRoom = new ToolStripMenuItem();
            mnuStaff = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuInvoice = new ToolStripMenuItem();
            mnuAccount = new ToolStripMenuItem();
            mnuService = new ToolStripMenuItem();
            mnuDatPhong = new ToolStripMenuItem();
            btnAddServiceUse = new ToolStripMenuItem();
            mnuReport = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuThongKePhong = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuBackUp = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            lblRong = new ToolStripStatusLabel();
            lblDateTime = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            picRoom = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            picRoomType = new PictureBox();
            label3 = new Label();
            picCustomer = new PictureBox();
            label4 = new Label();
            picService = new PictureBox();
            mnuTongQuat.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRoomType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picService).BeginInit();
            SuspendLayout();
            // 
            // mnuTongQuat
            // 
            mnuTongQuat.ImageScalingSize = new Size(20, 20);
            mnuTongQuat.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuManagement, mnuDatPhong, btnAddServiceUse, mnuReport, mnuHelp });
            mnuTongQuat.Location = new Point(0, 0);
            mnuTongQuat.Name = "mnuTongQuat";
            mnuTongQuat.Size = new Size(982, 28);
            mnuTongQuat.TabIndex = 5;
            mnuTongQuat.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripMenuItem1, mnuThoat });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(85, 24);
            mnuSystem.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(206, 26);
            mnuDangNhap.Text = "Đăng &nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(206, 26);
            mnuDangXuat.Text = "Đăng &xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(206, 26);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(203, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(206, 26);
            mnuThoat.Text = "&Thoát      Alt + F4";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuManagement
            // 
            mnuManagement.DropDownItems.AddRange(new ToolStripItem[] { mnuCustomer, mnuRoomType, mnuRoom, mnuStaff, toolStripMenuItem2, mnuInvoice, mnuAccount, mnuService });
            mnuManagement.Name = "mnuManagement";
            mnuManagement.Size = new Size(73, 24);
            mnuManagement.Text = "&Quản lý";
            // 
            // mnuCustomer
            // 
            mnuCustomer.Name = "mnuCustomer";
            mnuCustomer.Size = new Size(169, 26);
            mnuCustomer.Text = "&Khách hàng";
            mnuCustomer.Click += mnuCustomer_Click;
            // 
            // mnuRoomType
            // 
            mnuRoomType.Name = "mnuRoomType";
            mnuRoomType.Size = new Size(169, 26);
            mnuRoomType.Text = "&Loại phòng";
            mnuRoomType.Click += mnuRoomType_Click;
            // 
            // mnuRoom
            // 
            mnuRoom.Name = "mnuRoom";
            mnuRoom.Size = new Size(169, 26);
            mnuRoom.Text = "&Phòng";
            mnuRoom.Click += mnuRoom_Click;
            // 
            // mnuStaff
            // 
            mnuStaff.Name = "mnuStaff";
            mnuStaff.Size = new Size(169, 26);
            mnuStaff.Text = "&Nhân viên";
            mnuStaff.Click += mnuStaff_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(166, 6);
            // 
            // mnuInvoice
            // 
            mnuInvoice.Name = "mnuInvoice";
            mnuInvoice.Size = new Size(169, 26);
            mnuInvoice.Text = "&Hóa đơn";
            mnuInvoice.Click += mnuInvoice_Click;
            // 
            // mnuAccount
            // 
            mnuAccount.Name = "mnuAccount";
            mnuAccount.Size = new Size(169, 26);
            mnuAccount.Text = "&Tài khoảng";
            mnuAccount.Click += mnuAccount_Click;
            // 
            // mnuService
            // 
            mnuService.Name = "mnuService";
            mnuService.Size = new Size(169, 26);
            mnuService.Text = "&Dịch vụ";
            mnuService.Click += mnuService_Click;
            // 
            // mnuDatPhong
            // 
            mnuDatPhong.Name = "mnuDatPhong";
            mnuDatPhong.Size = new Size(94, 24);
            mnuDatPhong.Text = "&Đặt phòng";
            mnuDatPhong.Click += mnuDatPhong_Click;
            // 
            // btnAddServiceUse
            // 
            btnAddServiceUse.Name = "btnAddServiceUse";
            btnAddServiceUse.Size = new Size(111, 24);
            btnAddServiceUse.Text = "Thêm dịch vụ";
            btnAddServiceUse.Click += btnAddServiceUse_Click;
            // 
            // mnuReport
            // 
            mnuReport.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeDoanhThu, mnuThongKePhong });
            mnuReport.Name = "mnuReport";
            mnuReport.Size = new Size(152, 24);
            mnuReport.Text = "&Báo cáo - Thống kê";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(294, 26);
            mnuThongKeDoanhThu.Text = "Thống kê &doanh thu";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuThongKePhong
            // 
            mnuThongKePhong.Name = "mnuThongKePhong";
            mnuThongKePhong.Size = new Size(294, 26);
            mnuThongKePhong.Text = "Thống kê doanh thu theo &ngày";
            mnuThongKePhong.Click += mnuThongKePhong_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem, mnuBackUp });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(78, 24);
            mnuHelp.Text = "&Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.Size = new Size(284, 26);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng   Crtl+F1";
            mnuHuongDanSuDung.Click += mnuHuongDanSuDung_Click;
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(284, 26);
            mnuThongTinPhanMem.Text = "&Thông tin phần mềm";
            mnuThongTinPhanMem.Click += mnuThongTinPhanMem_Click;
            // 
            // mnuBackUp
            // 
            mnuBackUp.Name = "mnuBackUp";
            mnuBackUp.Size = new Size(284, 26);
            mnuBackUp.Text = "&Sao lưu và khôi phục dữ liệu";
            mnuBackUp.Click += mnuBackUp_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, lblRong, lblDateTime, lblLienKet });
            statusStrip1.Location = new Point(0, 627);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(982, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(121, 20);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // lblRong
            // 
            lblRong.Name = "lblRong";
            lblRong.Size = new Size(730, 20);
            lblRong.Spring = true;
            // 
            // lblDateTime
            // 
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 20);
            // 
            // lblLienKet
            // 
            lblLienKet.ActiveLinkColor = Color.Red;
            lblLienKet.IsLink = true;
            lblLienKet.LinkColor = Color.Teal;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(116, 20);
            lblLienKet.Text = "© 2025 HieuLee";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // picRoom
            // 
            picRoom.BackColor = Color.Transparent;
            picRoom.Image = (Image)resources.GetObject("picRoom.Image");
            picRoom.Location = new Point(274, 58);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(70, 62);
            picRoom.TabIndex = 8;
            picRoom.TabStop = false;
            picRoom.Click += picRoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 82);
            label1.Name = "label1";
            label1.Size = new Size(221, 38);
            label1.TabIndex = 10;
            label1.Text = "Quản lý phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 190);
            label2.Name = "label2";
            label2.Size = new Size(280, 38);
            label2.TabIndex = 13;
            label2.Text = "Quản lý loại phòng:";
            // 
            // picRoomType
            // 
            picRoomType.BackColor = Color.Transparent;
            picRoomType.Image = (Image)resources.GetObject("picRoomType.Image");
            picRoomType.Location = new Point(334, 166);
            picRoomType.Name = "picRoomType";
            picRoomType.Size = new Size(101, 90);
            picRoomType.TabIndex = 12;
            picRoomType.TabStop = false;
            picRoomType.Click += picRoomType_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 295);
            label3.Name = "label3";
            label3.Size = new Size(293, 38);
            label3.TabIndex = 15;
            label3.Text = "Quản lý khách hàng:";
            // 
            // picCustomer
            // 
            picCustomer.BackColor = Color.Transparent;
            picCustomer.Image = (Image)resources.GetObject("picCustomer.Image");
            picCustomer.Location = new Point(346, 271);
            picCustomer.Name = "picCustomer";
            picCustomer.Size = new Size(70, 62);
            picCustomer.TabIndex = 14;
            picCustomer.TabStop = false;
            picCustomer.Click += picCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 397);
            label4.Name = "label4";
            label4.Size = new Size(233, 38);
            label4.TabIndex = 17;
            label4.Text = "Quản lý dịch vụ:";
            // 
            // picService
            // 
            picService.BackColor = Color.Transparent;
            picService.Image = (Image)resources.GetObject("picService.Image");
            picService.Location = new Point(274, 373);
            picService.Name = "picService";
            picService.Size = new Size(70, 62);
            picService.TabIndex = 16;
            picService.TabStop = false;
            picService.Click += picService_Click;
            // 
            // frmMDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(label4);
            Controls.Add(picService);
            Controls.Add(label3);
            Controls.Add(picCustomer);
            Controls.Add(label2);
            Controls.Add(picRoomType);
            Controls.Add(label1);
            Controls.Add(picRoom);
            Controls.Add(statusStrip1);
            Controls.Add(mnuTongQuat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách sạn";
            WindowState = FormWindowState.Maximized;
            Load += frmMDI_Load;
            mnuTongQuat.ResumeLayout(false);
            mnuTongQuat.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRoomType).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picService).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private MenuStrip mnuTongQuat;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuManagement;
        private ToolStripMenuItem mnuCustomer;
        private ToolStripMenuItem mnuRoomType;
        private ToolStripMenuItem mnuRoom;
        private ToolStripMenuItem mnuStaff;
        private ToolStripMenuItem mnuDatPhong;
        private ToolStripMenuItem mnuReport;
        private ToolStripMenuItem mnuHelp;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel lblRong;
        private ToolStripStatusLabel lblLienKet;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblDateTime;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuInvoice;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuThongKePhong;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuAccount;
        private ToolStripMenuItem mnuService;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuBackUp;
        private ToolStripMenuItem btnAddServiceUse;
        private PictureBox picRoom;
        private Label label1;
        private Label label2;
        private PictureBox picRoomType;
        private Label label3;
        private PictureBox picCustomer;
        private Label label4;
        private PictureBox picService;
    }
}