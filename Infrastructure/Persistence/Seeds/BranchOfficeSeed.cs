using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeds
{
    public static class BranchOfficeSeed
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<BranchOffice>().HasData(
            new BranchOffice
            {
                BranchOfficeId = 1,
                Name = "Sucursal Recoleta",
                Address = "Av. Santa Fe 1234",
                Phone = "011-4822-3344",
                Hours = "08:00-20:00",
                Latitude = -34.5883m,
                Longitude = -58.3926m,
                BranchOfficeZoneId = 1,                 
                City = "Ciudad Autónoma de Buenos Aires",
                PostalCode = "C1123ABC",
                Province = "Ciudad Autónoma de Buenos Aires",
                LocationReference = "Frente al Cementerio de Recoleta"
            },
            new BranchOffice
            {
                BranchOfficeId = 2,
                Name = "Sucursal Nueva Córdoba",
                Address = "Av. Vélez Sársfield 750",
                Phone = "0351-422-5566",
                Hours = "09:00-19:00",
                Latitude = -31.4110m,
                Longitude = -64.1836m,
                BranchOfficeZoneId = 2,                 
                City = "Córdoba",
                PostalCode = "X5000XYZ",
                Province = "Córdoba",
                LocationReference = "A media cuadra de la Plaza San Martín"
            }
        );
        }
    }
}
