using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class AddPerformanceChargeStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PerformanceChargeStatus",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceChargeStatus",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerformanceChargeStatus",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.DropColumn(
                name: "PerformanceChargeStatus",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");
        }
    }
}
