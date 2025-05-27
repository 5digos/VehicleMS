using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Dtos.Response;
using Application.Interfaces.IServices.IVehicleServices;
using FluentValidation;
using Application.Exceptions;
using Domain.Entities;
using Application.Dtos.Request;
using Microsoft.AspNetCore.Authorization;

namespace VehicleMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleGetServices _vehicleGetService;
        private readonly IVehiclePatchServices _vehiclePatchService;
        private readonly IVehicleReviewGetServices _reviewGetService;

        public VehicleController(
            IVehicleGetServices vehicleGetService,
            IVehiclePatchServices vehiclePatchService,
            IVehicleReviewGetServices reviewGetService)
        {
            _vehicleGetService = vehicleGetService;
            _vehiclePatchService = vehiclePatchService;
            _reviewGetService = reviewGetService;

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
        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(typeof(List<VehicleResponse>), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        public async Task<ActionResult> GetVehicles(
            [FromQuery] int? branchOffice,
            [FromQuery] int? category,
            [FromQuery] int? seatingCapacity,
            [FromQuery] int? transmissionType,
            [FromQuery] string? color,
            [FromQuery] string? brand,
            [FromQuery] int? maxPrice,
            [FromQuery] int? offset,
            [FromQuery] int? size)
        {

            try
            {
                var result = await _vehicleGetService.GetVehicles(branchOffice, category, seatingCapacity, transmissionType, color, brand, maxPrice, offset, size);

                Response.Headers.Add("offset", (offset ?? 0).ToString());
                Response.Headers.Add("size", (size ?? 100000).ToString());
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
        [AllowAnonymous]
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(VehicleDetailsResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 404)]
        public async Task<IActionResult> GetVehicleById([FromRoute] Guid id)
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
        [Authorize(Policy = "ActiveUser")]
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

        /// <summary>
        /// Actualiza la sucursal asociada a un vehículo (tras devolución).
        /// </summary>
        [HttpPatch("{id}/branchOffice")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateBranchOffice([FromRoute] Guid id, [FromQuery] int branchOfficeId)
        {

            try
            {
                await _vehiclePatchService.UpdateBranchOffice(id, branchOfficeId);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return new JsonResult(new ApiError { Message = ex.Message }) { StatusCode = 404 };
            }
        }


        /// <summary>
        /// Retrieves reviews for a vehicle, optional Rating filter and pagination.
        /// </summary>
        [AllowAnonymous]
        [HttpGet("{id}/reviews")]
        [ProducesResponseType(typeof(List<VehicleReviewResponse>), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        public async Task<IActionResult> GetReviews(
            [FromRoute] Guid id,
            [FromQuery] int? rating,
            [FromQuery] int? offset,
            [FromQuery] int? size)
        {
            try
            {
                var result = await _reviewGetService.GetReviews(id, rating, offset, size);
                Response.Headers.Add("offset", (offset ?? 0).ToString());
                Response.Headers.Add("size", (size ?? 100000).ToString());
                Response.Headers.Add("totalCount", result.TotalCount.ToString());
                return Ok(result.Reviews);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }
        }
    }
}
