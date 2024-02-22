using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Gestion_de_Bibliotecav3.DTOs.PrestamoDTOs;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;

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

        public PrestamoDTO BuscarPrestamoPorID(int id)
        {
            return servicioDTO.aDTO(repositorioPrestamos.Get(id));
        }

        public List<Prestamo> findAll()
        {
            return (List<Prestamo>)repositorioPrestamos.GetAll();
        }

        public void Agregar(BuscarEjemplarDTO ejemplardto, BuscarUsuarioDTO usuariodto, DateTime fechaVencimiento)
        {
            BusquedaUsuarioDTO usuario = servicioUsuario.obtenerPorDni(usuariodto.DNI);
            Ejemplar ejemplar = repositorioEjemplares.BuscarPorCodigo(ejemplardto.codigo);
            Prestamo prestamo = new Prestamo(usuario, ejemplar, fechaVencimiento);
            repositorioPrestamos.Agregar(prestamo);
        }

        public void Actualizar(Prestamo prestamo)
        {
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID))
            { //Debe de existir el usuario
                repositorioPrestamos.Actualizar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Eliminar(PrestamoDTO prestamodto)
        {
            Prestamo prestamo = repositorioPrestamos.Get(int.Parse(prestamodto.ID));
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID))
            {
                repositorioPrestamos.Eliminar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public List<Prestamo> BuscarPrestamosActivos()
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaEnUnaSemana = fechaHoy.AddDays(7);

            return repositorioPrestamos.buscarPorFechas(fechaHoy, fechaEnUnaSemana);
        }

        public List<PrestamoAVencerDTO> ProximosPrestamosAVencer(DateTime fechaHoy)
        {
            return repositorioPrestamos.ProximosPrestamosAVencer(fechaHoy).Select(prestamo => servicioDTO.aDTOVencer(prestamo)).ToList();
        }

        public List<Prestamo> BuscarPrestamoPorCodigoEjemplar(string codigo)
        {
            if (codigo != null)
            {
                return repositorioPrestamos.BuscarPrestamoPorCodigoEjemplar(codigo);
            }
            throw new SystemException();
        }

        public List<Prestamo> BuscarPrestamoPorDNI(int DNI)
        {
            if (DNI != null)
            {
                return repositorioPrestamos.BuscarPrestamoPorDNI(DNI);
            }
            throw new SystemException();
        }

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

        public List<Prestamo> BuscarPorNombreEjemplar(string nombre)
        {
            if (nombre != null)
            {
                return repositorioPrestamos.buscarPorNombreEjemplar(nombre);
            }
            throw new SystemException();
        }

        // BUSCAR TODOS LOS PRESTAMOS  
        // BUSCAR LO QUE COINCIDEN CON UN USUARIO
        // DEVOLVER LOS EJEMPLARES 

        public List<Ejemplar> ejemplaresUsuario(BusquedaUsuarioDTO usuario)
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

        public string AsignarVencimiento(string dni)
        {
            if (dni != null)
            {
                DateTime fechaHoy = DateTime.Today;
                return (fechaHoy.AddDays(VariablesGlobales.duracionPrestamoBase + servicioUsuario.ObtenerDiasExtra(int.Parse(dni)))).Date.ToString();
            }
            throw new SystemException();
        }

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

        private Estado StringAEstado (string estado)
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

