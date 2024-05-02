using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class modifingCriminalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourtDesitions",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "EventStatus",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "ExpertsToCourt",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "ExpertsToProsecuter",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "ProsocuterFocus",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "ToFederal",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.RenameColumn(
                name: "AmountOfAppealMale",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                newName: "NumberOfMaleAppellants");

            migrationBuilder.RenameColumn(
                name: "AmountOfAppealFemale",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                newName: "NumberOfFemaleAppellants");

            migrationBuilder.AlterColumn<string>(
                name: "Respondant",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Other",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CrimeType",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Applicant",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FederalBreakingRequest",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FileEndResult",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FileStatus",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HighCourtDecission",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OtherCourtDecition",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhoJudgeCommentedOnDecision",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhoLawyeCommented",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FederalBreakingRequest",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "FileEndResult",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "FileStatus",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "HighCourtDecission",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "OtherCourtDecition",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "WhoJudgeCommentedOnDecision",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.DropColumn(
                name: "WhoLawyeCommented",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters");

            migrationBuilder.RenameColumn(
                name: "NumberOfMaleAppellants",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                newName: "AmountOfAppealMale");

            migrationBuilder.RenameColumn(
                name: "NumberOfFemaleAppellants",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                newName: "AmountOfAppealFemale");

            migrationBuilder.AlterColumn<string>(
                name: "Respondant",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Other",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CrimeType",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Applicant",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourtDesitions",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EventStatus",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpertsToCourt",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpertsToProsecuter",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProsocuterFocus",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ToFederal",
                schema: "ExpertUserMngt",
                table: "Cr_Decided_Judicial_and_Prosecuters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
