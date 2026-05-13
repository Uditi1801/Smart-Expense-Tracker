# Smart Expense Tracker 💸

A desktop-based personal finance management application built using **C#, .NET, and Avalonia UI** that helps users efficiently track income and expenses through a clean graphical interface.

## Overview

Smart Expense Tracker is a desktop application designed to simplify personal finance management by allowing users to record, monitor, and manage their financial transactions in an organized way.

The application was developed as part of an **Object-Oriented Programming project**, with a focus on applying practical software development concepts such as problem solving, OOP design, UI development, and file handling.

---

## Features ✨

* Add **Income** and **Expense** transactions
* Categorize transactions for better organization
* Record transaction details including:

  * Transaction Type
  * Category
  * Amount
  * Notes
  * Date
* View complete transaction history
* Delete selected transactions
* Automatic calculation of:

  * Total Income
  * Total Expenses
  * Current Balance
* Persistent data storage using **JSON**
* User-friendly desktop graphical interface

---

## Tech Stack 🛠️

**Programming Language**

* C#

**Framework**

* .NET

**UI Framework**

* Avalonia UI

**Data Storage**

* JSON File Handling

**Concepts Applied**

* Object-Oriented Programming (OOP)
* Encapsulation
* Separation of Concerns
* File Handling
* GUI Development
* Application Logic Design

---

## Project Structure 📂

```text
SmartExpenseTrackerGUI/
│
├── Models/
│   └── Transaction.cs
│
├── Services/
│   └── FileService.cs
│
├── MainWindow.axaml
├── MainWindow.axaml.cs
├── App.axaml
├── App.axaml.cs
├── Program.cs
├── SmartExpenseTrackerGUI.csproj
├── SmartExpenseTrackerGUI.sln
└── transactions.json
```

---

## How It Works ⚙️

1. Launch the application
2. Select transaction type (**Income / Expense**)
3. Choose the relevant category
4. Enter the amount
5. Add optional notes
6. Select the transaction date
7. Click **Add Transaction**
8. View transaction history instantly
9. Monitor updated totals:

   * Income
   * Expenses
   * Remaining Balance
10. Data is automatically saved in the JSON file for persistence

---

## OOP Design Implementation 🧠

### Transaction Class

Represents each financial transaction with properties such as:

* Unique Transaction ID
* Transaction Type
* Category
* Amount
* Notes
* Date

### FileService Class

Responsible for:

* Saving transaction data
* Loading saved transactions
* Managing JSON file operations

This separation ensures cleaner architecture and better maintainability.

---

## Demo Video 🎥

Project demonstration:

https://www.youtube.com/watch?v=xFodJqz779Q

---

## Screenshots 📸

*Add application screenshots here*

Example:

* Main dashboard
* Transaction history view
* Income/expense demonstration

---

## Learning Outcomes 📚

Through this project, I strengthened my understanding of:

* Object-Oriented Programming
* Desktop GUI development
* File handling and JSON serialization
* Application architecture
* Data persistence
* Problem-solving through practical implementation

---

## Future Improvements 🚀

Potential enhancements:

* Monthly analytics dashboard
* Expense filtering and search
* Budget setting functionality
* Charts and financial insights
* CSV export support
* Database integration (SQLite)
* Dark/Light theme toggle

---

## Author 👩‍💻

**Uditi**

Software Engineering student passionate about software development, problem solving, and building practical applications.

---

## License

This project is created for educational and portfolio purposes.
