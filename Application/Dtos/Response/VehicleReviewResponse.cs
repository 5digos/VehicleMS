using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class VehicleReviewResponse
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }        
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public static explicit operator VehicleReviewResponse(VehicleReview vehicleReview)
        {
            return new VehicleReviewResponse
            {
                Id = vehicleReview.ReviewId,
                VehicleId = vehicleReview.VehicleId,
                Rating = vehicleReview.Rating,
                Comment = vehicleReview.Comment,
                CreatedAt = vehicleReview.CreatedAt
            };
        }
    }
}
