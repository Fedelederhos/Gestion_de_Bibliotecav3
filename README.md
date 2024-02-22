![logo-utn(1)](https://user-images.githubusercontent.com/70183535/190873516-80c3ce3f-310f-48bc-9a89-cd00ac7fbd6b.png)
# Gestion_de_Bibliotecav3
Proyecto para la materia Taller de Programación perteneciente a la carrera Ingeniería en Sistemas de Información en la UTN FRCU.
Desarrollo de Aplicación de gestión de prestamos para una biblioteca.

# Materia
* Taller de Programación
# Docentes
* Ing. Tanga, Enzo.
* Ing. Tripodi, Esteban.
# Equipo
* Lederhos, Federico    fedelederhos5@gmail.com
* Lopez, Martin         tincho1597lopez@gmail.com
* Valiente, Luciana     lucianagabrielavaliente@gmail.com
* Thea, Lucía           luciabananita@gmail.com

# Descripción de la Aplicación
La aplicación es capaz de realizar acciones para gestionar los préstamos, como ser administración de usuarios, alta libros, registro de préstamos y devoluciones. Cuenta además con funcionalidades de reportes y notificaciones para facilitar la gestión de los mismos.
Está desarrollada en un modelo por capas que permite la separación de responsabilidades y la modularidad del sistema. Aquí se emplea para separar la lógica de negocio y la presentación de la información. 
Esta modalidad facilita el desarrollo, la prueba y el mantenimiento de cada capa de forma independiente, e incluso permite agregar o quitar capas según las necesidades del sistema y su posible crecimiento, lo que se traduce en una facilidad de escalabilidad.

# Tecnología Utilizada
* BD creada en MySQL Workbench.
* .NET y lenguaje C#.
* WinForms.

# Requerimientos funcionales solventados
* Alta de libros: La aplicación deberá ser capaz de dar de alta libros para que los ejemplares estén disponibles para el préstamo, para ello tiene que acceder a un catálogo online con el fin de obtener los metadatos del libro. De estos metadatos solo deben ser persistidos lo que considere el alumno sean relevantes.
* Alta de usuarios: La aplicación deberá poder dar de alta usuarios para que puedan ser utilizados en la misma. Los usuarios pueden ser de dos tipos, administrador o simple. Un usuario de tipo administrador será un usuario que pueda interactuar con la aplicación con el fin de realizar las diferentes acciones para gestionar los préstamos. En cambio un usuario o usuario simple no puede interactuar en el sistema y su sola presencia en el mismo es debido a que será objetivo los préstamos.
* Préstamos y devoluciones de ejemplares: La aplicación deberá ser capaz de registrar un préstamo de un ejemplar de un libro a un usuario, estableciendo datos acerca del préstamo como ser fecha de préstamo, fecha de devolución, etc. Además la aplicación deberá poder registrar también la devolución de los ejemplares prestados.
* Reporte de préstamos próximos a vencer: La aplicación deberá ser capaz de generar un reporte de préstamos próximos a vencer. El objetivo de este reporte es que un usuario administrador pueda acceder a él para visualizar los ejemplares a ser devueltos en los próximos 7 días.
* Scoring de prestamos: La aplicación deberá mantener un scoring de préstamos de manera de establecer premios y/castigos en el uso de los servicios de la aplicación.
* Notificación de vencimiento de préstamo: Cuando el préstamo se encuentre entre los dos días hábiles a ser vencido, se le enviará una notificación por mail al usuario avisando de esta situación. El envío de notificaciones a los usuarios deberá quedar registradas en la aplicación.

# Requerimientos no funcionales abordados
* La aplicación deberá ser robusta ante cualquier tipo de errores.
* La aplicación deberá ser fácil de usar e intuitiva.
* La interfaz del usuario deberá ser consistente y no deberá tener errores de interacción ni de visualización de información.
* La aplicación deberá ser desarrollado sobre la plataforma .NET y en lenguaje C#.
* El programa deberá tener una interfaz gráfica, se sugiere el uso de WinForms, integrando los conocimientos y técnicas adquiridos durante la cátedra. La incorporación de conocimientos no adquiridos durante la cátedra serán también bienvenidos.
* El programa deberá persistir las configuraciones y otros datos en una Base de Datos relacional, utilizando el gestor es a elección del alumno. Se espera que en un futuro puedan configurarse persistencia en distintos gestores de Bases de Datos u otras formas de persistencia (como por ejemplo archivos, Bases de Datos No-SQL, entre otras), por lo que el software debe estar preparado para ello.
* La aplicación deberá contener una bitácora de monitoreo (archivo de log), que permita hacer diagnósticos ante la ocurrencia de errores.
* Se espera que en un futuro la aplicación pueda acceder a diferentes catálogos online de libros. El sistema deberá estar diseñado para que los cambios a realizar para incorporar catálogos sea el menor posible.
* Se espera además incorporar en un futuro otros mecanismos de notificación de vencimiento de préstamos, por lo que se debe tener esto en cuenta en el desarrollo de la aplicación.
* El código fuente deberá estar correctamente comentado y documentado con los formatos correspondientes.

# Documentación disponible
* Prototipado de pantallas: https://lucid.app/lucidchart/2459c858-fde7-455c-8ae0-64529da7b607/edit?invitationId=inv_cdb388a1-3f7e-45c7-a0a2-433b43d320cf&page=0_0#
* Diagrama de clases: https://drive.google.com/file/d/1BBDvEeFKdT-VrlLrmMQvY9V6IF42DbFs/view?usp=sharing
* Manual de Usuario: https://drive.google.com/file/d/1McrI-AZPIm1mCP0cKwZqxEE15MXO-I7t/view?usp=sharing

# Guía de instalación
## Versionado y Paquetes
* Aplicación de Windows Forms 7.0
* Microsoft.EntityFrameworkCore 7.0.2
* MySQL.EntityFramework 7.0.2
* Se instaló NuGet en Visual Studio para utilizar EntityFramework.

## Material consultado y utilizado
* Catálogo online de Open Library (https://openlibrary.org /) que es un sitio de internet el cual posee datos gratuitos de libros, publicaciones, revistas, etc.: https://openlibrary.org/developers/api
* Documentación de uso de .NET(C#): https://learn.microsoft.com/en-us/ef/dotnet-data/
* MySQL Workbench documentation: https://dev.mysql.com/doc/workbench/en/
