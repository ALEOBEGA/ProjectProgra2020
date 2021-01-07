using ProjectProgra2020;
using Microsoft.EntityFrameworkCore;


namespace ProjectProgra2020.Models{
    public class DBcarritoContext: DbContext
    {
        public DbSet<Carrito_de_compras> Carrito_de_compras{get;set;}
        public DBcarritoContext(DbContextOptions dco): base(dco){
            
        }
    }
}