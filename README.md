# UserManagementAPI

A simple learning project built to practice designing and developing RESTful APIs using **ASP.NET Core**.

---

## Overview

This project demonstrates the fundamentals of building a clean, structured, and secure API.  
It includes user management operations, validation, error handling, logging, and token‑based authentication.

---

## Technologies Used

- ASP.NET Core Web API  
- Entity Framework Core  
- SQL Server  
- AutoMapper  
- FluentValidation  
- JWT Authentication  
- Custom Middleware (Logging, Error Handling, Authentication)  
- Dependency Injection  
- REST Architecture  

---

## Features

- Create, update, delete, and retrieve users  
- Input validation with FluentValidation  
- Global exception handling  
- Request/response logging middleware  
- JWT‑based authentication  
- Clean service‑repository architecture  
- Pagination for improved performance  

---

## Project Structure

```txt
UserManagementAPI/
│
├── Controllers/
│   └── UsersController.cs
│       Handles all HTTP endpoints for user operations.
│
├── DTOs/
│   ├── UserCreateDto.cs
│   ├── UserUpdateDto.cs
│   ├── UserResponseDto.cs
│   └── PagedResult.cs
│       Data transfer objects used for requests and responses.
│
├── Middleware/
│   ├── ExceptionMiddleware.cs
│       Catches unhandled exceptions and returns standardized error responses.
│   └── RequestResponseLoggingMiddleware.cs
│       Logs all incoming requests and outgoing responses.
│
├── Models/
│   └── User.cs
│       Entity model representing a user in the database.
│
├── Repositories/
│   ├── IUserRepository.cs
│   └── UserRepository.cs
│       Data access layer responsible for interacting with the database.
│
├── Services/
│   ├── IUserService.cs
│   └── UserService.cs
│       Business logic layer for user operations.
│
├── Validators/
│   ├── UserCreateValidator.cs
│   └── UserUpdateValidator.cs
│       FluentValidation rules for validating incoming user data.
│
├── Mappings/
│   └── MappingProfile.cs
│       AutoMapper configuration for mapping between entities and DTOs.
│
├── appsettings.json
│       Application configuration (database connection, JWT settings, etc.).
│
└── Program.cs
        Application entry point and middleware pipeline configuration.
