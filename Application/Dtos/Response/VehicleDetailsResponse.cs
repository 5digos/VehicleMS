using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class VehicleDetailsResponse
    {
        public VehicleResponse Vehicle { get; set; }
        public List<VehicleReviewResponse> Reviews { get; set; }
        public List<VehicleDocumentResponse> Documents { get; set; }



        public static explicit operator VehicleDetailsResponse(Vehicle vehicle)
        {
            return new VehicleDetailsResponse
            {
                Vehicle = (VehicleResponse)vehicle,
                Reviews = vehicle.Reviews?.Select(r => (VehicleReviewResponse)r).ToList() ?? new List<VehicleReviewResponse>(),
                Documents = vehicle.Documents.Select(d => (VehicleDocumentResponse)d).ToList() ?? new List<VehicleDocumentResponse>()
            };
        }
    }
}
