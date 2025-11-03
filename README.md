Project:** Disaster Alleviation Foundation (C# MVC Web App)

## 🧩 **1. Project Overview**

The **Disaster Alleviation Foundation** web application is designed to assist with managing disaster relief efforts.
It enables users to report incidents, donate essential resources, and register as volunteers to help affected communities.

The system is developed using **ASP.NET Core MVC** and connected to an **Azure SQL Database**.
Version control and continuous integration are handled through **Azure DevOps**, using **Azure Repos** for source management and **Azure Pipelines** for automated builds and deployments.

 Implemented Features**

**User Registration & Login**

* Secure account creation, login, and logout functionality.
* Password hashing and user data validation.
* Role-based access for administrators and volunteers.

**Disaster Reporting**

* Allows users to report disaster incidents with location, type, and description.
* Information is stored in the connected Azure SQL database.

**Resource Donation**

* Users can donate resources such as food, water, and clothing.
* Donations are tracked and managed by administrators.

**Volunteer Management**

* Volunteers can register and view available relief tasks.
* Admins can assign and monitor volunteer activities.

---

## 💻 **3. Tools and Technologies Used**

* **ASP.NET Core MVC (C#)** – Web application framework
* **Azure SQL Database** – Data storage
* **Azure Repos** – Version control system
* **Azure Pipelines** – Continuous integration and deployment
* **Visual Studio 2022** – Development environment
* **Entity Framework Core** – ORM for database operations
* **Bootstrap / CSS** – Front-end styling

---
## 📊 Testing & Quality Assurance

### ✅ Comprehensive Test Coverage
- **Unit Testing**: 85%+ code coverage for core business logic using MSTest
- **Integration Testing**: Verified database interactions and API endpoints
- **Load Testing**: Handled 100+ concurrent users via Azure Load Testing
- **Stress Testing**: Identified system breaking points and bottlenecks
- **UI Testing**: Validated all user interface functionality and workflows

### 🚀 Automated Deployment
- **CI/CD Pipeline**: Azure DevOps automates build, test, and deployment to Azure App Services
- **Zero-Downtime Deployments**: Rolling updates with proper rollback mechanisms
- **Quality Gates**: Automated testing prevents broken code from reaching production

## 🏁 **Conclusion**

The Disaster Alleviation Foundation web application demonstrates how technology can streamline disaster management through efficient reporting, donation tracking, and volunteer coordination.
It successfully integrates cloud-based tools for scalability and automation, providing a reliable foundation for future enhancements and real-world implementation.

---


