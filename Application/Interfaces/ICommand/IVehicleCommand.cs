using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICommand
{
    public interface IVehicleCommand
    {
        Task AddVehicleReview(Vehicle vehicle, VehicleReview review);
        Task UpdateBranchOffice(Vehicle vehicle);
    }
}
