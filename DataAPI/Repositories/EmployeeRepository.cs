using DataAPI.Helpers;
using DataAPI.Models;

namespace DataAPI.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IApiHelper _apiHelper;
    private List<Employee>? _employees;

    public EmployeeRepository(IApiHelper apiHelper)
    {
        _apiHelper = apiHelper;
    }
    
    public async Task<IEnumerable<Employee>?> List()
    {
        if (_employees == null)
            await GetEmployees();
        
        return _employees;
    }

    private async Task GetEmployees()
    {
        _employees = await _apiHelper.GetEmployees();
    }
}