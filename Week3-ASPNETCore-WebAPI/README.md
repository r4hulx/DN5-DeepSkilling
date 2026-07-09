# 🚀 Week 3 - ASP.NET Core Web API

This repository contains the Week 3 assignment of the Cognizant DN 5.0 Deep Skilling Program.

The project demonstrates building a RESTful ASP.NET Core Web API integrated with SQL Server using Entity Framework Core.

---

# 📌 Topics Covered

- ASP.NET Core Web API
- Controllers
- Routing
- CRUD Operations
- Entity Framework Core
- SQL Server
- Dependency Injection
- DbContext
- EF Core Migrations
- Swagger / OpenAPI

---

# 🛠 Tech Stack

- ASP.NET Core 10.0
- C#
- Entity Framework Core
- SQL Server 2022 (Docker)
- Swagger UI
- Visual Studio Code

---

# 📂 Project Structure

```
StudentApi
│
├── Controllers
│   └── StudentsController.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── Models
│   └── Student.cs
│
├── Migrations
│
├── Properties
│
├── Program.cs
├── appsettings.json
├── StudentApi.csproj
```

---

# 📚 Features

- Create Student
- View All Students
- View Student By Id
- Update Student
- Delete Student

---

# 🗄 Database

Database: SQL Server

ORM: Entity Framework Core

Migration:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

# ▶️ Run the Project

Restore packages

```bash
dotnet restore
```

Run the project

```bash
dotnet run
```

Open Swagger

```
http://localhost:5042/swagger
```

---

# 📖 API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | /api/Students | Get all students |
| GET | /api/Students/{id} | Get student by id |
| POST | /api/Students | Create student |
| PUT | /api/Students/{id} | Update student |
| DELETE | /api/Students/{id} | Delete student |

---

# 👨‍💻 Author

**Rahul Das**

B.Tech Computer Science Engineering

Cognizant DN 5.0 Deep Skilling Program