# Roll Call


📚 Documentación del Proyecto: Roll Call

Este documento describe la arquitectura y las funcionalidades del proyecto Roll Call, enfocado en la gestión de alumnos y la generación de reportes. El proyecto está estructurado en capas para separar las responsabilidades y facilitar el desarrollo colaborativo.

---

### 📁 Estructura del Repositorio

El proyecto se organiza en las siguientes carpetas principales, cada una con un propósito específico:

* **`BNL` (Business & Logic):**
    Esta carpeta contiene los **modelos de datos** del negocio. Estos modelos (`.cs`) son clases que sirven como plantillas para los datos que se manejan en la aplicación. Aquí se define la estructura de las entidades del proyecto.
    * `Alumno.cs`: Modelo de datos para la entidad Alumno.
    * `Curso.cs`: Modelo de datos para la entidad Curso.

* **`DAL` (Data Access Layer):**
    Esta carpeta es la capa de **acceso a datos**. Su función es gestionar toda la interacción con la base de datos para aislar la lógica de la aplicación de las operaciones de persistencia.
    * `Conexion.cs`: Clase central para establecer y gestionar la conexión a la base de datos.
    * **Clases de Repositorio:** Clases dedicadas a operaciones específicas de cada tabla. Siguen el patrón de diseño **Repositorio**, asegurando que cada clase se comunique únicamente con su tabla correspondiente.
        * `RepositorioAlumno.cs`: Maneja todas las operaciones **CRUD** (Crear, Leer, Actualizar, Borrar) para la tabla `Alumnos`.
        * `RepositorioAsignatura.cs`: Maneja todas las operaciones **CRUD** para la tabla `Asignatura`.
        * `Repositorio[NombreTabla].cs`: Este patrón se replicará para el resto de las tablas de la base de datos.

---

### 📝 Resumen del Estado Actual

Actualmente, el desarrollo se enfoca en las siguientes áreas:

* **Gestión de Alumnos:** Se ha completado la implementación de las operaciones básicas para la tabla `Alumnos` a través de la clase `RepositorioAlumno`.
* **Generación de Reportes:** Se está trabajando en el módulo para generar reportes, el cual utilizará los datos de los modelos y los repositorios para construir la información final.

Esta arquitectura facilita el desarrollo en equipo y garantiza que cualquier modificación en la base de datos, como cambiar el nombre de una columna, solo requiera ajustes en la capa `DAL`, sin afectar la lógica del resto del programa.


# Sau saul Sauloso de monterrey
