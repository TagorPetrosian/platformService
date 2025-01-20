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
4. Added Swagger/OpenAPI support
   ```bash
   dotnet add package Microsoft.AspNetCore.OpenApi
   dotnet add package Swashbuckle.AspNetCore
   ```
