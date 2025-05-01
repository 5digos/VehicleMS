using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Dtos.Response;
using Application.Interfaces.IServices.IVehicleServices;
using FluentValidation;
using Application.Exceptions;
using Domain.Entities;
using Application.Dtos.Request;

namespace VehicleMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleGetServices _vehicleGetService;
        private readonly IVehiclePatchServices _vehiclePatchService;

        public VehicleController(IVehicleGetServices vehicleGetService, IVehiclePatchServices vehiclePatchService)
        {
            _vehicleGetService = vehicleGetService;
            _vehiclePatchService = vehiclePatchService;
        }

        /// <summary>
        /// Retrieves available vehicles using optional filters and pagination. 
        /// </summary>
        /// <param name="branchOffice">Optional. ID of the branch office.</param>
        /// <param name="category">Optional. Category of the vehicle.</param>
        /// <param name="seatingCapacity">Optional. Seating capacity of the vehicle.</param>
        /// <param name="transmissionType">Optional. Type of transmission.</param>
        /// <param name="maxPrice">Optional. Maximum price of the vehicle.</param>        
        /// <param name="offset">Optional. Skip the specified number of records (used for pagination).</param>
        /// <param name="size">Optional. Limit the number of records returned (used for pagination).</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<VehicleResponse>), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        public async Task<ActionResult> GetVehicles(
            [FromQuery] int? branchOffice,
            [FromQuery] int? category,
            [FromQuery] int? seatingCapacity,
            [FromQuery] int? transmissionType,
            [FromQuery] int? maxPrice,            
            [FromQuery] int? offset,
            [FromQuery] int? size)
        {

            try
            {
                var result = await _vehicleGetService.GetVehicles(branchOffice, category, seatingCapacity, transmissionType, maxPrice, offset, size);

                Response.Headers.Add("offset", (offset ?? 0).ToString());
                Response.Headers.Add("size", (size ?? 0).ToString());
                Response.Headers.Add("totalCount", result.TotalCount.ToString());

                return new JsonResult(result.Vehicles) { StatusCode = 200 };
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }
        }


        /// <summary>
        /// Retrieves detailed information about a specific vehicle by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the vehicle.</param>
        /// <response code="200">Success</response>
        /// <returns>The project details.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(VehicleDetailsResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 404)]
        public async Task<IActionResult> GetProjectById([FromRoute] Guid id)
        {
            try
            {
                var result = await _vehicleGetService.GetVehicleById(id);
                return new JsonResult(result) { StatusCode = 200 };
            }
            catch (NotFoundException ex)
            {
                return new JsonResult(new ApiError { Message = ex.Message }) { StatusCode = 404 };
            }
        }


        /// <summary>
        /// Add a new review to an existing vehicle.
        /// </summary>
        /// <param name="id">The unique identifier of the vehicle.</param>
        /// /// <param name="reviewRequest">The details of the review to be added.</param>
        /// <response code="200">Success</response>
        /// <returns>The project details.</returns>
        [HttpPatch("{id}/reviews")]
        [ProducesResponseType(typeof(VehicleReviewResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        public async Task<IActionResult> AddReview([FromRoute] Guid id, [FromBody] VehicleReviewRequest reviewRequest)
        {
            try
            {
                var result = await _vehiclePatchService.AddReview(id, reviewRequest);
                return new JsonResult(result) { StatusCode = 200 };
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }
        }
    }
}
