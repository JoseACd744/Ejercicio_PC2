using Ejercicio_PC2.Shared.Infrastructure.Configuration.Extensions;
using Ejercicio_PC2.Subscriptions.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_PC2.Shared.Infrastructure.Configuration;

public class AppDbContext : DbContext
{
    public DbSet<Destination> Destinations { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Destination>().HasKey(x => x.name);
        modelBuilder.Entity<Destination>().Property(x => x.name).HasColumnName("name");
        modelBuilder.Entity<Destination>().Property(x => x.MaxUsers).HasColumnName("max_users");
        modelBuilder.Entity<Destination>().Property(x => x.IsRisky).HasColumnName("is_risky");
        
        modelBuilder.UseSnakeCaseNamingConvention();
    }
    
}