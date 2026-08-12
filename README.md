# 🎓 Student Management System

A full-stack **Student Management System** built using **ASP.NET Core MVC, C#, Entity Framework Core, and SQL Server**.

The application allows administrators to manage student records, courses, and reports through a clean and responsive web interface.

## 🚀 Features

### 👨‍🎓 Student Management

* Add new students
* View all students
* View student details
* Edit student information
* Delete students
* Search students
* Dynamic course selection
* Student dashboard

### 📚 Course Management

* Add courses
* View available courses
* Edit course information
* Delete courses
* Display courses dynamically in the Student form

### 📊 Dashboard & Reports

* Total students
* Total courses
* Male students
* Female students
* Student statistics
* Reports dashboard

### 🎨 User Interface

* Responsive Bootstrap UI
* Modern dashboard cards
* Bootstrap Icons
* Professional forms
* Student details profile page
* Confirmation page before deleting records

## 🛠️ Technologies Used

| Technology            | Purpose                   |
| --------------------- | ------------------------- |
| C#                    | Backend programming       |
| ASP.NET Core MVC      | Web application framework |
| Entity Framework Core | Database access / ORM     |
| SQL Server            | Database                  |
| LINQ                  | Data querying             |
| Razor Views           | Frontend                  |
| HTML                  | Page structure            |
| CSS                   | Styling                   |
| Bootstrap             | Responsive UI             |
| Bootstrap Icons       | UI icons                  |

## 🏗️ Project Architecture

```text
StudentManagement
│
├── Controllers
│   ├── StudentController.cs
│   ├── CourseController.cs
│   └── ReportController.cs
│
├── Models
│   ├── Student.cs
│   └── Course.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── Views
│   ├── Student
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   │
│   ├── Course
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   │
│   └── Report
│       └── Index.cshtml
│
├── wwwroot
│   └── css
│       └── site.css
│
├── Program.cs
├── appsettings.json
└── StudentManagement.csproj
```

## 🔄 CRUD Operations

The Student module implements all four CRUD operations:

### Create

```csharp
_context.Students.Add(student);
_context.SaveChanges();
```

### Read

```csharp
var students = _context.Students.ToList();
```

### Update

```csharp
_context.Students.Update(student);
_context.SaveChanges();
```

### Delete

```csharp
_context.Students.Remove(student);
_context.SaveChanges();
```

## 🔎 LINQ Queries

The project uses LINQ for database querying and reporting.

### Search Students

```csharp
var students = _context.Students
    .Where(x => x.Name.Contains(search))
    .ToList();
```

### Count Students

```csharp
var totalStudents = _context.Students.Count();
```

### Count Students by Gender

```csharp
var maleStudents = _context.Students
    .Count(x => x.Gender == "Male");
```

### Average Age

```csharp
var averageAge = _context.Students
    .Average(x => x.Age);
```

## 🗄️ Database

The application uses **SQL Server** with **Entity Framework Core**.

Main database tables:

```text
Students
Courses
```

Entity Framework Core is used to perform database operations without writing SQL for every CRUD operation.

## ⚙️ How to Run the Project

### 1. Clone the repository

```bash
git clone https://github.com/TubaShaikh446/StudentManagementSystem.git
```

### 2. Open the project

Open:

```text
StudentManagement.sln
```

using Visual Studio.

### 3. Configure SQL Server

Update the connection string in:

```text
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=StudentDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

Use the SQL Server instance available on your machine.

### 4. Apply migrations

Open Package Manager Console and run:

```powershell
Update-Database
```

### 5. Run the application

Press:

```text
Ctrl + F5
```

or click **Run** in Visual Studio.

## 📌 Learning Outcomes

This project helped me understand:

* ASP.NET Core MVC
* MVC architecture
* Controllers and Actions
* Razor Views
* Model Binding
* Dependency Injection
* Entity Framework Core
* SQL Server database connectivity
* CRUD operations
* LINQ queries
* Database migrations
* Bootstrap UI development
* Form validation
* Search and filtering
* Dashboard statistics

## 🔮 Future Improvements

* Admin authentication and authorization
* Pagination
* Advanced student filtering
* Export reports to Excel/PDF
* Charts and analytics
* Student profile photo upload
* Role-based access control
* Deployment to Microsoft Azure

## 👩‍💻 Author

**Tuba Shaikh**

GitHub:
https://github.com/TubaShaikh446

## ⭐ Project

If you find this project useful, consider giving the repository a ⭐ on GitHub.
