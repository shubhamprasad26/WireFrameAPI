using Microsoft.EntityFrameworkCore.Migrations;

namespace WireFrame.Migrations
{
    public partial class basicFlightInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flightInfos_airliness_airlineId",
                table: "flightInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_flightInfos_mealss_mealTypeId",
                table: "flightInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_flightInfos_placess_destinationId",
                table: "flightInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_flightInfos_placess_sourceId",
                table: "flightInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_flightInfos_scheduleTypess_scheduleTypesId",
                table: "flightInfos");

            migrationBuilder.DropIndex(
                name: "IX_flightInfos_airlineId",
                table: "flightInfos");

            migrationBuilder.DropIndex(
                name: "IX_flightInfos_destinationId",
                table: "flightInfos");

            migrationBuilder.DropIndex(
                name: "IX_flightInfos_mealTypeId",
                table: "flightInfos");

            migrationBuilder.DropIndex(
                name: "IX_flightInfos_scheduleTypesId",
                table: "flightInfos");

            migrationBuilder.DropIndex(
                name: "IX_flightInfos_sourceId",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "airlineId",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "destinationId",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "mealTypeId",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "scheduleTypesId",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "sourceId",
                table: "flightInfos");

            migrationBuilder.AddColumn<string>(
                name: "airline",
                table: "flightInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "destination",
                table: "flightInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mealType",
                table: "flightInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "scheduleTypes",
                table: "flightInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "source",
                table: "flightInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "airline",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "destination",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "mealType",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "scheduleTypes",
                table: "flightInfos");

            migrationBuilder.DropColumn(
                name: "source",
                table: "flightInfos");

            migrationBuilder.AddColumn<int>(
                name: "airlineId",
                table: "flightInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "destinationId",
                table: "flightInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mealTypeId",
                table: "flightInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "scheduleTypesId",
                table: "flightInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sourceId",
                table: "flightInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_flightInfos_airlineId",
                table: "flightInfos",
                column: "airlineId");

            migrationBuilder.CreateIndex(
                name: "IX_flightInfos_destinationId",
                table: "flightInfos",
                column: "destinationId");

            migrationBuilder.CreateIndex(
                name: "IX_flightInfos_mealTypeId",
                table: "flightInfos",
                column: "mealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_flightInfos_scheduleTypesId",
                table: "flightInfos",
                column: "scheduleTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_flightInfos_sourceId",
                table: "flightInfos",
                column: "sourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_flightInfos_airliness_airlineId",
                table: "flightInfos",
                column: "airlineId",
                principalTable: "airliness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_flightInfos_mealss_mealTypeId",
                table: "flightInfos",
                column: "mealTypeId",
                principalTable: "mealss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_flightInfos_placess_destinationId",
                table: "flightInfos",
                column: "destinationId",
                principalTable: "placess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_flightInfos_placess_sourceId",
                table: "flightInfos",
                column: "sourceId",
                principalTable: "placess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_flightInfos_scheduleTypess_scheduleTypesId",
                table: "flightInfos",
                column: "scheduleTypesId",
                principalTable: "scheduleTypess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
