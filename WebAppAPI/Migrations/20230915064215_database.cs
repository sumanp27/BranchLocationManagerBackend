using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52cf6354-006f-4ef6-be9d-8e8423b9ff30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e70e38d1-1de1-4bcb-8dea-8eab15a8d70a");

            migrationBuilder.DropColumn(
                name: "OPENED_DT",
                table: "Branches");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f193acd-1b94-40e2-a323-08407544e430", "d34e1be8-cf40-443b-824b-3cc6b43e1770", "user", "USER" },
                    { "79f8332a-9275-46b6-bb89-eaa1cea97d46", "85906400-b3a6-4334-8ba0-6d7ddd159f65", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f193acd-1b94-40e2-a323-08407544e430");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79f8332a-9275-46b6-bb89-eaa1cea97d46");

            migrationBuilder.AddColumn<DateTime>(
                name: "OPENED_DT",
                table: "Branches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52cf6354-006f-4ef6-be9d-8e8423b9ff30", "014323ac-106e-4b5c-8ec1-0e4f9d4dc1d9", "Administrator", "ADMINISTRATOR" },
                    { "e70e38d1-1de1-4bcb-8dea-8eab15a8d70a", "b20e604e-3adf-4e88-bd52-2e51a54c2120", "user", "USER" }
                });
        }
    }
}
