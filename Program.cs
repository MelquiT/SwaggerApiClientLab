//using MyApiClientNamespace;
using SwaggerApiClientLab2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer(); //only required for minimal APIs
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//Task.Run(() => app.RunAsync());

//await Task.Delay(3000); //This delay ensures the server is fully started before generating the client
//await new ClientGenerator().GenerateClient();
//await Task.Delay(3000);

//var httpClient = new HttpClient();
//var client = new GeneratedApiClient("http://localhost:5000", httpClient);
//var user = await client.UserAsync(1);
//var weather = await client.WeatherForecastAsync();
//Console.WriteLine($"Fetched User: ID:{user.Id}, Name:{user.Name}");
//Console.WriteLine($"Fetched Weather Forecasts: total: {weather.Count}");
