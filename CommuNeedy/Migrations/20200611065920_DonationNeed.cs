using Microsoft.EntityFrameworkCore.Migrations;

namespace CommuNeedy.Migrations
{
    public partial class DonationNeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59e2f71f-8e18-4ea1-ba67-30251d095506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad370739-5de6-4ca4-9ce0-63a5fcb3faae");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "DonationNeed",
                columns: table => new
                {
                    NeedId = table.Column<int>(nullable: false),
                    DonationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationNeed", x => new { x.NeedId, x.DonationId });
                    table.ForeignKey(
                        name: "FK_DonationNeed_Needs_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Needs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationNeed_Donation_NeedId",
                        column: x => x.NeedId,
                        principalTable: "Donation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e47c7e34-e06b-4065-a82d-d84ffcc7d395", "24920b92-4316-4adf-9046-65e814825d85", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b1f9301-ba7c-4bf4-93a8-08916833b061", "7d2e7a64-8744-4422-a655-1df602ab192e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_DonationNeed_DonationId",
                table: "DonationNeed",
                column: "DonationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonationNeed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b1f9301-ba7c-4bf4-93a8-08916833b061");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e47c7e34-e06b-4065-a82d-d84ffcc7d395");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59e2f71f-8e18-4ea1-ba67-30251d095506", "51d6dc97-397f-4d66-b04c-f2962e15965e", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad370739-5de6-4ca4-9ce0-63a5fcb3faae", "a8881d76-fc16-4461-bbee-7b4da5201d66", "Administrator", "ADMINISTRATOR" });
        }
    }
}
