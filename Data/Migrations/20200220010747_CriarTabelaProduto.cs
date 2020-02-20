using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CriarTabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Cliente",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 19, 22, 7, 47, 412, DateTimeKind.Local).AddTicks(3044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 2, 19, 21, 19, 49, 558, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(maxLength: 250, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    ClienteId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ClienteId",
                table: "Produto",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ClienteId1",
                table: "Produto",
                column: "ClienteId1",
                unique: true,
                filter: "[ClienteId1] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 19, 21, 19, 49, 558, DateTimeKind.Local).AddTicks(3930),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 19, 22, 7, 47, 412, DateTimeKind.Local).AddTicks(3044));
        }
    }
}
