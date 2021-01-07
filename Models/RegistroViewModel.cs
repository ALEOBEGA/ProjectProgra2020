using System.ComponentModel.DataAnnotations;

namespace ProjectProgra2020.Models
{
    public class RegistroViewModel
    {
        [Required]
        public string id { get; set; }
        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "La contraseña y la confirmación no coinciden.")]
        public string PasswordConfirmacion { get; set; }
    }
}