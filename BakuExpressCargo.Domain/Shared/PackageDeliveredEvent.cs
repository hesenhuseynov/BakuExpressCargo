using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Shared
{
    public class PackageDeliveredEvent : DomainEvent
    {
        public int PackageId { get; set; }
        public DateTime DeliveredAt { get; set; }

        public PackageDeliveredEvent(int packageId)
        {
            PackageId = packageId;
            DeliveredAt = OccurredOn;
        }
    }
}
