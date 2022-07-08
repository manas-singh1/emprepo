using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppAssingment.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employeer",
                columns: table => new
                {
                    EId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDoj = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeer", x => x.EId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employeer");
        }
    }
}
