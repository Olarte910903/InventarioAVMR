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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura la relación muchos a muchos
            modelBuilder.Entity<TrabajoRealizado>()
                .HasMany(tr => tr.ItemsUtilizados)
                .WithMany(i => i.TrabajosRealizados);

            base.OnModelCreating(modelBuilder);
        }
    }
}
