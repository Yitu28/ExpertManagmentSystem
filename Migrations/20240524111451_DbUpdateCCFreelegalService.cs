using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class DbUpdateCCFreelegalService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmountinOther",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CCPDecissionStatus",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountinOther",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "CCPDecissionStatus",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");
        }
    }
}
