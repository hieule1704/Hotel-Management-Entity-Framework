namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            btnNhap = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            txtTuKhoa = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip = new ToolStrip();
            btnXuat = new ToolStripButton();
            btnInHoaDon = new ToolStripButton();
            dgvInvoice = new DataGridView();
            InvoiceId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            StaffName = new DataGridViewTextBoxColumn();
            InvoiceDate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            PaymentType = new DataGridViewTextBoxColumn();
            InvoiceDetail = new DataGridViewLinkColumn();
            groupBox2 = new GroupBox();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
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
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, toolStripSeparator1, btnNhap, btnXuat, btnInHoaDon });
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
            btnXuat.Click += btnXuat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Image = (Image)resources.GetObject("btnInHoaDon.Image");
            btnInHoaDon.ImageTransparentColor = Color.Magenta;
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(104, 24);
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.ToolTipText = "Xuất ra tập tin Excel";
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // dgvInvoice
            // 
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.AllowUserToDeleteRows = false;
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Columns.AddRange(new DataGridViewColumn[] { InvoiceId, CustomerName, StaffName, InvoiceDate, TotalAmount, PaymentType, InvoiceDetail });
            dgvInvoice.Dock = DockStyle.Fill;
            dgvInvoice.Location = new Point(3, 50);
            dgvInvoice.MultiSelect = false;
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowHeadersVisible = false;
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.Size = new Size(970, 595);
            dgvInvoice.TabIndex = 6;
            // 
            // InvoiceId
            // 
            InvoiceId.DataPropertyName = "InvoiceId";
            InvoiceId.FillWeight = 37.4331551F;
            InvoiceId.HeaderText = "ID";
            InvoiceId.MinimumWidth = 6;
            InvoiceId.Name = "InvoiceId";
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.FillWeight = 110.4278F;
            CustomerName.HeaderText = "Khách hàng";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            // 
            // StaffName
            // 
            StaffName.DataPropertyName = "StaffName";
            StaffName.FillWeight = 110.4278F;
            StaffName.HeaderText = "Nhân viên";
            StaffName.MinimumWidth = 6;
            StaffName.Name = "StaffName";
            // 
            // InvoiceDate
            // 
            InvoiceDate.DataPropertyName = "InvoiceDate";
            InvoiceDate.FillWeight = 110.4278F;
            InvoiceDate.HeaderText = "Ngày lập";
            InvoiceDate.MinimumWidth = 6;
            InvoiceDate.Name = "InvoiceDate";
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.FillWeight = 110.4278F;
            TotalAmount.HeaderText = "Tổng tiền";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            // 
            // PaymentType
            // 
            PaymentType.DataPropertyName = "PaymentType";
            PaymentType.FillWeight = 110.4278F;
            PaymentType.HeaderText = "Loại thanh toán";
            PaymentType.MinimumWidth = 6;
            PaymentType.Name = "PaymentType";
            // 
            // InvoiceDetail
            // 
            InvoiceDetail.DataPropertyName = "InvoiceDetail";
            InvoiceDetail.FillWeight = 110.4278F;
            InvoiceDetail.HeaderText = "Hóa đơn chi tiết";
            InvoiceDetail.MinimumWidth = 6;
            InvoiceDetail.Name = "InvoiceDetail";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvInvoice);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(0, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 648);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
            // 
            // frmInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmInvoice_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripButton btnNhap;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip;
        private ToolStripButton btnXuat;
        private DataGridView dgvInvoice;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn InvoiceDate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn PaymentType;
        private DataGridViewLinkColumn InvoiceDetail;
        private ToolStripButton btnInHoaDon;
    }
}