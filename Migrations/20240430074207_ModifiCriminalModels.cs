using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class ModifiCriminalModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cr_Decide_Judicial_Appeals",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Decided_Judical_Breaks",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Decided_Prosecuter_Appeal",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Decided_Prosecuter_Breaks",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Direct_Chare_Decissions",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Direct_Charge_Openings",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Judical_Appeal_Openings",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Judical_Break_Openings",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Prosecuter_Appeal_Openings",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Prosocuter_Break_Openinigs",
                schema: "ExpertUserMngt");

            migrationBuilder.CreateTable(
                name: "Cr_Decided_Judicial_and_Prosecuters",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Decided_Judicial_and_ProsecuterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProsocuterNo = table.Column<int>(type: "int", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtDesitions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsocuterFocus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToProsecuter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToCourt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfAppealMale = table.Column<int>(type: "int", nullable: false),
                    AmountOfAppealFemale = table.Column<int>(type: "int", nullable: false),
                    EventStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToFederal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Decided_Judicial_and_Prosecuters", x => x.Cr_Decided_Judicial_and_ProsecuterId);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Judicial_and_Prosecuters_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Judicial_and_Prosecuters_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_JudicalAppealDirectChareges",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_JudicalAppealDirectCharegeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Openinig_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prosocuters_No = table.Column<int>(type: "int", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respondent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Worked_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_of_Administration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_Returen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Returen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prosocuter_Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_JudicalAppealDirectChareges", x => x.Cr_JudicalAppealDirectCharegeId);
                    table.ForeignKey(
                        name: "FK_Cr_JudicalAppealDirectChareges_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_JudicalAppealDirectChareges_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Judicial_and_Prosecuters_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Judicial_and_Prosecuters_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_JudicalAppealDirectChareges_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_JudicalAppealDirectChareges",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_JudicalAppealDirectChareges_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_JudicalAppealDirectChareges",
                column: "SectrorsDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cr_Decided_Judicial_and_Prosecuters",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_JudicalAppealDirectChareges",
                schema: "ExpertUserMngt");

            migrationBuilder.CreateTable(
                name: "Cr_Decide_Judicial_Appeals",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Decide_Judicial_AppealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountOfAppealFemale = table.Column<int>(type: "int", nullable: false),
                    AmountOfAppealMale = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtDesitions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtNo = table.Column<int>(type: "int", nullable: false),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToCourt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToProsecuter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opening_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsocuterFocus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosocuter_No = table.Column<int>(type: "int", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToFederal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Decide_Judicial_Appeals", x => x.Cr_Decide_Judicial_AppealId);
                    table.ForeignKey(
                        name: "FK_Cr_Decide_Judicial_Appeals_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Decide_Judicial_Appeals_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Decided_Judical_Breaks",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Decided_Judical_BreakId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountOfAppealFemale = table.Column<int>(type: "int", nullable: false),
                    AmountOfAppealMale = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtDesitions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtNo = table.Column<int>(type: "int", nullable: false),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToCourt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToProsecuter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opening_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsocuterFocus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosocuter_No = table.Column<int>(type: "int", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToFederal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Decided_Judical_Breaks", x => x.Cr_Decided_Judical_BreakId);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Judical_Breaks_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Judical_Breaks_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Decided_Prosecuter_Appeal",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Decided_Prosecuter_AppealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountOfAppealFemale = table.Column<int>(type: "int", nullable: false),
                    AmountOfAppealMale = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtDesitions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToCourt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToProsecuter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsocuterFocus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsocuterNo = table.Column<int>(type: "int", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToFederal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Decided_Prosecuter_Appeal", x => x.Cr_Decided_Prosecuter_AppealId);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Prosecuter_Appeal_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Prosecuter_Appeal_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Decided_Prosecuter_Breaks",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Decided_Prosecuter_BreakId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountOfAppealFemale = table.Column<int>(type: "int", nullable: false),
                    AmountOfAppealMale = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtDesitions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToCourt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertsToProsecuter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsocuterFocus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsocuterNo = table.Column<int>(type: "int", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToFederal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Decided_Prosecuter_Breaks", x => x.Cr_Decided_Prosecuter_BreakId);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Prosecuter_Breaks_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Decided_Prosecuter_Breaks_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Direct_Chare_Decissions",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Direct_Chare_DecissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdministrationExper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtRecordNo = table.Column<int>(type: "int", nullable: false),
                    DefendantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Egzibit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoliceRecordNo = table.Column<int>(type: "int", nullable: false),
                    ProsecuterDesition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsecuterRecordNo = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfCrime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Worda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YemisikirAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Direct_Chare_Decissions", x => x.Cr_Direct_Chare_DecissionId);
                    table.ForeignKey(
                        name: "FK_Cr_Direct_Chare_Decissions_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Direct_Chare_Decissions_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Direct_Charge_Openings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Direct_Charge_OpeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Addmision_Expert = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court_record_No = table.Column<int>(type: "int", nullable: false),
                    Date_Of_Returen_and_Mode = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Defendant_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Defendant_Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expert_Signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opening_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Police_Record_No = table.Column<int>(type: "int", nullable: false),
                    Prosocuter_Record_No = table.Column<int>(type: "int", nullable: false),
                    Type_of_Crime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Worda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Direct_Charge_Openings", x => x.Cr_Direct_Charge_OpeningId);
                    table.ForeignKey(
                        name: "FK_Cr_Direct_Charge_Openings_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Direct_Charge_Openings_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Judical_Appeal_Openings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Judical_Appeal_OpeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    CrimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_Administration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_Returen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Openinig_data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prosocuter_Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosocuters_No = table.Column<int>(type: "int", nullable: false),
                    Respondent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Returen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Worked_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Judical_Appeal_Openings", x => x.Cr_Judical_Appeal_OpeningId);
                    table.ForeignKey(
                        name: "FK_Cr_Judical_Appeal_Openings_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Judical_Appeal_Openings_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Judical_Break_Openings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Judical_Break_OpeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    Crime_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_of_Administration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_of_Appientment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Openig_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prosecuter_Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosecuter_No = table.Column<int>(type: "int", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Worked_Professional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Judical_Break_Openings", x => x.Cr_Judical_Break_OpeningId);
                    table.ForeignKey(
                        name: "FK_Cr_Judical_Break_Openings_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Judical_Break_Openings_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Prosecuter_Appeal_Openings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Prosecuter_Appeal_OpeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    Crime_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosecuter_Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosecuter_No = table.Column<int>(type: "int", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Worked_Proffissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Prosecuter_Appeal_Openings", x => x.Cr_Prosecuter_Appeal_OpeningId);
                    table.ForeignKey(
                        name: "FK_Cr_Prosecuter_Appeal_Openings_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Prosecuter_Appeal_Openings_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cr_Prosocuter_Break_Openinigs",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Prosocuter_Break_OpeninigId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    Crime_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_of_Administration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_Appointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_returen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prosocuter_Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosocuter_No = table.Column<int>(type: "int", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Worked_Proffesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Prosocuter_Break_Openinigs", x => x.Cr_Prosocuter_Break_OpeninigId);
                    table.ForeignKey(
                        name: "FK_Cr_Prosocuter_Break_Openinigs_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cr_Prosocuter_Break_Openinigs_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decide_Judicial_Appeals_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Decide_Judicial_Appeals",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decide_Judicial_Appeals_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Decide_Judicial_Appeals",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Judical_Breaks_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judical_Breaks",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Judical_Breaks_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judical_Breaks",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Prosecuter_Appeal_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Prosecuter_Appeal",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Prosecuter_Appeal_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Prosecuter_Appeal",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Prosecuter_Breaks_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Prosecuter_Breaks",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Decided_Prosecuter_Breaks_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Prosecuter_Breaks",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Direct_Chare_Decissions_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Direct_Chare_Decissions",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Direct_Chare_Decissions_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Direct_Chare_Decissions",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Direct_Charge_Openings_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Direct_Charge_Openings",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Direct_Charge_Openings_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Direct_Charge_Openings",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Judical_Appeal_Openings_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Judical_Appeal_Openings",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Judical_Appeal_Openings_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Judical_Appeal_Openings",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Judical_Break_Openings_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Judical_Break_Openings",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Judical_Break_Openings_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Judical_Break_Openings",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Prosecuter_Appeal_Openings_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Prosecuter_Appeal_Openings",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Prosecuter_Appeal_Openings_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Prosecuter_Appeal_Openings",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Prosocuter_Break_Openinigs_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Cr_Prosocuter_Break_Openinigs",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cr_Prosocuter_Break_Openinigs_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Cr_Prosocuter_Break_Openinigs",
                column: "SectrorsDepartmentId");
        }
    }
}
