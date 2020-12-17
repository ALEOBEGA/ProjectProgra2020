using System;
using System.ComponentModel.DataAnnotations;



namespace ProjectProgra2020.Models
{
    public class Producton
    {
        [Key]
        public int idproducto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public string categoria { get; set; }
        
        
    }
}