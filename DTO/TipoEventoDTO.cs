using System.ComponentModel.DataAnnotations;

namespace ClaudEventos.DTO
{
    public class TipoEventoDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [StringLength(100, ErrorMessage ="O nome do tipo de evento deve ter no máximo 100 caracteres")]
        [MinLength(3, ErrorMessage ="O nome do tipo de evento deve ter no mínimo 3 caracteres")]
        public string Nome {get;set;}
        
    }
}