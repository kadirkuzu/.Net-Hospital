# Hospital Appointment Scheduling System

## Overview

The Hospital Appointment Scheduling System is a web-based application that facilitates the scheduling of medical appointments for patients. It provides a user-friendly interface for users to select a medical department, clinic, and doctor, and schedule appointments based on the availability of doctors.

## Technologies Used

- **C#**: The backend logic and business rules are implemented using C#.
- **ASP.NET Core MVC**: The web application framework for building the user interface.
- **Entity Framework Core**: Object-relational mapping (ORM) for database interactions.
- **HTML/CSS**: Frontend structure and styling.
- **JavaScript**: Enhancing user interactivity on the client side.
- **SQL Server**: Database management system for storing application data.

## Project Structure

The project is organized into several classes representing key entities:

- **MedicalDepartment**: Represents a medical department (e.g., Cardiology, Pediatrics, etc.).
- **Clinic**: Represents a clinic associated with a medical department.
- **Doctor**: Represents a doctor with working hours and associated clinic.
- **WorkSchedule**: Represents the working hours of a doctor for a specific day.
- **User**: Represents a registered user.
- **Patient**: Represents a patient, including patient-specific information.
- **UserPatient**: Extends the User class to include patient-specific information.
- **UserAppointment**: Represents a registered user's appointment.
- **PatientAppointment**: Extends the UserAppointment class to include patient details.
