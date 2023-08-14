using HRService.Models;

namespace HRService.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
    }
}
