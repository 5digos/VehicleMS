using Application.Dtos.Request;
using Application.Dtos.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IServices.IVehicleServices
{
    public interface IVehiclePatchServices
    {
        Task<VehicleReviewResponse> AddReview(Guid vehicleId, VehicleReviewRequest reviewRequest);
    }
}
