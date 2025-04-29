using Application.Dtos.Response;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.IVehicleCategoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.VehicleCategoryServices
{
    public class VehicleCategoryGetServices : IVehicleCategoryGetServices
    {
        private readonly IVehicleCategoryQuery _vehicleCategoryQuery;

        public VehicleCategoryGetServices(IVehicleCategoryQuery vehicleCategoryQuery)
        {
            _vehicleCategoryQuery = vehicleCategoryQuery;
        }

        public async Task<List<VehicleCategoryResponse>> GetAll()
        {
            var vehicleCategories = await _vehicleCategoryQuery.GetAll();

            var result = vehicleCategories.Select(v => new VehicleCategoryResponse
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description,
            }).ToList();

            return result;
        }
    }
}
