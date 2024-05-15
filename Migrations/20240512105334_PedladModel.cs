using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class PedladModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ExpertUserMngt");

            migrationBuilder.CreateTable(
                name: "CCdlt",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CCdltId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DltFileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltRecorNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltApplicant = table.Column<int>(type: "int", nullable: false),
                    DltResponder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltGender = table.Column<int>(type: "int", nullable: false),
                    DltAge = table.Column<int>(type: "int", nullable: false),
                    DltSupportType = table.Column<int>(type: "int", nullable: false),
                    DltDoo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DlttypesofIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltAmountBirr = table.Column<int>(type: "int", nullable: false),
                    DltAmountKarie = table.Column<int>(type: "int", nullable: false),
                    DltAddressZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltAddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltExpertName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DltDoAss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DltDoRet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DltLOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DltPDecission = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DltAssignto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCdlt", x => x.CCdltId);
                });

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
                    Age = table.Column<int>(type: "int", nullable: false),
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
                    Age = table.Column<int>(type: "int", nullable: true),
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
                name: "DirectChargeOpennings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectChargeOpennings", x => x.Id);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssuedCourtWrittenForOrganization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSubmittedToCourt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateApointmented = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DecissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CivilCaseCategory = table.Column<int>(type: "int", nullable: false),
                    DirectChargeOppeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectChargeFollowUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectChargeFollowUps_DirectChargeOpennings_DirectChargeOppeningId",
                        column: x => x.DirectChargeOppeningId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "DirectChargeOpennings",
                        principalColumn: "Id",
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
                name: "CCdlt",
                schema: "ExpertUserMngt");

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
                name: "Cr_Crime_Types",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "DirectChargeOpennings",
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
