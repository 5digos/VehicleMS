using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeds
{
    public static class VehicleStatusSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleStatus>().HasData(
                new VehicleStatus { Id = 1, Name = "Disponible" },
                new VehicleStatus { Id = 2, Name = "Ocupado" },
                new VehicleStatus { Id = 3, Name = "En Mantenimiento" }
            );
        }
    }
}
