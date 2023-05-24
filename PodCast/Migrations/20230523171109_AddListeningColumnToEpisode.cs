using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PodCast.Migrations
{
    public partial class AddListeningColumnToEpisode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListeningCount",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListeningCount",
                table: "Episodes");
        }
    }
}
