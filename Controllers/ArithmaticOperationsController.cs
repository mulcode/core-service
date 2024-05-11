using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class ArithmaticOperationsController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(ArithmaticOperations operations)
        {
            ArithmaticOperationsDataAccess dataAccess = new ArithmaticOperationsDataAccess();
            dataAccess.Create(operations);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            ArithmaticOperationsDataAccess dataAccess = new ArithmaticOperationsDataAccess();
            var operations = dataAccess.Get();
            return Ok(operations);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            ArithmaticOperationsDataAccess dataAccess = new ArithmaticOperationsDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(ArithmaticOperations operations)
        {
            ArithmaticOperationsDataAccess dataAccess = new ArithmaticOperationsDataAccess();
            return Ok(dataAccess.Put(operations));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            ArithmaticOperationsDataAccess dataAccess = new ArithmaticOperationsDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}