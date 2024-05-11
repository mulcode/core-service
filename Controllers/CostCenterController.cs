using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class CostCenterController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(CostCenter costCenter)
        {
            CostCenterDataAccess dataAccess = new CostCenterDataAccess();
            dataAccess.Create(costCenter);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            CostCenterDataAccess dataAccess = new CostCenterDataAccess();
            var costCenters = dataAccess.Get();
            return Ok(costCenters);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            CostCenterDataAccess dataAccess = new CostCenterDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(CostCenter costCenter)
        {
            CostCenterDataAccess dataAccess = new CostCenterDataAccess();
            return Ok(dataAccess.Put(costCenter));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            CostCenterDataAccess dataAccess = new CostCenterDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}