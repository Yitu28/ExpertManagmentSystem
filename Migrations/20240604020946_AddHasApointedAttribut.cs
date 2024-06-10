using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class AddHasApointedAttribut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasBeenAppointed",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasBeenAppointed",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");
        }
    }
}
