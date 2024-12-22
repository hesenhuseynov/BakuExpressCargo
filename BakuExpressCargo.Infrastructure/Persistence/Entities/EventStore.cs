using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Infrastructure.Persistence.Entities
{
    public class EventStore
    {
        public int Id { get; set; }
        public string AggregateId { get; set; } 
        public string EventType { get; set; }
        public string Data { get; set; }
        public DateTime OccurredOn { get; set; } 
    }
}
