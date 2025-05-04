using Application.Dtos.Response;
using Application.Interfaces.IServices.IBranchOfficeServices;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BranchOfficeController : ControllerBase
    {
        private readonly IBranchOfficeGetServices _BranchOfficeGetService;

        public BranchOfficeController(IBranchOfficeGetServices branchOfficeGetService)
        {
            _BranchOfficeGetService = branchOfficeGetService;
        }



        /// <summary>
        /// Retrieves a list of branch offices based on optional filters.
        /// </summary>
        /// <param name="name">Optional. Name of the branch office.</param>
        /// <param name="zone">Optional. ID of the branch office zone (1-Zona Norte, 2-Zona Sur, 3-Zona Oeste, 4-Capital Federal, 5-Interior del País).</param>
        /// <param name="city">Optional. City of the branch office.</param>
        /// <param name="postalCode">Optional. Postal code of the branch office.</param>
        /// <param name="province">Optional. Province of the branch office.</param>
        /// <response code="200">Success</response>
        /// /// <returns>A list of BranchOffices that match the specified filters.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<BranchOfficeResponse>), 200)]
        public async Task<ActionResult> GetBranchOffices(
            [FromQuery] string? name,
            [FromQuery] int? zone,
            [FromQuery] string? city,
            [FromQuery] string? postalCode,
            [FromQuery] string? province)
        {
            try
            {
                var result = await _BranchOfficeGetService.GetBranchOffices(name, zone, city, postalCode, province);
                return new JsonResult(result) { StatusCode = 200 };
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }
        }
    }
}
