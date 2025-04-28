using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class GetVehiclesResponse
    {
        public List<VehicleResponse> Vehicles { get; set; } = new List<VehicleResponse>();
        public int TotalCount { get; set; }
    }
}
