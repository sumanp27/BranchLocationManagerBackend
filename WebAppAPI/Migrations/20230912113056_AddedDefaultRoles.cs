using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52cf6354-006f-4ef6-be9d-8e8423b9ff30", "014323ac-106e-4b5c-8ec1-0e4f9d4dc1d9", "Administrator", "ADMINISTRATOR" },
                    { "e70e38d1-1de1-4bcb-8dea-8eab15a8d70a", "b20e604e-3adf-4e88-bd52-2e51a54c2120", "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52cf6354-006f-4ef6-be9d-8e8423b9ff30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e70e38d1-1de1-4bcb-8dea-8eab15a8d70a");
        }
    }
}
