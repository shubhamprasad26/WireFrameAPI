using Microsoft.EntityFrameworkCore.Migrations;

namespace WireFrame.Migrations
{
    public partial class AdminFlightBookingImp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flightInfos_scheduleTypess_scheduleDatesId",
                table: "flightInfos");

            migrationBuilder.RenameColumn(
                name: "scheduleDatesId",
                table: "flightInfos",
                newName: "scheduleTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_flightInfos_scheduleDatesId",
                table: "flightInfos",
                newName: "IX_flightInfos_scheduleTypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_flightInfos_scheduleTypess_scheduleTypesId",
                table: "flightInfos",
                column: "scheduleTypesId",
                principalTable: "scheduleTypess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flightInfos_scheduleTypess_scheduleTypesId",
                table: "flightInfos");

            migrationBuilder.RenameColumn(
                name: "scheduleTypesId",
                table: "flightInfos",
                newName: "scheduleDatesId");

            migrationBuilder.RenameIndex(
                name: "IX_flightInfos_scheduleTypesId",
                table: "flightInfos",
                newName: "IX_flightInfos_scheduleDatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_flightInfos_scheduleTypess_scheduleDatesId",
                table: "flightInfos",
                column: "scheduleDatesId",
                principalTable: "scheduleTypess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
