﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Request
{
    public class VehicleReviewRequest
    {
        public Guid ReservationId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
    }
}
