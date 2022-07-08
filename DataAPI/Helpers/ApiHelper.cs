using System.Net.Http.Headers;
using DataAPI.Models;

namespace DataAPI.Helpers;

public class ApiHelper : IApiHelper
{
    private const string ApiUrl = "https://api.1337co.de/v3/employees";
    
    private readonly IConfiguration _configuration;
    private readonly IHttpClientFactory _httpClientFactory;

    public ApiHelper(IConfiguration configuration, IHttpClientFactory httpClientFactory)
    {
        _configuration = configuration;
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<Employee>?> GetEmployees()
    {
        var apiKey = _configuration["ApiKey"];
        if (string.IsNullOrEmpty(apiKey)) throw new Exception("Please set ApiKey in the configuration file");
        
        var client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Add("Authorization", apiKey);

        return await client.GetFromJsonAsync<List<Employee>>(ApiUrl);
    }
}