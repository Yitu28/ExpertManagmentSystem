using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class FreeLservicesFollowupDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CCFreeLegServiceFollowup",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    FreeLegServiceFollowupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Doc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Doa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecisionStatus = table.Column<int>(type: "int", nullable: true),
                    Decisionmadeby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCFreelServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCFreeLegServiceFollowup", x => x.FreeLegServiceFollowupId);
                    table.ForeignKey(
                        name: "FK_CCFreeLegServiceFollowup_CCFreelServices_CCFreelServicesId",
                        column: x => x.CCFreelServicesId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "CCFreelServices",
                        principalColumn: "CCFreelServicesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CCFreeLegServiceFollowup_CCFreelServicesId",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                column: "CCFreelServicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CCFreeLegServiceFollowup",
                schema: "ExpertUserMngt");
        }
    }
}
