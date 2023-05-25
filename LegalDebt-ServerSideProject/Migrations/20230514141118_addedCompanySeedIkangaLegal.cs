using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegalDebt_ServerSideProject.Migrations
{
    /// <inheritdoc />
    public partial class addedCompanySeedIkangaLegal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Cellphone", "Name" },
                values: new object[] { 1, "123 @ address", 0, "IkanaLegal" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
