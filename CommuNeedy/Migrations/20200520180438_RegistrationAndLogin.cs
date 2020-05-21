using Microsoft.EntityFrameworkCore.Migrations;

namespace CommuNeedy.Migrations
{
    public partial class RegistrationAndLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24cdae83-08d8-433e-8bee-15d0d866d660");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49412263-6e08-4c65-9ec0-56bda95d1ca9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f08dce2-7f01-4571-8bcc-e429e904cb47", "b376abcc-f7ca-40ad-bd1b-4f84d9b86cff", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b57be691-5219-457b-ac8a-e846f28b74d2", "406edcff-4e30-465c-916a-2b8733f2cf45", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f08dce2-7f01-4571-8bcc-e429e904cb47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b57be691-5219-457b-ac8a-e846f28b74d2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24cdae83-08d8-433e-8bee-15d0d866d660", "3633324d-00df-425f-9480-f039dedfe6a5", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49412263-6e08-4c65-9ec0-56bda95d1ca9", "2af2faa6-2fa8-41c1-a146-6d9e008d8f9e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
