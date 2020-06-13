using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class PedidoPedidoSituacao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoSituacaos_Pedidoss_PedidoId",
                table: "PedidoSituacaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidoss_Clientes_ClienteId",
                table: "Pedidoss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidoss",
                table: "Pedidoss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoSituacaos",
                table: "PedidoSituacaos");

            migrationBuilder.RenameTable(
                name: "Pedidoss",
                newName: "Pedidos");

            migrationBuilder.RenameTable(
                name: "PedidoSituacaos",
                newName: "PedidoSituacoes");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidoss_ClienteId",
                table: "Pedidos",
                newName: "IX_Pedidos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoSituacaos_PedidoId",
                table: "PedidoSituacoes",
                newName: "IX_PedidoSituacoes_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoSituacoes",
                table: "PedidoSituacoes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoSituacoes_Pedidos_PedidoId",
                table: "PedidoSituacoes",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoSituacoes_Pedidos_PedidoId",
                table: "PedidoSituacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoSituacoes",
                table: "PedidoSituacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.RenameTable(
                name: "PedidoSituacoes",
                newName: "PedidoSituacaos");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "Pedidoss");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoSituacoes_PedidoId",
                table: "PedidoSituacaos",
                newName: "IX_PedidoSituacaos_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidoss",
                newName: "IX_Pedidoss_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoSituacaos",
                table: "PedidoSituacaos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidoss",
                table: "Pedidoss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoSituacaos_Pedidoss_PedidoId",
                table: "PedidoSituacaos",
                column: "PedidoId",
                principalTable: "Pedidoss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidoss_Clientes_ClienteId",
                table: "Pedidoss",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
