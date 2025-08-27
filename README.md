# 🔐 JWT Authentication with Refresh Token - ASP.NET Core

Educational implementation demonstrating JWT authentication with refresh token mechanisms in ASP.NET Core Web API.

## ✨ Features

- JWT Authentication with Access & Refresh tokens
- Token rotation for security
- Role-based authorization
- ASP.NET Core Identity integration
- Persistent token storage with expiration

## 🛠️ Tech Stack

- ASP.NET Core 5/6 Web API
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity

## 🚀 Quick Start

1. **Clone & Setup**
   ```bash
   git clone <repo-url>
   cd project-folder
   ```

2. **Configure Database**
   Update `appsettings.json` with your SQL Server connection string

3. **Run Migrations**
   ```bash
   dotnet ef database update
   ```

4. **Start Application**
   ```bash
   dotnet run
   ```

5. **Test with Postman**
   - `POST /api/auth/register` - Register user
   - `POST /api/auth/login` - Login & get tokens
   - `POST /api/auth/refresh` - Refresh expired tokens

## 🎓 Learning Goals

- Understand JWT token issuance and validation
- Implement secure token rotation
- Integrate refresh tokens with ASP.NET Core Identity

## ⚠️ Disclaimer

**Educational use only.** Not production-ready. Follow security best practices for production systems.
