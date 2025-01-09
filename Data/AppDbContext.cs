using InventarioAVMR.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioAVMR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<TrabajoRealizado> TrabajosRealizados { get; set; }
        public DbSet<Bordado> Bordados { get; set; }
        public DbSet<ColorHilo> ColorHilos { get; set; }
        public DbSet<BordadoHilo> BordadoHilos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura la relación muchos a muchos
           base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BordadoHilo>()
                .HasKey(bc => new { bc.BordadoId, bc.ColorHiloId });

            modelBuilder.Entity<BordadoHilo>()
                .HasOne(bc => bc.Bordado)
                .WithMany(b => b.BordadoHilo)
                .HasForeignKey(bc => bc.BordadoId);

            modelBuilder.Entity<BordadoHilo>()
                .HasOne(bc => bc.ColorHilo)
                .WithMany(c => c.BordadoHilo)
                .HasForeignKey(bc => bc.ColorHiloId);
        }
    }
}
