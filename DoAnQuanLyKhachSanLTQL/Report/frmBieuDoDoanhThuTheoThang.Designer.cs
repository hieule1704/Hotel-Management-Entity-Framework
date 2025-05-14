namespace DoAnQuanLyKhachSanLTQL.Report
{
    partial class frmBieuDoDoanhThuTheoThang
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(1, 1);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(980, 650);
            reportViewer.TabIndex = 1;
            // 
            // frmBieuDoDoanhThuTheoThang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(reportViewer);
            Name = "frmBieuDoDoanhThuTheoThang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biểu đồ doanh thu theo tháng";
            Load += frmBieuDoDoanhThuTheoThang_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}