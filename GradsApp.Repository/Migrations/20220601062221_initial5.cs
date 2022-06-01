using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradsApp.Repository.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UserProfiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UserProfiles",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }
    }
}
