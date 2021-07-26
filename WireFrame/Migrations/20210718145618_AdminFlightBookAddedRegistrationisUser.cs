using Microsoft.EntityFrameworkCore.Migrations;

namespace WireFrame.Migrations
{
    public partial class AdminFlightBookAddedRegistrationisUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isAdmin",
                table: "registrations",
                newName: "isUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isUser",
                table: "registrations",
                newName: "isAdmin");
        }
    }
}
