using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("order");

            builder.HasIndex(e => e.IdClientFk, "IdClientFk");

            builder.HasOne(d => d.IdClientFkNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdClientFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_ibfk_1");

            builder.HasMany(d => d.IdProductFks).WithMany(p => p.IdOrderFks)
                .UsingEntity<Dictionary<string, object>>(
                    "OrderProduct",
                    r => r.HasOne<Product>().WithMany()
                        .HasForeignKey("IdProductFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("order_product_ibfk_1"),
                    l => l.HasOne<Order>().WithMany()
                        .HasForeignKey("IdOrderFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("order_product_ibfk_2"),
                    j =>
                    {
                        j.HasKey("IdOrderFk", "IdProductFk")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("order_product");
                        j.HasIndex(new[] { "IdProductFk" }, "IdProductFk");
                    });
        }
    }
}