using System;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectProgra2020.Models;
namespace ProjectProgra2020.Models
{
    public class Carrito_de_compras
    {

        public string id{ get; set; }

        public string nombre{ get; set; }

        public double precio{ get; set;}

        public string descripcion { get; set;}

        public string imagen { get; set; }

        public string categoria { get; set;}

        public int cant { get; set; }
    }
}