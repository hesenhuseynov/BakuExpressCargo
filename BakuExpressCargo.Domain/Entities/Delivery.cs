using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Entities
{
    public  class Delivery
    {
        public int Id { get; set; }
        public int PackageId { get; set; }

        public Package Package { get; set; }

        public DateTime DateTime  { get; set; }

        public string TrackingNumber { get; set; }
    }
}
