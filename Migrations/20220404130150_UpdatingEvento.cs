using Microsoft.EntityFrameworkCore.Migrations;

namespace ClaudEventos.Migrations
{
    public partial class UpdatingEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fotoURL",
                table: "Eventos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fotoURL",
                table: "Eventos");
        }
    }
}
