using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class UpdateCCFreeLegalServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "typesofIssue",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCategory",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerCategory",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.AlterColumn<string>(
                name: "typesofIssue",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
