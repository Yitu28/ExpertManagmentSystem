using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class AddHasApointedAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasBeenAppointed",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.AddColumn<bool>(
                name: "HasBeenAppointed",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasBeenAppointed",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.AddColumn<bool>(
                name: "HasBeenAppointed",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "bit",
                nullable: true);
        }
    }
}
