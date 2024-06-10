using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class EditBirrToContractInvestigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountInBir",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountInBirr",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountInBirr",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.AddColumn<string>(
                name: "AmountInBir",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
