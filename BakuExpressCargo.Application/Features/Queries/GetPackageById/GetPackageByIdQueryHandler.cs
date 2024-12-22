using BakuExpressCargo.Application.DTOs;
using BakuExpressCargo.Application.Exceptions;
using BakuExpressCargo.Application.Repositores;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Features.Queries.GetPackageById
{
    public  class GetPackageByIdQueryHandler:IRequestHandler<GetPackageByIdQuery,PackageDto>
    {
        private readonly IPackageRepository _packageRepository;

        public GetPackageByIdQueryHandler(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public async Task<PackageDto> Handle(GetPackageByIdQuery request, CancellationToken cancellationToken)
        {
            var package = await _packageRepository.GetByIdAsync(request.PackageId);

            if (package is null)
                throw new NotFoundException("Package not found ");

            return new PackageDto
            {
                Id = package.Id,
                SenderName = package.SenderName,
                ReceiverName = package.ReceiverName,
                Weight = package.Weight,
                Status = package.Status.ToString()
            };

        }
    }
}
