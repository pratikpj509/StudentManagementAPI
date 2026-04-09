# 🎓 Student Management System (ASP.NET Core Web API)

## 📌 Project Overview

This project is a **Student Management System** developed using ASP.NET Core Web API.
It provides RESTful APIs to perform CRUD operations on student data with secure access using JWT Authentication.

---

## 🚀 Features

* Add Student
* Get All Students
* Get Student by ID
* Update Student
* Delete Student
* JWT Authentication (Secure APIs)
* Global Exception Handling (Middleware)
* Swagger API Documentation
* Layered Architecture

---

## 🛠️ Technologies Used

* ASP.NET Core Web API
* Entity Framework Core (Code-First)
* SQL Server (LocalDB)
* JWT Authentication
* Swagger (Swashbuckle)

---

## 🏗️ System Architecture

![Image](https://images.openai.com/static-rsc-4/k3F4vIccxn3CpqDtJWkdRL4XwrVQxox-QPrC8MizfqB4cgxABymiNQWVpm0pjmA6toih8-hU5UkNbR9NgQXWu7wtxGDBdeGaRTJuJWO9epK_WVIhBOPuZbcfdvJrz3KMylLYTmejkJQn_6EArr7veA2KcNfbMSvxICsUqk7Ac6_mmSc8xMYCzLOjK-UusghV?purpose=fullsize)

![Image](https://images.openai.com/static-rsc-4/y2sPsCj8ZvfsKNEGVfK8NJcbC-8lSnJBFZnMH-JM7_TWA5HAx7gU1omnz6rS2ZJjWNorBoL6gICoqBy4ScUbPdPvhh-ZDasTTMTIFMxU9fQRsfQS0TFE-xKdpXrNB7aeGFtbBBPNPY1NwYjTZHLwG88JgbcEaBjvsHKCNmpHLwFGgOyNWwwB3BLl79ZFnN5s?purpose=fullsize)

![Image](https://images.openai.com/static-rsc-4/LFH4gIQp_i7K-IS3hygc_x-A9xAwZ64H9MdhKTOo3TPqECncyA9kkn4aa0C1hH5qSvx1BMFE8LZiE1BkssJXOZdgOpHYgh-JLxEdWZ9KdizSdIOv0n3u4RxbtfiuMPCqkDjHABeIND3DVP7PUiMdAkeGNMOk5XMbIg15Ss9Qo6Llo87dTpIHRBMDGXdGwQkY?purpose=fullsize)

![Image](https://images.openai.com/static-rsc-4/qP5-6UrHfxKZkSHtF7bOcCzNCgvekFtF4mkpQlW7G-bIzatYNX27T_uzIj5akbB78FrZ7NZqagTOyF7K4B1TWDMhl9lkDcH7-CtxzfaQx2WMZZq3nrGuyuCApXPz86S4IDdhuafr8_-hfAuKUyMoHWeLeCsIFSVohwZPO2IXl5kAFkjmq-e1ta-toeuENLcg?purpose=fullsize)

![Image](https://images.openai.com/static-rsc-4/3HuZicu1DgCiiEzMqf0rTikoeNxXq06wX5vZ_FTMEf331gVDbM5PBUtepF5glTGAcKLbQmjRbaayiL_U3cyCrVSzkA5Fovw4GKvWvIrKh76k4sSaK1ecVou7h8aDVA78DThkGVOAlBrDC5wm9Q5JmDibHwOFkwbR3yuAm1mNEuK5gYUHmXY7M0LSY-hpx9lt?purpose=fullsize)

The application follows a **Layered Architecture**:

* **Controller Layer** → Handles HTTP requests and responses
* **Service Layer** → Contains business logic
* **Repository Layer** → Handles database operations
* **Database Layer** → SQL Server using Entity Framework Core

### 🔄 Flow:

Client → Controller → Service → Repository → Database → Response

---

## 🗄️ Database Architecture



### 📊 Student Table Structure:

| Column Name | Data Type         |
| ----------- | ----------------- |
| Id          | int (Primary Key) |
| Name        | nvarchar          |
| Email       | nvarchar          |
| Age         | int               |
| Course      | nvarchar          |
| CreatedDate | datetime          |

---

## 🔐 Authentication (JWT)

* User logs in using username and password
* Server generates JWT token
* Token is sent in Authorization header
* Protected APIs require valid token

Example:
Authorization: Bearer <token>

---

## 📁 Project Structure

StudentManagementAPI/
│
├── Controllers/
├── Models/
├── Data/
├── Repository/
├── Services/
├── Middleware/
├── Helpers/
├── appsettings.json
└── Program.cs

---

## ⚙️ Setup Instructions

1. Clone the repository:
   git clone https://github.com/your-username/student-management-api.git

2. Open project in Visual Studio

3. Update connection string in appsettings.json

4. Run Migration:
   Add-Migration InitialCreate
   Update-Database

5. Run application:
   Press F5

6. Open Swagger:
   [https://localhost:xxxx/swagger](https://localhost:xxxx/swagger)

---

## 🧪 API Endpoints

### 🔐 Auth

POST /api/auth/login

### 📚 Student

GET /api/student
GET /api/student/{id}
POST /api/student
PUT /api/student
DELETE /api/student/{id}

---

## ⚠️ Error Handling

* Global Exception Middleware is implemented
* Returns proper HTTP status codes

---

## 📈 Future Enhancements

* Role-based authentication
* Input validation
* Logging using Serilog
* Frontend integration (React/Angular)

---

## 📌 Conclusion

This project demonstrates real-world API development using ASP.NET Core with secure authentication, clean architecture, and scalable design.
