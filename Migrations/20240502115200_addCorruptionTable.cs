using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class addCorruptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CO_Closed_SentInReverse",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_Closed_SentInReverseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Defenedant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefenedantZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpinionGiven = table.Column<int>(type: "int", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_Closed_SentInReverse", x => x.CO_Closed_SentInReverseId);
                    table.ForeignKey(
                        name: "FK_CO_Closed_SentInReverse_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CO_CorruptionCharge",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_CorruptionChargeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prosecutorNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestigationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecisionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefendentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DefendantJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrimeType = table.Column<int>(type: "int", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvestigationApproved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_CorruptionCharge", x => x.CO_CorruptionChargeId);
                    table.ForeignKey(
                        name: "FK_CO_CorruptionCharge_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CO_FederalAppealOrBreak",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_FederalAppealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupremCourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appellant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answerer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Appointment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F_AppealOrBreak = table.Column<int>(type: "int", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_FederalAppealOrBreak", x => x.CO_FederalAppealId);
                    table.ForeignKey(
                        name: "FK_CO_FederalAppealOrBreak_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CO_FirstOrder",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_FirstOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecotorRecordNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneProsecotorRecordNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefendantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_FirstOrder", x => x.CO_FirstOrderId);
                    table.ForeignKey(
                        name: "FK_CO_FirstOrder_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CO_Petition",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_PetitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplainantsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    OrderedClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LetterNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LetterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_Petition", x => x.CO_PetitionId);
                    table.ForeignKey(
                        name: "FK_CO_Petition_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CO_RegionalBreakAppeal",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_RegionalBreakAppealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appellant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answerer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CO_CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reasons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    R_BreakingOrAppeal = table.Column<int>(type: "int", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_RegionalBreakAppeal", x => x.CO_RegionalBreakAppealId);
                    table.ForeignKey(
                        name: "FK_CO_RegionalBreakAppeal_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CO_Warranty",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CO_WarrantyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProsecotorNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    WarrantyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO_Warranty", x => x.CO_WarrantyId);
                    table.ForeignKey(
                        name: "FK_CO_Warranty_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CO_Closed_SentInReverse_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_Closed_SentInReverse",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_CorruptionCharge_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_CorruptionCharge",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_FederalAppealOrBreak_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_FederalAppealOrBreak",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_FirstOrder_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_FirstOrder",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_Petition_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_Petition",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_RegionalBreakAppeal_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_RegionalBreakAppeal",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CO_Warranty_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CO_Warranty",
                column: "SectrorsDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CO_Closed_SentInReverse",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_CorruptionCharge",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_FederalAppealOrBreak",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_FirstOrder",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_Petition",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_RegionalBreakAppeal",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CO_Warranty",
                schema: "ExpertUserMngt");
        }
    }
}
