using Microsoft.EntityFrameworkCore.Migrations;

namespace LBL.Migrations
{
    public partial class RegionAndTeamTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Organizer",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "Organizer",
                table: "Regions");
        }
    }
}
