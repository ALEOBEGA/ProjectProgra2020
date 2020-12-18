using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectProgra2020.Models
{
 [Table("t_carrito")]
    public class Carrito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Column("user_id")]
        public string user_id { get; set; }

        [Column("producto_id")]
        public int producto_id { get; set; }
    }
}