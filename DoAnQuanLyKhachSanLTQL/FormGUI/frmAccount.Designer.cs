namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmAccount
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            groupBox1 = new GroupBox();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            btnDoiAnh = new Guna.UI2.WinForms.Guna2Button();
            picProfilePicture = new PictureBox();
            cboStaffId = new ComboBox();
            label3 = new Label();
            cboStatus = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvAccount = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            StaffId = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ProfilePicture = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfilePicture).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(141, 29);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(185, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 63);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 27);
            txtPassword.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picProfilePicture);
            groupBox1.Controls.Add(cboStaffId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 190);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tài khoảng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoRoundedCorners = true;
            btnLamMoi.CustomizableEdges = customizableEdges1;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.FillColor = Color.FromArgb(64, 64, 64);
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = HorizontalAlignment.Left;
            btnLamMoi.Location = new Point(540, 113);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 19;
            btnLamMoi.ShadowDecoration.Color = Color.Green;
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLamMoi.Size = new Size(113, 40);
            btnLamMoi.TabIndex = 38;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = HorizontalAlignment.Left;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoRoundedCorners = true;
            btnXoa.CustomizableEdges = customizableEdges3;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.FromArgb(128, 128, 255);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = HorizontalAlignment.Left;
            btnXoa.Location = new Point(282, 113);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 19;
            btnXoa.ShadowDecoration.Color = Color.Green;
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = HorizontalAlignment.Left;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AutoRoundedCorners = true;
            btnSua.CustomizableEdges = customizableEdges5;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.Maroon;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = HorizontalAlignment.Left;
            btnSua.Location = new Point(158, 113);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 19;
            btnSua.ShadowDecoration.Color = Color.Green;
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = HorizontalAlignment.Left;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.AutoRoundedCorners = true;
            btnThem.CustomizableEdges = customizableEdges7;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.Olive;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = HorizontalAlignment.Left;
            btnThem.Location = new Point(28, 113);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 19;
            btnThem.ShadowDecoration.Color = Color.Green;
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = HorizontalAlignment.Left;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.AutoRoundedCorners = true;
            btnLuu.CustomizableEdges = customizableEdges9;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.Green;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = HorizontalAlignment.Left;
            btnLuu.Location = new Point(416, 113);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.BorderRadius = 19;
            btnLuu.ShadowDecoration.Color = Color.Green;
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = HorizontalAlignment.Left;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.AutoRoundedCorners = true;
            btnDoiAnh.CustomizableEdges = customizableEdges11;
            btnDoiAnh.DisabledState.BorderColor = Color.DarkGray;
            btnDoiAnh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDoiAnh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDoiAnh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDoiAnh.FillColor = Color.Silver;
            btnDoiAnh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoiAnh.ForeColor = Color.White;
            btnDoiAnh.Image = (Image)resources.GetObject("btnDoiAnh.Image");
            btnDoiAnh.ImageAlign = HorizontalAlignment.Left;
            btnDoiAnh.Location = new Point(862, 17);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.ShadowDecoration.BorderRadius = 19;
            btnDoiAnh.ShadowDecoration.Color = Color.Green;
            btnDoiAnh.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDoiAnh.Size = new Size(100, 65);
            btnDoiAnh.TabIndex = 33;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.TextAlign = HorizontalAlignment.Left;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picProfilePicture
            // 
            picProfilePicture.Location = new Point(684, 17);
            picProfilePicture.Name = "picProfilePicture";
            picProfilePicture.Size = new Size(160, 160);
            picProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfilePicture.TabIndex = 27;
            picProfilePicture.TabStop = false;
            // 
            // cboStaffId
            // 
            cboStaffId.FormattingEnabled = true;
            cboStaffId.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboStaffId.Location = new Point(468, 26);
            cboStaffId.Name = "cboStaffId";
            cboStaffId.Size = new Size(149, 28);
            cboStaffId.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 29);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 25;
            label3.Text = "Mã nhân viên:";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboStatus.Location = new Point(466, 63);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 67);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Quyền hạn(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoảng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvAccount);
            groupBox2.Location = new Point(0, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 454);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tài khoảng";
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { Username, Password, StaffId, Status, ProfilePicture });
            dgvAccount.Dock = DockStyle.Fill;
            dgvAccount.Location = new Point(3, 23);
            dgvAccount.MultiSelect = false;
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersVisible = false;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(970, 428);
            dgvAccount.TabIndex = 2;
            dgvAccount.CellFormatting += dgvAccount_CellFormatting;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Tên tài khoảng";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // StaffId
            // 
            StaffId.DataPropertyName = "StaffId";
            StaffId.HeaderText = "Mã nhân viên";
            StaffId.MinimumWidth = 6;
            StaffId.Name = "StaffId";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Quyền hạng";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // ProfilePicture
            // 
            ProfilePicture.DataPropertyName = "ProfilePicture";
            ProfilePicture.HeaderText = "Ảnh xác thực";
            ProfilePicture.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ProfilePicture.MinimumWidth = 6;
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Resizable = DataGridViewTriState.True;
            ProfilePicture.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += frmAccount_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfilePicture).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private GroupBox groupBox1;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvAccount;
        private ComboBox cboStatus;
        private ComboBox cboStaffId;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnDoiAnh;
        private PictureBox picProfilePicture;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn StaffId;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewImageColumn ProfilePicture;
    }
}