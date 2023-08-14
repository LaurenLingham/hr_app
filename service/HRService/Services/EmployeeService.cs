using HRService.Models;

namespace HRService.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> _employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
