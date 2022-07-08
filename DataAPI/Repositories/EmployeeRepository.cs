using DataAPI.Helpers;
using DataAPI.Models;

namespace DataAPI.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IApiDataClient _apiDataClient;
    
    public EmployeeRepository(IApiDataClient apiDataClient)
    {
        _apiDataClient = apiDataClient;
    }
    
    public async Task<IEnumerable<Employee>?> List()
    {
        return await _apiDataClient.GetEmployees();
    }
}