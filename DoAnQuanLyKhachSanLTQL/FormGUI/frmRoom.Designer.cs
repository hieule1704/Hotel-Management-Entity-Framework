namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox2 = new GroupBox();
            dgvRoom = new DataGridView();
            RoomId = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            RoomTypeId = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            txtNotes = new TextBox();
            txtRoomNumber = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cboRoomTypeName = new ComboBox();
            label2 = new Label();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvRoom);
            groupBox2.Location = new Point(0, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 497);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.AllowUserToDeleteRows = false;
            dgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoom.Columns.AddRange(new DataGridViewColumn[] { RoomId, RoomNumber, RoomTypeId, Notes });
            dgvRoom.Dock = DockStyle.Fill;
            dgvRoom.Location = new Point(3, 23);
            dgvRoom.MultiSelect = false;
            dgvRoom.Name = "dgvRoom";
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.RowHeadersWidth = 51;
            dgvRoom.Size = new Size(970, 471);
            dgvRoom.TabIndex = 2;
            // 
            // RoomId
            // 
            RoomId.DataPropertyName = "RoomId";
            RoomId.HeaderText = "ID";
            RoomId.MinimumWidth = 6;
            RoomId.Name = "RoomId";
            // 
            // RoomNumber
            // 
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.HeaderText = "Số phòng";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            // 
            // RoomTypeId
            // 
            RoomTypeId.DataPropertyName = "RoomTypeId";
            RoomTypeId.HeaderText = "Loại phòng";
            RoomTypeId.MinimumWidth = 6;
            RoomTypeId.Name = "RoomTypeId";
            RoomTypeId.Resizable = DataGridViewTriState.True;
            RoomTypeId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Notes
            // 
            Notes.DataPropertyName = "Notes";
            Notes.HeaderText = "Ghi chú";
            Notes.MinimumWidth = 6;
            Notes.Name = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(141, 114);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(480, 27);
            txtNotes.TabIndex = 10;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(141, 29);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(480, 27);
            txtRoomNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 117);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Ghi chú:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboRoomTypeName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(txtRoomNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 147);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // cboRoomTypeName
            // 
            cboRoomTypeName.FormattingEnabled = true;
            cboRoomTypeName.Location = new Point(141, 69);
            cboRoomTypeName.Name = "cboRoomTypeName";
            cboRoomTypeName.Size = new Size(480, 28);
            cboRoomTypeName.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 31;
            label2.Text = "Loại phòng:";
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
            btnSua.Location = new Point(858, 32);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 19;
            btnSua.ShadowDecoration.Color = Color.Green;
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 30;
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
            btnThem.Location = new Point(646, 32);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 19;
            btnThem.ShadowDecoration.Color = Color.Green;
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 29;
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
            btnLamMoi.Location = new Point(803, 85);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 19;
            btnLamMoi.ShadowDecoration.Color = Color.Green;
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLamMoi.Size = new Size(113, 40);
            btnLamMoi.TabIndex = 28;
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
            btnXoa.Location = new Point(697, 85);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 19;
            btnXoa.ShadowDecoration.Color = Color.Green;
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 27;
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
            btnLuu.Location = new Point(752, 32);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.BorderRadius = 19;
            btnLuu.ShadowDecoration.Color = Color.Green;
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 26;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = HorizontalAlignment.Left;
            btnLuu.Click += btnLuu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Số phòng:";
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phòng";
            Load += frmRoom_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvRoom;
        private TextBox txtNotes;
        private TextBox txtRoomNumber;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Label label2;
        private ComboBox cboRoomTypeName;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomTypeId;
        private DataGridViewTextBoxColumn Notes;
    }
}