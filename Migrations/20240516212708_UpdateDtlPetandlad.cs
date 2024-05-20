using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class UpdateDtlPetandlad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PePDecisoion",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "DltPDecission",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.AddColumn<int>(
                name: "CCPeDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCLadDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CCDltDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CCPeDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "CCLadDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.DropColumn(
                name: "CCDltDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.AddColumn<string>(
                name: "PePDecisoion",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DltPDecission",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
