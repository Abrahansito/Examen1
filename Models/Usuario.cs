using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EXAMEN_1.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required, EmailAddress (ErrorMessage = "El correo electrónico no es válido")]
        public string? Email { get; set; }

        [Required (ErrorMessage = "El pais es obligatorio")] 
        public string? Pais { get; set; }
        
    }
}