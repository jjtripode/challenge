using System.ComponentModel.DataAnnotations;

namespace NubimetricsApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [MinLength(3), MaxLength(100)]
        public string Apellido { get; set; }
      
        [MinLength(3), MaxLength(100)]
        public string Email { get; set; }

        [MinLength(3), MaxLength(100)]
        public string Password { get; set; }
    }
}