using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(Location location)
        {
            LocationDataAccess dataAccess = new LocationDataAccess();
            dataAccess.Create(location);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            LocationDataAccess dataAccess = new LocationDataAccess();
            var locations = dataAccess.Get();
            return Ok(locations);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            LocationDataAccess dataAccess = new LocationDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(Location location)
        {
            LocationDataAccess dataAccess = new LocationDataAccess();
            return Ok(dataAccess.Put(location));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            LocationDataAccess dataAccess = new LocationDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}