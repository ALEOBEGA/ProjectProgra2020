using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectProgra2020.Models;
using ProjectProgra2020.Controllers;

namespace ProjectProgra2020.Models
{
    
    public class producto
    {
        
        [Key]

        public int idproducto{ get; set;} 

        public string nombre{ get; set; }

        public double precio{ get; set;}

        public string descripcion { get; set;}

        public string imagen { get; set; }

        public string categoria { get; set;}

        
        
        
    }
}