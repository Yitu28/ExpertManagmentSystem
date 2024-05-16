using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class UpdateCCPetionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CCLegaladvicesId",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                newName: "CCPetitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CCPetitionId",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                newName: "CCLegaladvicesId");
        }
    }
}
