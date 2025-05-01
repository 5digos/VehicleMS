using Application.Dtos.Response;
using Application.Interfaces.IServices.IBranchOfficeZoneServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleMS.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BranchOfficeZoneController : ControllerBase
    {
        private readonly IBranchOfficeZoneGetServices _branchOfficeZoneGetServices;

        public BranchOfficeZoneController(IBranchOfficeZoneGetServices branchOfficeZoneGetServices)
        {
            _branchOfficeZoneGetServices = branchOfficeZoneGetServices;
        }


        /// <summary>
        /// Retrieves a list of all branch office zones.
        /// </summary>
        /// <response code="200"> Success </response>
        [HttpGet]
        [ProducesResponseType(typeof(List<GenericResponse>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _branchOfficeZoneGetServices.GetAll();
            return new JsonResult(result);
        }
    }
}
