using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeds
{
    public static class TransmissionTypeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransmissionType>().HasData(
                new TransmissionType { Id = 1, Name = "Manual" },
                new TransmissionType { Id = 2, Name = "Automático" }                
            );
        }
    }
}
