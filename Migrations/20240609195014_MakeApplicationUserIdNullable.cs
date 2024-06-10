using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class MakeApplicationUserIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractInvestigations_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadingCommandUnAppealNotSupporteds_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractInvestigations_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadingCommandUnAppealNotSupporteds_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractInvestigations_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadingCommandUnAppealNotSupporteds_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractInvestigations_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadingCommandUnAppealNotSupporteds_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
