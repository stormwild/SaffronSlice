namespace SaffronSlice.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SaffronSlice.Core.Entities;

public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
{
    public void Configure(EntityTypeBuilder<Pizza> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
               .HasConversion(p => p.Value, p => new PizzaSku(p));

        builder.OwnsOne(p => p.Size, a =>
        {
            a.Property(s => s.Size)
             .HasConversion(v => v.ToString(), v => (PizzaSizeType)Enum.Parse(typeof(PizzaSizeType), v))
             .HasColumnName("Size");
        });

        builder.HasOne(p => p.PizzaType)
               .WithMany(t => t.Pizzas)
               .HasForeignKey(p => p.PizzaTypeId);

        builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
    }
}
