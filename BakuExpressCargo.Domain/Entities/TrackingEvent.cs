using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Entities
{
    public  class TrackingEvent
    {
        public int Id { get; set; }
        public int PackageId { get; set; }

        public Package Package { get; set; }

        public string EventDescription  { get; set; }

        public DateTime EventTime { get; set; }

        public string Location { get; set; }

    }
}
