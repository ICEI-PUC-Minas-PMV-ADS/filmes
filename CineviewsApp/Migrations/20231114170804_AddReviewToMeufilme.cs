using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineviewsApp.Migrations
{
    public partial class AddReviewToMeufilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "MeusFilmes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "MeusFilmes");
        }
    }
}
