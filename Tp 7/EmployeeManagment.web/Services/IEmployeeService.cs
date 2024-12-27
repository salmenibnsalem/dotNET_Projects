using EmployeeManagment.web.Models;

namespace EmployeeManagment.web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();

        Task<Employee> GetEmployee(int id);
    }
}
