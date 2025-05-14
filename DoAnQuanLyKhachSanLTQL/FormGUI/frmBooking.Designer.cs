namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtInvoiceId = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cboRoom = new ComboBox();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            numGuestQuantity = new NumericUpDown();
            label3 = new Label();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            cboCustomerName = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnNhap = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            txtTuKhoa = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip = new ToolStrip();
            btnXuat = new ToolStripButton();
            dgvBooking = new DataGridView();
            BookingId = new DataGridViewTextBoxColumn();
            InvoiceId = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            GuestQuantity = new DataGridViewTextBoxColumn();
            CheckInDate = new DataGridViewTextBoxColumn();
            CheckOutDate = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGuestQuantity).BeginInit();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Location = new Point(141, 112);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.ReadOnly = true;
            txtInvoiceId.Size = new Size(177, 27);
            txtInvoiceId.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 115);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 26;
            label7.Text = "Mã hóa đơn:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboRoom);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(numGuestQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpCheckOut);
            groupBox1.Controls.Add(dtpCheckIn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboCustomerName);
            groupBox1.Controls.Add(txtInvoiceId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 173);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đặt phòng";
            // 
            // cboRoom
            // 
            cboRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoom.FormattingEnabled = true;
            cboRoom.Items.AddRange(new object[] { "Nam", "Nữ", "Giới tính thứ 3" });
            cboRoom.Location = new Point(141, 71);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(177, 28);
            cboRoom.TabIndex = 44;
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
            btnSua.Location = new Point(859, 42);
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
            btnThem.Location = new Point(647, 42);
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
            btnLamMoi.Location = new Point(804, 95);
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
            btnXoa.Location = new Point(698, 95);
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
            btnLuu.Location = new Point(753, 42);
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
            // numGuestQuantity
            // 
            numGuestQuantity.Location = new Point(486, 25);
            numGuestQuantity.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numGuestQuantity.Name = "numGuestQuantity";
            numGuestQuantity.Size = new Size(134, 27);
            numGuestQuantity.TabIndex = 38;
            numGuestQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 27);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 37;
            label3.Text = "Số lượng khách:";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CustomFormat = "";
            dtpCheckOut.Location = new Point(443, 110);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(177, 27);
            dtpCheckOut.TabIndex = 36;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CustomFormat = "";
            dtpCheckIn.Location = new Point(443, 71);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(177, 27);
            dtpCheckIn.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 114);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 33;
            label6.Text = "Check out:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 74);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 31;
            label4.Text = "Check in:";
            // 
            // cboCustomerName
            // 
            cboCustomerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomerName.FormattingEnabled = true;
            cboCustomerName.Items.AddRange(new object[] { "Nam", "Nữ", "Giới tính thứ 3" });
            cboCustomerName.Location = new Point(141, 26);
            cboCustomerName.Name = "cboCustomerName";
            cboCustomerName.Size = new Size(177, 28);
            cboCustomerName.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Số phòng:";
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
            // btnNhap
            // 
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(119, 24);
            btnNhap.Text = "Nhập dữ liệu";
            btnNhap.ToolTipText = "Nhập dữ liệu từ Excel";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(300, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(93, 24);
            toolStripLabel1.Text = "Tìm kiếm:";
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
            // btnXuat
            // 
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 24);
            btnXuat.Text = "Xuất dữ liệu";
            btnXuat.ToolTipText = "Xuất ra tập tin Excel";
            // 
            // dgvBooking
            // 
            dgvBooking.AllowUserToAddRows = false;
            dgvBooking.AllowUserToDeleteRows = false;
            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Columns.AddRange(new DataGridViewColumn[] { BookingId, InvoiceId, RoomNumber, GuestQuantity, CheckInDate, CheckOutDate });
            dgvBooking.Dock = DockStyle.Fill;
            dgvBooking.Location = new Point(3, 50);
            dgvBooking.MultiSelect = false;
            dgvBooking.Name = "dgvBooking";
            dgvBooking.RowHeadersVisible = false;
            dgvBooking.RowHeadersWidth = 51;
            dgvBooking.Size = new Size(970, 418);
            dgvBooking.TabIndex = 6;
            dgvBooking.SelectionChanged += dgvBooking_SelectionChanged;
            // 
            // BookingId
            // 
            BookingId.DataPropertyName = "BookingId";
            BookingId.FillWeight = 32.08556F;
            BookingId.HeaderText = "ID";
            BookingId.MinimumWidth = 6;
            BookingId.Name = "BookingId";
            // 
            // InvoiceId
            // 
            InvoiceId.DataPropertyName = "InvoiceId";
            InvoiceId.FillWeight = 113.582886F;
            InvoiceId.HeaderText = "Mã hóa đơn";
            InvoiceId.MinimumWidth = 6;
            InvoiceId.Name = "InvoiceId";
            // 
            // RoomNumber
            // 
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.FillWeight = 113.582886F;
            RoomNumber.HeaderText = "Số phòng";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            // 
            // GuestQuantity
            // 
            GuestQuantity.DataPropertyName = "GuestQuantity";
            GuestQuantity.FillWeight = 113.582886F;
            GuestQuantity.HeaderText = "Số lượng khách";
            GuestQuantity.MinimumWidth = 6;
            GuestQuantity.Name = "GuestQuantity";
            // 
            // CheckInDate
            // 
            CheckInDate.DataPropertyName = "CheckInDate";
            CheckInDate.FillWeight = 113.582886F;
            CheckInDate.HeaderText = "Ngày nhận phòng";
            CheckInDate.MinimumWidth = 6;
            CheckInDate.Name = "CheckInDate";
            // 
            // CheckOutDate
            // 
            CheckOutDate.DataPropertyName = "CheckOutDate";
            CheckOutDate.FillWeight = 113.582886F;
            CheckOutDate.HeaderText = "Ngày trả phòng";
            CheckOutDate.MinimumWidth = 6;
            CheckOutDate.Name = "CheckOutDate";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvBooking);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(0, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 471);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách đặt phòng";
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt phòng";
            Load += frmBooking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGuestQuantity).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtInvoiceId;
        private Label label7;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ToolStripButton btnNhap;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip;
        private ToolStripButton btnXuat;
        private DataGridView dgvBooking;
        private GroupBox groupBox2;
        private ComboBox cboCustomerName;
        private Label label6;
        private Label label4;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private NumericUpDown numGuestQuantity;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private ComboBox cboRoom;
        private DataGridViewTextBoxColumn BookingId;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn GuestQuantity;
        private DataGridViewTextBoxColumn CheckInDate;
        private DataGridViewTextBoxColumn CheckOutDate;
    }
}