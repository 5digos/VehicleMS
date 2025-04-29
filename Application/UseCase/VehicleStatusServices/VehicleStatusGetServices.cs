using Application.Dtos.Response;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.IVehicleStatusServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.VehicleStatusServices
{
    public class VehicleStatusGetServices : IVehicleStatusGetServices
    {
        private readonly IVehicleStatusQuery _vehicleStatusQuery;

        public VehicleStatusGetServices(IVehicleStatusQuery vehicleStatusQuery)
        {
            _vehicleStatusQuery = vehicleStatusQuery;
        }

        public async Task<List<GenericResponse>> GetAll()
        {
            var vehicleStatus = await _vehicleStatusQuery.GetAll();

            var result = vehicleStatus.Select(v => new GenericResponse
            {
                Id = v.Id,
                Name = v.Name                
            }).ToList();

            return result;
        }
    }
}
