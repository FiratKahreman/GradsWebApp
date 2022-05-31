using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradsApp.Repository.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostText",
                table: "SocialPosts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostText",
                table: "SocialPosts");
        }
    }
}
