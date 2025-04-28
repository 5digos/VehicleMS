using Application.Interfaces.IQuery;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Query
{
    public class VehicleQuery : IVehicleQuery
    {
        private readonly AppDbContext _context;

        public VehicleQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<(IEnumerable<Vehicle> Vehicles, int TotalCount)> GetVehicles(
            int? branchOffice, 
            int? category, 
            int? seatingCapacity, 
            int? transmissionType, 
            int? maxPrice,             
            int? offset, 
            int? size)
        {
            var query = _context.Vehicles.Where(v => v.VehicleStatusId == 1) 
                .Include(v => v.VehicleStatus)
                .Include(v => v.BranchOffice)
                .Include(v => v.Category)
                .Include(v => v.TransmissionType)
                .AsQueryable();

            if (branchOffice.HasValue) 
            { 
                query = query.Where(v => v.BranchOfficeId  == branchOffice.Value);
            }

            if (category.HasValue) 
            {
                query = query.Where(v => v.CategoryId == category.Value);
            }

            if (seatingCapacity.HasValue) 
            {
                query = query.Where(p => p.SeatingCapacity == seatingCapacity.Value);
            }

            if (transmissionType.HasValue) 
            {
                query = query.Where(v => v.TransmissionTypeId == transmissionType.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(v => v.Price <= (decimal)maxPrice.Value);
            }            

            var totalCount = await query.CountAsync();

            if (offset.HasValue)
            {
                query = query.Skip(offset.Value);
            }

            if (size.HasValue)
            {
                query = query.Take(size.Value);
            }

            var vehicles = await query.ToListAsync();

            return (vehicles, totalCount);
        }
    }
}
