using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForceT.Server.Migrations
{
    public partial class iden1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69c2620c-5b13-47d3-9f5e-fff5370bd8c2", "81c9403b-d4cd-4edb-8929-440aad2ae209", "Admin", "ADMIN" },
                    { "1b794e51-8266-47d2-bb24-7ecf71852c36", "d47ae7e8-efd7-4c01-a77c-25ef78cbeda6", "TourneeUpdt", "TourneeUpdt" },
                    { "058ac7fe-6e0c-4791-aea9-7e490e19f43b", "a6cd5701-be32-4662-a8e4-590f228e0038", "TourneeRead", "TourneeRead" },
                    { "42809b08-20d2-407b-b195-b249170bd214", "a5aaa19d-1dfd-4338-9703-47d6ab0a73fd", "TourneeCreat", "TourneeCreat" },
                    { "ce6ac039-3339-417d-8496-9166c0e2a5df", "7a43292d-e25a-48ae-8573-5ba46000fa63", "CourseDlet", "CourseDlet" },
                    { "1e9daf8c-4c68-46ca-9050-cd172d233fb5", "799fdb6f-150c-4390-8c67-18e0774afc3e", "CourseUpdt", "CourseUpdt" },
                    { "7b172b78-5904-4947-aa06-1086a8257673", "56228f11-6669-47bb-896a-9314b431459d", "CourseRead", "CourseRead" },
                    { "be82510e-97c1-44ef-95b9-3cb1a8f1bad3", "d0d3aa62-0767-41fe-988f-5ef8d2418f87", "CourseCreat", "CourseCreat" },
                    { "40f46f9c-b0bb-4580-b910-3446209bf317", "d8e543e2-933f-4d51-a959-f60aadf04f05", "AdresseDlet", "AdresseDlet" },
                    { "1d2a9f13-8e1b-44c8-81f2-1f7e76ce974d", "36e0c674-0800-4480-909e-0f96a52264f0", "AdresseUpdt", "AdresseUpdt" },
                    { "037a1502-76d7-45cc-a7c5-79e0c8fe2291", "6fa980da-d17f-4608-88b5-7386af329ac9", "AdresseRead", "AdresseRead" },
                    { "9d13d7b1-4304-4b3c-a347-16994952ee21", "63aa0863-af2c-4465-9245-73ec84d10f81", "AdresseCreat", "AdresseCreat" },
                    { "b5545546-10e1-4625-ad10-6daf8c37848a", "5ef2e343-4ec7-42c4-b6c7-bdfb44cbcb99", "AgenceDlet", "AgenceDlet" },
                    { "313e8ee5-84a6-495d-9ebf-79e7129b2fff", "3f507399-a42b-4dad-8d3e-f561f9721685", "AgenceUpdt", "AgenceUpdt" },
                    { "0044889a-e7d7-4b58-a128-1675638a83a2", "207ca19d-2c9a-4756-8854-d8cf39176c4a", "AgenceRead", "AgenceRead" },
                    { "fb0db5ea-8474-418e-aaa4-0f35a126f97c", "b77a1ec7-bf70-4bb7-8998-fc9d904c2932", "AgenceCreat", "AgenceCreat" },
                    { "376f6768-fd8a-49d7-b5c1-991fe1d6d700", "d863d05e-06ae-4b74-8622-cd8bbd065c8c", "ZoneDlet", "ZoneDlet" },
                    { "e710f164-f5ee-409f-bf4c-0e8eb7f86faa", "0ae662eb-3a77-49e6-8cc0-dff36d783816", "ZoneUpdt", "ZoneUpdt" },
                    { "a7c94eae-d5f7-4de1-8a4e-35e6966e93e0", "bb99b0dd-ab37-4b50-ab58-3c23093faebe", "ZoneRead", "ZoneRead" },
                    { "7b6a59f4-47e5-4779-89d9-506828955e0a", "abd6dacc-395a-4d51-bb5a-d6b6c3511807", "ZoneCreat", "ZoneCreat" },
                    { "c92c7326-d847-4e38-963d-47377d5651d8", "39ba1ce5-c669-4eab-97ac-15af69dd32d8", "SondageDlet", "SondageDlet" },
                    { "8d0d3cb6-c823-43d6-9c86-ba0217198f32", "4eeddb68-3eba-40fc-9141-e39e8a5a18ad", "SondageUpdt", "SondageUpdt" },
                    { "efbb2427-b17f-43ca-be5b-b5ce00ca96eb", "9a404fe4-bc20-46ae-b707-0bac1874dd96", "SondageRead", "SondageRead" },
                    { "80aeb289-858a-4e17-be4c-bf2665162068", "da09a1e8-eb18-44d2-acb2-0dd7242523c3", "SondageCreat", "SondageCreat" },
                    { "207562aa-bfe6-475d-b9eb-c0e0600704ed", "1e77cd9d-a17a-4965-887a-3c84dade92f6", "VehiculeDlet", "VehiculeDlet" },
                    { "c3d82a71-c0cd-4420-adb1-225e349e14a9", "0779906f-ea2b-416a-9f2d-0ab7129af866", "VehiculeUpdt", "VehiculeUpdt" },
                    { "cb50b92d-417c-443c-b06d-e245cda807ed", "62b7839d-9c1b-40eb-8f6c-4b162916bd35", "VehiculeRead", "VehiculeRead" },
                    { "4d9e7d2d-65ed-4620-8898-c4bfe8600e63", "5b342b11-13ee-4221-8b4d-c161f663996f", "VehiculeCreat", "VehiculeCreat" },
                    { "0ade0a90-9403-42f9-b4f9-318383d06980", "c601287b-c2ea-42d5-b76b-290d719a09bc", "TourneeDlet", "TourneeDlet" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7d392424-e2c6-434b-ac49-9bb33e8293be", 0, "cd4ca31c-cb33-4125-a9d4-4264a6605768", "admin@forcetracking.com", false, true, null, "ADMIN@FORCETRACKING.COM", "ADMINISTRATEUR", "AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==", "", false, "Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL", false, "administrateur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0044889a-e7d7-4b58-a128-1675638a83a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "037a1502-76d7-45cc-a7c5-79e0c8fe2291");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "058ac7fe-6e0c-4791-aea9-7e490e19f43b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ade0a90-9403-42f9-b4f9-318383d06980");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b794e51-8266-47d2-bb24-7ecf71852c36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d2a9f13-8e1b-44c8-81f2-1f7e76ce974d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e9daf8c-4c68-46ca-9050-cd172d233fb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "207562aa-bfe6-475d-b9eb-c0e0600704ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "313e8ee5-84a6-495d-9ebf-79e7129b2fff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "376f6768-fd8a-49d7-b5c1-991fe1d6d700");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f46f9c-b0bb-4580-b910-3446209bf317");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42809b08-20d2-407b-b195-b249170bd214");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d9e7d2d-65ed-4620-8898-c4bfe8600e63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69c2620c-5b13-47d3-9f5e-fff5370bd8c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b172b78-5904-4947-aa06-1086a8257673");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b6a59f4-47e5-4779-89d9-506828955e0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80aeb289-858a-4e17-be4c-bf2665162068");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d0d3cb6-c823-43d6-9c86-ba0217198f32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d13d7b1-4304-4b3c-a347-16994952ee21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7c94eae-d5f7-4de1-8a4e-35e6966e93e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5545546-10e1-4625-ad10-6daf8c37848a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be82510e-97c1-44ef-95b9-3cb1a8f1bad3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3d82a71-c0cd-4420-adb1-225e349e14a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c92c7326-d847-4e38-963d-47377d5651d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb50b92d-417c-443c-b06d-e245cda807ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce6ac039-3339-417d-8496-9166c0e2a5df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e710f164-f5ee-409f-bf4c-0e8eb7f86faa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efbb2427-b17f-43ca-be5b-b5ce00ca96eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb0db5ea-8474-418e-aaa4-0f35a126f97c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d392424-e2c6-434b-ac49-9bb33e8293be");

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                values: new object[] { "43592427-a291-46be-8cf9-a89314b496dc", 0, "cd4ca31c-cb33-4125-a9d4-4264a6605768", "admin@forcetracking.com", false, true, null, "ADMIN@FORCETRACKING.COM", "ADMINISTRATEUR", "AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==", "", false, "Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL", false, "administrateur" });
        }
    }
}
