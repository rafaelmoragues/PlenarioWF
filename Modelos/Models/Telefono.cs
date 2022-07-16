using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasPlenario.Models
{
    public class Telefono
    {
        [Key]
        public int TelefonoId { get; set; }
        [Required]
        [Display(Name = "Numero de teléfono")]
        public string TelefonoNumero { get; set; }
        public int PersonaId { get; set; }
        public Persona? Persona { get; set; }
    }
}
