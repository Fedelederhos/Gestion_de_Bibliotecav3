using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    public class ServicioUsuario
    {
        private RepositorioUsuarios repositorioUsuarios;

        public Usuario Get(int id)
        {
                return repositorioUsuarios.Get(id);
        }

        public Usuario obtenerPorDni(int dni)
        {
                return repositorioUsuarios.obtenerPorDni(dni);
        }

        public List<Usuario> GetAll()
        {
            return (List<Usuario>)repositorioUsuarios.GetAll();
        }

        public void Agregar(UsuarioDTO usuariodto)
        {
            if (usuariodto.DNI != null && !repositorioUsuarios.ExistePorDni(usuariodto.DNI))
            { 
                //No debe existir el usuario
                Usuario usuario = new Usuario(usuariodto.DNI, usuariodto.Nombre, usuariodto.Direccion, usuariodto.Telefono, usuariodto.Email);
                repositorioUsuarios.Agregar(usuario);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Actualizar(Usuario usuario)
        {
            if (usuario.ID != null && repositorioUsuarios.Existe(usuario.ID))
            { //Debe de existir el usuario
                repositorioUsuarios.Actualizar(usuario.ID, usuario);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Eliminar(Usuario usuario)
        {
            if (usuario.ID != null && repositorioUsuarios.Existe(usuario.ID)) //Debe de existir el usuario
            {
                repositorioUsuarios.Eliminar(usuario.ID, usuario);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }


        public void Eliminar(int dni)
        {
            if (dni != null && repositorioUsuarios.Existe(dni)) //Debe de existir el usuario
            {
                repositorioUsuarios.Eliminar(dni);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public bool Existe(int dni)
        {
            return repositorioUsuarios.Existe(dni);
        }

        public int ObtenerDiasExtra(int dni)
        {
            Usuario usuario = repositorioUsuarios.obtenerPorDni(dni);
            return (int)Math.Floor((double)(usuario.Score / VariablesGlobales.puntosParaDiaExtra));
        }

        public List<Usuario> obtenerPorNombre(string nombre)
        {
            return repositorioUsuarios.obtenerPorNombre(nombre);
        }
    }
}
