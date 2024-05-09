using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class CivilCaseInIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ExpertUserMngt");

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
                    FileNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RecorNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Responder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    age = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    SupportType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Doo = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    typesofIssue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apsm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressZone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressWoreda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExpertName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DoAss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoRet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LOS = table.Column<DateTime>(type: "datetime2", nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_CCFreelServices_SectrorsDepartmentId",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                column: "SectrorsDepartmentId");

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
                name: "CCFreelServices",
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
                name: "SectrorsDepartment",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ZonalSectors",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "ReginaslSector",
                schema: "ExpertUserMngt");
        }
    }
}
