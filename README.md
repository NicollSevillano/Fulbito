# ⚽ Soccer Field Reservation System
This project involves the development of a complete system for managing and reserving soccer fields. 
It was built as part of university courses (Field and Final Diploma Project), using a multi-layer 
architecture and solid software engineering practices.

## 📌 Main Features
- Soccer field reservations
- Client and user management
- Availability schedule control
- Report generation
- Event and change logs
- Security and validation (login, permissions)
- Design patterns applied: **Composite**, **Singleton**, among others
- **n-tier** architecture

## 🧱 System Layers
| Layer | Description |
|-------|-------------|
| **BE (Business Entities)** | Contains domain entities such as `BeCliente`, `BeFactura`, `BeReserva`, etc. |
| **BLL (Business Logic Layer)** | Implements business rules and logic, such as validations and reservation policies. Example: `FacturaReporte.cs`, `PerfilManager.cs`. |
| **DAL (Data Access Layer)** | Handles database operations and connectivity. |
| **GUI (Graphical User Interface)** | Windows Forms-based interface for end users. Includes forms like `CobrarReserva.cs`, `RegistrarCliente.cs`, `GRUsuarios.cs`, etc. |
| **Services** | Shared logic and utilities such as `Encriptar.cs`, `LogBitacora.cs`, `LanguageManager.cs`. |
| **ServiceClass** | Auxiliary class implementations for permissions (`Permiso.cs`, `PermisoCompuesto.cs`), serialization, language setup, backups, etc. |
| **Controls** | Reusable custom components. |
| **Interfaces** | Interface definitions to ensure loose coupling. |
| **Mapper** | Maps entities to database structures and vice versa. |

## 🗃️ Database
The system uses a relational database (SQL Server). CRUD operations are performed using stored procedures and the DAL layer.

## 📈 Reports
The application generates reports such as:
- Completed reservations
- Issued invoices
- Usage history per user
Reports are viewable within the GUI and can be exported.

## 🔐 Security
- User authentication with password encryption
- Hierarchical permissions using the Composite pattern
- Event logging for action traceability

## 🧠 Implemented Design Patterns
- **Composite**: for permission management
- **Singleton**: configuration and language control
- **Factory** and **Strategy** in selected modules
- Clean separation of concerns across layers

## 🛠️ Technologies Used
- Language: C# (.NET Framework)
- IDE: Visual Studio
- Database: SQL Server
- Reports: iTextSharp and ReportViewer
- UI: Windows Forms

## 👨‍💻 Author
Developed by: **Nicoll Sevillano**  
Project for courses: Field / Diploma Project  
Year: 2025
