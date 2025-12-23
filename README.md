# BankAccountapp
Bank Account Management System (OOP Based – C# WinForms)
<img width="797" height="484" alt="Screenshot 2025-12-23 194715" src="https://github.com/user-attachments/assets/7ed7d211-b46e-451e-8624-d86221617977" />


An **Object-Oriented Programming (OOP) based Bank Account Management System** developed using **C# and Windows Forms**.  
This project demonstrates real-world banking operations while applying core OOP principles such as **Encapsulation, Inheritance, Abstraction, and Polymorphism**.

🎯 Project Objective

To build a simple banking application that:
- Uses **OOP concepts in C#**
- Separates **business logic** from **UI**
- Demonstrates inheritance and polymorphism through different account types

-  OOP Concepts Used (With Code Mapping)

### 1️⃣ Class & Object
- `BankAccount` and `SavingAccount` represent real-world entities.
- Accounts are created as objects at runtime.

### 2️⃣ Encapsulation
```csharp
public decimal Balance { get; protected set; }
