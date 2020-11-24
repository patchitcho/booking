using Microsoft.EntityFrameworkCore.Migrations;

namespace ForceT.Server.Migrations
{
    public partial class addadr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    AdresseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Societé = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: false),
                    Ville = table.Column<string>(nullable: false),
                    Codepostale = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Agenceid = table.Column<int>(nullable: false),
                    Commentaire = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.AdresseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresse");
        }
    }
}
