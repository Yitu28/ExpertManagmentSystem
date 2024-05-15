using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class Eco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PetWar",
                schema: "ExpertUserMngt",
                table: "Eco_WarrantyRecord");

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
                    Decission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecissionOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecissionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eco_Crime42A",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "Eco_crimePitition",
                schema: "ExpertUserMngt");

            migrationBuilder.AddColumn<int>(
                name: "PetWar",
                schema: "ExpertUserMngt",
                table: "Eco_WarrantyRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
