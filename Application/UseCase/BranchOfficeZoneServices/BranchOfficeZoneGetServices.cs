using Application.Dtos.Response;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.IBranchOfficeZoneServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.BranchOfficeZoneServices
{
    public class BranchOfficeZoneGetServices : IBranchOfficeZoneGetServices
    {
        private readonly IBranchOfficeZoneQuery _branchOfficeZoneQuery;

        public BranchOfficeZoneGetServices(IBranchOfficeZoneQuery branchOfficeZoneQuery)
        {
            _branchOfficeZoneQuery = branchOfficeZoneQuery;
        }

        public async Task<List<GenericResponse>> GetAll()
        {
            var branchOfficeZones = await _branchOfficeZoneQuery.GetAll();

            var result = branchOfficeZones.Select(v => new GenericResponse
            {
                Id = v.Id,
                Name = v.Name
            }).ToList();

            return result;
        }
    }
}
