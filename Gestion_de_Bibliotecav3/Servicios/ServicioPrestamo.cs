using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.PrestamoDTOs;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav3.Servicios
{
    internal class ServicioPrestamo
    {
        private RepositorioPrestamos repositorioPrestamos;
        private RepositorioUsuarios repositorioUsuarios;
        private RepositorioEjemplares repositorioEjemplares;
        private ServicioUsuario servicioUsuario;
        private ServicioEjemplar servicioEjemplar;
        private ServicioDTO servicioDTO;

        /// <summary>
        /// Busca un préstamo por su ID y lo convierte en un DTO
        /// </summary>
        /// <param name="id">Identificador del préstamo</param>
        /// <returns>DTO del préstamo encontrado</returns>
        public PrestamoDTO BuscarPrestamoPorID(int id)
        {
            return servicioDTO.aDTO(repositorioPrestamos.Get(id));
        }

        /// <summary>
        /// Obtiene todos los préstamos y los devuelve como una lista
        /// </summary>
        /// <returns>Lista de todos los préstamos</returns>
        public List<Prestamo> findAll()
        {
            return (List<Prestamo>)repositorioPrestamos.GetAll();
        }

        /// <summary>
        /// Agrega un nuevo préstamo a partir de los datos recibidos
        /// </summary>
        /// <param name="ejemplardto">DTO del ejemplar prestado</param>
        /// <param name="usuariodto">DTO del usuario que realiza el préstamo</param>
        /// <param name="fechaVencimiento">Fecha de vencimiento del préstamo</param>
        public void Agregar(BuscarEjemplarDTO ejemplardto, BuscarUsuarioDTO usuariodto, DateTime fechaVencimiento)
        {
            Usuario usuario = servicioUsuario.obtenerPorDni(usuariodto.DNI);
            Ejemplar ejemplar = repositorioEjemplares.BuscarPorCodigo(ejemplardto.codigo);
            Prestamo prestamo = new Prestamo(usuario, ejemplar, fechaVencimiento);
            repositorioPrestamos.Agregar(prestamo);
        }

        /// <summary>
        /// Actualiza la información de un préstamo existente
        /// </summary>
        /// <param name="prestamo">Datos actualizados del préstamo</param>
        public void Actualizar(Prestamo prestamo)
        {
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID))
            { //Debe de existir el usuario
                repositorioPrestamos.Actualizar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (será atrapado por el controlador)
        }

        /// <summary>
        /// Elimina un préstamo a partir de su DTO
        /// </summary>
        /// <param name="prestamodto">DTO del préstamo a eliminar</param>
        public void Eliminar(PrestamoDTO prestamodto)
        {
            Prestamo prestamo = repositorioPrestamos.Get(int.Parse(prestamodto.ID));
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID))
            {
                repositorioPrestamos.Eliminar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (será atrapado por el controlador)
        }

        /// <summary>
        /// Busca préstamos activos en el sistema
        /// </summary>
        /// <returns>Lista de préstamos activos</returns>
        public List<Prestamo> BuscarPrestamosActivos()
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaEnUnaSemana = fechaHoy.AddDays(7);

            return repositorioPrestamos.buscarPorFechas(fechaHoy, fechaEnUnaSemana);
        }

        /// <summary>
        /// Busca los préstamos que están próximos a vencerse
        /// </summary>
        /// <param name="fechaHoy">Fecha actual</param>
        /// <returns>Lista de préstamos próximos a vencerse en formato DTO</returns>
        public List<PrestamoAVencerDTO> ProximosPrestamosAVencer(DateTime fechaHoy)
        {
            return repositorioPrestamos.ProximosPrestamosAVencer(fechaHoy).Select(prestamo => servicioDTO.aDTOVencer(prestamo)).ToList();
        }

        /// <summary>
        /// Busca préstamos asociados a un código de ejemplar específico
        /// </summary>
        /// <param name="codigo">Código del ejemplar</param>
        /// <returns>Lista de préstamos asociados al código de ejemplar</returns>
        public List<Prestamo> BuscarPrestamoPorCodigoEjemplar(string codigo)
        {
            if (codigo != null)
            {
                return repositorioPrestamos.BuscarPrestamoPorCodigoEjemplar(codigo);
            }
            throw new SystemException();
        }

        /// <summary>
        /// Busca préstamos asociados a un DNI de usuario específico
        /// </summary>
        /// <param name="DNI">DNI del usuario</param>
        /// <returns>Lista de préstamos asociados al DNI del usuario</returns>
        public List<Prestamo> BuscarPrestamoPorDNI(int DNI)
        {
            if (DNI != null)
            {
                return repositorioPrestamos.BuscarPrestamoPorDNI(DNI);
            }
            throw new SystemException();
        }
    
        /// <summary>
        /// Busca préstamos por código de ejemplar o DNI de usuario y los devuelve como una lista de DTOs
        /// </summary>
        /// <param name="codigoODNI">Código de ejemplar o DNI de usuario</param>
        /// <returns>Lista de préstamos encontrados</returns>
        public List<PrestamoDTO> BuscarPrestamosPorCodigoODNI(string codigoODNI)
        {
            List<PrestamoDTO> prestamos = new List<PrestamoDTO>();
            int number1 = 0;
            bool canConvert = int.TryParse(codigoODNI, out number1);
            if (canConvert)
            {
                prestamos = this.BuscarPrestamoPorDNI(int.Parse(codigoODNI)).Select(prestamo => servicioDTO.aDTO(prestamo)).ToList();
            }
            else
            {
                prestamos = this.BuscarPrestamoPorCodigoEjemplar(codigoODNI).Select(prestamo => servicioDTO.aDTO(prestamo)).ToList();
            }

            return prestamos;
        }

        /// <summary>
        /// Busca préstamos por nombre de ejemplar
        /// </summary>
        /// <param name="nombre">Nombre del ejemplar</param>
        /// <returns>Lista de préstamos encontrados</returns>
        public List<Prestamo> BuscarPorNombreEjemplar(string nombre)
        {
            if (nombre != null)
            {
                return repositorioPrestamos.buscarPorNombreEjemplar(nombre);
            }
            throw new SystemException();
        }

        /// <summary>
        /// Devuelve los ejemplares asociados a un usuario
        /// </summary>
        /// <param name="usuario">Usuario del que se quieren obtener los ejemplares</param>
        /// <returns>Lista de ejemplares del usuario</returns>
        public List<Ejemplar> ejemplaresUsuario(Usuario usuario)
        {
            if (usuario != null && repositorioUsuarios.ExistePorDni(usuario.ID))
            {
                List<Prestamo> prestamos = (List<Prestamo>)repositorioPrestamos.GetAll();
                List<Ejemplar> ejemplares = (List<Ejemplar>)new List<Ejemplar>();

                foreach (Prestamo prestamo in prestamos)
                {
                    if (prestamo.Usuario == usuario)
                    {
                        ejemplares.Add(prestamo.Ejemplar);
                    }
                }

                return ejemplares;
            }
            throw new SystemException();
        }

        /// <summary>
        /// Asigna una fecha de vencimiento a partir del DNI de un usuario
        /// </summary>
        /// <param name="dni">DNI del usuario</param>
        /// <returns>Fecha de vencimiento asignada</returns>
        public string AsignarVencimiento(string dni)
        {
            if (dni != null)
            {
                DateTime fechaHoy = DateTime.Today;
                return (fechaHoy.AddDays(VariablesGlobales.duracionPrestamoBase + servicioUsuario.ObtenerDiasExtra(int.Parse(dni)))).Date.ToString();
            }
            throw new SystemException();
        }

        /// <summary>
        /// Busca un préstamo activo por código de ejemplar
        /// </summary>
        /// <param name="codigo">Código del ejemplar</param>
        /// <returns>Préstamo activo encontrado</returns>
        public Prestamo BuscarPrestamoActivo(string codigo)
        {
            Prestamo prestamo = new Prestamo();
            List<Prestamo> prestamos = repositorioPrestamos.BuscarPrestamoPorCodigoEjemplar(codigo);
            foreach (Prestamo buscado in prestamos)
            {
                if (buscado.FechaDevolucion == null)
                {
                    prestamo = buscado;
                }
            }
            return prestamo;
        }

        /// <summary>
        /// Convierte un estado representado como cadena de caracteres en un valor del tipo Estado
        /// </summary>
        /// <param name="estado">Estado representado como cadena de caracteres</param>
        /// <returns>Estado convertido</returns>
        private Estado StringAEstado(string estado)
        {
            switch (estado)
            {
                case "Bueno":
                    return Estado.Bueno;
                case "Regular":
                    return Estado.Regular;
                case "Arruinado":
                    return Estado.Arruinado;
                default:
                    return Estado.Bueno;
            }
        }

        /// <summary>
        /// Registra la devolución de un préstamo y realiza las actualizaciones correspondientes
        /// </summary>
        /// <param name="codigo">Código del ejemplar asociado al préstamo</param>
        /// <param name="estadostr">Estado del ejemplar devuelto</param>
        public void RegistrarDevolucionPrestamo(string codigo, string estadostr)
        {
            Prestamo prestamo = this.BuscarPrestamoActivo(codigo);
            Estado estado = StringAEstado(estadostr);


            if (prestamo != null) //Me fijo si se pasa un objeto y si este ademas no ha sido devuelto
            {
                prestamo.FechaDevolucion = DateTime.Now;
                prestamo.Ejemplar.Disponibilidad = true;
                DateTime fechaHoy = DateTime.Now.Date;
                DateTime fechaEntregaBase = prestamo.FechaEntrega.AddDays(VariablesGlobales.duracionPrestamoBase).Date;

                /* Verificacion si se paso la fecha de vencimiento */
                if (fechaHoy > prestamo.FechaVencimiento.Date)
                {
                    prestamo.Usuario.Score -= (fechaHoy.Date - prestamo.FechaVencimiento.Date).Days * VariablesGlobales.puntosPorDiaDeMora;
                }
                /* Verificacion si el usuario ocupo dias extras por su puntaje: se tiene en cuenta que pudo haberlo devuelto pasada la fecha de vencimiento */
                if (fechaHoy.Date > fechaEntregaBase)
                {
                    for (DateTime i = fechaEntregaBase; i > fechaHoy.Date || i > prestamo.FechaVencimiento.Date; i.AddDays(1))
                    {
                        prestamo.Usuario.Score -= VariablesGlobales.puntosParaDiaExtra;
                    }
                }

                /* Verificacion del estado y si se cumplen las dos condiciones para premiar por una correcta devolucion */
                if (estado > prestamo.Ejemplar.Estado)
                {
                    prestamo.Usuario.Score -= VariablesGlobales.puntosPorMalEstado;
                    prestamo.Ejemplar.Estado = estado;
                }
                else if (fechaHoy.Date < prestamo.FechaVencimiento.Date)
                {
                    prestamo.Usuario.Score += VariablesGlobales.puntosPorCorrectaDevolucion;
                }

                /* Actualizacion del score, el prestamo y el ejemplar */
                repositorioUsuarios.Actualizar(prestamo.Usuario.ID, prestamo.Usuario);
                repositorioEjemplares.Actualizar(prestamo.Ejemplar.ID, prestamo.Ejemplar);
                this.Actualizar(prestamo);
            }
            throw new SystemException();
        }

        /// <summary>
        /// Envía notificaciones de préstamos próximos a vencer
        /// </summary>
        public void EnviarNotificacion()
        {
            DateTime fechaHoy = DateTime.Now;
            List<Prestamo> prestamosAVencer = repositorioPrestamos.ProximosPrestamosAVencer(fechaHoy);

            foreach (Prestamo prestamo in prestamosAVencer)
            {
                if (!prestamo.Notificacion)
                {
                    // Configurar el cliente SMTP
                    SmtpClient clienteSmtp = new SmtpClient("lederhos.federico@proyecto.frcu.utn.edu.ar");
                    clienteSmtp.Port = 587;
                    clienteSmtp.EnableSsl = true;
                    clienteSmtp.Credentials = new NetworkCredential("lederhos.federico@proyecto.frcu.utn.edu.ar", "14123235");

                    // Crear el mensaje
                    MailMessage mensaje = new MailMessage();
                    mensaje.From = new MailAddress("lederhos.federico@proyecto.frcu.utn.edu.ar");
                    mensaje.To.Add(prestamo.Usuario.Email);
                    mensaje.Subject = ""; //Definir asunto
                    mensaje.Body = ""; //Definir mensaje

                    // Enviar el mensaje
                    clienteSmtp.Send(mensaje);
                    prestamo.Notificacion = true;
                    this.Actualizar(prestamo);
                }
            }
        }

    }
}

