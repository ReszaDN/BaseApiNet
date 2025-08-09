using Microsoft.EntityFrameworkCore;

namespace BaseApiNet.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // DbSet untuk model-model baru akan ditambahkan di sini
    // public DbSet<Product> Products { get; set; }
}