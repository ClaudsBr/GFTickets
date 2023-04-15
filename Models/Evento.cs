using System;

namespace ClaudEventos.Models
{
    public class Evento
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public TipoEvento tipoDeEvento {get; set;}
        public LocalEvento localDoEvento {get; set;}
        public DateTime dataDoEvento {get; set;}
        public int valorDoIngresso {get; set;}
        public int capacidadeDoEvento {get; set;}
        public string fotoURL {get;set;}
        
        public bool status {get; set;}
    }
}