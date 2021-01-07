using System.ComponentModel.DataAnnotations;

namespace ProjectProgra2020.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}