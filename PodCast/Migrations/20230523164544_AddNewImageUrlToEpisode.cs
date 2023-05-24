using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PodCast.Migrations
{
    public partial class AddNewImageUrlToEpisode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Episodes",
                newName: "CornerImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundImageUrl",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImageUrl",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "CornerImageUrl",
                table: "Episodes",
                newName: "ImageUrl");
        }
    }
}
