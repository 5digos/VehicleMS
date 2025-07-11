﻿using Application.Dtos.Response;
using Application.Exceptions;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.IBranchOfficeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.BranchOfficeServices
{
    public class BranchOfficeGetServices : IBranchOfficeGetServices
    {
        private readonly IBranchOfficeQuery _branchOfficeQuery;

        public BranchOfficeGetServices(IBranchOfficeQuery branchOfficeQuery)
        {
            _branchOfficeQuery = branchOfficeQuery;
        }

        public async Task<BranchOfficeResponse> GetBranchOfficeById(int id)
        {
            try
            {
                var branchOffice = await _branchOfficeQuery.GetBranchOfficeById(id);

                if (branchOffice == null)
                {
                    throw new NotFoundException("branchOffice not found");
                }

                return (BranchOfficeResponse)branchOffice;
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(ex.Message);
            }
        }

        public async Task<List<BranchOfficeResponse>> GetBranchOffices(string? name, int? zone, string? city, string? postalCode, string? province)
        {
            var branchOffices = await _branchOfficeQuery.GetBranchOffices(name, zone, city, postalCode, province);

            var responseBranchOffices = new List<BranchOfficeResponse>();

            foreach (var branchOffice in branchOffices) 
            {
                responseBranchOffices.Add((BranchOfficeResponse)branchOffice);
            }

            return responseBranchOffices;
        }
    }
}
