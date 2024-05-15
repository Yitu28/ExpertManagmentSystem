using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class UpdateCivilCaseModelUpbyandAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Peage",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                newName: "PeAge");

            migrationBuilder.RenameColumn(
                name: "age",
                schema: "ExpertUserMngt",
                table: "CCFreeLsfuViewModel",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "age",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "Dltage",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                newName: "DltAge");

            migrationBuilder.AddColumn<DateTime>(
                name: "PeCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PeCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PeDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PeUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LadCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LadCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LadDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LadDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LadEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LaddatededBy",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PDecission",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpertName",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<DateTime>(
                name: "CCServCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CCServCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CCServDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CCServDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CCServEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CCServUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FollupCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FollupCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FollupDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FollupDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FollupEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FollupUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DltCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DltCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DltDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DltDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DltEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DltUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "PeCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "PeDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "PeDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "PeEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "PeUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCPetition");

            migrationBuilder.DropColumn(
                name: "LadCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.DropColumn(
                name: "LadCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.DropColumn(
                name: "LadDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.DropColumn(
                name: "LadDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.DropColumn(
                name: "LadEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.DropColumn(
                name: "LaddatededBy",
                schema: "ExpertUserMngt",
                table: "CCLegaladvices");

            migrationBuilder.DropColumn(
                name: "CCServCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "CCServCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "CCServDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "CCServDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "CCServEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "CCServUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCFreelServices");

            migrationBuilder.DropColumn(
                name: "FollupCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup");

            migrationBuilder.DropColumn(
                name: "FollupCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup");

            migrationBuilder.DropColumn(
                name: "FollupDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup");

            migrationBuilder.DropColumn(
                name: "FollupDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup");

            migrationBuilder.DropColumn(
                name: "FollupEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup");

            migrationBuilder.DropColumn(
                name: "FollupUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCFreeLegServiceFollowup");

            migrationBuilder.DropColumn(
                name: "DltCreatedAt",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.DropColumn(
                name: "DltCreatedBy",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.DropColumn(
                name: "DltDeletedAt",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.DropColumn(
                name: "DltDeletedBy",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.DropColumn(
                name: "DltEdittedAt",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.DropColumn(
                name: "DltUpdatededBy",
                schema: "ExpertUserMngt",
                table: "CCdlt");

            migrationBuilder.RenameColumn(
                name: "PeAge",
                schema: "ExpertUserMngt",
                table: "CCPetition",
                newName: "Peage");

            migrationBuilder.RenameColumn(
                name: "Age",
                schema: "ExpertUserMngt",
                table: "CCFreeLsfuViewModel",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Age",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "DltAge",
                schema: "ExpertUserMngt",
                table: "CCdlt",
                newName: "Dltage");

            migrationBuilder.AlterColumn<string>(
                name: "PDecission",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpertName",
                schema: "ExpertUserMngt",
                table: "CCFreelServices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
