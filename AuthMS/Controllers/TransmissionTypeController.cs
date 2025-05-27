using Application.Dtos.Response;
using Application.Interfaces.IServices.ITransmissionTypeServices;
using Application.Interfaces.IServices.IVehicleStatusServices;
using Application.UseCase.VehicleStatusServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TransmissionTypeController : ControllerBase
    {
        private readonly ITransmissionTypeGetServices _transmissionTypeGetServices;

        public TransmissionTypeController(ITransmissionTypeGetServices transmissionTypeGetServices)
        {
            _transmissionTypeGetServices = transmissionTypeGetServices;
        }


        /// <summary>
        /// Retrieves a list of all transmission types.
        /// </summary>
        /// <response code="200"> Success </response>
        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(typeof(List<GenericResponse>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _transmissionTypeGetServices.GetAll();
            return new JsonResult(result);
        }
    }
}
