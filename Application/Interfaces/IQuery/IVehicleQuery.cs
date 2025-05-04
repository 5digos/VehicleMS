using Application.Dtos.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IQuery
{
    public interface IVehicleQuery
    {
        Task<(IEnumerable<Vehicle> Vehicles, int TotalCount)> GetVehicles(int? branchOffice, int? category, int? seatingCapacity, int? transmissionType, string? color, string? brand, int? maxPrice, int? offset, int? size);
        Task<Vehicle> GetVehicleById(Guid id);
    }
}
