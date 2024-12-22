using BakuExpressCargo.Application.Behaviours;
using BakuExpressCargo.Application.Features.Commands.CreatePackage;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application
{
    public  static  class ApplicationServiceRegistration
    {
        public static IServiceCollection AddAplicationService(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreatePackageCommandHandler).Assembly));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(EventProcessingBehavior<,>));

            return services;
        }
    }
}
