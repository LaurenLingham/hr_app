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
        public IActionResult DeleteEmployee(Employee employee)
        {
            _employeeService.DeleteEmployeeById(employee.Id);

            return NoContent();
        }

        [HttpPut]
        public Employee UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);

            return employee;
        }
    }
}
