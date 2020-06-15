using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommuNeedy.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b1f9301-ba7c-4bf4-93a8-08916833b061");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e47c7e34-e06b-4065-a82d-d84ffcc7d395");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Donation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategorySelectId",
                table: "Donation",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4653b022-1303-4c2e-b1b6-3f7b786494e6", "376c0fc9-e4ae-43cf-b16f-cceaa9b8c5ef", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4047ee86-b4c6-453c-932e-4d309119f562", "49e1cae5-d872-4b94-9bcb-e27cb336c547", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Donation_CategorySelectId",
                table: "Donation",
                column: "CategorySelectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_Categories_CategorySelectId",
                table: "Donation",
                column: "CategorySelectId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donation_Categories_CategorySelectId",
                table: "Donation");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Donation_CategorySelectId",
                table: "Donation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4047ee86-b4c6-453c-932e-4d309119f562");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4653b022-1303-4c2e-b1b6-3f7b786494e6");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "CategorySelectId",
                table: "Donation");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e47c7e34-e06b-4065-a82d-d84ffcc7d395", "24920b92-4316-4adf-9046-65e814825d85", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b1f9301-ba7c-4bf4-93a8-08916833b061", "7d2e7a64-8744-4422-a655-1df602ab192e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
