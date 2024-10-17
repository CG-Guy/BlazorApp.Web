# C# Development Test

**Test Details:**
- **Duration:** 5 hours
- **Sections:** 
  - Section A: C# RESTful API Development
  - Section B: SQL Database Interaction
  - Section C: Basic Blazor Frontend Development

- **Submission Requirements:** Zip file with your full name, including the solution code and a backup of the database.
  
## Project Overview

This test is divided into three sections: C# RESTful API development, SQL database interaction, and a basic Blazor frontend. You are expected to complete all three sections, adhering to the provided instructions. Bonus points are awarded for advanced implementations and optimizations.

---

## Section A: C# RESTful API Development

1. **API Endpoint Creation**  
   - Create an ASP.NET Core Web API project.
   - Implement an API endpoint that retrieves all users from a SQL Server database via HTTP GET at `/api/users`.
   
2. **Database Connection (DatabaseHelper)**  
   - Use ADO.NET to interact with the SQL Server database.
   - Define the connection string in `appsettings.json`.
   
3. **Controller Implementation**  
   - Create a `UserController` that depends on `DatabaseHelper` for database operations.
   - Return the user list as JSON.
   
4. **Logging with Delegate**  
   - Implement logging using a `LogEventDelegate`.
   - Log critical events like API access, database connection, and errors.

5. **Testing**
   - Test the API endpoint using Postman or a similar tool and provide screenshots.

---

## Section B: SQL Database Interaction

1. **Database Structure**  
   Create three tables:
   - **Users**: `UserId`, `FirstName`, `LastName`, `Email`, `CreatedAt`.
   - **Posts**: `PostId`, `UserId`, `Title`, `Content`, `CreatedAt`.
   - **Comments**: `CommentId`, `PostId`, `CommenterName`, `CommentText`, `CreatedAt`.
   
2. **SQL Queries**  
   - Retrieve all users.
   - Get posts by user ID 5.
   - Insert a new comment into `Comments` for post ID 10.
   - Delete comments for post ID 15.
   
3. **Schema Improvements**  
   - Improve table structures for scalability and performance.
   - Normalize tables, adjust data types, and implement indexing.
   
4. **Query Enhancement**  
   - Review provided SQL queries and optimize for readability and efficiency.

---

## Section C: Basic Blazor Frontend Development

1. **Blazor App Creation**  
   - Create a Blazor WebAssembly project.
   - Set up API communication for retrieving user data from the RESTful API.
   
2. **API Integration & Display**  
   - Fetch and display user data in a Blazor component.
   - Use data binding to present the user details.
   
3. **UI Enhancements**  
   - Implement pagination, sorting, or search features.
   - Ensure the interface handles large datasets smoothly.

4. **Bonus Points**  
   - Follow SOLID principles.
   - Use asynchronous programming to keep the UI responsive.
   - Handle API errors gracefully.

---

## Instructions for Running the Project

### Prerequisites:
- .NET SDK 6.0+
- SQL Server
- Visual Studio 2022 or any compatible IDE
- Postman (or similar tool)

### Steps:
1. **Clone the repository**  
   ```bash
   git clone <repository-url>
   ```

2. **Database Setup**
   - Restore the database backup file provided in the zip.
   - Configure the connection string in `appsettings.json`.

3. **Running the API**
   - Navigate to the API project directory:
     ```bash
     cd ApiProjectDirectory
     ```
   - Run the project:
     ```bash
     dotnet run
     ```

4. **Running the Blazor App**
   - Navigate to the Blazor project directory:
     ```bash
     cd BlazorProjectDirectory
     ```
   - Run the project:
     ```bash
     dotnet run
     ```

### Testing:
- Use Postman to test the API at `http://localhost:<port>/api/users`.
- Open the Blazor frontend in a browser to view user data.

---

### Bonus Points:
- Delegate-based logging.
- Database schema and query optimization.
- UI enhancements (pagination, sorting, search).
