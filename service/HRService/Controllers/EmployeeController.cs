using HRService.Models;
using HRService.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) 
        { 
            _employeeService = employeeService;
        }

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployeeById(id);
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);

            return StatusCode(201);
        }

        [HttpDelete]
        public List<Employee> Employee(Employee employee)
        {
            _employeeService.DeleteEmployee(employee);

            return _employeeService.GetEmployees();
        }
    }
}
