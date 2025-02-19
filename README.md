# PlatformService

initial build

1. Created initial Web API project with `dotnet new webapi`
2. Added Entity Framework Core packages:
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.Design
   dotnet add package Microsoft.EntityFrameworkCore.InMemory
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   ```
3. Added AutoMapper for object mapping
   ```bash
   dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
   ```
4. Added Swagger/OpenAPI support and code style packages
   ```bash
   dotnet add package Microsoft.AspNetCore.OpenApi
   dotnet add package Swashbuckle.AspNetCore
   dotnet add package Microsoft.CodeAnalysis.CSharp.CodeStyle
   ```

5. Run the project:
   ```bash
   dotnet run
   ```
   This will start the service on http://localhost:5000 (HTTP) and https://localhost:5001 (HTTPS)
   
   You can access the Swagger UI at https://localhost:5001/swagger to test the API endpoints.
