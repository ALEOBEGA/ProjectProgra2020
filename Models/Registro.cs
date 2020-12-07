using System;
using System.ComponentModel.DataAnnotations;


namespace projectProgra2020.Models
{
    public class Registro
    {
        [Key]
        public int dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        
    }
}