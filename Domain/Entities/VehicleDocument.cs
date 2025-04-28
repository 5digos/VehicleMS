using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VehicleDocument
    {
        public Guid DocumentId { get; set; }
        public Guid VehicleId { get; set; }
        public string DocType { get; set; }
        public string Url { get; set; }
        public DateTime UploadDate { get; set; }

        
        public Vehicle Vehicle { get; set; }
    }
}
