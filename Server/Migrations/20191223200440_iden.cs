using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proxima.Server.Migrations
{
    public partial class iden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_ProfilId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_ProfilId",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0271e846-eb67-409e-af24-1fee48982897");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0499cd0a-1d3d-486a-b31a-a53313947b3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "083fb77b-c657-4d91-9b1e-f69ed0fd01d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c59916b-8238-45b8-ad16-1db52eea075a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1426379a-41c8-47d2-acc2-4eae9f64953c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "177da35d-cfaf-46ba-89d1-332dc579c4bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2079eaac-dd90-45b3-96fe-cf89454f62c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "258b8747-801a-482d-959c-3f3c89b0096d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a05b3ff-16e9-493e-b4a6-5dad27044534");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e484cb3-7118-48ee-86aa-56072cff74a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "323d80ec-131d-4e16-8900-faa6f0368a05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b6febf6-5bf0-4eb7-9cfe-eac6900deea0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59abb89d-87c1-494f-aee5-435c50956f98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e63715b-7bce-468d-91a6-480f94124833");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6448ca0e-71ac-488d-b06e-8523230479c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "655ffac2-5e91-4ed2-b5da-c6ed08b6a36d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "671c3f34-36c8-4eac-a198-502cdfe8b4c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bc232d0-47a8-466a-aec1-a78ad76b6a87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74eefd9f-02a1-4efe-977f-47a7ba44c32f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75b185ba-4e98-477f-b9ec-c18ac990e6b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "816aaba6-9562-4781-b8c4-aed89f256b94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94ce159b-f90a-49bf-97b6-26d52d76de5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad697b99-8515-47c4-abd9-41bd6ed9f8c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1906b8f-7416-46af-bffd-89effd4b3057");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9d1c564-cecf-4bff-8528-adcbb1cc1527");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d43ab8b6-51ea-407c-a91b-c11a9a0aeb05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f69f6d5a-363f-40fa-a964-19ba7dce66e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb87144b-49d9-4d54-a234-48a770f846df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fecd1e0f-21b3-4958-b76e-06451aea7740");

            migrationBuilder.DropColumn(
                name: "name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "profilId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilId",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ecb5ea3-bc2c-4104-9039-e6cdfa90cb8b", "5ca21059-f849-4b21-8520-441a7690117f", "Admin", "ADMIN" },
                    { "ef014bd2-48d9-4d1c-b979-5408c7b1f1b9", "2d7092e7-0a52-4f2f-93fa-fb17e2785048", "TourneeUpdt", "TourneeUpdt" },
                    { "0ad4642f-b9cb-4984-8711-ccd12eae39ea", "3c26426b-2d0d-4580-9a64-d2a47d199926", "TourneeRead", "TourneeRead" },
                    { "b36590f6-15de-424c-90bb-445843f461aa", "6d82d3bb-fd3e-4b0e-b2f8-53cf5207706b", "TourneeCreat", "TourneeCreat" },
                    { "4708784e-83e1-4436-9657-c54bd82456f7", "418c1a02-ad97-4d73-9720-edeaf11928e9", "CourseDlet", "CourseDlet" },
                    { "b3cb1cd9-4e07-4031-8d6d-99871ed3fcdd", "1784cdca-8288-45df-9942-c27b60487b5e", "CourseUpdt", "CourseUpdt" },
                    { "ed636012-715c-4cfa-8f8e-39aa66c41628", "df4057fe-a956-4019-8199-b3cbf31c0e14", "CourseRead", "CourseRead" },
                    { "5a242a31-76c8-4ed4-91b3-55f9fc4a3800", "86efcd0d-7d41-4a88-8c5d-30ead472dee5", "CourseCreat", "CourseCreat" },
                    { "67384571-5cb6-46bc-87a0-6e38b9379893", "21bcd5e9-02d0-4136-ad33-773dd71b130e", "AdresseDlet", "AdresseDlet" },
                    { "a80aabae-8bc0-47f4-b06b-f092bb439071", "a4360e7a-a578-4af7-a305-df20726eef14", "AdresseUpdt", "AdresseUpdt" },
                    { "6b301ee8-22d8-4890-a2d0-00fe41a882df", "25176a29-748e-45aa-807e-ab9bb1def50b", "AdresseRead", "AdresseRead" },
                    { "605db567-0072-4fae-b32e-37192aa57dbf", "54fd8058-9129-405e-a9cb-e7f97162aead", "AdresseCreat", "AdresseCreat" },
                    { "35cd68f3-7fbe-43e6-9681-4f356e9a5f45", "0e539161-c3dd-4473-951d-5e778274f392", "AgenceDlet", "AgenceDlet" },
                    { "3c299db1-2c54-4a6d-a5b8-968f7ea1b017", "3c21cc10-1f80-48ae-aa00-45bb2a5463bd", "AgenceUpdt", "AgenceUpdt" },
                    { "7e52f5ce-056e-4963-bbea-9e85abfdf140", "c5466864-77d4-4f62-bcbd-672e9db6b021", "AgenceRead", "AgenceRead" },
                    { "d42ad489-13cc-44a5-ad14-2ea980f26e52", "54d86890-79e2-4ab9-bda3-6a4a2e67ac5d", "AgenceCreat", "AgenceCreat" },
                    { "2a88db49-2931-41f3-b03b-8124420de987", "ac5ff6ff-48ca-4694-bf46-cbf596a078cb", "ZoneDlet", "ZoneDlet" },
                    { "0539982b-449a-42a5-ba85-340b1a46dca4", "58d10ec1-ae04-4887-b674-b72d06485079", "ZoneUpdt", "ZoneUpdt" },
                    { "0387338c-c618-49bd-ac3f-552b70fd0790", "53fdb4d1-841b-4474-a3d9-dd015cd4331f", "ZoneRead", "ZoneRead" },
                    { "ea0caa4b-3b40-46ac-9ff9-eb81b5e4d455", "aac302ab-e5d4-480c-8e73-9ee2e39f2fc7", "ZoneCreat", "ZoneCreat" },
                    { "11b03500-7f50-4e9c-b489-7b7475f8df62", "7f568a63-aba6-4079-9205-885bc98449a6", "SondageDlet", "SondageDlet" },
                    { "3c29eb8a-5fec-463a-8f71-5f7a753afec1", "a57d7bab-c026-4f7b-a1ce-abde18d0b283", "SondageUpdt", "SondageUpdt" },
                    { "3e757a24-33f0-4754-9cbe-e78e3923ccf0", "e057e051-7e9c-46e5-bbb3-5e7f40764410", "SondageRead", "SondageRead" },
                    { "3c03b439-7316-48e7-8865-3f261c075a72", "3f16b1de-5b05-4d50-9661-d8e64fa3689a", "SondageCreat", "SondageCreat" },
                    { "d171c020-2e65-43c8-9bd2-351c90c9f906", "716eea5e-b985-4be8-a5fd-329c07eb8ef0", "VehiculeDlet", "VehiculeDlet" },
                    { "a8614a1f-55cf-4b2d-9d74-6da7af8e988a", "6369c1a5-fc8f-4228-b816-9c2eba451574", "VehiculeUpdt", "VehiculeUpdt" },
                    { "5a21b337-54df-44af-b76d-36a89a0b1203", "19f3e9a3-0936-4518-b907-0e2180def9db", "VehiculeRead", "VehiculeRead" },
                    { "3f69bebd-4203-4b0f-962f-1eccdc163074", "d17b65a8-a19a-4d0c-b498-ed0debc76802", "VehiculeCreat", "VehiculeCreat" },
                    { "ac5d9389-c11b-46c9-b6c4-ec278128fb8c", "bbb16680-ac5a-4d86-bd5b-1cd80af6e4fe", "TourneeDlet", "TourneeDlet" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "43592427-a291-46be-8cf9-a89314b496dc", 0, "cd4ca31c-cb33-4125-a9d4-4264a6605768", "admin@Proximaracking.com", false, true, null, "ADMIN@ProximaRACKING.COM", "ADMINISTRATEUR", "AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==", "", false, "Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL", false, "administrateur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "profilId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilId",
                table: "AspNetRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "ProfilId" },
                values: new object[,]
                {
                    { "671c3f34-36c8-4eac-a198-502cdfe8b4c3", "43c9d552-da99-4dc8-9566-ad18efe00e05", "Admin", "ADMIN", null },
                    { "6bc232d0-47a8-466a-aec1-a78ad76b6a87", "9d8c9e54-be5e-4e6e-be78-a2b40a747a12", "TourneeRead", "TourneeRead", null },
                    { "d43ab8b6-51ea-407c-a91b-c11a9a0aeb05", "74e216fa-a275-4d99-b7d1-f23f69d491db", "TourneeCreat", "TourneeCreat", null },
                    { "2e484cb3-7118-48ee-86aa-56072cff74a3", "757a07b6-d806-44b7-aebd-d756ca7814f3", "CourseDlet", "CourseDlet", null },
                    { "2a05b3ff-16e9-493e-b4a6-5dad27044534", "63aa1c09-2951-44f4-83e2-0cafea3dd366", "CourseUpdt", "CourseUpdt", null },
                    { "655ffac2-5e91-4ed2-b5da-c6ed08b6a36d", "e5769292-447c-46d5-97e6-a68f5db5054e", "CourseRead", "CourseRead", null },
                    { "6448ca0e-71ac-488d-b06e-8523230479c6", "81499670-066e-46de-8d03-b48639bf029a", "CourseCreat", "CourseCreat", null },
                    { "816aaba6-9562-4781-b8c4-aed89f256b94", "dd2736d4-3225-4e30-9b15-460728956a46", "AdresseDlet", "AdresseDlet", null },
                    { "74eefd9f-02a1-4efe-977f-47a7ba44c32f", "d68fe02f-106d-445b-8b8f-fb19c695c922", "AdresseUpdt", "AdresseUpdt", null },
                    { "0499cd0a-1d3d-486a-b31a-a53313947b3c", "093036e8-9e5d-4db1-b860-2e001893c744", "AdresseRead", "AdresseRead", null },
                    { "083fb77b-c657-4d91-9b1e-f69ed0fd01d2", "adf843a5-1ff5-4fca-b281-c6a9b543f056", "AdresseCreat", "AdresseCreat", null },
                    { "258b8747-801a-482d-959c-3f3c89b0096d", "992c9796-2229-4e42-8c8a-9cada7c91810", "AgenceDlet", "AgenceDlet", null },
                    { "2079eaac-dd90-45b3-96fe-cf89454f62c1", "14b3772d-2409-465b-9954-949538be500b", "AgenceUpdt", "AgenceUpdt", null },
                    { "ad697b99-8515-47c4-abd9-41bd6ed9f8c8", "a933bd60-c3f2-4477-a13b-0f0d48f12329", "TourneeUpdt", "TourneeUpdt", null },
                    { "75b185ba-4e98-477f-b9ec-c18ac990e6b5", "e00e2a26-1f8e-44e3-809a-ad2a08e0dae6", "AgenceRead", "AgenceRead", null },
                    { "323d80ec-131d-4e16-8900-faa6f0368a05", "7bb825c5-792c-4d2b-8804-5c6567e1f4d3", "ZoneDlet", "ZoneDlet", null },
                    { "0271e846-eb67-409e-af24-1fee48982897", "14074b29-ffd7-4fb7-b666-106b6b52466e", "ZoneUpdt", "ZoneUpdt", null },
                    { "fb87144b-49d9-4d54-a234-48a770f846df", "91a0a81c-4d6e-4403-bb97-c884fd78954b", "ZoneRead", "ZoneRead", null },
                    { "b1906b8f-7416-46af-bffd-89effd4b3057", "7585ac36-1101-4922-8391-a42aa3e4291f", "ZoneCreat", "ZoneCreat", null },
                    { "0c59916b-8238-45b8-ad16-1db52eea075a", "db314e89-e819-48d8-bc19-8ea4b5c7384c", "SondageDlet", "SondageDlet", null },
                    { "b9d1c564-cecf-4bff-8528-adcbb1cc1527", "5804382c-7f2f-488c-b04e-81d9d003629c", "SondageUpdt", "SondageUpdt", null },
                    { "f69f6d5a-363f-40fa-a964-19ba7dce66e8", "60aa7b13-ef86-4531-95a9-f52d32966637", "SondageRead", "SondageRead", null },
                    { "1426379a-41c8-47d2-acc2-4eae9f64953c", "69c23d87-4cc5-474a-a61d-50c889e63298", "SondageCreat", "SondageCreat", null },
                    { "177da35d-cfaf-46ba-89d1-332dc579c4bf", "bd8c8988-942a-46b3-9ffa-fd6d044ef532", "VehiculeDlet", "VehiculeDlet", null },
                    { "3b6febf6-5bf0-4eb7-9cfe-eac6900deea0", "1c1d3287-b0b3-4976-ab10-ad8bd991c09d", "VehiculeUpdt", "VehiculeUpdt", null },
                    { "59abb89d-87c1-494f-aee5-435c50956f98", "ad91181b-c6b6-4eee-8b1e-e5e446f24ede", "VehiculeRead", "VehiculeRead", null },
                    { "fecd1e0f-21b3-4958-b76e-06451aea7740", "173573f6-a527-4c0c-98d2-2021da3a0752", "VehiculeCreat", "VehiculeCreat", null },
                    { "94ce159b-f90a-49bf-97b6-26d52d76de5f", "f05cf539-de3f-4843-8588-d9da37e893c3", "AgenceCreat", "AgenceCreat", null },
                    { "5e63715b-7bce-468d-91a6-480f94124833", "28b3e004-98e4-46f6-894c-962b35a19337", "TourneeDlet", "TourneeDlet", null }
                });

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
    }
}
