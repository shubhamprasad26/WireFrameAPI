using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WireFrame.Migrations
{
    public partial class AdminFlightBookingConcept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "airliness",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airliness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mealss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mealss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "placess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plcs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "scheduleTypess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduleTypess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "flightInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    airlineId = table.Column<int>(type: "int", nullable: true),
                    sourceId = table.Column<int>(type: "int", nullable: true),
                    destinationId = table.Column<int>(type: "int", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scheduleDatesId = table.Column<int>(type: "int", nullable: true),
                    instrumentUsed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    businessSeats = table.Column<int>(type: "int", nullable: false),
                    nonBusinessSeats = table.Column<int>(type: "int", nullable: false),
                    cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    noofRows = table.Column<byte>(type: "tinyint", nullable: false),
                    mealTypeId = table.Column<int>(type: "int", nullable: true),
                    briefInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_flightInfos_airliness_airlineId",
                        column: x => x.airlineId,
                        principalTable: "airliness",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_flightInfos_mealss_mealTypeId",
                        column: x => x.mealTypeId,
                        principalTable: "mealss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_flightInfos_placess_destinationId",
                        column: x => x.destinationId,
                        principalTable: "placess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_flightInfos_placess_sourceId",
                        column: x => x.sourceId,
                        principalTable: "placess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_flightInfos_scheduleTypess_scheduleDatesId",
                        column: x => x.scheduleDatesId,
                        principalTable: "scheduleTypess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_flightInfos_scheduleDatesId",
                table: "flightInfos",
                column: "scheduleDatesId");

            migrationBuilder.CreateIndex(
                name: "IX_flightInfos_sourceId",
                table: "flightInfos",
                column: "sourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flightInfos");

            migrationBuilder.DropTable(
                name: "airliness");

            migrationBuilder.DropTable(
                name: "mealss");

            migrationBuilder.DropTable(
                name: "placess");

            migrationBuilder.DropTable(
                name: "scheduleTypess");
        }
    }
}
