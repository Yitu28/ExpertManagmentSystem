using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class Documentwaranty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ExpertUserMngt");

            migrationBuilder.CreateTable(
                name: "Cr_Crime_Types",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrimeTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cr_Crime_Types", x => x.Cr_Crime_TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Doc_serviceType",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Doc_serviceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Doc_serviceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doc_serviceType", x => x.Doc_serviceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Eco_GeneralCourtDecission",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_GeneralCourtDecissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneralCourtDecissionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_GeneralCourtDecission", x => x.Eco_GeneralCourtDecissionId);
                });

            migrationBuilder.CreateTable(
                name: "Eco_prosecutorComment",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_prosecutorCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_prosecutorComment", x => x.Eco_prosecutorCommentId);
                });

            migrationBuilder.CreateTable(
                name: "Eco_ProsecutorDecision",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_ProsecutorDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorDecisionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dept = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_ProsecutorDecision", x => x.Eco_ProsecutorDecisionId);
                });

            migrationBuilder.CreateTable(
                name: "ProsecutorLisence",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    LisenceNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProsecutorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job = table.Column<int>(type: "int", nullable: false),
                    ProffissionalLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GivingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProsecutorLisence", x => x.LisenceNo);
                });

            migrationBuilder.CreateTable(
                name: "ReginaslSector",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    ReginalSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReginalSectorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReginaslSector", x => x.ReginalSectorId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectorDepartmentViewModels",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    ReginalSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReginalSectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZonalSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZonalSectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WoredaSectorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WoredaSectorsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SectrorsDepartment",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectrorsDepartment", x => x.SectrorsDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Full_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentCategory = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Eco_ProsecutorAppeals",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_ProsecutorAppealsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileOpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProsecutorNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respondant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtDecission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eco_GeneralCourtDecissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaleApplicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FemaleApplicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppealStatus = table.Column<int>(type: "int", nullable: false),
                    FederalBreakingRequest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_ProsecutorAppeals", x => x.Eco_ProsecutorAppealsId);
                    table.ForeignKey(
                        name: "FK_Eco_ProsecutorAppeals_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eco_ProsecutorAppeals_Eco_GeneralCourtDecission_Eco_GeneralCourtDecissionId",
                        column: x => x.Eco_GeneralCourtDecissionId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Eco_GeneralCourtDecission",
                        principalColumn: "Eco_GeneralCourtDecissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProsecutorLisenceUpdate",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    ProsecutorLisenceUpdateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LisenceNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LisenceLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    people = table.Column<int>(type: "int", nullable: false),
                    FreeServantGender = table.Column<int>(type: "int", nullable: false),
                    FreeServantAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    disablity = table.Column<int>(type: "int", nullable: false),
                    IssuedType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    decide = table.Column<int>(type: "int", nullable: false),
                    OnAppointment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyAmmount = table.Column<double>(type: "float", nullable: false),
                    PayedtaxAmount = table.Column<double>(type: "float", nullable: false),
                    ServicePayed = table.Column<double>(type: "float", nullable: false),
                    lisenceUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProsecutorLisenceUpdate", x => x.ProsecutorLisenceUpdateId);
                    table.ForeignKey(
                        name: "FK_ProsecutorLisenceUpdate_ProsecutorLisence_LisenceNo",
                        column: x => x.LisenceNo,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "ProsecutorLisence",
                        principalColumn: "LisenceNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZonalSectors",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    ZonalSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZonalSectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReginalSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonalSectors", x => x.ZonalSectorId);
                    table.ForeignKey(
                        name: "FK_ZonalSectors_ReginaslSector_ReginalSectorId",
                        column: x => x.ReginalSectorId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "ReginaslSector",
                        principalColumn: "ReginalSectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CCFreelServices",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CCFreelServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecorNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    SupportType = table.Column<int>(type: "int", nullable: false),
                    Doo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    typesofIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apsm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DoAss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoRet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDecission = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FreelCategory = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCFreelServices", x => x.CCFreelServicesId);
                    table.ForeignKey(
                        name: "FK_CCFreelServices_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CCFreeLsfuViewModel",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Doc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FreeLegServiceFollowupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Doa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppointmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecisionStatus = table.Column<int>(type: "int", nullable: true),
                    Decisionmadeby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCFreelServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecorNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    SupportType = table.Column<int>(type: "int", nullable: true),
                    Doo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    typesofIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apsm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoAss = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DoRet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDecission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FreelCategory = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CCFreeLsfuViewModel_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ProsecutorComment = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Doc_CivilAssosation",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CivilLicenseNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssosationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    licensedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    licensedUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceFee = table.Column<double>(type: "float", nullable: false),
                    RecietNo = table.Column<int>(type: "int", nullable: false),
                    AssosationAim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssosationMember = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DisablityStatus = table.Column<int>(type: "int", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doc_CivilAssosation", x => x.CivilLicenseNo);
                    table.ForeignKey(
                        name: "FK_Doc_CivilAssosation_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doc_WarrantyDocument",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Doc_WarrantyDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Doc_serviceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<int>(type: "int", nullable: false),
                    serverAge = table.Column<int>(type: "int", nullable: false),
                    TemperFee = table.Column<double>(type: "float", nullable: false),
                    ServiceFee = table.Column<double>(type: "float", nullable: false),
                    Expert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    workedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doc_WarrantyDocument", x => x.Doc_WarrantyDocumentId);
                    table.ForeignKey(
                        name: "FK_Doc_WarrantyDocument_Doc_serviceType_Doc_serviceTypeId",
                        column: x => x.Doc_serviceTypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Doc_serviceType",
                        principalColumn: "Doc_serviceTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doc_WarrantyDocument_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eco_Crime42A",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_Crime42AId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecordNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoliceRecordNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefendenNamet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsecutorAdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProsecutorReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdmisstionOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Persistant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abrogated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderedIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnAdmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NonOrderedIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_Crime42A", x => x.Eco_Crime42AId);
                    table.ForeignKey(
                        name: "FK_Eco_Crime42A_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eco_Crime42A_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eco_crimePitition",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_crimePititionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PititionPresentBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prosecutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Decission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecissionOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecissionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_crimePitition", x => x.Eco_crimePititionId);
                    table.ForeignKey(
                        name: "FK_Eco_crimePitition_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eco_crimePitition_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eco_DirectChargeDecission",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_DirectChargeDecissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ecocrime = table.Column<int>(type: "int", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoliceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProsocuterNo = table.Column<int>(type: "int", nullable: false),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefendantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefendantGender = table.Column<int>(type: "int", nullable: false),
                    DefendantAge = table.Column<int>(type: "int", nullable: false),
                    RespodentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RespodentGender = table.Column<int>(type: "int", nullable: false),
                    RespodentAge = table.Column<int>(type: "int", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Woreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionExpert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfWitnesses = table.Column<int>(type: "int", nullable: false),
                    Exhibit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eco_ProsecutorDecisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_DirectChargeDecission", x => x.Eco_DirectChargeDecissionId);
                    table.ForeignKey(
                        name: "FK_Eco_DirectChargeDecission_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eco_DirectChargeDecission_Eco_ProsecutorDecision_Eco_ProsecutorDecisionId",
                        column: x => x.Eco_ProsecutorDecisionId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Eco_ProsecutorDecision",
                        principalColumn: "Eco_ProsecutorDecisionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eco_DirectChargeDecission_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eco_directChargeOpening",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_directChargeOpeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ecocrime = table.Column<int>(type: "int", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoliceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProsocuterNo = table.Column<int>(type: "int", nullable: false),
                    CourtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefendantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefendantGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Woreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionExpert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_directChargeOpening", x => x.Eco_directChargeOpeningId);
                    table.ForeignKey(
                        name: "FK_Eco_directChargeOpening_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eco_directChargeOpening_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eco_WarrantyRecord",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Eco_WarrantyRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prosocuters_No = table.Column<int>(type: "int", nullable: false),
                    Police_No = table.Column<int>(type: "int", nullable: false),
                    Court_No = table.Column<int>(type: "int", nullable: false),
                    DefendentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Woreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProsecutorComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cr_Crime_TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectrorsDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eco_WarrantyRecord", x => x.Eco_WarrantyRecordId);
                    table.ForeignKey(
                        name: "FK_Eco_WarrantyRecord_Cr_Crime_Types_Cr_Crime_TypeId",
                        column: x => x.Cr_Crime_TypeId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Cr_Crime_Types",
                        principalColumn: "Cr_Crime_TypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eco_WarrantyRecord_SectrorsDepartment_SectrorsDepartmentId",
                        column: x => x.SectrorsDepartmentId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "SectrorsDepartment",
                        principalColumn: "SectrorsDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectChargeOpennings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    DirectChargeOpenningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorsSRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourtRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaintiff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accused = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeOfIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountPerBirr = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPerSquerMetter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddressZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfTheExpert = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDirected = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeTakenToComplete = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsecutorDecission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectChargeOpennings", x => x.DirectChargeOpenningId);
                    table.ForeignKey(
                        name: "FK_DirectChargeOpennings_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WoredaSectors",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    WoredaSectorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WoredaSectorsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZonalSectorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoredaSectors", x => x.WoredaSectorsId);
                    table.ForeignKey(
                        name: "FK_WoredaSectors_ZonalSectors_ZonalSectorsId",
                        column: x => x.ZonalSectorsId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "ZonalSectors",
                        principalColumn: "ZonalSectorId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "DirectChargeFollowUps",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    DirectChargeFollowUpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssuedCourtWrittenForOrganization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSubmittedToCourt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateApointmented = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DecissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CivilCaseCategory = table.Column<int>(type: "int", nullable: false),
                    DirectChargeOppeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectChargeFollowUps", x => x.DirectChargeFollowUpId);
                    table.ForeignKey(
                        name: "FK_DirectChargeFollowUps_DirectChargeOpennings_DirectChargeOppeningId",
                        column: x => x.DirectChargeOppeningId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "DirectChargeOpennings",
                        principalColumn: "DirectChargeOpenningId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectChargeFollowUps_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CCFreeLegServiceFollowup_CCFreelServicesId",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                column: "CCFreelServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_CCFreelServices_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CCFreeLsfuViewModel_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CCFreeLsfuViewModel",
                column: "SectrorsDepartmentId");

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

            migrationBuilder.CreateIndex(
                name: "IX_DirectChargeFollowUps_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectChargeFollowUps_DirectChargeOppeningId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                column: "DirectChargeOppeningId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectChargeOpennings_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Doc_CivilAssosation_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Doc_CivilAssosation",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doc_WarrantyDocument_Doc_serviceTypeId",
                schema: "ExpertUserMngt",
                table: "Doc_WarrantyDocument",
                column: "Doc_serviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Doc_WarrantyDocument_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Doc_WarrantyDocument",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_Crime42A_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Eco_Crime42A",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_Crime42A_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Eco_Crime42A",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_crimePitition_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Eco_crimePitition",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_crimePitition_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Eco_crimePitition",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_DirectChargeDecission_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Eco_DirectChargeDecission",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_DirectChargeDecission_Eco_ProsecutorDecisionId",
                schema: "ExpertUserMngt",
                table: "Eco_DirectChargeDecission",
                column: "Eco_ProsecutorDecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_DirectChargeDecission_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Eco_DirectChargeDecission",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_directChargeOpening_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Eco_directChargeOpening",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_directChargeOpening_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Eco_directChargeOpening",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_ProsecutorAppeals_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Eco_ProsecutorAppeals",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_ProsecutorAppeals_Eco_GeneralCourtDecissionId",
                schema: "ExpertUserMngt",
                table: "Eco_ProsecutorAppeals",
                column: "Eco_GeneralCourtDecissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_WarrantyRecord_Cr_Crime_TypeId",
                schema: "ExpertUserMngt",
                table: "Eco_WarrantyRecord",
                column: "Cr_Crime_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eco_WarrantyRecord_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "Eco_WarrantyRecord",
                column: "SectrorsDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProsecutorLisenceUpdate_LisenceNo",
                schema: "ExpertUserMngt",
                table: "ProsecutorLisenceUpdate",
                column: "LisenceNo");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "ExpertUserMngt",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "ExpertUserMngt",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "ExpertUserMngt",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "ExpertUserMngt",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "ExpertUserMngt",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "ExpertUserMngt",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "ExpertUserMngt",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WoredaSectors_ZonalSectorsId",
                schema: "ExpertUserMngt",
                table: "WoredaSectors",
                column: "ZonalSectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ZonalSectors_ReginalSectorId",
                schema: "ExpertUserMngt",
                table: "ZonalSectors",
                column: "ReginalSectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CCFreeLegServiceFollowup",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CCFreeLsfuViewModel",
                schema: "ExpertUserMngt");

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

            migrationBuilder.DropTable(
                name: "Cr_Decided_Judicial_and_Prosecuters",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_JudicalAppealDirectChareges",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "DirectChargeFollowUps",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Doc_CivilAssosation",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Doc_WarrantyDocument",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_Crime42A",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_crimePitition",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_DirectChargeDecission",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_directChargeOpening",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_ProsecutorAppeals",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_prosecutorComment",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_WarrantyRecord",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ProsecutorLisenceUpdate",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "SectorDepartmentViewModels",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "WoredaSectors",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CCFreelServices",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "DirectChargeOpennings",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Doc_serviceType",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_ProsecutorDecision",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_GeneralCourtDecission",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Cr_Crime_Types",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ProsecutorLisence",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ZonalSectors",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "SectrorsDepartment",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ReginaslSector",
                schema: "ExpertUserMngt");
        }
    }
}
