using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradsApp.Repository.Migrations
{
    public partial class mezunMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostTitle",
                table: "SocialPosts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostTitle",
                table: "SocialPosts");
        }
    }
}
