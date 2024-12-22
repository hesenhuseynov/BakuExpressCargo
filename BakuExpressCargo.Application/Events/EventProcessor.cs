using BakuExpressCargo.Domain.Shared;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Events
{
    public  class EventProcessor
    {
        private readonly ILogger<EventProcessor> _logger;

        public EventProcessor(ILogger<EventProcessor> logger)
        {
            _logger = logger;
        }

        public void ProcessEvents()
        {
            var events = DomainEventDispatcher.GetAllEvents();

            foreach (var domainEvent in events)
            {
                if (domainEvent is PackageDeliveredEvent deliveredEvent)
                {
                    // İşlem yapılacak event
                    _logger.LogInformation($"Package {deliveredEvent.PackageId} was delivered at {deliveredEvent.DeliveredAt}");
                }
            }

            DomainEventDispatcher.ClearEvents();
        }


    }
}
