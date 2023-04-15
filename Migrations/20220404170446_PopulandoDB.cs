using Microsoft.EntityFrameworkCore.Migrations;

namespace ClaudEventos.Migrations
{
    public partial class PopulandoDB : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(1, 'Pop/Eletronica',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(2, 'Rock/Metal',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(3, 'Samba/Pagode',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(4, 'Funk/Trap',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(5, 'Axé/Forró',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(6, 'Sertanejo',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(7, 'MPB/Bossa Nova',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(8, 'Rap/Hip Hop',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(9, 'Jazz/Blues',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(10, 'Erudita/Ópera',1)");
            mb.Sql("INSERT INTO TipoEventos(Id, Nome, Status) VALUES(11, 'Outros Estilos',1)");

            mb.Sql("INSERT INTO LocalEventos(Id, Nome, Endereco, Status) VALUES(1, 'Espaço das Américas', ' Rua Tagipuru, 795 - Barra Funda - São Paulo, SP', 1)");
            mb.Sql("INSERT INTO LocalEventos(Id, Nome, Endereco, Status) VALUES(2, 'UnimedHall', 'Av. das Nações Unidas, 17955 - Vila Almeida, São Paulo - SP', 1)");
            mb.Sql("INSERT INTO LocalEventos(Id, Nome, Endereco, Status) VALUES(3, 'Allianz Parque', 'Av. Francisco Matarazzo, 1705 - Água Branca, São Paulo - SP', 1)");
            mb.Sql("INSERT INTO LocalEventos(Id, Nome, Endereco, Status) VALUES(4, 'Tokio Marine Hall', 'R. Bragança Paulista, 1281 - Várzea de Baixo, São Paulo - SP', 1)");
            mb.Sql("INSERT INTO LocalEventos(Id, Nome, Endereco, Status) VALUES(5, 'Manifesto Bar', 'R. Iguatemi, 36 - Itaim Bibi, São Paulo - SP', 1)");
            mb.Sql("INSERT INTO LocalEventos(Id, Nome, Endereco, Status) VALUES(6, 'Estádio do Morumbi', 'Praça Roberto Gomes Pedrosa, 1 - Morumbi, São Paulo - SP', 1)");

            
            mb.Sql("INSERT INTO Eventos(Id, Nome, tipoDeEventoId, localDoEventoId, dataDoEvento, valorDoIngresso, capacidadeDoEvento, status, fotoURL) VALUES(1, 'The Killers', 2, 3, date'2022-05-14', 240, 38000, 1,'https://a-static.mlcdn.com.br/618x463/dvd-the-killers-itunes-festival-2012-jam-records/discocenter/6e6503c2dd0011ebacab4201ac18500e/01f3c7b5e54d08d174177f38a7cd5bf2.jpg')");
            mb.Sql("INSERT INTO Eventos(Id, Nome, tipoDeEventoId, localDoEventoId, dataDoEvento, valorDoIngresso, capacidadeDoEvento, status, fotoURL) VALUES(2, 'Keane', 1, 2, date'2022-03-30', 180, 3500, 1, 'https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/9/98/Keanecornbury.jpg/1280px-Keanecornbury.jpg')");
            mb.Sql("INSERT INTO Eventos(Id, Nome, tipoDeEventoId, localDoEventoId, dataDoEvento, valorDoIngresso, capacidadeDoEvento, status, fotoURL) VALUES(3, 'Jay-Z', 8, 1, date'2022-06-08', 350, 5500, 1, 'https://www.amica.it/wp-content/uploads/2019/12/APE-GettyImages-1010060996-635x953.jpg')");
            mb.Sql("INSERT INTO Eventos(Id, Nome, tipoDeEventoId, localDoEventoId, dataDoEvento, valorDoIngresso, capacidadeDoEvento, status, fotoURL) VALUES(4, 'Coldplay', 1, 3, date'2022-10-30', 480, 48000, 1, 'https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/ColdplayBBC071221_%2853_of_53%29_%2851740659597%29.jpg/220px-ColdplayBBC071221_%2853_of_53%29_%2851740659597%29.jpg')");
            mb.Sql("INSERT INTO Eventos(Id, Nome, tipoDeEventoId, localDoEventoId, dataDoEvento, valorDoIngresso, capacidadeDoEvento, status, fotoURL) VALUES(5, 'Depeche Mode', 1, 1, date'2022-11-23', 360, 5500, 1, 'https://www.telekom.com/resource/image/486646/landscape_ratio4x3/320/240/aa1c175e9489c6b5e02fb149f004c152/Zs/bi-170301-bandfoto-depeche-mode-en.jpg')");
            mb.Sql("INSERT INTO Eventos(Id, Nome, tipoDeEventoId, localDoEventoId, dataDoEvento, valorDoIngresso, capacidadeDoEvento, status, fotoURL) VALUES(6, 'Zeca Pagodinho', 3, 2, date'2022-08-25', 250, 3500, 1, 'https://upload.wikimedia.org/wikipedia/commons/0/05/Zeca_Pagodinho_2022.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Eventos");
        }
    }
}
