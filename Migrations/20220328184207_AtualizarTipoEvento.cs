using Microsoft.EntityFrameworkCore.Migrations;

namespace ClaudEventos.Migrations
{
    public partial class AtualizarTipoEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "TipoEventos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TipoEventos");
        }
    }
}
