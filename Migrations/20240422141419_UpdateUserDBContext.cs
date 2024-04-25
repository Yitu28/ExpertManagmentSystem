using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class UpdateUserDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserCategory",
                schema: "ExpertUserMngt",
                table: "Users",
                newName: "DepartmentCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentCategory",
                schema: "ExpertUserMngt",
                table: "Users",
                newName: "UserCategory");
        }
    }
}
