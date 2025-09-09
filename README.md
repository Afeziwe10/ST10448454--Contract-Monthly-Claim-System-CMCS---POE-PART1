# Contract Monthly Claim System (CMCS)

## Overview
The Contract Monthly Claim System (CMCS) is a .NET (WPF) application developed as part of the PROG6212 Portfolio of Evidence (POE).  
The system streamlines the process of submitting, reviewing, and verifying monthly claims for Independent Contractor (IC) lecturers.  

The application is currently in **prototype stage** with mock data, focusing on GUI design and navigation. Future parts of the POE will add database integration and full functionality.


## Features
### Lecturer
- Submit monthly claims (module, hours, rates, documents).
- View submitted claims and track their status.
- Secure role-based access (lecturer only).

### Coordinator
- Review lecturer claims.
- Approve or reject claims.
- View a history of processed claims.

### Manager
- Verify final reports.
- View claim summaries (total, approved, rejected).
- Access detailed claim records by lecturer and module.


## Technology Stack
- **Language:** C#  
- **Framework:** .NET Core (WPF for GUI)  
- **Version Control:** GitHub (with regular commits)  
- **Design Tools:** UML class diagrams, project planning in Excel/Word  


## Folder Structure
- `Documentation/` → Reports, design rationale, UML diagrams  
- `Pages/` → WPF XAML pages for Lecturer, Coordinator, Manager  
- `Resources/` → Styles, themes, icons  
- `App/` → Core WPF application files  
- `README.md` → This file  

