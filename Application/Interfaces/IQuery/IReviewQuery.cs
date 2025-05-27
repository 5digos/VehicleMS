using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IQuery
{
    public interface IReviewQuery
    {
        Task<(IEnumerable<VehicleReview> Reviews, int TotalCount)>
            GetReviewsByVehicle(Guid vehicleId, int? rating, int? offset, int? size);
    }
}
