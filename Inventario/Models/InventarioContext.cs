using Inventario.ViewModels;
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
        public DbSet<TIPO_EQUIPO> TiposEquipo { get; set; }
        public DbSet<MARCA_EQUIPO> MarcasEquipo { get; set; }
        public DbSet<TECLADO> Teclados { get; set; }
        public DbSet<MOUSE> Mouses { get; set; }
        public DbSet<MONITOR> Monitores { get; set; }
        public DbSet<DOCK_STATION> Docks { get; set; }
        public DbSet<CANDADO> Candados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = Startup.Configuration["Data:InventarioContextConnection"];
            
            optionsBuilder.UseSqlServer(connString);
            
            base.OnConfiguring(optionsBuilder);
        } 
    }
}
