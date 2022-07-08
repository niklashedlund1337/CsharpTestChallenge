using DataAPI.Helpers;
using DataAPI.Models;

namespace DataAPI.Tests.Mocks;

public class ApiHelperMock : IApiHelper
{
    private readonly List<Employee> _employees;

    public ApiHelperMock(List<Employee> employees)
    {
        _employees = employees;
    }
    
    public Task<List<Employee>?> GetEmployees()
    {
        return Task.FromResult(_employees);
    }
}