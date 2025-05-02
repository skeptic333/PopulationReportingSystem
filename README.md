 Population Reporting System

 📌 Project Overview
This is a **desktop-based population reporting system** developed in **C# (WinForms)** with **SQL Server** as the backend database. The application generates detailed reports about population, countries, cities, and languages, as per real-world reporting needs.

  Technologies Used
- C# (.NET Framework or .NET Core) – WinForms GUI
- SQL Server
- Docker (for containerized SQL setup)
- Git & GitHub (for version control)
- GitHub Actions (CI/CD - setup in progress)

 Getting Started

 Prerequisites
- Visual Studio (with .NET Desktop Development workload)
- SQL Server (local or via Docker)
- Docker Desktop (optional, for database container)
- .NET SDK (for WinForms)

 How to Run the Application

 Option 1: Run SQL Server via Docker
```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Pass123" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
