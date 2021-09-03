using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class IhopeFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstonianOfficeId",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Borrowings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beginning = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Employee_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstonianOffice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstonianOffice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beginning = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(nullable: true),
                    foundingDate = table.Column<DateTime>(nullable: false),
                    EstonianOfficeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_EstonianOffice_EstonianOfficeId",
                        column: x => x.EstonianOfficeId,
                        principalTable: "EstonianOffice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EstonianOfficeId",
                table: "Employee",
                column: "EstonianOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_EstonianOfficeId",
                table: "Company",
                column: "EstonianOfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EstonianOffice_EstonianOfficeId",
                table: "Employee",
                column: "EstonianOfficeId",
                principalTable: "EstonianOffice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EstonianOffice_EstonianOfficeId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Borrowings");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "EstonianOffice");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EstonianOfficeId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EstonianOfficeId",
                table: "Employee");
        }
    }
}
