using Microsoft.EntityFrameworkCore.Migrations;

namespace DrugStore.Migrations
{
    public partial class _4thDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPFCliente = table.Column<string>(nullable: true),
                    VendedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Funcionario_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemCompra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    CompraId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Compra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Medicamento_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_VendedorId",
                table: "Compra",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_CompraId",
                table: "ItemCompra",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_ProdutoId",
                table: "ItemCompra",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemCompra");

            migrationBuilder.DropTable(
                name: "Compra");
        }
    }
}
