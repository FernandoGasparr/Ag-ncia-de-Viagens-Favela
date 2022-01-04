using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Favela.Migrations
{
    public partial class favela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_promocao_FPromocaoId",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_promocao",
                table: "promocao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "promocao",
                newName: "FPromocao");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "FCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_FPromocaoId",
                table: "FCliente",
                newName: "IX_FCliente_FPromocaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FPromocao",
                table: "FPromocao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FCliente",
                table: "FCliente",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FCliente_FPromocao_FPromocaoId",
                table: "FCliente",
                column: "FPromocaoId",
                principalTable: "FPromocao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FCliente_FPromocao_FPromocaoId",
                table: "FCliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FPromocao",
                table: "FPromocao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FCliente",
                table: "FCliente");

            migrationBuilder.RenameTable(
                name: "FPromocao",
                newName: "promocao");

            migrationBuilder.RenameTable(
                name: "FCliente",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_FCliente_FPromocaoId",
                table: "Cliente",
                newName: "IX_Cliente_FPromocaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_promocao",
                table: "promocao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_promocao_FPromocaoId",
                table: "Cliente",
                column: "FPromocaoId",
                principalTable: "promocao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
