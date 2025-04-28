using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VehicleReview
    {
        public Guid ReviewId { get; set; }
        public Guid VehicleId { get; set; }
        public Guid ReservationId { get; set; }   
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        
        public Vehicle Vehicle { get; set; }
    }
}
