using InventarioAVMR.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioAVMR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
