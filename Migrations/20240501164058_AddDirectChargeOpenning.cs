using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class AddDirectChargeOpenning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CivilCaseCategory",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CivilCaseCategory",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings");
        }
    }
}
