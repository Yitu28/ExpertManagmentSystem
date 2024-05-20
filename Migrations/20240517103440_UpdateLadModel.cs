using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class UpdateLadModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LadPDecisoion",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.AlterColumn<string>(
                name: "CCPeDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CCLadDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CCDltDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CCPeDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CCLadDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "LadPDecisoion",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CCDltDecissionTypes",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
