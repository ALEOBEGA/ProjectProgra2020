using System;
using System.ComponentModel.DataAnnotations;


namespace projectProgra2020.Models
{
    public class Categoria
    {
        [Key]
        public int categoriaid { get; set; }
        public string codigo_cat { get; set; }
        public string nombre { get; set; }
        
        
    }
}