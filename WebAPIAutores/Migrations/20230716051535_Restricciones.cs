using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAutores.Migrations
{
    public partial class Restricciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peticions_LlavesApi_LlaveId1",
                table: "Peticions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peticions",
                table: "Peticions");

            migrationBuilder.DropIndex(
                name: "IX_Peticions_LlaveId1",
                table: "Peticions");

            migrationBuilder.DropColumn(
                name: "LlaveId1",
                table: "Peticions");

            migrationBuilder.RenameTable(
                name: "Peticions",
                newName: "Peticiones");

            migrationBuilder.AlterColumn<int>(
                name: "LlaveId",
                table: "Peticiones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peticiones",
                table: "Peticiones",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RestriccionesDominio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LlaveId = table.Column<int>(type: "int", nullable: false),
                    Dominio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestriccionesDominio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestriccionesDominio_LlavesApi_LlaveId",
                        column: x => x.LlaveId,
                        principalTable: "LlavesApi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestriccionesIP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LlaveId = table.Column<int>(type: "int", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestriccionesIP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestriccionesIP_LlavesApi_LlaveId",
                        column: x => x.LlaveId,
                        principalTable: "LlavesApi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peticiones_LlaveId",
                table: "Peticiones",
                column: "LlaveId");

            migrationBuilder.CreateIndex(
                name: "IX_RestriccionesDominio_LlaveId",
                table: "RestriccionesDominio",
                column: "LlaveId");

            migrationBuilder.CreateIndex(
                name: "IX_RestriccionesIP_LlaveId",
                table: "RestriccionesIP",
                column: "LlaveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peticiones_LlavesApi_LlaveId",
                table: "Peticiones",
                column: "LlaveId",
                principalTable: "LlavesApi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peticiones_LlavesApi_LlaveId",
                table: "Peticiones");

            migrationBuilder.DropTable(
                name: "RestriccionesDominio");

            migrationBuilder.DropTable(
                name: "RestriccionesIP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peticiones",
                table: "Peticiones");

            migrationBuilder.DropIndex(
                name: "IX_Peticiones_LlaveId",
                table: "Peticiones");

            migrationBuilder.RenameTable(
                name: "Peticiones",
                newName: "Peticions");

            migrationBuilder.AlterColumn<string>(
                name: "LlaveId",
                table: "Peticions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LlaveId1",
                table: "Peticions",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peticions",
                table: "Peticions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Peticions_LlaveId1",
                table: "Peticions",
                column: "LlaveId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Peticions_LlavesApi_LlaveId1",
                table: "Peticions",
                column: "LlaveId1",
                principalTable: "LlavesApi",
                principalColumn: "Id");
        }
    }
}
