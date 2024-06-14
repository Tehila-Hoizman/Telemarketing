# Telemarketing Management System

Telemarketing is a desktop application for managing telemarketing campaigns. It provides tools for creating, monitoring, and analyzing telemarketing campaigns efficiently.

## Architecture Overview

The Telemarketing Project follows a three-tier architecture model:

- **Data Access Layer (DAL)**: Responsible for interacting with the database, including CRUD (Create, Read, Update, Delete) operations and data manipulation. Uses Microsoft Access as the underlying database.

- **Graphical User Interface (GUI)**: Provides a user-friendly interface for users to interact with the application. Built using WinForms technology, allowing for intuitive navigation and data entry.

- **Business Logic Layer (BLL)**: Contains the core logic of the application, including business rules, validation, and processing. Acts as an intermediary between the GUI and DAL, ensuring data integrity and consistency.

## Features

**Manager**: Time tracking, shift management, project management, call management, viewing employee data.
**Employee**: Donor management, donation processing, dialing donors, handling missed calls, viewing project data.

## Database

The Telemarketing application uses Microsoft Access as its underlying database. Access is a relational database management system (RDBMS) that provides a convenient and user-friendly way to store and manage data.

## Installation

1. Clone the repository:

    ```
    git clone https://github.com/tehila0601/Telemarketing.git
    ```

2. Open the solution file `Telemarketing.sln` in Visual Studio.

3. Build and run the application from Visual Studio.

## Login Credentials

To access the application, please use the following credentials:

- **Username:** tehila0601
- **Password:** Aa12345678
  
## Technologies Used

- WinForms: A graphical user interface framework for .NET applications.

## Directory Structure

The project directory is organized as follows:

- **DAL**: Contains the data access layer components, including database access and data manipulation logic.
- **GUI**: Contains the graphical user interface components, including forms, controls, and event handlers.
- **BLL**: Contains the business logic layer components, including business rules, validation, and processing logic.



