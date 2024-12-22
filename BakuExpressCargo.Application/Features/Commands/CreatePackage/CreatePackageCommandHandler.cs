using BakuExpressCargo.Application.Repositores;
using BakuExpressCargo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Features.Commands.CreatePackage
{
    public class CreatePackageCommandHandler : IRequestHandler<CreatePackageCommand, CreatePackageResponse>
    {
        private readonly IPackageRepository _packageRepository;

        public CreatePackageCommandHandler(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
            
        }


        public async  Task<CreatePackageResponse> Handle(CreatePackageCommand request, CancellationToken cancellationToken)
        {
            var package = new Package(
                request.SenderName,
                request.ReceiverName,
                request.SenderAddress,
                request.ReceiverAddress,
                request.Weight,
                new PackageSize(10, 20, 30, 50)
                );

            await _packageRepository.AddAsync(package);

            await _packageRepository.AddAsync(package);

            return new CreatePackageResponse
            {
                Id = package.Id,
                Status = package.Status.ToString(),
                CreatedAt = package.CreatedAt
            };

        }
    }
}
