using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.AutorDTOs;
using Gestion_de_Bibliotecav3.DTOs.CategoriaDTOs;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;
using Gestion_de_Bibliotecav3.DTOs.PrestamoDTOs;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    public class ServicioDTO
    {
        public LibroDTO aDTO(Libro libro)
        {
            LibroDTO dto = new LibroDTO();
            dto.ISBN = libro.ISBN;
            dto.Nombre = libro.Nombre;
            dto.FechaPublicacion = libro.FechaPublicacion;
            dto.Autores = libro.Autores.Select(autor => aDTO(autor)).ToList();
            dto.Categorias = libro.Categorias.Select(categoria => aDTO(categoria)).ToList();
            return dto;
        }

        public AutorDTO aDTO(Autor autor)
        {
            AutorDTO dto = new AutorDTO();
            dto.Nombre = autor.Nombre;
            return dto;
        }

        public CategoriaDTO aDTO(Categoria categoria)
        {
            CategoriaDTO dto = new CategoriaDTO();
            dto.Nombre = categoria.Nombre;
            return dto;
        }

        public UsuarioDTO aDTO(Usuario usuario)
        {
            UsuarioDTO dto = new UsuarioDTO();
            dto.DNI = usuario.DNI;
            dto.Nombre = usuario.Nombre;
            dto.Telefono = usuario.Telefono;
            dto.Direccion = usuario.Direccion;
            dto.Email = usuario.Email;
            return dto;
        }

        public BuscarUsuarioDTO aDTOBuscar(Usuario usuario)
        {
            BuscarUsuarioDTO dto = new BuscarUsuarioDTO();
            dto.DNI = usuario.DNI;
            dto.Nombre = usuario.Nombre;
            dto.Telefono = usuario.Telefono;
            dto.Direccion = usuario.Direccion;
            dto.Email = usuario.Email;
            dto.Score = usuario.Score.ToString();
            return dto;
        }

        public BuscarEjemplarDTO aDTO(Ejemplar ejemplar)
        {
            BuscarEjemplarDTO dto = new BuscarEjemplarDTO();
            dto.isbn = ejemplar.Libro.ISBN;
            dto.nombre = ejemplar.Libro.Nombre;
            dto.codigo = ejemplar.Codigo;
            dto.fechaAlta = ejemplar.FechaAlta.Date.ToString("dd/mm/yyyy");
            dto.fechaBaja = ejemplar.FechaBaja.Date.ToString("dd/mm/yyyy");
            return dto;
        }

        public PrestamoDTO aDTO(Prestamo prestamo)
        {
            PrestamoDTO dto = new PrestamoDTO();
            dto.ID = prestamo.ID.ToString();
            dto.CodigoEjemplar = prestamo.Ejemplar.Codigo;
            dto.DNIUsuario = prestamo.Usuario.DNI.ToString();
            dto.FechaEntrega = prestamo.FechaEntrega.Date.ToString("dd/mm/yyyy");
            dto.FechaVencimiento = prestamo.FechaVencimiento.Date.ToString("dd/mm/yyyy");
            dto.FechaDevolucion = prestamo.FechaDevolucion.ToString();
            dto.Notificacion = prestamo.Notificacion.ToString();
            return dto;
        }

        public PrestamoAVencerDTO aDTOVencer(Prestamo prestamo)
        {
            PrestamoAVencerDTO dto = new PrestamoAVencerDTO();
            dto.DNIUsuario = prestamo.Usuario.DNI.ToString();
            dto.CodigoEjemplar = prestamo.Ejemplar.Codigo;
            dto.FechaVencimiento = prestamo.FechaVencimiento.ToString();
            return dto;
        }
    }
}
