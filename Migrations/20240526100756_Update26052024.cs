using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class Update26052024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Flservreq",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Courts",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flservreq",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "Courts",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup");
        }
    }
}
