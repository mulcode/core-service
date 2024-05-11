using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class DevisionController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(Devision devision)
        {
            DevisionDataAccess dataAccess = new DevisionDataAccess();
            dataAccess.Create(devision);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            DevisionDataAccess dataAccess = new DevisionDataAccess();
            var devisions = dataAccess.Get();
            return Ok(devisions);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            DevisionDataAccess dataAccess = new DevisionDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(Devision devision)
        {
            DevisionDataAccess dataAccess = new DevisionDataAccess();
            return Ok(dataAccess.Put(devision));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            DevisionDataAccess dataAccess = new DevisionDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}