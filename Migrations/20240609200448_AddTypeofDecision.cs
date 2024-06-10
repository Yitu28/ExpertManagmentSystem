using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class AddTypeofDecision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeofDecision",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeofDecision",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");
        }
    }
}
