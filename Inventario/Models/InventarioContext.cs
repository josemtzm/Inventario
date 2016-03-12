using Microsoft.Data.Entity;

namespace Inventario.Models
{
    public class InventarioContext : DbContext
    {
        public InventarioContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = Startup.Configuration["Data:InventarioContextConnection"];
            
            optionsBuilder.UseSqlServer(connString);
            
            base.OnConfiguring(optionsBuilder);
        } 
    }
}
