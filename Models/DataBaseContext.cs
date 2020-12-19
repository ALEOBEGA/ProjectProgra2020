using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProjectProgra2020.Models;
using ProjectProgra2020.Controllers;


namespace ProjectProgra2020.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<ProjectProgra2020.Models.Registro> Registro { get; set; }
        
        public DbSet<ProjectProgra2020.Models.Producto> producto { get; set; }
     public DbSet<ProjectProgra2020.Models.Carrito> Carritos { get; set; }




    }
}