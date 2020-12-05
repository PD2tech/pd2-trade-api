using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class AddNoteToTradeOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "TradeOffer",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Durability",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxDamage",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxDurability",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinDamage",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "TradeOffer");

            migrationBuilder.DropColumn(
                name: "Durability",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "MaxDamage",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "MaxDurability",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "MinDamage",
                table: "Item");
        }
    }
}
