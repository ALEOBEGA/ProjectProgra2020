using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjectProgra2020.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<ProjectProgra2020.Models.Contacto> Contactos { get; set; }

        public DbSet<ProjectProgra2020.Models.Producto> Productos { get; set; }

        public DbSet<ProjectProgra2020.Models.OrdenDetail> OrdenDetails { get; set; }
    }
}
