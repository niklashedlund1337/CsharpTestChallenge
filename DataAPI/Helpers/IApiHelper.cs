using DataAPI.Models;

namespace DataAPI.Helpers;

public interface IApiHelper
{
    Task<List<Employee>?> GetEmployees();
}