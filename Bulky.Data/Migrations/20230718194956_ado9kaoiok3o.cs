using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class ado9kaoiok3o : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 7, "123", "123", "123", 123.0, 123.0, 123.0, 123.0, "123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
