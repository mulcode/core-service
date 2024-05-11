using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class DesignationController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(Designation designation)
        {
            DesignationDataAccess dataAccess = new DesignationDataAccess();
            dataAccess.Create(designation);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            DesignationDataAccess dataAccess = new DesignationDataAccess();
            var designations = dataAccess.Get();
            return Ok(designations);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            DesignationDataAccess dataAccess = new DesignationDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(Designation designation)
        {
            DesignationDataAccess dataAccess = new DesignationDataAccess();
            return Ok(dataAccess.Put(designation));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            DesignationDataAccess dataAccess = new DesignationDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}