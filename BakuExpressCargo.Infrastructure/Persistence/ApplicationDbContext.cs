using BakuExpressCargo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Infrastructure.Persistence
{
    public  class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions  options ):base(options)
        {

            
        }

        public DbSet<Package>Packages  { get; set; }
        public DbSet<Persistence.Entities.EventStore> EventStores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);

        }

    }
}
