using ECommerceOrder.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceOrder.Infrastructure.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o=>o.Id);

        builder.Property(o=>o.Quantity)
            .HasDefaultValue(0);

        builder.Property(o=>o.TotalAmount)
            .HasColumnType("decimal(18,2)");

        builder.Property(o=>o.ProductId)
            .IsRequired();

        builder.Property(o=>o.UnitPrice)
            .HasColumnType("decimal(18,2)");

        builder.HasOne(o => o.Product)
            .WithMany()
            .HasForeignKey(o => o.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}