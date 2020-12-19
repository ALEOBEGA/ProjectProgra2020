using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectProgra2020.Models;
using ProjectProgra2020.Controllers;

namespace ProjectProgra2020.Models
{
    
    public class Producto
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idproducto")]
        public int idproducto{ get; set;} 

        [Column("categoria")]
        public string categoria { get; set;}

        [Column("nombre")]
        public string nombre{ get; set; }
        
        [Column("descripcion")]
        public string descripcion { get; set;}

        [Column("precio")]
        public double precio{ get; set;}

        [Column("imagen")]
        public string imagen { get; set; }

        
        
        
    }
}