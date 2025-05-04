using Application.Dtos.Request;
using Application.Dtos.Response;
using Application.Exceptions;
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
    public class VehicleGetServices : IVehicleGetServices
    {
        private readonly IVehicleQuery _vehicleQuery;
        private readonly IValidatorHandler<GetVehiclesRequest> _validator;

        public VehicleGetServices(IValidatorHandler<GetVehiclesRequest> validator, IVehicleQuery vehicleQuery)
        {
            _validator = validator;
            _vehicleQuery = vehicleQuery;
        }
        

        public async Task<GetVehiclesResponse> GetVehicles(int? branchOffice, int? category, int? seatingCapacity, int? transmissionType, string? color, string? brand, int? maxPrice, int? offset, int? size)
        {
            var request = new GetVehiclesRequest
            {
                BranchOffice = branchOffice,
                Category = category,
                SeatingCapacity = seatingCapacity,
                TransmissionType = transmissionType,
                Color = color,
                Brand = brand,
                MaxPrice = maxPrice,                
                Offset = offset,
                Size = size
            };

            await _validator.Validate(request);

            var (vehicles, totalCount) = await _vehicleQuery.GetVehicles(branchOffice, category, seatingCapacity, transmissionType, color, brand, maxPrice, offset, size);
            var responseVehicles = new List<VehicleResponse>();

            foreach (var vehicle in vehicles)
            {
                responseVehicles.Add((VehicleResponse)vehicle);
            }

            return new GetVehiclesResponse
            {
                Vehicles = responseVehicles,
                TotalCount = totalCount
            };
        }

        public async Task<VehicleDetailsResponse> GetVehicleById(Guid id)
        {
            try
            { 
                var vehicle = await _vehicleQuery.GetVehicleById(id);

                if (vehicle == null)
                {
                    throw new NotFoundException("Vehicle not found");
                }

                return (VehicleDetailsResponse)vehicle;
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(ex.Message);
            }
        }
    }
}
