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
    public class BranchOfficeZoneQuery : IBranchOfficeZoneQuery
    {
        private readonly AppDbContext _context;

        public BranchOfficeZoneQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<BranchOfficeZone>> GetAll()
        {
            var result = await _context.Zones.ToListAsync();

            return result;
        }
    }
}
