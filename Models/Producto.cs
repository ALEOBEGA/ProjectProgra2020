using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectProgra2020.Models;

namespace ProjectProgra2020.Models
{

    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID{ get; set;} 

        [Column("id_user")]
        public int userID{ get; set; }

        [Column("id_categoria")]
        public int catID { get; set;}

        [Column("titulo")]
        public String Name{ get; set; }
        
        [Column("descripcion")]
        public String Description { get; set;}

        [Column("precio")]
        public int Price{ get; set;}

        [Column("image")]
        public byte[] Picture { get; set; }

        [NotMapped]
        public String imageData { get; set; }
        
        
    }
}