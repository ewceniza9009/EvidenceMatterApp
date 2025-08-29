# APP

This is a server-side Blazor application for managing legal matters and their associated evidence.

## Features

  * **User Authentication**: Secure user registration and login using JWT.
  * **Matter Management**: Full CRUD (Create, Read, Update, Delete) functionality for legal matters.
  * **Evidence Management**: Full CRUD functionality for evidence, linked to specific matters.
  * **Filtering**: Filter evidence by the associated matter.
  * **Modern Architecture**: Utilizes the Repository Pattern, DTOs, and AutoMapper for a clean, scalable, and maintainable codebase.

-----

## 🛠️ Setup and Installation

Follow these steps to get the application running on your local machine.

### 1\. Prerequisites

Ensure you have the following software installed:

  * [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) (or the version specified in `BlazorApp1.csproj`)
  * [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express edition is sufficient)
  * A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/).

### 2\. Database Configuration

The application uses Entity Framework Core to manage the database.

**a. Update Connection String:**

Open the `appsettings.json` file. Locate the `ConnectionStrings` section and modify the `DefaultConnection` to point to your local SQL Server instance.

For example, if your server name is `(localdb)\mssqllocaldb`, the string would look like this:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=BlazorApp1Db;Trusted_Connection=True;MultipleActiveResultSets=true"
},
```

**b. Apply Migrations:**

The migrations to create the database schema are already included in the project. To apply them, open a terminal in the root directory of the project (where `BlazorApp1.csproj` is located) and run the following command:

```bash
dotnet ef database update
```

This will create a new database named `BlazorApp1Db` (or whatever you named it in the connection string) with all the necessary tables for users, matters, and evidence.

### 3\. Application Configuration

The `appsettings.json` file also contains the settings for JWT (JSON Web Tokens). The default secret key is for development purposes only. For a production environment, you should replace the `JWT:Secret` with a long, complex, and randomly generated string.

```json
"JWT": {
  "Secret": "THIS IS A SECURE SECRET KEY FOR JWT AUTHENTICATION",
  "Issuer": "https://localhost:7158",
  "Audience": "https://localhost:7158"
}
```

-----

## 🚀 Running the Application

Once the setup is complete, you can run the application from your terminal:

```bash
dotnet run
```

The application will launch, and you can access it in your web browser at the URL provided in the terminal output (e.g., `https://localhost:7158`).

-----

## 📁 Project Structure

Here is a brief overview of the key folders in the project:

  * `/Data`: Contains the `ApplicationDbContext` for Entity Framework Core.
  * `/Dtos`: Contains Data Transfer Objects used to shape data for the UI.
  * `/Mappings`: Contains the AutoMapper profiles for object-to-object mapping.
  * `/Models`: Contains the database entity models (`MattersModel`, `EvidenceModel`).
  * `/Pages`: Contains the Blazor components that make up the application's pages.
  * `/Repositories`: Contains the generic repository implementation for data access.
  * `/Shared`: Contains shared Blazor components like the main layout and navigation menu.
