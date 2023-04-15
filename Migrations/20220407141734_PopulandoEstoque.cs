using Microsoft.EntityFrameworkCore.Migrations;

namespace ClaudEventos.Migrations
{
    public partial class PopulandoEstoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Eventos_EventoId",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "bannerURL",
                table: "Eventos");

            migrationBuilder.AlterColumn<int>(
                name: "EventoId",
                table: "Estoques",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Eventos_EventoId",
                table: "Estoques",
                column: "EventoId",
                principalTable: "Eventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Eventos_EventoId",
                table: "Estoques");

            migrationBuilder.AddColumn<string>(
                name: "bannerURL",
                table: "Eventos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "EventoId",
                table: "Estoques",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Eventos_EventoId",
                table: "Estoques",
                column: "EventoId",
                principalTable: "Eventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
