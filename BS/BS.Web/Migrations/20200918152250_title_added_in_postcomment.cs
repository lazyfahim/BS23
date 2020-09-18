using Microsoft.EntityFrameworkCore.Migrations;

namespace BS.Web.Migrations
{
    public partial class title_added_in_postcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommentBody",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CommentBody",
                table: "Comments");
        }
    }
}
