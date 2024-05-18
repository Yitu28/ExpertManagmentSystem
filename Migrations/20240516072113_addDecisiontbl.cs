using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class addDecisiontbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourtsDecision",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CourtsDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DecisionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourtsDecision", x => x.CourtsDecisionId);
                });

            migrationBuilder.CreateTable(
                name: "ProsecutorsDecision",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    ProsecutorsDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DecisionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProsecutorsDecision", x => x.ProsecutorsDecisionId);
                });

            migrationBuilder.CreateTable(
                name: "CO_CorruptionCharge",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_CorruptionChargeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prosecutorNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestigationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefendentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantGender = table.Column<int>(type: "int", nullable: false),
                    ApplicantAge = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Woreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofWitnesses = table.Column<int>(type: "int", nullable: false),
                    Exhibit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProsecutorsDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CourtsDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_CorruptionCharge", x => x.CO_CorruptionChargeId);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCharge_CourtsDecision_CourtsDecisionId",
                        column: x => x.CourtsDecisionId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "CourtsDecision",
                        principalColumn: "CourtsDecisionId");
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCharge_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCharge_ProsecutorsDecision_ProsecutorsDecisionId",
                        column: x => x.ProsecutorsDecisionId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "ProsecutorsDecision",
                        principalColumn: "ProsecutorsDecisionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCharge_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCharge_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCharge_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCharge_CourtsDecisionId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge",
                column: "CourtsDecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCharge_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCharge_ProsecutorsDecisionId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge",
                column: "ProsecutorsDecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCharge_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge",
                column: "SectrorsDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CO_CorruptionCharge",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CourtsDecision",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ProsecutorsDecision",
                schema: "ExpertUserMngt");
        }
    }
}
