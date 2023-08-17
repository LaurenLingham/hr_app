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
            return _employees.Single(e => e.Id == id);
        }

        public void AddEmployee(Employee newEmployee)
        {
            if (!_employees.Exists(e => e.Id == newEmployee.Id))
            {
                _employees.Add(newEmployee);
            }
        }

        public void DeleteEmployeeById(int id)
        {
            _employees.Remove(GetEmployeeById(id));
        }

        public void UpdateEmployee(Employee employee)
        {
            var indexToUpdate = _employees.FindIndex(e => e.Id == employee.Id);
 
            _employees[indexToUpdate] = employee;
        }
    }
}
