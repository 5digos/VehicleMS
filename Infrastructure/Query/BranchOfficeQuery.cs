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
    public class BranchOfficeQuery : IBranchOfficeQuery
    {
        private readonly AppDbContext _context;

        public BranchOfficeQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BranchOffice> GetBranchOfficeById(int id)
        {
            var branchOffice = await _context.Set<BranchOffice>()
                .Include(x => x.Zone)
                .FirstOrDefaultAsync(v => v.BranchOfficeId == id);

            return branchOffice;
        }

        public async Task<IEnumerable<BranchOffice>> GetBranchOffices(string? name, int? zone, string? city, string? postalCode, string? province)
        {
            var query = _context.BranchOffices
                .Include(bo => bo.Zone)
                .AsQueryable();

            if (!string.IsNullOrEmpty(name)) 
            {
                query = query.Where(bo => bo.Name.ToLower().Contains(name.ToLower()));
            }

            if (zone.HasValue)
            {
                query = query.Where(bo => bo.BranchOfficeZoneId == zone.Value);
            }

            if (!string.IsNullOrEmpty(city))
            {
                query = query.Where(bo => bo.City.ToLower().Contains(city.ToLower()));
            }

            if (!string.IsNullOrEmpty(postalCode)) 
            {
                query = query.Where(bo => bo.PostalCode.ToLower().Contains(postalCode.ToLower()));
            }

            if (!string.IsNullOrEmpty(province))
            {
                query = query.Where(bo => bo.Province.ToLower().Contains(province.ToLower()));
            }

            var branchOffices = await query.ToListAsync();

            return branchOffices;
        }
    }
}
