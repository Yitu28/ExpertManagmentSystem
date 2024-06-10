using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class editePerformanceCharge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeOfPerformanceCgarge",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                newName: "TypeOfPerformanceCharge");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeOfPerformanceCharge",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                newName: "TypeOfPerformanceCgarge");
        }
    }
}
