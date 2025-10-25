# Contract Monthly Claim System (CMCS)

##  Overview  

The **Contract Monthly Claim System (CMCS)** is a **.NET (WPF)** desktop application developed as part of the **PROG6212 Portfolio of Evidence (POE)**.  
It streamlines the process of **submitting, reviewing, and verifying monthly claims** for **Independent Contractor (IC)** lecturers within an academic institution.

Originally developed as a prototype focusing on **user interface and navigation**, CMCS has now evolved into a **fully functional system** with **database integration**, **secure login**, and **role-based workflows**.

---

##  Features  

###  Lecturer  
- Submit monthly claims with details such as **module name**, **hours worked**, **hourly rate**, and **supporting documents** (`.pdf`, `.docx`, `.xlsx`).  
- Automatically calculate the total claim amount.  
- View submitted claims and track **approval status**.  
- Communicate directly with the **Coordinator** using the built-in messaging system.  

### Coordinator  
- Review and process lecturer-submitted claims.  
- **Approve** or **reject** claims with feedback.  
- View claim history by lecturer and module.  
- Send and receive messages between **Lecturers** and **Managers**.  

### Manager  
- Verify and finalize **approved claims**.  
- Generate **PDF summary reports** with totals and claim statuses.  
- Communicate with Coordinators for additional verification.  

---

## Technology Stack  

| Component | Description |
|------------|-------------|
| **Language** | C# |
| **Framework** | .NET Core (WPF for GUI) |
| **Database** | Microsoft SQL Server (Entity Framework Core) |
| **PDF Generation** | iTextSharp |
| **Version Control** | GitHub |
| **Design Tools** | UML Diagrams, Excel, Word |
| **UI Styling** | Custom WPF Styles with Glow Effects |

---

## Folder Structure  

```bash
CMCS/
│
├── Documentation/        → Reports, UML diagrams, and project documents
├── Data/                 → Entity Framework context and migrations
├── Models/               → User, Claim, and Message models
├── Pages/                → WPF XAML pages for Lecturer, Coordinator, and Manager
├── Dialogs/              → Custom dialog boxes (Success, Error, Confirm)
├── Resources/            → Styles, color themes, and icons
├── Uploads/              → Saved document uploads
├── App.xaml              → Global resources and startup
├── README.md             → This file
└── CMCS.csproj           → Project configuration
