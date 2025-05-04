using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class VehicleResponse
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public decimal Price { get; set; }
        public int SeatingCapacity { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }
        public GenericResponse Status { get; set; } 
        public GenericResponse TransmissionType { get; set; }
        public VehicleCategoryResponse Category { get; set; }
        public BranchOfficeResponse BranchOffice { get; set; }



        public static explicit operator VehicleResponse(Vehicle vehicle)
        {
            return new VehicleResponse
            {
                Id = vehicle.VehicleId,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                Year = vehicle.Year,
                LicensePlate = vehicle.LicensePlate,
                Price = vehicle.Price,
                SeatingCapacity = vehicle.SeatingCapacity,
                Color = vehicle.Color,
                ImageUrl = vehicle.ImageUrl,
                Status = (GenericResponse)vehicle.VehicleStatus,
                TransmissionType = (GenericResponse)vehicle.TransmissionType,
                Category = (VehicleCategoryResponse)vehicle.Category,
                BranchOffice = (BranchOfficeResponse)vehicle.BranchOffice
            };
        }
    }
}
