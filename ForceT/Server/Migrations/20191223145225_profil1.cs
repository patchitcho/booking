using Microsoft.EntityFrameworkCore.Migrations;

namespace ForceT.Server.Migrations
{
    public partial class profil1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ProfilId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ProfilId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ProfilId",
                table: "AspNetUserRoles");

            migrationBuilder.AddColumn<string>(
                name: "ProfilId",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ProfilId",
                table: "AspNetRoles",
                column: "ProfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_ProfilId",
                table: "AspNetRoles",
                column: "ProfilId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_ProfilId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_ProfilId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ProfilId",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "ProfilId",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ProfilId",
                table: "AspNetUserRoles",
                column: "ProfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ProfilId",
                table: "AspNetUserRoles",
                column: "ProfilId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
