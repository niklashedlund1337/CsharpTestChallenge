using DataAPI.Helpers;
using DataAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddSingleton<IApiDataClient, ApiDataClient>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Welcome to the DataAPI!");

app.Run();