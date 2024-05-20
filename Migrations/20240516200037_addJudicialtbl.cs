using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class addJudicialtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CO_JudicialAppealOrBreak",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_JudicialAppealOrBreakId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupremCourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appellant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answerer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LowerCourtDecision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProsecutorComment = table.Column<int>(type: "int", nullable: false),
                    Various = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertOpinion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F_AppealOrBreak = table.Column<int>(type: "int", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_JudicialAppealOrBreak", x => x.CO_JudicialAppealOrBreakId);
                    table.ForeignKey(
                        name: "FK_CO_JudicialAppealOrBreak_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_JudicialAppealOrBreak_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_JudicialAppealOrBreak_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CO_JudicialAppealOrBreakDecision",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_JudicialAppealOrBreakDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CO_JudicialAppealOrBreakId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    F_AppealOrBreak = table.Column<int>(type: "int", nullable: false),
                    ExpertOpinion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Various = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewExisting = table.Column<int>(type: "int", nullable: false),
                    WinnerLoser = table.Column<int>(type: "int", nullable: false),
                    FederalRequested = table.Column<int>(type: "int", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_JudicialAppealOrBreakDecision", x => x.CO_JudicialAppealOrBreakDecisionId);
                    table.ForeignKey(
                        name: "FK_CO_JudicialAppealOrBreakDecision_CO_JudicialAppealOrBreak_CO_JudicialAppealOrBreakId",
                        column: x => x.CO_JudicialAppealOrBreakId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "CO_JudicialAppealOrBreak",
                        principalColumn: "CO_JudicialAppealOrBreakId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_JudicialAppealOrBreakDecision_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CO_JudicialAppealOrBreak_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreak",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_JudicialAppealOrBreak_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreak",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_JudicialAppealOrBreak_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreak",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_JudicialAppealOrBreakDecision_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreakDecision",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_JudicialAppealOrBreakDecision_CO_JudicialAppealOrBreakId",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreakDecision",
                column: "CO_JudicialAppealOrBreakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CO_JudicialAppealOrBreakDecision",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_JudicialAppealOrBreak",
                schema: "ExpertUserMngt");
        }
    }
}
