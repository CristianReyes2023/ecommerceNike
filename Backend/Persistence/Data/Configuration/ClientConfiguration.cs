using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("client");

            builder.HasIndex(e => e.IdAddressFk, "IdAddressFk");

            builder.Property(e => e.IdClient).HasMaxLength(30);
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.Telephone).HasMaxLength(40);

            builder.HasOne(d => d.IdAddressFkNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdAddressFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_ibfk_1");
        }
    }
}