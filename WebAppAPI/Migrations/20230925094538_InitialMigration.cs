using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BU_CODE5 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OPENED_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CURRENCY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BUSINESS_HOURS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LATITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LONGITUDE = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BU_CODE5);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
