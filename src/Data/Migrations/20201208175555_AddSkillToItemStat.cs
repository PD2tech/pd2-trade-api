using Microsoft.EntityFrameworkCore.Migrations;

namespace Pd2TradeApi.Server.Data.Migrations
{
    public partial class AddSkillToItemStat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "ItemStat",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill",
                table: "ItemStat");
        }
    }
}
