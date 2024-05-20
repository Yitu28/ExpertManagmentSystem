using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class addCorruptionChargetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DecisionStatus",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CO_CorruptionCourtDecision",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_CorruptionCourtDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CO_CorruptionChargeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtsDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_CorruptionCourtDecision", x => x.CO_CorruptionCourtDecisionId);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCourtDecision_CO_CorruptionCharge_CO_CorruptionChargeId",
                        column: x => x.CO_CorruptionChargeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "CO_CorruptionCharge",
                        principalColumn: "CO_CorruptionChargeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCourtDecision_CourtsDecision_CourtsDecisionId",
                        column: x => x.CourtsDecisionId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "CourtsDecision",
                        principalColumn: "CourtsDecisionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCourtDecision_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCourtDecision_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCourtDecision",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCourtDecision_CO_CorruptionChargeId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCourtDecision",
                column: "CO_CorruptionChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCourtDecision_CourtsDecisionId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCourtDecision",
                column: "CourtsDecisionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CO_CorruptionCourtDecision",
                schema: "ExpertUserMngt");

            migrationBuilder.DropColumn(
                name: "DecisionStatus",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge");
        }
    }
}
