# Week 2 - Entity Framework Core & ASP.NET Core Web API

## 📌 Overview

This project is part of the Cognizant DN 5.0 Deep Skilling Program.

It demonstrates the implementation of a RESTful Web API using ASP.NET Core and Entity Framework Core with SQL Server. The project follows a layered architecture and includes JWT Authentication, Dependency Injection, DTOs, Validation, Exception Handling, and CRUD operations.

---

## 🚀 Features

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server Database
- Docker SQL Server
- CRUD Operations
- DTO Pattern
- Model Validation
- Dependency Injection
- Service Layer Architecture
- Global Exception Handling Middleware
- Logging
- JWT Authentication
- JWT Authorization
- Protected APIs

---

## 🛠️ Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Docker
- Swagger
- JWT Authentication
- C#
- REST API

---

## 📁 Project Structure

```text
StudentApi
│
├── Controllers
│   ├── StudentsController.cs
│   └── AuthController.cs
│
├── Models
│   ├── Student.cs
│   └── User.cs
│
├── DTOs
│   ├── StudentDto.cs
│   ├── CreateStudentDto.cs
│   ├── UpdateStudentDto.cs
│   ├── LoginDto.cs
│   └── RegisterDto.cs
│
├── Services
│   ├── IStudentService.cs
│   ├── StudentService.cs
│   ├── IAuthService.cs
│   └── AuthService.cs
│
├── Middleware
│   └── ExceptionMiddleware.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── StudentApi.csproj
```

---

## 📌 API Endpoints

### Authentication

| Method | Endpoint | Description |
|---------|----------|-------------|
| POST | `/api/Auth/register` | Register a new user |
| POST | `/api/Auth/login` | Login and generate JWT |

### Students

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | `/api/Students` | Get all students |
| GET | `/api/Students/{id}` | Get student by ID |
| POST | `/api/Students` | Create a new student |
| PUT | `/api/Students/{id}` | Update student |
| DELETE | `/api/Students/{id}` | Delete student |

---

## 🔒 Authentication

JWT Authentication has been implemented.

Authenticated users can access protected Student APIs.

---

## ▶️ How to Run

### Clone Repository

```bash
git clone <repository-url>
```

### Navigate

```bash
cd StudentApi
```

### Restore Packages

```bash
dotnet restore
```

### Apply Migrations

```bash
dotnet ef database update
```

### Run Project

```bash
dotnet run
```

### Open Swagger

```
http://localhost:5174/swagger
```

---

## 🎯 Learning Outcomes

Through this project I learned:

- Building REST APIs with ASP.NET Core
- Entity Framework Core
- SQL Server Integration
- CRUD Operations
- DTO Pattern
- Dependency Injection
- Service Layer Architecture
- Global Exception Handling
- JWT Authentication & Authorization
- Swagger API Testing

---

## 👨‍💻 Author

**Rahul Das**

B.Tech Computer Science Engineering

Cognizant DN 5.0 Deep Skilling Program