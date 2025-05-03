using Domain.Entities;
using Infrastructure.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeds
{
    public static class VehicleSeeder
    { 
        public static async Task SeedAsync(AppDbContext context, PatenteGenerator gen)
        {
            // 2.1. Aplico migraciones pendientes
            await context.Database.MigrateAsync();

            // 2.2. Seed de sucursales (si no existen)
            if (!context.BranchOffices.Any())
            {
                context.BranchOffices.AddRange(new[]
                {
                    new BranchOffice {
                        BranchOfficeId    = 1,
                        Name              = "Sucursal Recoleta",
                        Address           = "Av. Santa Fe 1234",
                        Phone             = "011-4822-3344",
                        Hours             = "08:00-20:00",
                        Latitude          = -34.5883m,
                        Longitude         = -58.3926m,
                        BranchOfficeZoneId= 1,
                        City              = "CABA",
                        PostalCode        = "C1123ABC",
                        Province          = "CABA",
                        LocationReference = "Frente al Cementerio de Recoleta"
                    },
                    new BranchOffice {
                        BranchOfficeId    = 2,
                        Name              = "Sucursal Nueva Córdoba",
                        Address           = "Av. Vélez Sársfield 750",
                        Phone             = "0351-422-5566",
                        Hours             = "09:00-19:00",
                        Latitude          = -31.4110m,
                        Longitude         = -64.1836m,
                        BranchOfficeZoneId= 2,
                        City              = "Córdoba",
                        PostalCode        = "X5000XYZ",
                        Province          = "Córdoba",
                        LocationReference = "A media cuadra de la Plaza San Martín"
                    }
                });
            }

            // 2.3. Seed de vehículos (si no existen)
            if (!context.Vehicles.Any())
            {
                var cars = new List<Vehicle>
                {
                    new Vehicle {
                        VehicleId        = Guid.NewGuid(),
                        Brand            = "Chevrolet",
                        Model            = "Camaro",
                        LicensePlate     = gen.Next(),
                        Year             = 2018,
                        Price            = 15000m,
                        SeatingCapacity  = 2,
                        ImageUrl         = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId  = 1,
                        BranchOfficeId   = 1,
                        CategoryId       = 5,
                        TransmissionTypeId = 1,
                        Color            = "Blanco"
                    },
                    new Vehicle {
                        VehicleId        = Guid.NewGuid(),
                        Brand            = "Ford",
                        Model            = "Fiesta",
                        LicensePlate     = gen.Next(),
                        Year             = 2020,
                        Price            = 18000m,
                        SeatingCapacity  = 5,
                        ImageUrl         = "https://example.com/fiesta.jpg",
                        VehicleStatusId  = 1,
                        BranchOfficeId   = 2,
                        CategoryId       = 2,
                        TransmissionTypeId = 2,
                        Color            = "Rojo"
                    }
                };
                context.Vehicles.AddRange(cars);
            }

            // 2.4. Guardo todos los cambios
            await context.SaveChangesAsync();
        }
    }
}
