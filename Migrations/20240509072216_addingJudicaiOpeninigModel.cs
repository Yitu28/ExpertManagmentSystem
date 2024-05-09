using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class addingJudicaiOpeninigModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JudicalAppealOpenings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    JudicalAppealOpeningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpeninigDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcsecuterNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JudicalAppealOpenings", x => x.JudicalAppealOpeningId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JudicalAppealOpenings",
                schema: "ExpertUserMngt");
        }
    }
}
