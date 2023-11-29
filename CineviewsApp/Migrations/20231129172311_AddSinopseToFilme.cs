using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineviewsApp.Migrations
{
    public partial class AddSinopseToFilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sinopse",
                table: "Filmes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sinopse",
                table: "Filmes");
        }
    }
}
