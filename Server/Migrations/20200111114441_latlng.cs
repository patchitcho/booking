using Microsoft.EntityFrameworkCore.Migrations;

namespace Proxima.Server.Migrations
{
    public partial class latlng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01eb0c02-cac6-43f6-a07b-03fe8f6a5a2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093c7e83-9ce6-4ce9-a4ce-f7beee924ee5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09e1a27f-3287-4daf-b9ff-910135be58f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "147b1761-3114-44e2-8504-62010c7a1481");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee98e5d-d636-4117-9537-b32fd8bd1374");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31e0d721-94ba-43d2-874d-a45beee884bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33b7aaa6-6718-4ba3-a138-828ba28972f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3483bf12-7395-49ea-8d17-0c89dd7ec0fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ba57626-6a90-4459-abbe-188e41b73d91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41856507-b2a4-42ea-99b7-94cf396f0c36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4401f048-782d-4471-a4c9-f60510d9ac1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48d679f7-9953-4d1a-b33e-8100f2d5e560");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52a4d577-dac0-4d36-976b-80f892ed97eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53b471ba-7053-4d1b-9fc8-f36cbcfa8cd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53cb97bd-4289-48cf-8527-f38c7a6678b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c5992dc-a493-41a7-8369-80fa80d8cf2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "779f708f-56a2-4483-9e7c-63f2bf910cd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999b4fcb-fc79-47e0-b09e-f81b335617f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e80623f-68e8-4a93-a45b-1535f5be2663");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a00a2fcf-495a-4ff0-bbec-95305a395e49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a09b197e-666f-48b8-a02b-bef752723df3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1717271-5dad-4dfb-8824-50a5c8954c09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8e59641-c4bc-422e-9eec-ff712e772001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af7b3e3a-cec6-47b7-912c-7327be558003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8b7be73-b0d5-4359-8b11-a7008141661c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfe93425-594a-4f1f-9a88-685148302021");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "debb4d0a-28f2-4884-a537-8f66f6fff4a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7babf98-b14e-4944-aee1-254b15ca3708");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff4f6fd8-f22d-4568-bdd4-05eeb4f1a80d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "806edb29-9623-435c-9d2c-8b9629bf8349");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bfe93425-594a-4f1f-9a88-685148302021", "6c4023f5-c305-44a6-898c-40b3d2626762", "Admin", "ADMIN" },
                    { "f7babf98-b14e-4944-aee1-254b15ca3708", "12b68af3-f102-40d7-aa51-db8d75b653f1", "TourneeUpdt", "TourneeUpdt" },
                    { "779f708f-56a2-4483-9e7c-63f2bf910cd9", "11557517-3c16-439b-8744-251dad9751c9", "TourneeRead", "TourneeRead" },
                    { "ff4f6fd8-f22d-4568-bdd4-05eeb4f1a80d", "bdc0d432-6802-46d8-a97d-de3082bda90e", "TourneeCreat", "TourneeCreat" },
                    { "a8e59641-c4bc-422e-9eec-ff712e772001", "220eae1e-f579-408b-8ccf-66fe599d4856", "CourseDlet", "CourseDlet" },
                    { "093c7e83-9ce6-4ce9-a4ce-f7beee924ee5", "b2b520c7-03ae-42ac-8b5e-779c61f28fc9", "CourseUpdt", "CourseUpdt" },
                    { "147b1761-3114-44e2-8504-62010c7a1481", "03697f3f-40eb-4b44-b5f5-ce0aa2bdfb06", "CourseRead", "CourseRead" },
                    { "3483bf12-7395-49ea-8d17-0c89dd7ec0fb", "1d3ae06a-1789-423d-9100-24dcbce360d8", "CourseCreat", "CourseCreat" },
                    { "a00a2fcf-495a-4ff0-bbec-95305a395e49", "163b077f-476d-4a4b-88a3-94285709f53d", "AdresseDlet", "AdresseDlet" },
                    { "4401f048-782d-4471-a4c9-f60510d9ac1f", "283b121d-0e14-486d-a27a-30c1fb3bce83", "AdresseUpdt", "AdresseUpdt" },
                    { "48d679f7-9953-4d1a-b33e-8100f2d5e560", "bf55a24f-d81c-4ed6-997b-57cb3062e054", "AdresseRead", "AdresseRead" },
                    { "53cb97bd-4289-48cf-8527-f38c7a6678b6", "2920bad0-45bc-47e1-84c6-4a8e804c4a07", "AdresseCreat", "AdresseCreat" },
                    { "09e1a27f-3287-4daf-b9ff-910135be58f4", "fbb091c6-49b4-4d03-bc53-a68d07704678", "AgenceDlet", "AgenceDlet" },
                    { "1ee98e5d-d636-4117-9537-b32fd8bd1374", "2279b7db-c187-4d66-9835-14f700bc2454", "AgenceUpdt", "AgenceUpdt" },
                    { "01eb0c02-cac6-43f6-a07b-03fe8f6a5a2a", "9fd2a2a6-b1f5-43ac-ae15-1cc51c7d9c02", "AgenceRead", "AgenceRead" },
                    { "52a4d577-dac0-4d36-976b-80f892ed97eb", "bc958c7a-e6a0-47d5-bb8f-2be29e255264", "AgenceCreat", "AgenceCreat" },
                    { "999b4fcb-fc79-47e0-b09e-f81b335617f6", "d3f66466-f1dd-4332-8411-4af80ad715bd", "ZoneDlet", "ZoneDlet" },
                    { "31e0d721-94ba-43d2-874d-a45beee884bf", "17736399-654a-4d20-aa6f-560e1c4ea7ef", "ZoneUpdt", "ZoneUpdt" },
                    { "af7b3e3a-cec6-47b7-912c-7327be558003", "50c96913-855f-4adb-bb2f-a0335e28b9e6", "ZoneRead", "ZoneRead" },
                    { "53b471ba-7053-4d1b-9fc8-f36cbcfa8cd0", "0d0bbb07-f3ae-4403-994c-4a6955deea91", "ZoneCreat", "ZoneCreat" },
                    { "debb4d0a-28f2-4884-a537-8f66f6fff4a2", "1e407936-8ecd-409a-8f1c-dbffcb7b278f", "SondageDlet", "SondageDlet" },
                    { "41856507-b2a4-42ea-99b7-94cf396f0c36", "3440610c-6038-41e6-a534-7b0881c4734a", "SondageUpdt", "SondageUpdt" },
                    { "5c5992dc-a493-41a7-8369-80fa80d8cf2e", "14143890-4b4f-4801-9fd7-6ab9709541f9", "SondageRead", "SondageRead" },
                    { "a09b197e-666f-48b8-a02b-bef752723df3", "98a69451-4d2e-460c-aff8-276589dbae15", "SondageCreat", "SondageCreat" },
                    { "a1717271-5dad-4dfb-8824-50a5c8954c09", "f65d5aa8-4301-45c5-9dbc-5902616c0bf8", "VehiculeDlet", "VehiculeDlet" },
                    { "3ba57626-6a90-4459-abbe-188e41b73d91", "7aa795a5-83da-4458-aef3-376b7f1aad23", "VehiculeUpdt", "VehiculeUpdt" },
                    { "9e80623f-68e8-4a93-a45b-1535f5be2663", "dab5d8e7-5abc-47b7-a97e-e9ae1c8fcf03", "VehiculeRead", "VehiculeRead" },
                    { "b8b7be73-b0d5-4359-8b11-a7008141661c", "fe0f42ad-a039-4821-9dd8-ae5f5b93f6a2", "VehiculeCreat", "VehiculeCreat" },
                    { "33b7aaa6-6718-4ba3-a138-828ba28972f7", "d9c48a80-4faf-49e9-a058-097e0fae0f8a", "TourneeDlet", "TourneeDlet" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "806edb29-9623-435c-9d2c-8b9629bf8349", 0, "cd4ca31c-cb33-4125-a9d4-4264a6605768", "admin@Proximaracking.com", false, true, null, "ADMIN@ProximaRACKING.COM", "ADMINISTRATEUR", "AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==", "", false, "Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL", false, "administrateur" });
        }
    }
}
