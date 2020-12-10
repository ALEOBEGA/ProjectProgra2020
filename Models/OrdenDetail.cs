//Orden de compra, detalles de productos Id, Precio y Cantidad
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectProgra2020.Models
{
    [Table("t_orden_detail")]
    
    public class Orden
    {
        [Display(Name="Cantidad")]
        [Column("quantity")]
        public Decimal Quantity { get; set; }

        [Display(Name="Precio")]
        [Column("price")]
        public Decimal Price { get; set; }
    }
}
    