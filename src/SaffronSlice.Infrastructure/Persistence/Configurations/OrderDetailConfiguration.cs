namespace SaffronSlice.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SaffronSlice.Core.Entities;

public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasKey(od => od.Id);
        builder.Property(od => od.Id)
               .HasConversion(od => od.Value, od => new OrderDetailId(od));


        builder.HasOne(od => od.Order)
               .WithMany(o => o.OrderDetails)
               .HasForeignKey(od => od.OrderId);

        builder.HasOne(od => od.Pizza)
               .WithMany()
               .HasForeignKey(od => od.PizzaId);

        builder.Property(od => od.Quantity).IsRequired();
    }
}
