using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    public partial class updateZonalModels01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WoredaSectors_ZonalSectors_ZonalSectorsZonalSectorId",
                table: "WoredaSectors");

            migrationBuilder.DropIndex(
                name: "IX_WoredaSectors_ZonalSectorsZonalSectorId",
                table: "WoredaSectors");

            migrationBuilder.DropColumn(
                name: "ZonalSectorsZonalSectorId",
                table: "WoredaSectors");

            migrationBuilder.AddColumn<Guid>(
                name: "ZonalSectorsId",
                table: "WoredaSectors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_WoredaSectors_ZonalSectorsId",
                table: "WoredaSectors",
                column: "ZonalSectorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_WoredaSectors_ZonalSectors_ZonalSectorsId",
                table: "WoredaSectors",
                column: "ZonalSectorsId",
                principalTable: "ZonalSectors",
                principalColumn: "ZonalSectorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WoredaSectors_ZonalSectors_ZonalSectorsId",
                table: "WoredaSectors");

            migrationBuilder.DropIndex(
                name: "IX_WoredaSectors_ZonalSectorsId",
                table: "WoredaSectors");

            migrationBuilder.DropColumn(
                name: "ZonalSectorsId",
                table: "WoredaSectors");

            migrationBuilder.AddColumn<Guid>(
                name: "ZonalSectorsZonalSectorId",
                table: "WoredaSectors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WoredaSectors_ZonalSectorsZonalSectorId",
                table: "WoredaSectors",
                column: "ZonalSectorsZonalSectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_WoredaSectors_ZonalSectors_ZonalSectorsZonalSectorId",
                table: "WoredaSectors",
                column: "ZonalSectorsZonalSectorId",
                principalTable: "ZonalSectors",
                principalColumn: "ZonalSectorId");
        }
    }
}
