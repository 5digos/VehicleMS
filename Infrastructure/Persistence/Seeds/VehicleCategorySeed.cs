using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeds
{
    public static class VehicleCategorySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleCategory>().HasData(
                new VehicleCategory { Id = 1, Name = "Sedán", Description = "Vehículo de tamaño mediano, ideal para uso familiar o personal, con un diseño cerrado y cómodo." },
                new VehicleCategory { Id = 2, Name = "SUV", Description = "Vehículo utilitario deportivo, con mayor espacio y capacidad para terrenos difíciles." },
                new VehicleCategory { Id = 3, Name = "Hatchback", Description = "Vehículo compacto con una puerta trasera que da acceso al baúl, ideal para la ciudad." },
                new VehicleCategory { Id = 4, Name = "Pickup", Description = "Vehículo con una cabina y una zona de carga abierta, ideal para transporte de mercancías." },
                new VehicleCategory { Id = 5, Name = "Deportivo", Description = "Vehículo diseñado para altas prestaciones, con un diseño aerodinámico y potente." },
                new VehicleCategory { Id = 6, Name = "Coupé", Description = "Vehículo de dos puertas con un diseño elegante y deportivo, ideal para uso personal." },
                new VehicleCategory { Id = 7, Name = "Minivan", Description = "Ideal para familias grandes o grupos." }
            );
        }
    }
}
