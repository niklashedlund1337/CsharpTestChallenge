using DataAPI.Models;

namespace DataAPI.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>?> List();
}