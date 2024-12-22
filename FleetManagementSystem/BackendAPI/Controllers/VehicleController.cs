
using Microsoft.AspNetCore.Mvc;
using BackendAPI.Models;
using BackendAPI.Services;

namespace BackendAPI.Controllers
{
    [ApiController]
    [Route("api/vehicles")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost("location")]
        public IActionResult PostLocation(VehicleLocation location)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid input data");
            _vehicleService.SaveLocation(location);
            return Ok("Location saved successfully");
        }

        [HttpGet("locations")]
        public IActionResult GetLocations()
        {
            var locations = _vehicleService.GetLatestLocations();
            return Ok(locations);
        }
    }
}
