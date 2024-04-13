namespace SaffronSlice.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SaffronSlice.Core.Entities;

public class PizzaTypeConfiguration : IEntityTypeConfiguration<PizzaType>
{
    public void Configure(EntityTypeBuilder<PizzaType> builder)
    {
        builder.HasKey(pt => pt.Id);

        builder.Property(pt => pt.Id)
               .HasConversion(pt => pt.Value, pt => new PizzaTypeSku(pt));

        builder.Property(pt => pt.Name).IsRequired();

        builder.Property(pt => pt.Category)
               .HasConversion(pt => pt.Category, pt => new PizzaTypeCategory(pt));


        builder.Property(pt => pt.Ingredients).IsRequired();

        builder.HasMany(pt => pt.Pizzas)
               .WithOne(p => p.PizzaType)
               .HasForeignKey(p => p.PizzaTypeId);
    }
}

