using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class documentwarrantyp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfService",
                schema: "ExpertUserMngt",
                table: "Doc_WarrantyDocument");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeOfService",
                schema: "ExpertUserMngt",
                table: "Doc_WarrantyDocument",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
