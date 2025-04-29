using Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IServices.IVehicleServices
{
    public interface IVehicleGetServices
    {
        Task<GetVehiclesResponse> GetVehicles(int? branchOffice, int? category, int? seatingCapacity, int? transmissionType, int? maxPrice, int? offset, int? size);
        Task<VehicleDetailsResponse> GetVehicleById(Guid id);
    }
}
