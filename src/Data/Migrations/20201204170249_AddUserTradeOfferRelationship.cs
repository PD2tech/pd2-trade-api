using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class AddUserTradeOfferRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PosterId",
                table: "TradeOffer",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TradeOffer_PosterId",
                table: "TradeOffer",
                column: "PosterId");

            migrationBuilder.AddForeignKey(
                name: "FK_TradeOffer_User_PosterId",
                table: "TradeOffer",
                column: "PosterId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TradeOffer_User_PosterId",
                table: "TradeOffer");

            migrationBuilder.DropIndex(
                name: "IX_TradeOffer_PosterId",
                table: "TradeOffer");

            migrationBuilder.DropColumn(
                name: "PosterId",
                table: "TradeOffer");
        }
    }
}
