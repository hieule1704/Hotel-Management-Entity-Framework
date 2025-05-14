using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyKhachSanLTQL.Data;
using Microsoft.Reporting.WinForms;

namespace DoAnQuanLyKhachSanLTQL.Report
{
    public partial class frmBieuDoDoanhThuTheoThang : Form
    {
        HotelDbContext context = new HotelDbContext();
        QLHoaDon.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLHoaDon.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Report");

        public frmBieuDoDoanhThuTheoThang()
        {
            InitializeComponent();
        }

        private void frmBieuDoDoanhThuTheoThang_Load(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.Invoices.Select(r => new Invoice
            {
                InvoiceId = r.InvoiceId,
                CustomerId = r.CustomerId,
                StaffId = r.StaffId,
                InvoiceDate = r.InvoiceDate,
                TotalAmount = r.TotalAmount,
                PaymentType = r.PaymentType
            }).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                    row.CustomerId,
                    row.StaffId,
                    row.TotalAmount ?? 0, // Handle nullable TotalAmount
                    row.PaymentType ?? string.Empty, // Handle nullable PaymentType
                    row.InvoiceDate.ToString("yyyy-MM-dd") // Format date as string
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "DanhSachHoaDon",
                Value = danhSachHoaDonDataTable
            };

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThuTheoThang.rdlc");

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}
