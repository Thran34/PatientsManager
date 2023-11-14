# Requirements Specification - PatientsManager

## Table of Contents
- [General Requirements Description](#general-requirements-description)
- [Functionalities](#functionalities)
- [Architecture and Technology Choice](#architecture-and-technology-choice)
- [Architecture](#architecture)
- [Technologies](#technologies)
- [Running Instructions](#running-instructions)
- [API Documentation](#api-documentation)

## General Requirements Description

The aim of the project is to create a simple ASP.NET Core Web API application for patient registration in a medical clinic. The application will be used to store the medical data of the clinic's patients, such as disease history, allergies and upcoming visits.

### Functionalities

1. **Patient Registration:** The application allows adding new patients, storing basic personal information.

2. **Patient Data Editing:** Users can edit existing patient data.

3. **Patient List:** The application provides a list of registered patients.

4. **Patient Details:** Upon selecting a specific patient, the application displays detailed information, such as visit history.

5. **Adding Visits:** Ability to register new patient visits, including date, time, and purpose of the visit.

## Architecture and Technology Choice

### Architecture

The application will be based on a client-server architecture, where the client is the API interface, and the server is the database storing patient data. The proposed architecture is a three-tier architecture:

1. **Presentation Layer:** ASP.NET Core Web API - handling HTTP requests, processing input data, and returning responses.

2. **Business Layer:** Responsible for the application's business logic, entities, etc.

3. **Database Layer:** Database (e.g., Microsoft SQL Server) - storing patient data, visits, and other relevant information.

### Technologies

1. **ASP.NET Core:** The ASP.NET Core framework was chosen for building the presentation layer due to its flexibility, performance, and HTTP request handling capabilities.

2. **Entity Framework Core:** Chosen as the Object-Relational Mapping (ORM) for communication with the database.

3. **Microsoft SQL Server:** Selected as the database management system due to its popularity, stability, and support for Entity Framework Core.

4. **Swagger:** For API documentation and testing facilitation.

## Running Instructions

1. Clone the repository.
2. Open the project in an ASP.NET Core-compatible development environment.
3. Run migrations to create the database schema.
4. Update database with new schema.
5. Start the application.

## API Documentation

The API documentation is available at the `/swagger` endpoint, where you can find descriptions of available endpoints, parameters, and examples of requests and responses.

---
