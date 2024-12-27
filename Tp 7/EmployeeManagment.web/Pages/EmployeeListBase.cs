using EmployeeManagment.web.Models;
using EmployeeManagment.web.Services;
using Microsoft.AspNetCore.Components;
namespace BlazorApp_EmployeeList.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]

        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()

        {
            Employees = new List<Employee>();

            Employees = (await EmployeeService.GetEmployees()).ToList();

        }
    }
}