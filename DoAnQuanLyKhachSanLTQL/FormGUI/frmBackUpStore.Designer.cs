namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmBackUpStore
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
            btnSaoLuu = new Button();
            btnPhucHoi = new Button();
            SuspendLayout();
            // 
            // btnSaoLuu
            // 
            btnSaoLuu.Location = new Point(30, 30);
            btnSaoLuu.Name = "btnSaoLuu";
            btnSaoLuu.Size = new Size(150, 40);
            btnSaoLuu.TabIndex = 0;
            btnSaoLuu.Text = "Sao lưu dữ liệu";
            btnSaoLuu.UseVisualStyleBackColor = true;
            btnSaoLuu.Click += btnSaoLuu_Click;
            // 
            // btnPhucHoi
            // 
            btnPhucHoi.Location = new Point(211, 30);
            btnPhucHoi.Name = "btnPhucHoi";
            btnPhucHoi.Size = new Size(150, 40);
            btnPhucHoi.TabIndex = 1;
            btnPhucHoi.Text = "Phục hồi dữ liệu";
            btnPhucHoi.UseVisualStyleBackColor = true;
            btnPhucHoi.Click += btnPhucHoi_Click;
            // 
            // frmBackUpStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 100);
            Controls.Add(btnPhucHoi);
            Controls.Add(btnSaoLuu);
            Name = "frmBackUpStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sao lưu / Phục hồi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSaoLuu;
        private Button btnPhucHoi;
    }
}