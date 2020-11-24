using Microsoft.EntityFrameworkCore.Migrations;

namespace ForceT.Server.Migrations
{
    public partial class accees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
