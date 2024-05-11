using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class JobRoleController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(JobRoles jobRoles)
        {
            JobRoleDataAccess dataAccess = new JobRoleDataAccess();
            dataAccess.Create(jobRoles);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            JobRoleDataAccess dataAccess = new JobRoleDataAccess();
            var jobRoles = dataAccess.Get();
            return Ok(jobRoles);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            JobRoleDataAccess dataAccess = new JobRoleDataAccess();
            return Ok(dataAccess.Get(id));
        }
        [HttpPut("Put")]
        public IActionResult Put(JobRoles jobRoles)
        {
            JobRoleDataAccess dataAccess = new JobRoleDataAccess();
            return Ok(dataAccess.Put(jobRoles));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            JobRoleDataAccess dataAccess = new JobRoleDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}