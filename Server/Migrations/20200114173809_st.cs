using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proxima.Server.Migrations
{
    public partial class st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Familleproduit",
                columns: table => new
                {
                    FamilleproduitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libellé = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familleproduit", x => x.FamilleproduitId);
                });

            migrationBuilder.CreateTable(
                name: "JournalStock",
                columns: table => new
                {
                    JournalStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Qte = table.Column<int>(nullable: false),
                    Motif = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalStock", x => x.JournalStockId);
                });

            migrationBuilder.CreateTable(
                name: "JournalStockV",
                columns: table => new
                {
                    JournalStockVId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Qte = table.Column<int>(nullable: false),
                    Motif = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalStockV", x => x.JournalStockVId);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    ProduitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeArticle = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Prix = table.Column<double>(nullable: false),
                    TypeproduitId = table.Column<int>(nullable: false),
                    FamilleproduitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.ProduitId);
                });

            migrationBuilder.CreateTable(
                name: "Quantite",
                columns: table => new
                {
                    QuantiteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qte = table.Column<int>(nullable: false),
                    ProduitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantite", x => x.QuantiteId);
                });

            migrationBuilder.CreateTable(
                name: "StockInterne",
                columns: table => new
                {
                    StockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(nullable: false),
                    Quantite = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInterne", x => x.StockId);
                });

            migrationBuilder.CreateTable(
                name: "StockVehicule",
                columns: table => new
                {
                    StockVId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiculeId = table.Column<int>(nullable: false),
                    ProduitId = table.Column<int>(nullable: false),
                    Qte = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockVehicule", x => x.StockVId);
                });

            migrationBuilder.CreateTable(
                name: "Typeproduit",
                columns: table => new
                {
                    TypeproduitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libellé = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typeproduit", x => x.TypeproduitId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Familleproduit");

            migrationBuilder.DropTable(
                name: "JournalStock");

            migrationBuilder.DropTable(
                name: "JournalStockV");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Quantite");

            migrationBuilder.DropTable(
                name: "StockInterne");

            migrationBuilder.DropTable(
                name: "StockVehicule");

            migrationBuilder.DropTable(
                name: "Typeproduit");
        }
    }
}
