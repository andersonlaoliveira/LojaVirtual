using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class PedidoPedidoSituacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidoss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cliente = table.Column<int>(nullable: true),
                    TransactionId = table.Column<string>(nullable: true),
                    FreteEmpresa = table.Column<string>(nullable: true),
                    FreteCodRastreamento = table.Column<string>(nullable: true),
                    FormaPagamento = table.Column<string>(nullable: true),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    DadosTransaction = table.Column<string>(nullable: true),
                    DadosProdutos = table.Column<string>(nullable: true),
                    DataRegistro = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<string>(nullable: true),
                    NFE = table.Column<string>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidoss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidoss_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidoSituacaos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<string>(nullable: true),
                    Dados = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoSituacaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoSituacaos_Pedidoss_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidoss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoSituacaos_PedidoId",
                table: "PedidoSituacaos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidoss_ClienteId",
                table: "Pedidoss",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoSituacaos");

            migrationBuilder.DropTable(
                name: "Pedidoss");
        }
    }
}
