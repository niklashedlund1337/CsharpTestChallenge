using DataAPI.Models;
using DataAPI.Repositories;
using DataAPI.Tests.Mocks;
using Xunit;

namespace DataAPI.Tests;

public class EmployeeRepositoryTests
{
    [Fact]
    public async Task List_WithEmptyData_ReturnsZeroCount()
    {
        //Arrange
        var apiDataClient = new ApiDataClientMock(new List<Employee>());
        var employeeRepository = new EmployeeRepository(apiDataClient);

        //Act
        var actual = await employeeRepository.List();

        //Assert
        Assert.NotNull(actual);
        Assert.Empty(actual);
    }
}