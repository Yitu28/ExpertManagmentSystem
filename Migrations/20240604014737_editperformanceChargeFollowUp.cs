using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class editperformanceChargeFollowUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfCourtCasePresented",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropColumn(
                name: "NameOfTheExpert",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.AddColumn<string>(
                name: "NameOfCourtCasePresented",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOfTheExpert",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfCourtCasePresented",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.DropColumn(
                name: "NameOfTheExpert",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.AddColumn<string>(
                name: "NameOfCourtCasePresented",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOfTheExpert",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
