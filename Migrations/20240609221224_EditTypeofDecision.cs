using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class EditTypeofDecision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeofDecision",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                newName: "TypeofDecission");

            migrationBuilder.RenameColumn(
                name: "DecisionStatus",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                newName: "TypeOfDecission");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeofDecission",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                newName: "TypeofDecision");

            migrationBuilder.RenameColumn(
                name: "TypeOfDecission",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                newName: "DecisionStatus");
        }
    }
}
