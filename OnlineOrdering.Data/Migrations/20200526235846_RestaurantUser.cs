using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineOrdering.Data.Migrations
{
    public partial class RestaurantUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "RestaurantTaxRate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "ItemTaxRate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "ItemAttributeGroup",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "CategoryPickUpTimeSlot",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "CategoryDeliveryTimeSlot",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "Addresses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_UserId",
                table: "Restaurants",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_AspNetUsers_UserId",
                table: "Restaurants",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_AspNetUsers_UserId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_UserId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "RestaurantTaxRate");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "ItemTaxRate");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "ItemAttributeGroup");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "CategoryPickUpTimeSlot");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "CategoryDeliveryTimeSlot");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Addresses");
        }
    }
}
