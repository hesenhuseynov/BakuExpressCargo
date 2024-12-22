using BakuExpressCargo.Application.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Behaviours
{
    public class EventProcessingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly EventProcessor _eventProcessor;

        public EventProcessingBehavior(EventProcessor eventProcessor)
        {
            _eventProcessor = eventProcessor;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var response = await next();

            // Domain Event'leri işleme
            _eventProcessor.ProcessEvents();

            return response;
        }
    }
}
