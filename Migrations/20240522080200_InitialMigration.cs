using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class InitialMigration : Migration
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
                    DltApplicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    DltExpertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltDoAss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DltDoRet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DltLOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCDltDecissionTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DltAssignto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DltCreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DltUpdatededBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DltDeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DltCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DltEdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DltDeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCdlt", x => x.CCdltId);
                });

            migrationBuilder.CreateTable(
                name: "CCLegaladvices",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CCLegaladvicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LadFileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ladvicerequester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadDoariv = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadAmountBirr = table.Column<int>(type: "int", nullable: false),
                    LadAmountKarie = table.Column<int>(type: "int", nullable: false),
                    LadAddressZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadAddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadExpertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadDaos = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadDoare = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadTimeTaken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCLadDecissionTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadAssignto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadCreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LaddatededBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LadDeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LadCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LadEdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LadDeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCLegaladvices", x => x.CCLegaladvicesId);
                });

            migrationBuilder.CreateTable(
                name: "CCPetition",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    CCPetitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeFileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pevicerequester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeGender = table.Column<int>(type: "int", nullable: false),
                    PeAge = table.Column<int>(type: "int", nullable: false),
                    PeSupportType = table.Column<int>(type: "int", nullable: false),
                    PeDoariv = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeAddressZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeAddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeExpertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeDaos = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeDoare = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeTimeTaken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCPeDecissionTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeAssignto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeCreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeUpdatededBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeDeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeEdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeDeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCPetition", x => x.CCPetitionId);
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
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    SupportType = table.Column<int>(type: "int", nullable: true),
                    Doo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    typesofIssue = table.Column<int>(type: "int", nullable: false),
                    CustomerCategory = table.Column<int>(type: "int", nullable: true),
                    AmountinBirr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amountincarie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoAss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoRet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCPDecissionTypes = table.Column<int>(type: "int", nullable: true),
                    CCServCreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CCServUpdatededBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CCServDeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CCServCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CCServEdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CCServDeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "ContractInvestigations",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contractor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractReciepient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeOfContract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountPerMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TheInstitutionRequestedForExamination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfTheExpert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeTakenToComplete = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractInvestigations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractInvestigations_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DirectChargeOpennings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorsRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaintiff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accused = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeOfIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountPerBirr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountPerSquerMetter = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AddressZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfTheExpert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDirected = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeTakenToComplete = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsecutorDecission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CivilCaseCategory = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "LeadingCommandUnAppealNotSupporteds",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaintiff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accused = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeOfIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeadingCommandAndUnSupportAppeal = table.Column<int>(type: "int", nullable: true),
                    AmountPerBirr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountPerSquerMetter = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProsecutorSupportTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfTheExpert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeTakenToComplete = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsecutorDecission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadingCommandUnAppealNotSupporteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadingCommandUnAppealNotSupporteds_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PerformanceChargeOpennings",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProsecutorsSRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaintiff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accused = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerType = table.Column<int>(type: "int", nullable: false),
                    OpenningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmountInBirr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountPerSquerMetter = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AddressZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressWoreda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfPerformanceCgarge = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceChargeOpennings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceChargeOpennings_Users_ApplicationUserId",
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
                    CCFreelServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollupCreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FollupUpdatededBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FollupDeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FollupCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FollupEdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FollupDeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    IssuedCourtWrittenForOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSubmittedToCourt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateApointmented = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CivilCaseCategory = table.Column<int>(type: "int", nullable: true),
                    DirectChargeOppeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DirectChargeFollowUps_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PerformanceChargeFollowUps",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameOfTheExpert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfCourtCasePresented = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApointmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HasDecissionMade = table.Column<bool>(type: "bit", nullable: true),
                    TypeOfDecission = table.Column<int>(type: "int", nullable: true),
                    DecidedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoneyGained = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProperyClosed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiffrenetReasons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerformanceChargeOpenningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EdittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceChargeFollowUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceChargeFollowUps_PerformanceChargeOpennings_PerformanceChargeOpenningId",
                        column: x => x.PerformanceChargeOpenningId,
                        principalSchema: "ExpertUserMngt",
                        principalTable: "PerformanceChargeOpennings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerformanceChargeFollowUps_Users_ApplicationUserId",
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
                name: "IX_ContractInvestigations_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                column: "ApplicationUserId");

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
                name: "IX_LeadingCommandUnAppealNotSupporteds_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceChargeFollowUps_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceChargeFollowUps_PerformanceChargeOpenningId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                column: "PerformanceChargeOpenningId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceChargeOpennings_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
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
                name: "CCLegaladvices",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CCPetition",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ContractInvestigations",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "DirectChargeFollowUps",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "LeadingCommandUnAppealNotSupporteds",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "PerformanceChargeFollowUps",
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
                name: "PerformanceChargeOpennings",
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
