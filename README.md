# Population Reporting System

## Project Overview
This project is a population reporting system. It uses a C# backend with SQL Server as the database. The backend is exposed via an ASP.NET Core Web API.

## Getting Started

### Prerequisites
- Docker
- .NET Core SDK for building backend
- Docker Compose for managing containers

### Running the Backend and Database
1. Clone this repository.
2. Ensure Docker is installed and running.
3. From the root directory, run the following command to start all services (backend, database):
   ```bash
   docker-compose up --build
