using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SaffronSlice.Core.Entities;

namespace SaffronSlice.Infrastructure.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.Id)
               .HasConversion(o => o.Value, o => new OrderId(o));

        builder.HasMany(o => o.OrderDetails)
               .WithOne(d => d.Order)
               .HasForeignKey(d => d.OrderId);
    }
}

