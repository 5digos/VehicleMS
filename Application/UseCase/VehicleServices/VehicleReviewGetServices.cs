using Application.Dtos.Request;
using Application.Dtos.Response;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.IVehicleServices;
using Application.Interfaces.IValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.VehicleServices
{
    public class VehicleReviewGetServices : IVehicleReviewGetServices
    {
        private readonly IReviewQuery _reviewQuery;
        private readonly IValidatorHandler<GetVehicleReviewsRequest> _validator;

        public VehicleReviewGetServices(
            IValidatorHandler<GetVehicleReviewsRequest> validator,
            IReviewQuery reviewQuery)
        {
            _validator = validator;
            _reviewQuery = reviewQuery;
        }

        public async Task<GetVehicleReviewsResponse> GetReviews(
            Guid vehicleId,
            int? rating,
            int? offset,
            int? size)
        {
            var req = new GetVehicleReviewsRequest
            {
                Rating = rating,
                Offset = offset,
                Size = size
            };

            await _validator.Validate(req);

            var (entities, total) = await _reviewQuery
                .GetReviewsByVehicle(vehicleId, rating, offset, size);

            var dtoList = entities
                .Select(r => (VehicleReviewResponse)r)
                .ToList();

            return new GetVehicleReviewsResponse
            {
                Reviews = dtoList,
                TotalCount = total
            };
        }
    }
}
