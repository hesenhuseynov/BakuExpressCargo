using BakuExpressCargo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Features.Commands.CreatePackage
{
    public  class CreatePackageCommand:IRequest<CreatePackageResponse>
    {
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public Adress SenderAddress { get; set; }
        public Adress ReceiverAddress { get; set; }
        public decimal Weight { get; set; }
        public int PackageSizeId { get; set; }
    }


    public class CreatePackageResponse
    {
        public int Id { get; set; }
        public string Status  { get; set; }

        public DateTime CreatedAt { get; set; }
    }

}
