using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerShop.Migrations
{
    public partial class BeersChanged2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Beerss",
                table: "Beerss");

            migrationBuilder.RenameTable(
                name: "Beerss",
                newName: "Beers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beers",
                table: "Beers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Beers",
                table: "Beers");

            migrationBuilder.RenameTable(
                name: "Beers",
                newName: "Beerss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beerss",
                table: "Beerss",
                column: "Id");
        }
    }
}
