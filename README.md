# PD2 Trade API

PD2 Trade API Written in C# .NET 5 -

This is an UNOFFICIAL trade api of https://projectdiablo2.com
. Hoping to become the official trade api of Project Diablo 2 -

** WARNING - USE OF THIS WEBSITE CAN AND WILL RESULT IN A PERMANENT BAN FROM Project Diablo 2 SERVERS WHILE IN UNOFFICIAL STATE. **

## Contributing
1) Fork the repository to your own github account - Working branch is `develop`
2) Push code to your fork
3) Open PR from your repository to the `develop` branch

### Pre-requisites
1) .NET 5 Runtime
2) .NET 5 SDK
3) ASP.NET Libraries
4) Local MySQL Server

### Setup
1) Open the .sln file at the root of the project
2) Configure appsettings.Development.json to match your local MySQL Instance Settings
2) Click the play button to run the projec

### Main Libraries
1) Entity Framework
2) ASP.NET

### Creating Database Migrations (Visual Studio):

- Open `Package Manager Console` (Tools -> Nuget Package Manager -> PMC)
- Change `Default project` to `src\Data`
- Execute `Add-Migration` command providing a name (Proper Case naming standard) for the database migration
 
```
    add-migration MigrationName
```
