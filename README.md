# FameFinds – Location-Based Shop Discovery Platform

FameFinds is a monolithic web application that helps users discover famous products and cultural specialties of different cities.  
The platform also enables local businesses and artisans to promote and market their products digitally, improving visibility and customer reach through a centralized system.

The application supports location-based shop discovery using geographic data and map-based navigation.

---

## 🚀 Key Features

- Monolithic web application with clear separation of concerns
- OTP-based user account creation with email verification
- Supports two user roles: **Shop Owner** and **Customer**
- Secure authentication using JWT and role-based authorization
- Location-based shop discovery using map integration
- Add and manage shops by selecting location on the map
- Google Maps integration for navigation and directions
- Advanced search, filtering, and category-based listings
- Ratings and reviews for shops and products
- Global exception handling and request validation
- Optimized data access using EF Core and Dapper
- Modular and reusable frontend components

---

## 🧩 Application Modules

- **User Module:**  
  Authentication, OTP-based account creation, email verification, role-based authorization (Shop Owner & Customer), and profile management

- **Shop Module:**  
  Shop registration, shop details, categories, and location data using map integration

- **Search Module:**  
  Location-based search, filtering, and category-wise discovery

- **Review Module:**  
  Ratings and reviews for shops and products

- **Notification Module:**  
  Email-based notifications and verification messages

---

## 🏗️ Architecture Overview

- Monolithic application with layered architecture  
- Controllers handle HTTP requests and responses  
- Services contain business logic  
- Repositories manage database operations  
- External services integrated for maps and email notifications

---

## 🔄 Data Flow

- User sends request from client (web UI)
- API controller processes the request
- Service layer applies business logic
- Repository layer interacts with the database
- Response is returned to the client

---

## 🧰 Technologies Used

- **Backend:** C#, ASP.NET Core, REST APIs, JWT, EF Core, Dapper, LINQ  
- **Database:** SQL Server  
- **Frontend:** Angular, TypeScript  
- **Maps & Location Services:** Google Maps API    
- **Testing:** Unit Testing  
- **Version Control:** Git, GitHub

---

## ⚙️ Setup & Installation

1. Clone the repository  
   ```bash
   git clone https://github.com/jesuisPraful/FameFinds.git
