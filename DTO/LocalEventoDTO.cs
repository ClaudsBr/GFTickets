using System.ComponentModel.DataAnnotations;

namespace ClaudEventos.DTO
{
    public class LocalEventoDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage ="O nome do local do evento é obrigatório!")]
        [StringLength(100, ErrorMessage ="O nome do local de evento deve ter no máximo 100 caracteres")]
        [MinLength(3,ErrorMessage = "O nome do local de evento deve ter no mínimo 3 caracteres")]
        public string Nome {get; set;}
        
        [Required(ErrorMessage ="O endereço do local do evento é obrigatório!")]
        [StringLength(150, ErrorMessage ="O endereço do local do evento deve ter no máximo 150 caracteres")]
        [MinLength(5,ErrorMessage = "O endereço do local do evento deve ter no mínimo 5 caracteres")]
        public string Endereco {get; set;}
    }
}