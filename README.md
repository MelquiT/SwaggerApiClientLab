# SwaggerApiClientLab

A .NET 9 demonstration project showcasing automatic API client generation using NSwag and Swashbuckle in an ASP.NET Core Web API application.

## Project Overview

This project demonstrates how to:
- Create a minimal ASP.NET Core Web API with Swagger/OpenAPI documentation
- Automatically generate a strongly-typed HTTP client from Swagger/OpenAPI specifications using NSwag
- Consume the generated client to interact with the API endpoints

## Project Overview
- **ASP.NET Core Web API** (.NET 9) with controller-based endpoints
- **Swagger UI** integration for interactive API documentation
- **NSwag-based client generation** from OpenAPI specifications
- **Sample endpoints:**
  - GET /api/User/{id} - Retrieves user information by ID
  - GET /WeatherForecast - Returns weather forecast data

## Project Structure

```
SwaggerApiClientLab2/
├── Controllers/
│   └── UserController.cs          # Sample API controller
├── ClientGenerator.cs             # NSwag client generation utility
├── GeneratedApiClient.cs          # Auto-generated API client (NSwag output)
├── Program.cs                     # Application entry point
└── SwaggerApiClientLab2.csproj   # Project file
```

## Development Workflow
1.	Start the API server (app.Run())
2.	Generate the client (run ClientGenerator.GenerateClient())
3.	Use the generated client to make type-safe API calls
4.	Iterate: Modify API → Regenerate client → Update consuming code
