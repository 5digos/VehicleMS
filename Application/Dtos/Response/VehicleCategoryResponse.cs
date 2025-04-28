using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class VehicleCategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public static explicit operator VehicleCategoryResponse(VehicleCategory vehicleCategory)
        {
            return new VehicleCategoryResponse
            {
                Id = vehicleCategory.Id,
                Name = vehicleCategory.Name,
                Description = vehicleCategory.Description
            };
        }
    }
}
