using BakuExpressCargo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Application.Repositores
{
    public  interface IPackageRepository
    {
        Task<Package> GetByIdAsync(int id);
        Task AddAsync(Package package);
    }
}
