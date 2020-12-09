using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class SwapToManyToManyTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStat_Item_ItemId",
                table: "ItemStat");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemStat_ItemSocket_ItemSocketId",
                table: "ItemStat");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemStat_Runeword_RunewordId",
                table: "ItemStat");

            migrationBuilder.DropIndex(
                name: "IX_ItemStat_ItemId",
                table: "ItemStat");

            migrationBuilder.DropIndex(
                name: "IX_ItemStat_ItemSocketId",
                table: "ItemStat");

            migrationBuilder.DropIndex(
                name: "IX_ItemStat_RunewordId",
                table: "ItemStat");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemStat");

            migrationBuilder.DropColumn(
                name: "ItemSocketId",
                table: "ItemStat");

            migrationBuilder.DropColumn(
                name: "RunewordId",
                table: "ItemStat");

            migrationBuilder.CreateTable(
                name: "ItemItemStat",
                columns: table => new
                {
                    ItemStatsId = table.Column<long>(type: "bigint", nullable: false),
                    ItemsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItemStat", x => new { x.ItemStatsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_ItemItemStat_Item_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemItemStat_ItemStat_ItemStatsId",
                        column: x => x.ItemStatsId,
                        principalTable: "ItemStat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemStatRuneword",
                columns: table => new
                {
                    ItemStatsId = table.Column<long>(type: "bigint", nullable: false),
                    RunewordsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatRuneword", x => new { x.ItemStatsId, x.RunewordsId });
                    table.ForeignKey(
                        name: "FK_ItemStatRuneword_ItemStat_ItemStatsId",
                        column: x => x.ItemStatsId,
                        principalTable: "ItemStat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemStatRuneword_Runeword_RunewordsId",
                        column: x => x.RunewordsId,
                        principalTable: "Runeword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemStat_ItemsId",
                table: "ItemItemStat",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatRuneword_RunewordsId",
                table: "ItemStatRuneword",
                column: "RunewordsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemItemStat");

            migrationBuilder.DropTable(
                name: "ItemStatRuneword");

            migrationBuilder.AddColumn<long>(
                name: "ItemId",
                table: "ItemStat",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ItemSocketId",
                table: "ItemStat",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RunewordId",
                table: "ItemStat",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_ItemId",
                table: "ItemStat",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_ItemSocketId",
                table: "ItemStat",
                column: "ItemSocketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_RunewordId",
                table: "ItemStat",
                column: "RunewordId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStat_Item_ItemId",
                table: "ItemStat",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStat_ItemSocket_ItemSocketId",
                table: "ItemStat",
                column: "ItemSocketId",
                principalTable: "ItemSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStat_Runeword_RunewordId",
                table: "ItemStat",
                column: "RunewordId",
                principalTable: "Runeword",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
