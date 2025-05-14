namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox2 = new GroupBox();
            dgvCustomer = new DataGridView();
            CustomerId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            CreditCard = new DataGridViewTextBoxColumn();
            IdProof = new DataGridViewTextBoxColumn();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtIdProof = new TextBox();
            txtCreditCard = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            txtContactNumber = new TextBox();
            comGender = new ComboBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            toolStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCustomer);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(0, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 451);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { CustomerId, FullName, ContactNumber, Email, Address, Gender, CreditCard, IdProof });
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(3, 50);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(970, 398);
            dgvCustomer.TabIndex = 6;
            // 
            // CustomerId
            // 
            CustomerId.DataPropertyName = "CustomerId";
            CustomerId.FillWeight = 42.78075F;
            CustomerId.HeaderText = "ID";
            CustomerId.MinimumWidth = 6;
            CustomerId.Name = "CustomerId";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.FillWeight = 108.174171F;
            FullName.HeaderText = "Họ tên";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // ContactNumber
            // 
            ContactNumber.DataPropertyName = "ContactNumber";
            ContactNumber.FillWeight = 108.174171F;
            ContactNumber.HeaderText = "SĐT";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.FillWeight = 108.174171F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.FillWeight = 108.174171F;
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.FillWeight = 108.174171F;
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            // 
            // CreditCard
            // 
            CreditCard.DataPropertyName = "CreditCard";
            CreditCard.FillWeight = 108.174171F;
            CreditCard.HeaderText = "Thẻ tín dụng";
            CreditCard.MinimumWidth = 6;
            CreditCard.Name = "CreditCard";
            // 
            // IdProof
            // 
            IdProof.DataPropertyName = "IdProof";
            IdProof.FillWeight = 108.174171F;
            IdProof.HeaderText = "CMND/CCCD";
            IdProof.MinimumWidth = 6;
            IdProof.Name = "IdProof";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip.Location = new Point(3, 23);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(970, 27);
            toolStrip.TabIndex = 5;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(93, 24);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(300, 27);
            txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnNhap
            // 
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(119, 24);
            btnNhap.Text = "Nhập dữ liệu";
            btnNhap.ToolTipText = "Nhập dữ liệu từ Excel";
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 24);
            btnXuat.Text = "Xuất dữ liệu";
            btnXuat.ToolTipText = "Xuất ra tập tin Excel";
            btnXuat.Click += btnXuat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoRoundedCorners = true;
            btnLamMoi.CustomizableEdges = customizableEdges21;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.FillColor = Color.FromArgb(64, 64, 64);
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = HorizontalAlignment.Left;
            btnLamMoi.Location = new Point(792, 91);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 19;
            btnLamMoi.ShadowDecoration.Color = Color.Green;
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnLamMoi.Size = new Size(113, 40);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = HorizontalAlignment.Left;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoRoundedCorners = true;
            btnXoa.CustomizableEdges = customizableEdges23;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.FromArgb(128, 128, 255);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = HorizontalAlignment.Left;
            btnXoa.Location = new Point(691, 91);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 19;
            btnXoa.ShadowDecoration.Color = Color.Green;
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnXoa.Size = new Size(80, 40);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = HorizontalAlignment.Left;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AutoRoundedCorners = true;
            btnSua.CustomizableEdges = customizableEdges25;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.Maroon;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = HorizontalAlignment.Left;
            btnSua.Location = new Point(853, 32);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 19;
            btnSua.ShadowDecoration.Color = Color.Green;
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnSua.Size = new Size(82, 40);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = HorizontalAlignment.Left;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.AutoRoundedCorners = true;
            btnThem.CustomizableEdges = customizableEdges27;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.Olive;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = HorizontalAlignment.Left;
            btnThem.Location = new Point(652, 32);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 19;
            btnThem.ShadowDecoration.Color = Color.Green;
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = HorizontalAlignment.Left;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.AutoRoundedCorners = true;
            btnLuu.CustomizableEdges = customizableEdges29;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.Green;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = HorizontalAlignment.Left;
            btnLuu.Location = new Point(758, 32);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.BorderRadius = 19;
            btnLuu.ShadowDecoration.Color = Color.Green;
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnLuu.Size = new Size(89, 40);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = HorizontalAlignment.Left;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(141, 154);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(809, 27);
            txtAddress.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(141, 29);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(177, 27);
            txtFullName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 70);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 31);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 157);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdProof);
            groupBox1.Controls.Add(txtCreditCard);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtContactNumber);
            groupBox1.Controls.Add(comGender);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 193);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtIdProof
            // 
            txtIdProof.Location = new Point(443, 115);
            txtIdProof.Name = "txtIdProof";
            txtIdProof.Size = new Size(177, 27);
            txtIdProof.TabIndex = 29;
            // 
            // txtCreditCard
            // 
            txtCreditCard.Location = new Point(141, 112);
            txtCreditCard.Name = "txtCreditCard";
            txtCreditCard.Size = new Size(177, 27);
            txtCreditCard.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 118);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 27;
            label6.Text = "CMND/CCCD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 115);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 26;
            label7.Text = "Số tài khoảng:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(443, 28);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 27);
            txtEmail.TabIndex = 25;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(141, 68);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(177, 27);
            txtContactNumber.TabIndex = 24;
            // 
            // comGender
            // 
            comGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comGender.FormattingEnabled = true;
            comGender.Items.AddRange(new object[] { "Nam", "Nữ", "Giới tính thứ 3" });
            comGender.Location = new Point(443, 67);
            comGender.Name = "comGender";
            comGender.Size = new Size(177, 28);
            comGender.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            // 
            // frmCustomer
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            Load += frmCustomer_Load;
            DragDrop += frmCustomer_DragDrop;
            DragEnter += frmCustomer_DragEnter;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private TextBox txtAddress;
        private TextBox txtFullName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtContactNumber;
        private ComboBox comGender;
        private TextBox txtEmail;
        private TextBox txtIdProof;
        private TextBox txtCreditCard;
        private Label label6;
        private Label label7;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn CreditCard;
        private DataGridViewTextBoxColumn IdProof;
    }
}