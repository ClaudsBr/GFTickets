namespace ClaudEventos.Models
{
    public class Estoque
    {
        public int Id {get; set;}
        public Evento Evento {get; set;}
        public int EventoId {get;set;}
        public int Quantidade {get; set;}
    }
}