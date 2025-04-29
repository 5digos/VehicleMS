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
    public class VehicleCategoryQuery : IVehicleCategoryQuery
    {
        private readonly AppDbContext _context;

        public VehicleCategoryQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<VehicleCategory>> GetAll()
        {
            var result = await _context.VehicleCategories.ToListAsync();

            return result;
        }
    }
}
