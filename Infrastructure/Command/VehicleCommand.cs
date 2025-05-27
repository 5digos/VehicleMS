using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class VehicleCommand : IVehicleCommand
    {
        private readonly AppDbContext _context;

        public VehicleCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddVehicleReview(Vehicle vehicle, VehicleReview review)
        {
            _context.Add(review);
            _context.Update(vehicle);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBranchOffice(Vehicle vehicle)
        {           
            _context.Vehicles.Update(vehicle);
            await _context.SaveChangesAsync();
        }
    }
}
