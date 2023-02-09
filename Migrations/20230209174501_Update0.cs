using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace technicalAssesment.Migrations
{
    /// <inheritdoc />
    public partial class Update0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerData",
                columns: table => new
                {
                    dataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cellphone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    physicalAddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    physicalSuburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    physicalCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    physicalPostalCode = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    postalAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalSuburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalCode = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerData", x => x.dataId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerData");
        }
    }
}
