using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav3.Servicios
{
    internal class ServicioPrestamo
    {
        private RepositorioPrestamos repositorioPrestamos;
        private RepositorioUsuarios repositorioUsuarios;
        private ServicioUsuario servicioUsuario;
        private ServicioEjemplar servicioEjemplar;

        public Prestamo BuscarPrestamoPorID(int id)
        {
            return repositorioPrestamos.Get(id);
        }

        public List<Prestamo> findAll()
        {
            return (List<Prestamo>)repositorioPrestamos.GetAll();
        }

        public void Agregar(Prestamo prestamo)
        {
            if (prestamo.ID != null && !repositorioPrestamos.Existe(prestamo.ID))
            { //No debe existir el usuario
                repositorioPrestamos.Agregar(prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Actualizar(Prestamo prestamo)
        {
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID))
            { //Debe de existir el usuario
                repositorioPrestamos.Actualizar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Eliminar(Prestamo prestamo)
        {
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID)) //Debe de existir el usuario
            {
                repositorioPrestamos.Eliminar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public List<Prestamo> ProximosAVencerse()
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaEnUnaSemana = fechaHoy.AddDays(7);

            return repositorioPrestamos.buscarPorFechas(fechaHoy, fechaEnUnaSemana);
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

        public List<Prestamo> BuscarPrestamosPorCodigoODNI(string codigoODNI)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            int number1 = 0;
            bool canConvert = int.TryParse(codigoODNI, out number1);
            if (canConvert)
            {
                prestamos = this.BuscarPrestamoPorDNI(int.Parse(codigoODNI));
            }
            else
            {
                prestamos = this.BuscarPrestamoPorCodigoEjemplar(codigoODNI);
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

        public DateTime AsignarVencimiento(int dni)
        {
            if (dni != null)
            {
                DateTime fechaHoy = DateTime.Today;
                return (fechaHoy.AddDays(VariablesGlobales.duracionPrestamoBase + servicioUsuario.ObtenerDiasExtra(dni)));
            }
            throw new SystemException();
        }

        public Prestamo BuscarPrestamoActivo(string codigo)
        {
            Prestamo prestamo = new Prestamo();
            List<Prestamo> prestamos = BuscarPrestamosPorCodigoODNI(codigo);
            foreach (Prestamo buscado in prestamos)
            {
                if (buscado.FechaDevolucion == null)
                {
                    prestamo = buscado;
                }
            }
            return prestamo;
        }

        public void RegistrarDevolucionPrestamo(string codigo, Estado estado)
        {
            Prestamo prestamo = this.BuscarPrestamoActivo(codigo);
            
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
                servicioUsuario.Actualizar(prestamo.Usuario);
                servicioEjemplar.Actualizar(prestamo.Ejemplar);
                this.Actualizar(prestamo);
            }
            throw new SystemException();
        }
    }
}

