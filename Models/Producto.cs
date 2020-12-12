using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using projectProgra2020.Models;

namespace projectProgra2020.Models
{
    [Table("t_producto")]
    
    public class Producto
    {
        [Key]
        public int idproducto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public string categoria { get; set;}
        
        
    }
}