using Microsoft.EntityFrameworkCore.Migrations;

namespace CommuNeedy.Migrations
{
    public partial class CategoryNeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4047ee86-b4c6-453c-932e-4d309119f562");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4653b022-1303-4c2e-b1b6-3f7b786494e6");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Needs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategorySelectId",
                table: "Needs",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29114049-d691-4d55-a733-fa7770498923", "c6779ba3-3e9a-416d-9d99-7987ec26f935", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d66eb8e-7bef-4bc3-a2e1-c66bee627033", "f52ec758-8fc1-43ff-b394-ca659259e5c3", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Needs_CategorySelectId",
                table: "Needs",
                column: "CategorySelectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Needs_Categories_CategorySelectId",
                table: "Needs",
                column: "CategorySelectId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Needs_Categories_CategorySelectId",
                table: "Needs");

            migrationBuilder.DropIndex(
                name: "IX_Needs_CategorySelectId",
                table: "Needs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d66eb8e-7bef-4bc3-a2e1-c66bee627033");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29114049-d691-4d55-a733-fa7770498923");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Needs");

            migrationBuilder.DropColumn(
                name: "CategorySelectId",
                table: "Needs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4653b022-1303-4c2e-b1b6-3f7b786494e6", "376c0fc9-e4ae-43cf-b16f-cceaa9b8c5ef", "Vistor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4047ee86-b4c6-453c-932e-4d309119f562", "49e1cae5-d872-4b94-9bcb-e27cb336c547", "Administrator", "ADMINISTRATOR" });
        }
    }
}
