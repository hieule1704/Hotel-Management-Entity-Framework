namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 398);
            label1.Name = "label1";
            label1.Size = new Size(219, 38);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(55, 449);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(400, 43);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(55, 565);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(400, 43);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 514);
            label2.Name = "label2";
            label2.Size = new Size(151, 38);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // btnThoat
            // 
            btnThoat.AutoRoundedCorners = true;
            btnThoat.CustomizableEdges = customizableEdges1;
            btnThoat.DisabledState.BorderColor = Color.DarkGray;
            btnThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThoat.FillColor = Color.FromArgb(128, 128, 255);
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.ImageAlign = HorizontalAlignment.Left;
            btnThoat.Location = new Point(337, 632);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.BorderRadius = 19;
            btnThoat.ShadowDecoration.Color = Color.Green;
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThoat.Size = new Size(100, 58);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = HorizontalAlignment.Left;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.AutoRoundedCorners = true;
            btnDangNhap.CustomizableEdges = customizableEdges3;
            btnDangNhap.DisabledState.BorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangNhap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangNhap.FillColor = Color.Green;
            btnDangNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.ImageAlign = HorizontalAlignment.Left;
            btnDangNhap.Location = new Point(160, 632);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.ShadowDecoration.BorderRadius = 19;
            btnDangNhap.ShadowDecoration.Color = Color.Green;
            btnDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDangNhap.Size = new Size(151, 58);
            btnDangNhap.TabIndex = 22;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlign = HorizontalAlignment.Left;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(107, 31);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(311, 307);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 24;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(509, 724);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public TextBox txtUserName;
        public TextBox txtPassword;
    }
}