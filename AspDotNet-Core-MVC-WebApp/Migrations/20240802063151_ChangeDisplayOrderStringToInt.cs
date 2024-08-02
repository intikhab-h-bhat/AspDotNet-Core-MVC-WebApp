using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspDotNet_Core_MVC_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDisplayOrderStringToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "Catogries",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Catogries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Catogries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Catogries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DisplayOrder",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DisplayOrder",
                table: "Catogries",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Catogries",
                keyColumn: "Id",
                keyValue: 1,
                column: "DisplayOrder",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Catogries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DisplayOrder",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Catogries",
                keyColumn: "Id",
                keyValue: 3,
                column: "DisplayOrder",
                value: "1");
        }
    }
}
