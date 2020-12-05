using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class VariousModelUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CharacterName",
                table: "User",
                newName: "AccountName");

            migrationBuilder.RenameColumn(
                name: "CharacterName",
                table: "TradeOffer",
                newName: "AccountName");

            migrationBuilder.AlterColumn<bool>(
                name: "OptedInForEmails",
                table: "User",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "TradeOffer",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AddColumn<long>(
                name: "OfferedItemId",
                table: "TradeOffer",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Season",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "MinValue",
                table: "ItemStat",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "MaxValue",
                table: "ItemStat",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ItemStat",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ItemId",
                table: "ItemStat",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StrengthRequirement",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LevelRequirement",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCurrency",
                table: "Item",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "DexterityRequirement",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_TradeOffer_OfferedItemId",
                table: "TradeOffer",
                column: "OfferedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStat_ItemId",
                table: "ItemStat",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStat_Item_ItemId",
                table: "ItemStat",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeOffer_Item_OfferedItemId",
                table: "TradeOffer",
                column: "OfferedItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStat_Item_ItemId",
                table: "ItemStat");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeOffer_Item_OfferedItemId",
                table: "TradeOffer");

            migrationBuilder.DropIndex(
                name: "IX_TradeOffer_OfferedItemId",
                table: "TradeOffer");

            migrationBuilder.DropIndex(
                name: "IX_ItemStat_ItemId",
                table: "ItemStat");

            migrationBuilder.DropColumn(
                name: "OfferedItemId",
                table: "TradeOffer");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ItemStat");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemStat");

            migrationBuilder.RenameColumn(
                name: "AccountName",
                table: "User",
                newName: "CharacterName");

            migrationBuilder.RenameColumn(
                name: "AccountName",
                table: "TradeOffer",
                newName: "CharacterName");

            migrationBuilder.AlterColumn<bool>(
                name: "OptedInForEmails",
                table: "User",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "TradeOffer",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Season",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "MinValue",
                table: "ItemStat",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "MaxValue",
                table: "ItemStat",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StrengthRequirement",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LevelRequirement",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsCurrency",
                table: "Item",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DexterityRequirement",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
