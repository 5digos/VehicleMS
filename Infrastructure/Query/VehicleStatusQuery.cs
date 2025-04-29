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
    public class VehicleStatusQuery : IVehicleStatusQuery
    {
        private readonly AppDbContext _context;

        public VehicleStatusQuery(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<VehicleStatus>> GetAll()
        {
            var result = await _context.VehicleStatus.ToListAsync();

            return result;
        }
    }
}
