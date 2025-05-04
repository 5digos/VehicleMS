using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Request
{
    public class GetVehiclesRequest
    {
        public int? BranchOffice {  get; set; }
        public int? Category { get; set; }
        public int? SeatingCapacity { get; set; }
        public int? TransmissionType { get; set; }
        public string? Color { get; set; }
        public string? Brand { get; set; }
        public int? MaxPrice { get; set; }       
        public int? Offset { get; set; }
        public int? Size { get; set; }
    }
}
