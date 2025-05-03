using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeds
{
    public static class BranchOfficeZoneSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchOfficeZone>().HasData(
                new BranchOfficeZone { Id = 1, Name = "Zona Norte" },
                new BranchOfficeZone { Id = 2, Name = "Zona Sur" },
                new BranchOfficeZone { Id = 3, Name = "Zona Este" },
                new BranchOfficeZone { Id = 4, Name = "Zona Oeste" },
                new BranchOfficeZone { Id = 5, Name = "CABA" },
                new BranchOfficeZone { Id = 6, Name = "Interior del País" }
            );
        }
    }
}
