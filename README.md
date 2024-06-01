# Candidate Management API

This API provides functionalities to manage candidates using a repository pattern with Entity Framework Core, Making use of the new features like Primary Constrctuor, Top-level namespace and Minimal API.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Configuration](#configuration)
  - [Running the Application](#running-the-application)
- [API Endpoints](#api-endpoints)
  - [Add or Update Candidate](#add-or-update-candidate)

## Introduction

The Candidate Management API is built with .NET and utilizes Entity Framework Core to interact with a SQL Server database. It follows a generic repository pattern to ensure a clean separation of concerns and reusable data access logic.

## Features

- Add or update candidate records.
- Asynchronous operations for better performance and scalability.
- Repository pattern for flexible data access.

## Technologies Used

- .NET 8
- Entity Framework Core
- SQL Server

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server
- Visual Studio or any C# IDE

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/3bdlrhman/Candidate.git
    cd Candidate.git
    ```

2. Restore the dependencies:
    ```bash
    dotnet restore
    ```

### Configuration

1. Update the connection string in `appsettings.json`:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;"
      }
    }
    ```

### Running the Application

1. Apply migrations and update the database:
    ```bash
    dotnet ef database update
    ```

2. Run the application:
    ```bash
    dotnet run
    ```

## API Endpoints

### Add or Update Candidate

- **URL**: `/candidates`
- **Method**: `POST`
- **Request Body**:
    ```json
    {
    "Email": "abdoAhmed@gmail.com",
    "FirstName": "Abdo01",
    "LastName": "Ahmed01",
    "PhoneNumber": "011247067",
    "BestCallTime": "10 AM",
    "LinkedInProfile": "/linprof",
    "GitHubProfile": "/gitprof",
    "Comment": "nocomment"
   }
    ```
- **Response**: `200 OK`

