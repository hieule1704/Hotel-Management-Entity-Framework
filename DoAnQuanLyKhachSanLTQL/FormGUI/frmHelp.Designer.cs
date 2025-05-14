namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            toolStrip1 = new ToolStrip();
            lblLienKet = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 39);
            label1.TabIndex = 0;
            label1.Text = "Hướng dẫn sử dụng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(636, 597);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblLienKet });
            toolStrip1.Location = new Point(0, 657);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(639, 26);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblLienKet
            // 
            lblLienKet.ActiveLinkColor = Color.Red;
            lblLienKet.IsLink = true;
            lblLienKet.LinkColor = Color.Teal;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(116, 20);
            lblLienKet.Text = "© 2025 HieuLee";
            // 
            // frmHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 683);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "frmHelp";
            Text = "Hướng dẫn sử dụng";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private ToolStrip toolStrip1;
        private ToolStripStatusLabel lblLienKet;
    }
}