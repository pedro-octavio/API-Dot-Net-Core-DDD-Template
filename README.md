# API .NET CORE DDD TEMPLATE
The project API .Net Core DDD Template, is a model for .Net Core api using DDD design.
## PREREQUESITES
* [.Net Core](https://dotnet.microsoft.com/download);
* Some Database, in this case as using [MySql](https://www.mysql.com);
## CONFIGURING THE PROJECT
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in root directory
2) Insert your connectionstring in PROJECTName.API/appsettings.Development.json
3) Update database using this command:
> Visual Studio: Update-Database
> Terminal: dotnet  ef database update
4) Run the PROJECTName.API;
## MAKE WITH
* .Net Core
* Automapper
* EntityFramework Core
* FluentValidator
* Autofac
* MySql
## VERSIONS
* 1.0.0 - First Commit;
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*