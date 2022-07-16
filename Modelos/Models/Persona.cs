using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasPlenario.Models
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Crédito Máximo")]
        public double CreditoMaximo { get; set; }
        public virtual ICollection<Telefono>? Telefonos { get; set; }
    }
}
