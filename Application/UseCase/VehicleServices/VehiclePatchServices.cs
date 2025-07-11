﻿using Application.Dtos.Request;
using Application.Dtos.Response;
using Application.Exceptions;
using Application.Interfaces.ICommand;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.IVehicleServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.VehicleServices
{
    public class VehiclePatchServices : IVehiclePatchServices
    {
        private readonly IVehicleQuery _vehicleQuery;
        private readonly IVehicleCommand _vehicleCommand;
        private readonly IBranchOfficeQuery _branchOfficeQuery;

        public VehiclePatchServices(IVehicleQuery vehicleQuery, IVehicleCommand vehicleCommand, IBranchOfficeQuery branchOfficeQuery)
        {
            _vehicleQuery = vehicleQuery;
            _vehicleCommand = vehicleCommand;
            _branchOfficeQuery = branchOfficeQuery;

        }

        public async Task<VehicleReviewResponse> AddReview(Guid vehicleId, VehicleReviewRequest reviewRequest)
        {
            try
            {
                var vehicle = await _vehicleQuery.GetVehicleById(vehicleId);
                if (vehicle == null)
                {
                    throw new NotFoundException("Vehicle not found");
                }

                var newVehicleReview = new VehicleReview
                {
                    VehicleId = vehicle.VehicleId,
                    ReservationId = reviewRequest.ReservationId,
                    Rating = reviewRequest.Rating,
                    Comment = reviewRequest.Comment,
                    CreatedAt = DateTime.Now
                };
                await _vehicleCommand.AddVehicleReview(vehicle, newVehicleReview);

                return (VehicleReviewResponse)newVehicleReview;
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(ex.Message);
            }
        }

        public async Task UpdateBranchOffice(Guid vehicleId, int branchOfficeId)
        {
            var vehicle = await _vehicleQuery.GetVehicleById(vehicleId);
            if (vehicle == null)
            {
                throw new NotFoundException("Vehicle not found");
            }

            var branchOffice = await _branchOfficeQuery.GetBranchOfficeById(branchOfficeId);

            if (branchOffice == null)
            {
                throw new NotFoundException("Branch office not found");
            }

            vehicle.BranchOfficeId = branchOfficeId;
            vehicle.BranchOffice = branchOffice;

            await _vehicleCommand.UpdateBranchOffice(vehicle);
        }
    }
}
