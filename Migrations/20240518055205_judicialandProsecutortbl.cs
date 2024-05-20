using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class judicialandProsecutortbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "F_AppealOrBreak",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreakDecision",
                newName: "CourtDecision");

            migrationBuilder.RenameColumn(
                name: "F_AppealOrBreak",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreak",
                newName: "J_AppealOrBreak");

            migrationBuilder.CreateTable(
                name: "CO_ProsecutorAppealOrBreak",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_ProsecutorAppealOrBreakId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_CO_ProsecutorAppealOrBreak", x => x.CO_ProsecutorAppealOrBreakId);
                    table.ForeignKey(
                        name: "FK_CO_ProsecutorAppealOrBreak_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_ProsecutorAppealOrBreak_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_ProsecutorAppealOrBreak_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CO_ProsecutorAppealOrBreakDecision",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_ProsecutorAppealOrBreakDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CO_ProsecutorAppealOrBreakId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtDecision = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_CO_ProsecutorAppealOrBreakDecision", x => x.CO_ProsecutorAppealOrBreakDecisionId);
                    table.ForeignKey(
                        name: "FK_CO_ProsecutorAppealOrBreakDecision_CO_ProsecutorAppealOrBreak_CO_ProsecutorAppealOrBreakId",
                        column: x => x.CO_ProsecutorAppealOrBreakId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "CO_ProsecutorAppealOrBreak",
                        principalColumn: "CO_ProsecutorAppealOrBreakId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_ProsecutorAppealOrBreakDecision_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CO_ProsecutorAppealOrBreak_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "CO_ProsecutorAppealOrBreak",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_ProsecutorAppealOrBreak_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "CO_ProsecutorAppealOrBreak",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_ProsecutorAppealOrBreak_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_ProsecutorAppealOrBreak",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_ProsecutorAppealOrBreakDecision_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "CO_ProsecutorAppealOrBreakDecision",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_ProsecutorAppealOrBreakDecision_CO_ProsecutorAppealOrBreakId",
                schema: "ExpertUserMngt",
                table: "CO_ProsecutorAppealOrBreakDecision",
                column: "CO_ProsecutorAppealOrBreakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CO_ProsecutorAppealOrBreakDecision",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_ProsecutorAppealOrBreak",
                schema: "ExpertUserMngt");

            migrationBuilder.RenameColumn(
                name: "CourtDecision",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreakDecision",
                newName: "F_AppealOrBreak");

            migrationBuilder.RenameColumn(
                name: "J_AppealOrBreak",
                schema: "ExpertUserMngt",
                table: "CO_JudicialAppealOrBreak",
                newName: "F_AppealOrBreak");
        }
    }
}
