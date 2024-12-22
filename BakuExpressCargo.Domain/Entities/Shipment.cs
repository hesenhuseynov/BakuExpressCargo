using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Entities
{
    public  class Shipment
    {
        public int Id { get; set; }
        public string VehicleId { get; set; }

        public DateTime DeparTureTime  { get; set; }

        public DateTime ArrivalTime  { get; set; }

        public ICollection<Package> Packages { get; set; }
    }
}
