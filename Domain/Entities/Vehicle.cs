using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public int VehicleStatusId { get; set; }
        public int BranchOfficeId { get; set; }        
        public int CategoryId { get; set; }
        public int TransmissionTypeId { get; set; }
        public int SeatingCapacity { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        
        public VehicleStatus VehicleStatus { get; set; }
        public BranchOffice BranchOffice { get; set; }        
        public VehicleCategory Category { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public ICollection<VehicleReview> Reviews { get; set; }
        public ICollection<VehicleDocument> Documents { get; set; }
    }
}
