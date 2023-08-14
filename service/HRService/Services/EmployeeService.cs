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

        public Employee GetEmployeeById(int id)
        {
            return _employees[id];
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

    }
}
