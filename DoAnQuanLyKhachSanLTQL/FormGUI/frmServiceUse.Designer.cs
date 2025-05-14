namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmServiceUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceUse));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvServiceUse = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            cboServiceName = new ComboBox();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            numQuantity = new NumericUpDown();
            label3 = new Label();
            groupBox2 = new GroupBox();
            cboInvoiceId = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtTotalAmount = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            InvoiceId = new DataGridViewTextBoxColumn();
            ServiceId = new DataGridViewTextBoxColumn();
            ServiceQuantity = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvServiceUse).BeginInit();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServiceUse
            // 
            dgvServiceUse.AllowUserToAddRows = false;
            dgvServiceUse.AllowUserToDeleteRows = false;
            dgvServiceUse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceUse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceUse.Columns.AddRange(new DataGridViewColumn[] { InvoiceId, ServiceId, ServiceQuantity, TotalAmount });
            dgvServiceUse.Dock = DockStyle.Fill;
            dgvServiceUse.Location = new Point(3, 50);
            dgvServiceUse.MultiSelect = false;
            dgvServiceUse.Name = "dgvServiceUse";
            dgvServiceUse.RowHeadersVisible = false;
            dgvServiceUse.RowHeadersWidth = 51;
            dgvServiceUse.Size = new Size(970, 459);
            dgvServiceUse.TabIndex = 6;
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
            // cboServiceName
            // 
            cboServiceName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServiceName.FormattingEnabled = true;
            cboServiceName.Items.AddRange(new object[] { "Nam", "Nữ", "Giới tính thứ 3" });
            cboServiceName.Location = new Point(141, 71);
            cboServiceName.Name = "cboServiceName";
            cboServiceName.Size = new Size(177, 28);
            cboServiceName.TabIndex = 44;
            // 
            // btnSua
            // 
            btnSua.AutoRoundedCorners = true;
            btnSua.CustomizableEdges = customizableEdges1;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.Maroon;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = HorizontalAlignment.Left;
            btnSua.Location = new Point(870, 25);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 19;
            btnSua.ShadowDecoration.Color = Color.Green;
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 43;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = HorizontalAlignment.Left;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.AutoRoundedCorners = true;
            btnThem.CustomizableEdges = customizableEdges3;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.Olive;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = HorizontalAlignment.Left;
            btnThem.Location = new Point(658, 25);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 19;
            btnThem.ShadowDecoration.Color = Color.Green;
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 42;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = HorizontalAlignment.Left;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoRoundedCorners = true;
            btnLamMoi.CustomizableEdges = customizableEdges5;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.FillColor = Color.FromArgb(64, 64, 64);
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = HorizontalAlignment.Left;
            btnLamMoi.Location = new Point(815, 78);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 19;
            btnLamMoi.ShadowDecoration.Color = Color.Green;
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLamMoi.Size = new Size(113, 40);
            btnLamMoi.TabIndex = 41;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = HorizontalAlignment.Left;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoRoundedCorners = true;
            btnXoa.CustomizableEdges = customizableEdges7;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.FromArgb(128, 128, 255);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = HorizontalAlignment.Left;
            btnXoa.Location = new Point(709, 78);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 19;
            btnXoa.ShadowDecoration.Color = Color.Green;
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 40;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = HorizontalAlignment.Left;
            btnXoa.Click += btnXoa_Click;
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
            btnLuu.Location = new Point(764, 25);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.BorderRadius = 19;
            btnLuu.ShadowDecoration.Color = Color.Green;
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 39;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = HorizontalAlignment.Left;
            btnLuu.Click += btnLuu_Click;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(486, 25);
            numQuantity.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(134, 27);
            numQuantity.TabIndex = 38;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 27);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 37;
            label3.Text = "Số lần dùng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvServiceUse);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(0, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 512);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách dịch vụ đã dùng";
            // 
            // cboInvoiceId
            // 
            cboInvoiceId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInvoiceId.FormattingEnabled = true;
            cboInvoiceId.Items.AddRange(new object[] { "Nam", "Nữ", "Giới tính thứ 3" });
            cboInvoiceId.Location = new Point(141, 26);
            cboInvoiceId.Name = "cboInvoiceId";
            cboInvoiceId.Size = new Size(177, 28);
            cboInvoiceId.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên dịch vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(486, 72);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(134, 27);
            txtTotalAmount.TabIndex = 28;
            txtTotalAmount.TextChanged += txtInvoiceId_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 75);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 26;
            label7.Text = "Thành tiền:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboServiceName);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(numQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboInvoiceId);
            groupBox1.Controls.Add(txtTotalAmount);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 132);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // InvoiceId
            // 
            InvoiceId.DataPropertyName = "InvoiceId";
            InvoiceId.HeaderText = "Mã hóa đơn";
            InvoiceId.MinimumWidth = 6;
            InvoiceId.Name = "InvoiceId";
            // 
            // ServiceId
            // 
            ServiceId.DataPropertyName = "ServiceId";
            ServiceId.HeaderText = "Tên dịch vụ dùng";
            ServiceId.MinimumWidth = 6;
            ServiceId.Name = "ServiceId";
            // 
            // ServiceQuantity
            // 
            ServiceQuantity.DataPropertyName = "ServiceQuantity";
            ServiceQuantity.HeaderText = "Số lần dùng";
            ServiceQuantity.MinimumWidth = 6;
            ServiceQuantity.Name = "ServiceQuantity";
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Tổng tiền dịch vụ";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            // 
            // frmServiceUse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmServiceUse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dịch vụ đã dùng";
            Load += frmServiceUse_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServiceUse).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvServiceUse;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private ComboBox cboServiceName;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private NumericUpDown numQuantity;
        private Label label3;
        private GroupBox groupBox2;
        private ComboBox cboInvoiceId;
        private Label label2;
        private Label label1;
        private TextBox txtTotalAmount;
        private Label label7;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn ServiceId;
        private DataGridViewTextBoxColumn ServiceQuantity;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}