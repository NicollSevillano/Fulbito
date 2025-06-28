# ⚽ Sistema de Reservas de Canchas de Fútbol
Este proyecto consiste en el desarrollo de un sistema completo para la gestión y reserva de canchas de fútbol. 
Está diseñado como parte del desarrollo de materias universitarias (Campo y Proyecto Final de Diplomatura), 
utilizando una arquitectura en capas y buenas prácticas de ingeniería de software.

## 📌 Características Principales
- Reserva de canchas de fútbol
- Gestión de usuarios y clientes
- Control de horarios disponibles
- Generación de reportes
- Bitácoras de eventos y cambios
- Seguridad y validación (login, permisos)
- Patrón de diseño aplicado: **Composite**, **Singleton**, entre otros
- Arquitectura **n-tier** (multicapa)

## 🧱 Capas del Sistema
| Capa | Descripción |
|------|-------------|
| **BE (Business Entities)** | Contiene las entidades del dominio, como `BeCliente`, `BeFactura`, `BeReserva`, etc. |
| **BLL (Business Logic Layer)** | Implementa la lógica de negocio, como validaciones, reglas de reserva, etc. Ej: `FacturaReporte.cs`, `PerfilManager.cs`. |
| **DAL (Data Access Layer)** | Capa de acceso a datos, permite la conexión y operaciones sobre la base de datos. |
| **GUI (Interfaz Gráfica)** | Interfaz para el usuario final, implementada en Windows Forms. Contiene formularios como `CobrarReserva.cs`, `RegistrarCliente.cs`, `GRUsuarios.cs`, etc. |
| **Servicios** | Lógica común y utilitarios compartidos como `Encriptar.cs`, `LogBitacora.cs`, `LanguageManager.cs`. |
| **ServicioClase** | Implementación de clases auxiliares para la autorización (`Permiso.cs`, `PermisoCompuesto.cs`), serialización, configuración de idioma, backup, etc. |
| **Controles** | Componentes personalizados reutilizables. |
| **Interfaz** | Contratos de interfaces para una arquitectura desacoplada. |
| **Mapper** | Mapeo entre entidades y estructuras de base de datos. |

## 🗃️ Base de Datos
Se utiliza una base de datos relacional (SQL Server). Las operaciones CRUD se realizan a través de procedimientos almacenados y clases DAL.

## 📈 Reportes
El sistema permite la generación de reportes como:
- Reservas realizadas
- Facturas emitidas
- Historial de uso por usuario
Estos reportes pueden visualizarse desde la GUI y exportarse.

## 🔐 Seguridad
- Autenticación de usuarios con encriptación de contraseñas
- Permisos jerárquicos aplicando el patrón Composite
- Bitácora de eventos para trazabilidad de acciones

## 🧠 Patrones de Diseño Implementados
- **Composite**: para la gestión de permisos
- **Singleton**: configuración y gestión de idioma
- **Factory** y **Strategy** en ciertos módulos
- **Observer**: para actualizar el sistema al idioma seleccionado (actualmente español e inglés)
- Separación clara de capas (Responsabilidad Única)

## 🛠️ Tecnologías Utilizadas
- Lenguaje: C# (.NET Framework)
- IDE: Visual Studio
- Base de Datos: SQL Server
- Reportes: iTextSharp y ReportViewer
- Windows Forms para interfaz gráfica

## 👨‍💻 Autor
Desarrollado por: **Nicoll Sevillano**  
Proyecto para materias: Campo / Diploma
Año: 2025
