using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(Group group)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();
            var created = dataAccess.Create(group);
            return Ok(created);
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            GroupDataAccess dataAccess = new GroupDataAccess();
            var groups = dataAccess.Get();
            return Ok(groups);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(Group group)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();
            return Ok(dataAccess.Put(group));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}