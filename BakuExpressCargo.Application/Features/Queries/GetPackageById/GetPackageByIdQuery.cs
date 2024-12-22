using BakuExpressCargo.Application.DTOs;
using BakuExpressCargo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Features.Queries.GetPackageById
{
    public  class GetPackageByIdQuery:IRequest<PackageDto>
    {
        public int PackageId { get; set; }

        public GetPackageByIdQuery(int packageId)
        {
            PackageId = packageId;
        }

    }

}
