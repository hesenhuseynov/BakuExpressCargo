using BakuExpressCargo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Services
{
    public class TrackingService
    {
        public void AddTrackingEvent(Package package, string description, string location)
        {
            if (package is null)
                throw new ArgumentNullException(nameof(package));

            var trackingEvent = new TrackingEvent
            {
                Package = package,
                EventDescription = description,
                EventTime = DateTime.UtcNow,
                Location = location
            };


        }
    }
}
