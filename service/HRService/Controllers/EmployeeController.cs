using HRService.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return new List<Employee>();
        }
    }
}
