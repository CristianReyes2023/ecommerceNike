using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class GamaprodructConfiguration : IEntityTypeConfiguration<Gamaprodruct>
    {
        public void Configure(EntityTypeBuilder<Gamaprodruct> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("gamaprodruct");

            builder.Property(e => e.NameGama).HasMaxLength(50);
        }
    }
}