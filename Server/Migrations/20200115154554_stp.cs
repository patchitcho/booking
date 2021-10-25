using Microsoft.EntityFrameworkCore.Migrations;

namespace Proxima.Server.Migrations
{
    public partial class stp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProduitId",
                table: "StockInterne",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_StockInterne_ProduitId",
                table: "StockInterne",
                column: "ProduitId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockInterne_Produit_ProduitId",
                table: "StockInterne",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "ProduitId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockInterne_Produit_ProduitId",
                table: "StockInterne");

            migrationBuilder.DropIndex(
                name: "IX_StockInterne_ProduitId",
                table: "StockInterne");

            migrationBuilder.AlterColumn<int>(
                name: "ProduitId",
                table: "StockInterne",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
