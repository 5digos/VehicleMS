﻿using Domain.Entities;
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

                // ─── ZONA NORTE (BranchOfficeZoneId = 1) ───────────────────────────
                new BranchOffice {
                    BranchOfficeId    = 1,
                    Name              = "Sucursal San Isidro",
                    Address           = "Av. Del Libertador 16500",
                    Phone             = "011-4747-2442",
                    Hours             = "08:00-18:00",
                    Latitude          = -34.46659m,
                    Longitude         = -58.51120m,
                    BranchOfficeZoneId= 1,
                    City              = "San Isidro",
                    PostalCode        = "B1642",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca de la Plaza Mitre"
                },
                new BranchOffice {
                    BranchOfficeId    = 2,
                    Name              = "Sucursal Vicente López",
                    Address           = "Av. Maipú 1234",
                    Phone             = "011-4791-1234",
                    Hours             = "09:00-19:00",
                    Latitude          = -34.52664m,
                    Longitude         = -58.48269m,
                    BranchOfficeZoneId= 1,
                    City              = "Vicente López",
                    PostalCode        = "B1602",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca de la estación Vicente López"
                },
                new BranchOffice {
                    BranchOfficeId    = 3,
                    Name              = "Sucursal Olivos",
                    Address           = "Av. Maipú 2990",
                    Phone             = "011-4795-1850",
                    Hours             = "08:00-20:00",
                    Latitude          = -34.50828m,
                    Longitude         = -58.49208m,
                    BranchOfficeZoneId= 1,
                    City              = "Olivos",
                    PostalCode        = "B1636",
                    Province          = "Buenos Aires",
                    LocationReference = "Junto a la Plaza Olivos"
                },
                new BranchOffice {
                    BranchOfficeId    = 4,
                    Name              = "Sucursal Martínez",
                    Address           = "Beruti 1660",
                    Phone             = "011-4734-3600",
                    Hours             = "08:00-19:00",
                    Latitude          = -34.49152m,
                    Longitude         = -58.51122m,
                    BranchOfficeZoneId= 1,
                    City              = "Martínez",
                    PostalCode        = "B1640",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca de Plaza 9 de Julio"
                },
                new BranchOffice {
                    BranchOfficeId    = 5,
                    Name              = "Sucursal Boulogne",
                    Address           = "Av. Rolón 2007",
                    Phone             = "011-4749-4090",
                    Hours             = "09:00-18:00",
                    Latitude          = -34.50857m,
                    Longitude         = -58.56605m,
                    BranchOfficeZoneId= 1,
                    City              = "Boulogne",
                    PostalCode        = "B1643",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca del Shopping Los Arcos"
                },
                new BranchOffice {
                    BranchOfficeId    = 6,
                    Name              = "Sucursal San Fernando",
                    Address           = "Sarmiento 1249",
                    Phone             = "011-4743-0550",
                    Hours             = "08:00-17:00",
                    Latitude          = -34.43997m,
                    Longitude         = -58.55864m,
                    BranchOfficeZoneId= 1,
                    City              = "San Fernando",
                    PostalCode        = "B1646",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente a la Plaza Bartolome Mitre"
                },
                new BranchOffice {
                    BranchOfficeId    = 7,
                    Name              = "Sucursal Tigre",
                    Address           = "Av. Italia 1398",
                    Phone             = "011-4512-0550",
                    Hours             = "09:00-20:00",
                    Latitude          = -34.42351m,
                    Longitude         = -58.57615m,
                    BranchOfficeZoneId= 1,
                    City              = "Tigre",
                    PostalCode        = "B1648",
                    Province          = "Buenos Aires",
                    LocationReference = "A metros del Puerto de Frutos"
                },
                new BranchOffice {
                    BranchOfficeId    = 8,
                    Name              = "Sucursal Florida",
                    Address           = "Carlos Francisco Melo 2501",
                    Phone             = "011-4794-1075",
                    Hours             = "08:00-19:00",
                    Latitude          = -34.53501m,
                    Longitude         = -58.49238m,
                    BranchOfficeZoneId= 1,
                    City              = "Florida",
                    PostalCode        = "B1602",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca del Shopping Florida"
                },
                new BranchOffice {
                    BranchOfficeId    = 9,
                    Name              = "Sucursal Acassuso",
                    Address           = "Av. del Libertador 15089",
                    Phone             = "011-4795-1450",
                    Hours             = "09:00-19:00",
                    Latitude          = -34.47526m,
                    Longitude         = -58.49972m,
                    BranchOfficeZoneId= 1,
                    City              = "Acassuso",
                    PostalCode        = "B1641",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca del Hipodromo de San Isidro"
                },
                new BranchOffice {
                    BranchOfficeId    = 10,
                    Name              = "Sucursal Beccar",
                    Address           = "Av. Centenario 1920",
                    Phone             = "011-4794-1400",
                    Hours             = "08:00-18:00",
                    Latitude          = -34.46106m,
                    Longitude         = -58.52738m,
                    BranchOfficeZoneId= 1,
                    City              = "Beccar",
                    PostalCode        = "B1642",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente a la estacion Beccar"
                },

                // ─── ZONA SUR (BranchOfficeZoneId = 2) ─────────────────────────────
                new BranchOffice {
                    BranchOfficeId    = 11,
                    Name              = "Sucursal Quilmes",
                    Address           = "Av. Mitre 500",
                    Phone             = "011-4257-0500",
                    Hours             = "08:00-20:00",
                    Latitude          = -34.7206m,
                    Longitude         = -58.2673m,
                    BranchOfficeZoneId= 2,
                    City              = "Quilmes",
                    PostalCode        = "B1878",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente a la estación Quilmes"
                },
                new BranchOffice {
                    BranchOfficeId    = 12,
                    Name              = "Sucursal Lomas de Zamora",
                    Address           = "Av. Yrigoyen 700",
                    Phone             = "011-4220-0700",
                    Hours             = "09:00-19:00",
                    Latitude          = -34.7620m,
                    Longitude         = -58.3950m,
                    BranchOfficeZoneId= 2,
                    City              = "Lomas de Zamora",
                    PostalCode        = "B1832",
                    Province          = "Buenos Aires",
                    LocationReference = "Esquina con Camino Negro"
                },
                new BranchOffice {
                    BranchOfficeId    = 13,
                    Name              = "Sucursal Banfield",
                    Address           = "Av. Alsina 300",
                    Phone             = "011-4240-0300",
                    Hours             = "08:00-18:00",
                    Latitude          = -34.7907m,
                    Longitude         = -58.3958m,
                    BranchOfficeZoneId= 2,
                    City              = "Banfield",
                    PostalCode        = "B1828",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente a la estación Banfield"
                },
                new BranchOffice {
                    BranchOfficeId    = 14,
                    Name              = "Sucursal Avellaneda",
                    Address           = "Av. Belgrano 100",
                    Phone             = "011-4227-0100",
                    Hours             = "09:00-20:00",
                    Latitude          = -34.6559m,
                    Longitude         = -58.3645m,
                    BranchOfficeZoneId= 2,
                    City              = "Avellaneda",
                    PostalCode        = "B1870",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca del Puente Pueyrredón"
                },
                new BranchOffice {
                    BranchOfficeId    = 15,
                    Name              = "Sucursal Lanús",
                    Address           = "Av. 9 de Julio 2500",
                    Phone             = "011-4243-2500",
                    Hours             = "08:00-19:00",
                    Latitude          = -34.7025m,
                    Longitude         = -58.3794m,
                    BranchOfficeZoneId= 2,
                    City              = "Lanús",
                    PostalCode        = "B1824",
                    Province          = "Buenos Aires",
                    LocationReference = "A metros de la estación Lanús"
                },
                new BranchOffice {
                    BranchOfficeId    = 16,
                    Name              = "Sucursal Berazategui",
                    Address           = "Av. Mitre 2100",
                    Phone             = "011-4212-2100",
                    Hours             = "09:00-18:00",
                    Latitude          = -34.8282m,
                    Longitude         = -58.2165m,
                    BranchOfficeZoneId= 2,
                    City              = "Berazategui",
                    PostalCode        = "B1884",
                    Province          = "Buenos Aires",
                    LocationReference = "Esquina con calle 14"
                },
                new BranchOffice {
                    BranchOfficeId    = 17,
                    Name              = "Sucursal Florencio Varela",
                    Address           = "Av. Hudson 1900",
                    Phone             = "011-4211-1900",
                    Hours             = "08:00-17:00",
                    Latitude          = -34.8290m,
                    Longitude         = -58.2780m,
                    BranchOfficeZoneId= 2,
                    City              = "Florencio Varela",
                    PostalCode        = "B1888",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente al Shopping Varela"
                },
                new BranchOffice {
                    BranchOfficeId    = 18,
                    Name              = "Sucursal Almirante Brown",
                    Address           = "Av. Espora 4200",
                    Phone             = "011-4260-4200",
                    Hours             = "09:00-19:00",
                    Latitude          = -34.7840m,
                    Longitude         = -58.3895m,
                    BranchOfficeZoneId= 2,
                    City              = "Almirante Brown",
                    PostalCode        = "B1847",
                    Province          = "Buenos Aires",
                    LocationReference = "Junto a la Plaza Brown"
                },
                new BranchOffice {
                    BranchOfficeId    = 19,
                    Name              = "Sucursal San Vicente",
                    Address           = "Av. Pedro Buratovich 150",
                    Phone             = "011-4295-0150",
                    Hours             = "08:00-18:00",
                    Latitude          = -34.8650m,
                    Longitude         = -58.4052m,
                    BranchOfficeZoneId= 2,
                    City              = "San Vicente",
                    PostalCode        = "B1865",
                    Province          = "Buenos Aires",
                    LocationReference = "A metros del Hospital"
                },
                new BranchOffice {
                    BranchOfficeId    = 20,
                    Name              = "Sucursal Esteban Echeverría",
                    Address           = "Av. Brown 1500",
                    Phone             = "011-4296-1500",
                    Hours             = "09:00-20:00",
                    Latitude          = -34.8080m,
                    Longitude         = -58.4590m,
                    BranchOfficeZoneId= 2,
                    City              = "Esteban Echeverría",
                    PostalCode        = "B1842",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente a la Municipalidad"
                },

                // ─── ZONA OESTE (BranchOfficeZoneId = 3) ────────────────────────────
                new BranchOffice {
                    BranchOfficeId    = 21,
                    Name              = "Sucursal Morón",
                    Address           = "Av. Rivadavia 100",
                    Phone             = "011-4650-0100",
                    Hours             = "08:00-20:00",
                    Latitude          = -34.6500m,
                    Longitude         = -58.6200m,
                    BranchOfficeZoneId= 3,
                    City              = "Morón",
                    PostalCode        = "B1708",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca de la estación Morón"
                },
                new BranchOffice {
                    BranchOfficeId    = 22,
                    Name              = "Sucursal Merlo",
                    Address           = "Av. Libertador 200",
                    Phone             = "011-4660-0200",
                    Hours             = "09:00-19:00",
                    Latitude          = -34.6520m,
                    Longitude         = -58.7060m,
                    BranchOfficeZoneId= 3,
                    City              = "Merlo",
                    PostalCode        = "B1722",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente al Municipio de Merlo"
                },
                new BranchOffice {
                    BranchOfficeId    = 23,
                    Name              = "Sucursal Moreno",
                    Address           = "Av. Eva Perón 800",
                    Phone             = "011-4628-0800",
                    Hours             = "08:00-18:00",
                    Latitude          = -34.6475m,
                    Longitude         = -58.6192m,
                    BranchOfficeZoneId= 3,
                    City              = "Moreno",
                    PostalCode        = "B1744",
                    Province          = "Buenos Aires",
                    LocationReference = "A metros de la plaza central"
                },
                new BranchOffice {
                    BranchOfficeId    = 24,
                    Name              = "Sucursal Ituzaingó",
                    Address           = "Av. Rivadavia 8500",
                    Phone             = "011-4620-8500",
                    Hours             = "09:00-20:00",
                    Latitude          = -34.6574m,
                    Longitude         = -58.7035m,
                    BranchOfficeZoneId= 3,
                    City              = "Ituzaingó",
                    PostalCode        = "B1714",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente al Puente 12"
                },
                new BranchOffice {
                    BranchOfficeId    = 25,
                    Name              = "Sucursal Hurlingham",
                    Address           = "Av. Vergara 500",
                    Phone             = "011-4617-0500",
                    Hours             = "08:00-19:00",
                    Latitude          = -34.6083m,
                    Longitude         = -58.6150m,
                    BranchOfficeZoneId= 3,
                    City              = "Hurlingham",
                    PostalCode        = "B1686",
                    Province          = "Buenos Aires",  
                    LocationReference = "Cerca del Club Hurlingham"
                },
                new BranchOffice {
                    BranchOfficeId    = 26,
                    Name              = "Sucursal Tres de Febrero",
                    Address           = "Av. San Martín 2400",
                    Phone             = "011-4625-2400",
                    Hours             = "09:00-19:00",
                    Latitude          = -34.6394m,
                    Longitude         = -58.6477m,
                    BranchOfficeZoneId= 3,
                    City              = "Tres de Febrero",
                    PostalCode        = "B1678",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente al shopping Tres de Febrero"
                },
                new BranchOffice {
                    BranchOfficeId    = 27,
                    Name              = "Sucursal San Justo",
                    Address           = "Av. Vte. López y Planes 600",
                    Phone             = "011-4254-0600",
                    Hours             = "08:00-18:00",
                    Latitude          = -34.6946m,
                    Longitude         = -58.5449m,
                    BranchOfficeZoneId= 3,
                    City              = "San Justo",
                    PostalCode        = "B1754",
                    Province          = "Buenos Aires",
                    LocationReference = "Cerca del Hospital San Justo"
                },
                new BranchOffice {
                    BranchOfficeId    = 28,
                    Name              = "Sucursal Caseros",
                    Address           = "Av. San Martín 2500",
                    Phone             = "011-4624-2500",
                    Hours             = "09:00-20:00",
                    Latitude          = -34.6313m,
                    Longitude         = -58.5503m,
                    BranchOfficeZoneId= 3,
                    City              = "Caseros",
                    PostalCode        = "B1678",
                    Province          = "Buenos Aires",
                    LocationReference = "Frente a la estación Caseros"
                },
                new BranchOffice {
                    BranchOfficeId    = 29,
                    Name              = "Sucursal Rafael Castillo",
                    Address           = "Av. Eva Perón 3450",
                    Phone             = "011-4256-3450",
                    Hours             = "08:00-19:00",
                    Latitude          = -34.6983m,
                    Longitude         = -58.6180m,
                    BranchOfficeZoneId= 3,
                    City              = "Rafael Castillo",
                    PostalCode        = "B1758",
                    Province          = "Buenos Aires",
                    LocationReference = "A metros del Club Ferrocarril Oeste"
                },
                new BranchOffice {
                    BranchOfficeId    = 30,
                    Name              = "Sucursal Ciudad Evita",
                    Address           = "Av. Presidente Perón 2000",
                    Phone             = "011-4253-2000",
                    Hours             = "09:00-18:00",
                    Latitude          = -34.7000m,
                    Longitude         = -58.5010m,
                    BranchOfficeZoneId= 3,
                    City              = "Ciudad Evita",
                    PostalCode        = "B1753",
                    Province          = "Buenos Aires",
                    LocationReference = "Junto a la Plaza Evita"
                },

                // ─── CAPITAL FEDERAL (BranchOfficeZoneId = 4) ──────────────────────
                new BranchOffice {
                    BranchOfficeId    = 31,
                    Name              = "Sucursal Plaza de Mayo",
                    Address           = "Rivadavia 100",
                    Phone             = "011-4370-0100",
                    Hours             = "09:00-17:00",
                    Latitude          = -34.6082m,
                    Longitude         = -58.3738m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1084",
                    Province          = "CABA",
                    LocationReference = "Frente a Casa Rosada"
                },
                new BranchOffice {
                    BranchOfficeId    = 32,
                    Name              = "Sucursal Retiro",
                    Address           = "Av. Dr. J. M. Ramos Mejía 777",
                    Phone             = "011-4379-0777",
                    Hours             = "08:00-20:00",
                    Latitude          = -34.5882m,
                    Longitude         = -58.3744m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1061",
                    Province          = "CABA",
                    LocationReference = "Frente a la estación Retiro"
                },
                new BranchOffice {
                    BranchOfficeId    = 33,
                    Name              = "Sucursal Palermo",
                    Address           = "Av. Santa Fe 3200",
                    Phone             = "011-4833-3200",
                    Hours             = "09:00-21:00",
                    Latitude          = -34.5891m,
                    Longitude         = -58.4245m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1425",
                    Province          = "CABA",
                    LocationReference = "Esquina con Bulnes"
                },
                new BranchOffice {
                    BranchOfficeId    = 34,
                    Name              = "Sucursal Recoleta",
                    Address           = "Junín 1800",
                    Phone             = "011-4808-1800",
                    Hours             = "08:00-20:00",
                    Latitude          = -34.5884m,
                    Longitude         = -58.3910m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1113",
                    Province          = "CABA",
                    LocationReference = "Cerca del Cementerio"
                },
                new BranchOffice {
                    BranchOfficeId    = 35,
                    Name              = "Sucursal Belgrano",
                    Address           = "Av. Cabildo 2200",
                    Phone             = "011-4714-2200",
                    Hours             = "09:00-19:00",
                    Latitude          = -34.5570m,
                    Longitude         = -58.4478m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1426",
                    Province          = "CABA",
                    LocationReference = "Frente a la estación Belgrano R"
                },
                new BranchOffice {
                    BranchOfficeId    = 36,
                    Name              = "Sucursal San Telmo",
                    Address           = "Defensa 700",
                    Phone             = "011-4294-0700",
                    Hours             = "09:00-18:00",
                    Latitude          = -34.6195m,
                    Longitude         = -58.3733m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1065",
                    Province          = "CABA",
                    LocationReference = "A metros de Plaza Dorrego"
                },
                new BranchOffice {
                    BranchOfficeId    = 37,
                    Name              = "Sucursal La Boca",
                    Address           = "Caminito 415",
                    Phone             = "011-4302-0415",
                    Hours             = "10:00-18:00",
                    Latitude          = -34.6347m,
                    Longitude         = -58.3633m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1164",
                    Province          = "CABA",
                    LocationReference = "Junto al Puente de la Mujer"
                },
                new BranchOffice {
                    BranchOfficeId    = 38,
                    Name              = "Sucursal Microcentro",
                    Address           = "Florida 300",
                    Phone             = "011-4331-0300",
                    Hours             = "08:00-22:00",
                    Latitude          = -34.6083m,
                    Longitude         = -58.3707m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1005",
                    Province          = "CABA",
                    LocationReference = "A una cuadra de Av. Corrientes"
                },
                new BranchOffice {
                    BranchOfficeId    = 39,
                    Name              = "Sucursal Almagro",
                    Address           = "Av. Corrientes 3800",
                    Phone             = "011-4951-3800",
                    Hours             = "09:00-20:00",
                    Latitude          = -34.6050m,
                    Longitude         = -58.4185m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1182",
                    Province          = "CABA",
                    LocationReference = "Frente al teatro"
                },
                new BranchOffice {
                    BranchOfficeId    = 40,
                    Name              = "Sucursal Núñez",
                    Address           = "Av. del Libertador 7766",
                    Phone             = "011-4784-4500",
                    Hours             = "09:00-21:00",
                    Latitude          = -34.54300m,
                    Longitude         = -58.46186m,
                    BranchOfficeZoneId= 4,
                    City              = "Ciudad Autónoma de Buenos Aires",
                    PostalCode        = "C1428",
                    Province          = "CABA",
                    LocationReference = "Cerca del CeNARD"
                }
            );
        }
    }
}
