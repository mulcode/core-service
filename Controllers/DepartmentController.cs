using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(Department department)
        {
            DepartmentDataAccess dataAccess = new DepartmentDataAccess();
            dataAccess.Create(department);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            DepartmentDataAccess dataAccess = new DepartmentDataAccess();
            var departments = dataAccess.Get();
            return Ok(departments);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            DepartmentDataAccess dataAccess = new DepartmentDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(Department department)
        {
            DepartmentDataAccess dataAccess = new DepartmentDataAccess();
            return Ok(dataAccess.Put(department));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            DepartmentDataAccess dataAccess = new DepartmentDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}