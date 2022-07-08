using DataAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DataAPI.Controllers;

[ApiController]
[Route("api/{name}")]
public class EmployeeController : Controller
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var employees = await _employeeRepository.List();
        return Ok(employees);
    }
}