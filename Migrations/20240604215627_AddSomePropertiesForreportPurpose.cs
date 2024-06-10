using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class AddSomePropertiesForreportPurpose : Migration
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

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUser",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                newName: "EditedBy");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUser",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                newName: "EditedBy");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUser",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                newName: "EditedBy");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUser",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                newName: "EditedBy");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUser",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                newName: "EditedBy");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUser",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                newName: "EditedBy");

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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "ContractInvestigationDocumentStatus",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractInvestigationDocumentType",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TimeTakenToComplete",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddColumn<int>(
                name: "ContractInvestigationDocumentStatus",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractInvestigationDocumentType",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceChargeOpennings_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                column: "SectorDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceChargeFollowUps_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                column: "SectorDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadingCommandUnAppealNotSupporteds_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                column: "SectorDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractInvestigations_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                column: "SectorDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractInvestigations_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                column: "SectorDepartmentId",
                principalSchema: "ExpertUserMngt",
                principalTable: "SectrorsDepartment",
                principalColumn: "SectrorsDepartmentId");

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
                name: "FK_LeadingCommandUnAppealNotSupporteds_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                column: "SectorDepartmentId",
                principalSchema: "ExpertUserMngt",
                principalTable: "SectrorsDepartment",
                principalColumn: "SectrorsDepartmentId");

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
                name: "FK_PerformanceChargeFollowUps_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                column: "SectorDepartmentId",
                principalSchema: "ExpertUserMngt",
                principalTable: "SectrorsDepartment",
                principalColumn: "SectrorsDepartmentId");

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
                name: "FK_PerformanceChargeOpennings_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                column: "SectorDepartmentId",
                principalSchema: "ExpertUserMngt",
                principalTable: "SectrorsDepartment",
                principalColumn: "SectrorsDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                column: "ApplicationUserId",
                principalSchema: "ExpertUserMngt",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractInvestigations_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

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
                name: "FK_LeadingCommandUnAppealNotSupporteds_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadingCommandUnAppealNotSupporteds_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeFollowUps_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeFollowUps_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeOpennings_SectrorsDepartment_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceChargeOpennings_Users_ApplicationUserId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.DropIndex(
                name: "IX_PerformanceChargeOpennings_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.DropIndex(
                name: "IX_PerformanceChargeFollowUps_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropIndex(
                name: "IX_LeadingCommandUnAppealNotSupporteds_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropIndex(
                name: "IX_ContractInvestigations_SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.DropColumn(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropColumn(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps");

            migrationBuilder.DropColumn(
                name: "ContractInvestigationDocumentStatus",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropColumn(
                name: "ContractInvestigationDocumentType",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropColumn(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps");

            migrationBuilder.DropColumn(
                name: "ContractInvestigationDocumentStatus",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.DropColumn(
                name: "ContractInvestigationDocumentType",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.DropColumn(
                name: "SectorDepartmentId",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations");

            migrationBuilder.RenameColumn(
                name: "EditedBy",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeOpennings",
                newName: "ApplicationUserUser");

            migrationBuilder.RenameColumn(
                name: "EditedBy",
                schema: "ExpertUserMngt",
                table: "PerformanceChargeFollowUps",
                newName: "ApplicationUserUser");

            migrationBuilder.RenameColumn(
                name: "EditedBy",
                schema: "ExpertUserMngt",
                table: "LeadingCommandUnAppealNotSupporteds",
                newName: "ApplicationUserUser");

            migrationBuilder.RenameColumn(
                name: "EditedBy",
                schema: "ExpertUserMngt",
                table: "DirectChargeOpennings",
                newName: "ApplicationUserUser");

            migrationBuilder.RenameColumn(
                name: "EditedBy",
                schema: "ExpertUserMngt",
                table: "DirectChargeFollowUps",
                newName: "ApplicationUserUser");

            migrationBuilder.RenameColumn(
                name: "EditedBy",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                newName: "ApplicationUserUser");

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
                name: "TimeTakenToComplete",
                schema: "ExpertUserMngt",
                table: "ContractInvestigations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
