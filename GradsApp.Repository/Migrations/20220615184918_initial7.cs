using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradsApp.Repository.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "UserProfiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
