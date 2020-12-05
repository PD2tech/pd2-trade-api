using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class AddRunewordAndItemSocketModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<long>(
                name: "RunewordId",
                table: "Item",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TotalSockets",
                table: "Item",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ItemSocket",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSocket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemSocket_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Runeword",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SocketsNeeded = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runeword", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_ItemSocketId",
                table: "ItemStat",
                column: "ItemSocketId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_RunewordId",
                table: "ItemStat",
                column: "RunewordId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_RunewordId",
                table: "Item",
                column: "RunewordId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSocket_ItemId",
                table: "ItemSocket",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Runeword_RunewordId",
                table: "Item",
                column: "RunewordId",
                principalTable: "Runeword",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Runeword_RunewordId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemStat_ItemSocket_ItemSocketId",
                table: "ItemStat");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemStat_Runeword_RunewordId",
                table: "ItemStat");

            migrationBuilder.DropTable(
                name: "ItemSocket");

            migrationBuilder.DropTable(
                name: "Runeword");

            migrationBuilder.DropIndex(
                name: "IX_ItemStat_ItemSocketId",
                table: "ItemStat");

            migrationBuilder.DropIndex(
                name: "IX_ItemStat_RunewordId",
                table: "ItemStat");

            migrationBuilder.DropIndex(
                name: "IX_Item_RunewordId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ItemSocketId",
                table: "ItemStat");

            migrationBuilder.DropColumn(
                name: "RunewordId",
                table: "ItemStat");

            migrationBuilder.DropColumn(
                name: "RunewordId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TotalSockets",
                table: "Item");
        }
    }
}
