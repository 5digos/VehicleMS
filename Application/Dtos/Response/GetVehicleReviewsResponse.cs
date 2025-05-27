using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class GetVehicleReviewsResponse
    {
        public List<VehicleReviewResponse> Reviews { get; set; } = new();
        public int TotalCount { get; set; }
    }
}
