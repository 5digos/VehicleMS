using Application.Dtos.Response;
using Application.Interfaces.IServices.IVehicleStatusServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehicleStatusController : ControllerBase
    {
        private readonly IVehicleStatusGetServices _vehicleStatusGetServices;

        public VehicleStatusController(IVehicleStatusGetServices vehicleStatusGetServices)
        {
            _vehicleStatusGetServices = vehicleStatusGetServices;
        }



        /// <summary>
        /// Retrieves a list of all vehicle statuses.
        /// </summary>
        /// <response code="200"> Success </response>
        [HttpGet]
        [ProducesResponseType(typeof(List<GenericResponse>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _vehicleStatusGetServices.GetAll();
            return new JsonResult(result);
        }
    }
}
