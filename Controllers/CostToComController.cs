using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class CostToComController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(CostToCom costToCom)
        {
            CostToComDataAccess dataAccess = new CostToComDataAccess();
            dataAccess.Create(costToCom);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            CostToComDataAccess dataAccess = new CostToComDataAccess();
            var costToComs = dataAccess.Get();
            return Ok(costToComs);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            CostToComDataAccess dataAccess = new CostToComDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(CostToCom costToCom)
        {
            CostToComDataAccess dataAccess = new CostToComDataAccess();
            return Ok(dataAccess.Put(costToCom));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            CostToComDataAccess dataAccess = new CostToComDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}