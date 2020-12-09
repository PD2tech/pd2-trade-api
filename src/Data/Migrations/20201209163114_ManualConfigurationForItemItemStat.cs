using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class ManualConfigurationForItemItemStat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemStat_Item_ItemsId",
                table: "ItemItemStat");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemStat_ItemStat_ItemStatsId",
                table: "ItemItemStat");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "ItemItemStat",
                newName: "ItemStatId");

            migrationBuilder.RenameColumn(
                name: "ItemStatsId",
                table: "ItemItemStat",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemItemStat_ItemsId",
                table: "ItemItemStat",
                newName: "IX_ItemItemStat_ItemStatId");

            migrationBuilder.AlterColumn<int>(
                name: "RuneRarity",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MinDamage",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaxDurability",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaxDamage",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemLevel",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Durability",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Corrupted",
                table: "Item",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemStat_Item_ItemId",
                table: "ItemItemStat",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemStat_ItemStat_ItemStatId",
                table: "ItemItemStat",
                column: "ItemStatId",
                principalTable: "ItemStat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemStat_Item_ItemId",
                table: "ItemItemStat");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemItemStat_ItemStat_ItemStatId",
                table: "ItemItemStat");

            migrationBuilder.RenameColumn(
                name: "ItemStatId",
                table: "ItemItemStat",
                newName: "ItemsId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemItemStat",
                newName: "ItemStatsId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemItemStat_ItemStatId",
                table: "ItemItemStat",
                newName: "IX_ItemItemStat_ItemsId");

            migrationBuilder.AlterColumn<int>(
                name: "RuneRarity",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MinDamage",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxDurability",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxDamage",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemLevel",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Durability",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Corrupted",
                table: "Item",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemStat_Item_ItemsId",
                table: "ItemItemStat",
                column: "ItemsId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemItemStat_ItemStat_ItemStatsId",
                table: "ItemItemStat",
                column: "ItemStatsId",
                principalTable: "ItemStat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
