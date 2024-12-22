
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Infrastructure.Persistence.Configurations
{
    public class EventStoreConfiguration : IEntityTypeConfiguration<BakuExpressCargo.Infrastructure.Persistence.Entities.EventStore>
    {

       

        public void Configure(EntityTypeBuilder<Entities.EventStore> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.AggregateId).IsRequired();
            builder.Property(e => e.EventType).IsRequired();
            builder.Property(e => e.Data).IsRequired();
            builder.Property(e => e.OccurredOn).IsRequired();
        }
    }
}
