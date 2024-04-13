using Microsoft.EntityFrameworkCore;

using SaffronSlice.Core.Entities;

namespace SaffronSlice.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<PizzaType> PizzaTypes { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Order> Orders { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
