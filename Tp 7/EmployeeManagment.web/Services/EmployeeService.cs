using EmployeeManagment.web.Models;
using EmployeeManagment.web.Services;
using System.Net.Http.Json;

namespace BlazorApp_EmployeeList.services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()

        {

            return await httpClient.GetFromJsonAsync<Employee[]>("api/Employee");

        }

        public async Task<Employee> GetEmployee(int id)

        {

            return await httpClient.GetFromJsonAsync<Employee>($"api/Employee/{id}");

        }
    }
}