using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineviewsApp.Migrations
{
    public partial class AddThumbsToMeufilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThumbsDown",
                table: "MeusFilmes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThumbsUp",
                table: "MeusFilmes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbsDown",
                table: "MeusFilmes");

            migrationBuilder.DropColumn(
                name: "ThumbsUp",
                table: "MeusFilmes");
        }
    }
}
