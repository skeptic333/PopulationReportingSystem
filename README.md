Population Reporting System

Project Overview
This is a desktop-based population reporting system developed in C# with SQL Server as the backend database. The application generates reports about population, countries, and cities.

Technologies Used
- C# (.NET)
- SQL Server
- Docker
- Git & GitHub

Getting Started

Prerequisites
- Visual Studio
- SQL Server
- Docker Desktop
- .NET SDK

How to Run the Application

Run SQL Server via Docker
```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Pass123" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
