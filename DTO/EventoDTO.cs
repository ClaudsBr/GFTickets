using System;
using System.ComponentModel.DataAnnotations;
using ClaudEventos.Models;

namespace ClaudEventos.DTO
{
    public class EventoDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage ="O nome do Artista é obrigatório!")]
        [StringLength(100, ErrorMessage ="O nome do evento deve ter no máximo 100 caractéres")]
        [MinLength(5,ErrorMessage ="O nome do evento deve ter no mínximo 5 caractéres" )]
        public string Nome {get; set;}
        [Required(ErrorMessage ="O tipo do evento é obrigatório")]
        public int tipoDeEventoID {get; set;}
        [Required(ErrorMessage ="O local do evento é obrigatório")]
        public int localDoEventoID {get; set;}
        [Required(ErrorMessage ="A Data do Evento é obrigatória")]
        public DateTime dataDoEvento {get; set;}
        [Required(ErrorMessage ="O preço do Ingresso é obrigatório")]
        public int valorDoIngresso {get; set;}
        [Required(ErrorMessage ="A capacidade do Evento é obrigatória")]
        public int capacidadeDoEvento {get; set;}
        public string fotoURL {get;set;}
        
    }
}