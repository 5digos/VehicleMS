using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IQuery
{
    public interface IBranchOfficeQuery
    {
        Task<IEnumerable<BranchOffice>> GetBranchOffices(string? name, int? zone, string? city, string? postalCode, string? province);
        Task<BranchOffice> GetBranchOfficeById(int id);
    }
}
