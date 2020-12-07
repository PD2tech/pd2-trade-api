using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class AddSubcategoryToItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubCategory",
                table: "Item",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubCategory",
                table: "Item");
        }
    }
}
