using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAutores.Migrations
{
    public partial class Peticiones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peticions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LlaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPeticion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LlaveId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peticions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peticions_LlavesApi_LlaveId1",
                        column: x => x.LlaveId1,
                        principalTable: "LlavesApi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peticions_LlaveId1",
                table: "Peticions",
                column: "LlaveId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peticions");
        }
    }
}
