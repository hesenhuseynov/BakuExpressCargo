using BakuExpressCargo.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Interfaces
{
    public  interface IEventStoreService
    {
        Task SaveEventAsync(string aggregateId, DomainEvent domainEvent);
        Task<List<DomainEvent?>> GetEventsAsync(string aggregateId);
    }
}
