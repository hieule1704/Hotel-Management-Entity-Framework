namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvService = new DataGridView();
            ServiceId = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            ServiceType = new DataGridViewTextBoxColumn();
            ServicePrice = new DataGridViewTextBoxColumn();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            numServicePrice = new NumericUpDown();
            txtServiceName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            txtServiceType = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numServicePrice).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvService
            // 
            dgvService.AllowUserToAddRows = false;
            dgvService.AllowUserToDeleteRows = false;
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Columns.AddRange(new DataGridViewColumn[] { ServiceId, ServiceName, ServiceType, ServicePrice });
            dgvService.Dock = DockStyle.Fill;
            dgvService.Location = new Point(3, 23);
            dgvService.MultiSelect = false;
            dgvService.Name = "dgvService";
            dgvService.RowHeadersVisible = false;
            dgvService.RowHeadersWidth = 51;
            dgvService.Size = new Size(970, 472);
            dgvService.TabIndex = 2;
            // 
            // ServiceId
            // 
            ServiceId.DataPropertyName = "ServiceId";
            ServiceId.FillWeight = 21.3903751F;
            ServiceId.HeaderText = "ID";
            ServiceId.MinimumWidth = 6;
            ServiceId.Name = "ServiceId";
            // 
            // ServiceName
            // 
            ServiceName.DataPropertyName = "ServiceName";
            ServiceName.FillWeight = 126.2032F;
            ServiceName.HeaderText = "Tên dịch vụ";
            ServiceName.MinimumWidth = 6;
            ServiceName.Name = "ServiceName";
            // 
            // ServiceType
            // 
            ServiceType.DataPropertyName = "ServiceType";
            ServiceType.FillWeight = 126.2032F;
            ServiceType.HeaderText = "Loại dịch vụ";
            ServiceType.MinimumWidth = 6;
            ServiceType.Name = "ServiceType";
            // 
            // ServicePrice
            // 
            ServicePrice.DataPropertyName = "ServicePrice";
            ServicePrice.FillWeight = 126.2032F;
            ServicePrice.HeaderText = "Giá dịch vụ";
            ServicePrice.MinimumWidth = 6;
            ServicePrice.Name = "ServicePrice";
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
            btnLamMoi.Location = new Point(813, 82);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 19;
            btnLamMoi.ShadowDecoration.Color = Color.Green;
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLamMoi.Size = new Size(113, 40);
            btnLamMoi.TabIndex = 22;
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
            btnXoa.Location = new Point(707, 82);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 19;
            btnXoa.ShadowDecoration.Color = Color.Green;
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = HorizontalAlignment.Left;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.AutoRoundedCorners = true;
            btnLuu.CustomizableEdges = customizableEdges5;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.Green;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = HorizontalAlignment.Left;
            btnLuu.Location = new Point(762, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.BorderRadius = 19;
            btnLuu.ShadowDecoration.Color = Color.Green;
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = HorizontalAlignment.Left;
            btnLuu.Click += btnLuu_Click;
            // 
            // numServicePrice
            // 
            numServicePrice.Location = new Point(467, 95);
            numServicePrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numServicePrice.Name = "numServicePrice";
            numServicePrice.Size = new Size(150, 27);
            numServicePrice.TabIndex = 8;
            numServicePrice.TextAlign = HorizontalAlignment.Right;
            numServicePrice.ThousandsSeparator = true;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(141, 29);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(476, 27);
            txtServiceName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 97);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "Giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Loại dịch vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên dịch vụ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvService);
            groupBox2.Location = new Point(0, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 498);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại phòng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtServiceType);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(numServicePrice);
            groupBox1.Controls.Add(txtServiceName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 146);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại phòng";
            // 
            // btnSua
            // 
            btnSua.AutoRoundedCorners = true;
            btnSua.CustomizableEdges = customizableEdges7;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.Maroon;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = HorizontalAlignment.Left;
            btnSua.Location = new Point(868, 29);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 19;
            btnSua.ShadowDecoration.Color = Color.Green;
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = HorizontalAlignment.Left;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.AutoRoundedCorners = true;
            btnThem.CustomizableEdges = customizableEdges9;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.Olive;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = HorizontalAlignment.Left;
            btnThem.Location = new Point(656, 29);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 19;
            btnThem.ShadowDecoration.Color = Color.Green;
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = HorizontalAlignment.Left;
            btnThem.Click += btnThem_Click;
            // 
            // txtServiceType
            // 
            txtServiceType.Location = new Point(141, 94);
            txtServiceType.Name = "txtServiceType";
            txtServiceType.Size = new Size(243, 27);
            txtServiceType.TabIndex = 23;
            // 
            // frmService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dịch vụ";
            Load += frmService_Load;
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ((System.ComponentModel.ISupportInitialize)numServicePrice).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvService;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private NumericUpDown numServicePrice;
        private TextBox txtServiceName;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtServiceType;
        private DataGridViewTextBoxColumn ServiceId;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn ServiceType;
        private DataGridViewTextBoxColumn ServicePrice;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
    }
}