# Expense Tracker API
The Express Tracker API is a simple RESTFULL API built with ASP.NET Core to manage user expenses. It allows users to track their daily expenses and associate them with their user profiles. The application communicates with a SQL Server database using Entity Framework Core. 

---

## Developer
Eldhose Salby

---

## Project Requirements
- Application must build and run.
- ERD of the database.
- README that describes the application and its functionalities.
- The application should be ASP.NET Core application.
- The application should have unit tests and at least 20% coverage (at least 5 unit tests that tests 5 different methods/functionality of your code).
- The application should communicate via HTTP(s) (Must have POST, GET, DELETE).
- The application should be RESTful API.
- The application should persist data to a SQL Server DB.
- The application should communicate to DB via EF Core (Entity Framework Core).
  
---

## Tech Stack
- C# (Back End Programming Language)
- SQL Server (Azure Hosted)
- EF Core (ORM Tech)
- ASP.NET (Web API Framework)
- Swagger (Demo purpose)
- xUnit (Unit testing)

---

## User Stories
- **As a user**, I want to be able to add a new expense so that I can track my spending.
- **As a user**, I want to view all expenses and view by userId. 
- **As a user**, I want to be able to view all of my expenses so that I can see a summary of my expenditures.
- **As a user**, I want to be able to delete an expense when it was added by mistake.
- **As a user**, I want to delete and add a category and also view all categories.
- **As a user**, I want to be able to assign an expense to a category (e.g., Food, Transport) so that I can better organize and analyze my spending.

---

## ER Diagram
![alt text](<ER diagram.png>)

---

## MVP Goals
- Implement the ability for users to add, view, and delete expenses with category associations.
- Ensure that all user data and expenses are stored securely in a SQL Server database using EF Core.
- Provide fast and correct responses from the API when interacting with endpoints.
- Implement Category functionality, allowing users to assign expenses to categories and view them categorized.
- Create unit tests for core functionality (add, view, delete expenses, and category assignment).
- Use Swagger or similar tools for basic API documentation to make it easy for users to interact with the API.

---
## Stretch Goals
- Provide detailed expense reports with charts and graphs.
- Increase test coverage with unit and integration tests.
- Build a frontend using React or a mobile app for better user access.
