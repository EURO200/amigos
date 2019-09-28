using System;
using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public class Registro
    {
        [key]
        public int Friendld { get; set; }
        [Required][Range(5, 50)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [DateTime]
        public int Birthdate { get; set; }
        public string List { get; set; }
    }
}