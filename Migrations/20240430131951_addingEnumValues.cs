using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class addingEnumValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProsecutorComment",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProsecutorComment",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");
        }
    }
}
