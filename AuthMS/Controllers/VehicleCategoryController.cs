using Application.Dtos.Response;
using Application.Interfaces.IServices.ITransmissionTypeServices;
using Application.Interfaces.IServices.IVehicleCategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehicleCategoryController : ControllerBase
    {
        private readonly IVehicleCategoryGetServices _vehicleCategoryGetServices;

        public VehicleCategoryController(IVehicleCategoryGetServices vehicleCategoryGetServices)
        {
            _vehicleCategoryGetServices = vehicleCategoryGetServices;
        }


        /// <summary>
        /// Retrieves a list of all vehicle categories.
        /// </summary>
        /// <response code="200"> Success </response>
        [HttpGet]
        [ProducesResponseType(typeof(List<VehicleCategoryResponse>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _vehicleCategoryGetServices.GetAll();
            return new JsonResult(result);
        }
    }
}
