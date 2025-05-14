using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnQuanLyKhachSanLTQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNvarchar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Staff_Gender",
                table: "Staffs");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Customer_Gender",
                table: "Customers");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Staff_Gender",
                table: "Staffs",
                sql: "Gender IN (N'Nam', N'Nữ', N'Giới tính thứ 3')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices",
                sql: "PaymentType IN (N'Tiền mặc', N'Thẻ tín dụng')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Customer_Gender",
                table: "Customers",
                sql: "Gender IN (N'Nam', N'Nữ', N'Giới tính thứ 3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Staff_Gender",
                table: "Staffs");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Customer_Gender",
                table: "Customers");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Staff_Gender",
                table: "Staffs",
                sql: "Gender IN ('Nam', 'Nữ', 'Giới tính thứ 3')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Invoice_PaymentType",
                table: "Invoices",
                sql: "PaymentType IN ('Tiền mặc', 'Thẻ tín dụng')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Customer_Gender",
                table: "Customers",
                sql: "Gender IN ('Nam', 'Nữ', 'Giới tính thứ 3')");
        }
    }
}
