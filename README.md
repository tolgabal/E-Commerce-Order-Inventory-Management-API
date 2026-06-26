# E-Commerce Order & Inventory Management API 🚀

An enterprise-grade, architecturally rich "Core Backend" project designed to demonstrate production-ready design patterns, modern architectural principles, and advanced .NET mechanisms.

## 🎯 Project Overview
This project is a high-performance, scalable Order & Inventory Management API. Instead of focused on a massive business domain, it deeply focuses on architectural decisions, clean code practices, and answering the ultimate interview question: *"Why did you design it this way?"*

## 🏛️ Architectural & Design Patterns
This project acts as a playground for the following design patterns and mechanisms:

* **CQRS Pattern (with MediatR):** Separating read and write operations to optimize performance and maintainability.
* **Repository & Unit of Work Pattern:** Abstracting the data access layer and ensuring transactional integrity across multiple operations.
* **Dependency Injection (DI) Lifetimes:** Deep dive into `Transient`, `Scoped`, and `Singleton` behaviors by intentionally breaking and fixing dependencies.
* **Global Exception Handling:** Centralizing error management using a custom ASP.NET Core Middleware.

## 🛠️ Tech Stack
* **Platform:** .NET 8 / .NET 9 (Web API)
* **Database:** SQL Server
* **ORM:** Entity Framework Core
* **Libraries:** MediatR, FluentValidation (Optional but recommended)

## 🗺️ Roadmap / Progress
- [ ] Step 1: Professional GitHub Repo & Architecture Design
- [ ] Step 2: Setting up Domain Models & Database (EF Core)
- [ ] Step 3: Implementing Repository & Unit of Work
- [ ] Step 4: Introducing CQRS & MediatR
- [ ] Step 5: Master Class on Dependency Injection Lifetimes
- [ ] Step 6: Global Exception Middleware & Validation