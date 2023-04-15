using Microsoft.EntityFrameworkCore.Migrations;

namespace ClaudEventos.Migrations
{
    public partial class NewEstoque : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Estoques(Id, EventoId, Quantidade) VALUES(1, 1, 38000)");
            mb.Sql("INSERT INTO Estoques(Id, EventoId, Quantidade) VALUES(2, 2, 3500)");
            mb.Sql("INSERT INTO Estoques(Id, EventoId, Quantidade) VALUES(3, 3, 5500)");
            mb.Sql("INSERT INTO Estoques(Id, EventoId, Quantidade) VALUES(4, 4, 48000)");
            mb.Sql("INSERT INTO Estoques(Id, EventoId, Quantidade) VALUES(5, 5, 5500)");
            mb.Sql("INSERT INTO Estoques(Id, EventoId, Quantidade) VALUES(6, 6, 3500)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Estoques");
        }
    }
}
