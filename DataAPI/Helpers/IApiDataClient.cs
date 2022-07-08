using DataAPI.Models;

namespace DataAPI.Helpers;

public interface IApiDataClient
{
    Task<List<Employee>?> GetEmployees();
}