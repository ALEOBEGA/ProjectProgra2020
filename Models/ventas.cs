using System;
using System.ComponentModel.DataAnnotations;


namespace ProjectProgra2020.Models
{
    public class ventas
    {
        [Key]
        public int idventas { get; set; }
        public string idcliente { get; set; }
        public int idproducto { get; set; }
        public DateTime fechaventa { get; set; }
        public double preciot { get; set; }
        public int cantidad { get; set; }
        
    }
}