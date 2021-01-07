using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectProgra2020.Models;
namespace ProjectProgra2020.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjectProgra2020.Models.Registro> Registro { get; set; }
        public DbSet<ProjectProgra2020.Models.categoria> categoria { get; set; }
        public DbSet<ProjectProgra2020.Models.producto> producto { get; set; }
        public DbSet<ProjectProgra2020.Models.ventas> ventas { get; set; }
        //public DbSet<ProjectProgra2020.Models.productom> productosm { get; set; }
        //public DbSet<ProjectProgra2020.Models.producton> productosn { get; set; }
    }
}
