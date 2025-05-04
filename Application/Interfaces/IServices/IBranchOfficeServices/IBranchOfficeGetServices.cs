using Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IServices.IBranchOfficeServices
{
    public interface IBranchOfficeGetServices
    {
        Task<List<BranchOfficeResponse>> GetBranchOffices(string? name, int? zone, string? city, string? postalCode, string? province);
    }
}
