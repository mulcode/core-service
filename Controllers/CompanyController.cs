using CoreService.DataAccessLayer;
using CoreService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreService
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        [HttpPost("Post")]
        public IActionResult Create(Company company)
        {

            CompanyDataAccess dataAccess = new CompanyDataAccess();
            int rowAffected = dataAccess.Create(company);
            return Ok(rowAffected);
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            CompanyDataAccess dataAccess = new CompanyDataAccess();
            return Ok(dataAccess.Get());
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            CompanyDataAccess dataAccess = new CompanyDataAccess();
            return Ok(dataAccess.Get(id));
        }

        [HttpPut("Put")]
        public IActionResult Put(Company company)
        {
            CompanyDataAccess dataAccess = new CompanyDataAccess();
            return Ok(dataAccess.Put(company));
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            CompanyDataAccess dataAccess = new CompanyDataAccess();
            dataAccess.Delete(id);
            return Ok();
        }
    }
}