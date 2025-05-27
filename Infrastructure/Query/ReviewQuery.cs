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
    public class ReviewQuery : IReviewQuery
    {
        private readonly AppDbContext _context;
        public ReviewQuery(AppDbContext context) => _context = context;

        public async Task<(IEnumerable<VehicleReview> Reviews, int TotalCount)>
            GetReviewsByVehicle(Guid vehicleId, int? rating, int? offset, int? size)
        {
            var q = _context.VehicleReviews
                .Where(r => r.VehicleId == vehicleId)
                .AsQueryable();

            if (rating.HasValue)
                q = q.Where(r => r.Rating == rating.Value);

            var total = await q.CountAsync();

            if (offset.HasValue) q = q.Skip(offset.Value);
            if (size.HasValue) q = q.Take(size.Value);

            var list = await q.ToListAsync();
            return (list, total);
        }
    }
}
