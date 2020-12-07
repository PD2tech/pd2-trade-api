using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class AddCodeToItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TradeOffer_User_PosterId",
                table: "TradeOffer");

            migrationBuilder.AlterColumn<long>(
                name: "PosterId",
                table: "TradeOffer",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Item",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeOffer_User_PosterId",
                table: "TradeOffer",
                column: "PosterId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TradeOffer_User_PosterId",
                table: "TradeOffer");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Item");

            migrationBuilder.AlterColumn<long>(
                name: "PosterId",
                table: "TradeOffer",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_TradeOffer_User_PosterId",
                table: "TradeOffer",
                column: "PosterId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
