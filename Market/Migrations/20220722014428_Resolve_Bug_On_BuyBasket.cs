using Microsoft.EntityFrameworkCore.Migrations;

namespace Market.Migrations
{
    public partial class Resolve_Bug_On_BuyBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BuyBaskets_BuyBasketId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BuyBasketId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BuyBasketId",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyBasketId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BuyBasketId",
                table: "Products",
                column: "BuyBasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BuyBaskets_BuyBasketId",
                table: "Products",
                column: "BuyBasketId",
                principalTable: "BuyBaskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
