# AngularApiNetCore

ASP.NET Core 2.1 Web API with SQL Server

File -> New -> Project -> Asp.Net Core Web Application -> API

1. Package Manager - Install EntityFrameworkCore
   1.1 install-package Microsoft.EntityFrameworkCore.SqlServer
   1.2 install-package Microsoft.EntityFrameworkCore.SqlServer.Designer
   1.3 install-package Microsoft.EntityFrameworkCore.Tools
2. appsettings.json
   2.1 "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=True"
  },
3. Create folder Models
   3.1 Create class
4. Create folder Data
   4.1 Create folder Context.cs
   4.2 Configure service Context in startup.cs
   4.3 Create class DummyData.cs
   4.4 Initialize DummyData.cs in startup.cs
5. Migration
   5.1 Add-migration InitialCreate -o Data/Migrations
   5.2 Update-Database
   5.3 Execute API para inserir dados no banco (item 4.4)
6. Add Controllers (20 min)
   6.1 Api Controller with actions using EF
   6.2 Configure Lazzy Loading in Controller
   6.3 Configure Routes in launchSettings.json
