using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class VehicleDocumentResponse
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public string DocType { get; set; }
        public string Url { get; set; }

        public static explicit operator VehicleDocumentResponse(VehicleDocument vehicleDocument)
        {
            return new VehicleDocumentResponse
            {
                Id = vehicleDocument.DocumentId,
                VehicleId = vehicleDocument.VehicleId,
                DocType = vehicleDocument.DocType,
                Url = vehicleDocument.Url
            };
        }
    }
}
