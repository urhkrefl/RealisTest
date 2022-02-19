using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealisTest.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestInput",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    inputDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    inputTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestInput", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TestInput",
                columns: new[] { "Id", "Name", "inputDate", "inputTime" },
                values: new object[] { 1, "Testing", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 21, 5, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestInput");
        }
    }
}
