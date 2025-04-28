using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class BranchOfficeResponse
    {
        public int BranchOfficeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Hours { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string LocationReference { get; set; }


        public static explicit operator BranchOfficeResponse(BranchOffice branchOffice)
        {
            return new BranchOfficeResponse
            {
                BranchOfficeId = branchOffice.BranchOfficeId,
                Name = branchOffice.Name,
                Address = branchOffice.Address,
                Phone = branchOffice.Phone,
                Hours = branchOffice.Hours,
                Latitude = branchOffice.Latitude,
                Longitude = branchOffice.Longitude,
                City = branchOffice.City,
                PostalCode = branchOffice.PostalCode,
                Province = branchOffice.Province,
                LocationReference = branchOffice.LocationReference
            };
        }
    }
}
