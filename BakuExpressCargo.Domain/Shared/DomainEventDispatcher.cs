using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Shared
{
    public static class DomainEventDispatcher
    {
        private static readonly List<DomainEvent> _domainEvents = new();

        public static void Raise(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public static IReadOnlyCollection<DomainEvent> GetAllEvents()
        {
            return _domainEvents.AsReadOnly();
        }

        public static void ClearEvents()
        {
            _domainEvents.Clear();
        }
    }
}
