using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class AddDirectChargeopenningAndFollwup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProsecutorComment",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "int",
                nullable: true);

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
                name: "DirectChargeFollowUps",
                schema: "ExpertUserMngt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssuedCourtWrittenForOrganization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSubmittedToCourt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateApointmented = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DecissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectChargeFollowUps",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "DirectChargeOpennings",
                schema: "ExpertUserMngt");

            migrationBuilder.DropColumn(
                name: "ProsecutorComment",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");
        }
    }
}
