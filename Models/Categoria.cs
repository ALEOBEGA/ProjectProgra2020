using System;
using System.ComponentModel.DataAnnotations;

using ProjectProgra2020.Models;
namespace ProjectProgra2020.Models
{
    public class categoria
    {
        [Key]
        public int categoriaid { get; set; }
        public string nombre { get; set; }
        
        
    }
}