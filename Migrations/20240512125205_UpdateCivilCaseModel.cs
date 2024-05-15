using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class UpdateCivilCaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    LadTimeTaken = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadPDecisoion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LadAssignto = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CCLegaladvicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    PeTimeTaken = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PePDecisoion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeAssignto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCPetition", x => x.CCLegaladvicesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CCLegaladvices",
                schema: "ExpertUserMngt");

            migrationBuilder.DropTable(
                name: "CCPetition",
                schema: "ExpertUserMngt");
        }
    }
}
