using BakuExpressCargo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Infrastructure.Persistence.Configurations
{
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SenderName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.ReceiverName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Weight).IsRequired();
            builder.Property(p => p.CreatedAt).IsRequired();
        }
    }
}
