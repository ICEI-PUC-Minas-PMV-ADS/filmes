using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineviewsApp.Migrations
{
    public partial class AddIsAssistidoColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAssistido",
                table: "Filmes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAssistido",
                table: "Filmes");
        }
    }
}
