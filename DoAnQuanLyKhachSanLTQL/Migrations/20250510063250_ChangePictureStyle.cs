using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnQuanLyKhachSanLTQL.Migrations
{
    /// <inheritdoc />
    public partial class ChangePictureStyle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices",
                sql: "PaymentType IN (N'Tiền mặc', N'Thẻ tín dụng')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices",
                sql: "PaymentType IN (N'Tiền mặc', N'Chuyển khoảng')");
        }
    }
}
