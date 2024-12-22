using BakuExpressCargo.Application.Interfaces;
using BakuExpressCargo.Domain.Shared;
using BakuExpressCargo.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BakuExpressCargo.Infrastructure.EventStore
{


    public class EventStoreService : IEventStoreService
    {
        private readonly ApplicationDbContext _dbContext;

        public EventStoreService(ApplicationDbContext dbContext )
        {
            _dbContext = dbContext;
        }


        public async Task SaveEventAsync(string aggregateId, DomainEvent domainEvent)
        {
            var eventStore = new Persistence.Entities.EventStore
            {
                AggregateId = aggregateId,
                EventType = domainEvent.GetType().Name,
                Data = JsonSerializer.Serialize(domainEvent),
                OccurredOn = domainEvent.OccurredOn,

            };
            await _dbContext.EventStores.AddAsync(eventStore);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<DomainEvent?>> GetEventsAsync(string aggregateId)
        {
            var events = await _dbContext.EventStores.Where(e => e.AggregateId == aggregateId)
                 .ToListAsync();

              return events.Select(e =>
              
                  (DomainEvent?)JsonSerializer.Deserialize(e.Data,Type.GetType(e.EventType)))
                .ToList();
        }

    }

}
