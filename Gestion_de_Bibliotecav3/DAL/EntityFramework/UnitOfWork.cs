using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AdministradorPrestamosDBContext iDBContext;
        private IRepositorioPrestamos iRepositorioPrestamos;
        private IRepositorioUsuarios iRepositorioUsuarios;
        private IRepositorioEjemplares iRepositorioEjemplares;
        private IRepositorioCategorias iRepositorioCategorias;
        private IRepositorioAutores iRepositorioAutores;
        private IRepositorioLibros iRepositorioLibros;
        private IRepositorioAdministrador iRepositorioAdministrador;

        public IRepositorioPrestamos RepositorioPrestamos => iRepositorioPrestamos;
        public IRepositorioUsuarios RepositorioUsuarios => iRepositorioUsuarios;
        public IRepositorioEjemplares RepositorioEjemplares => iRepositorioEjemplares;
        public IRepositorioEjemplares Repositorio => iRepositorioEjemplares;
        public IRepositorioCategorias RepositorioCategorias => iRepositorioCategorias;
        public IRepositorioAutores RepositorioAutores => iRepositorioAutores;
        public IRepositorioLibros RepositorioLibros => iRepositorioLibros;
        public IRepositorioAdministrador RepositorioAdministrador => iRepositorioAdministrador;

        public UnitOfWork(AdministradorPrestamosDBContext pDBContext)
        {
            if (pDBContext == null)
            {
                throw new NotImplementedException();
            }

            this.iDBContext = pDBContext;
            this.iRepositorioPrestamos = new RepositorioPrestamos(pDBContext);
            this.iRepositorioUsuarios = new RepositorioUsuarios(pDBContext);
            this.iRepositorioEjemplares = new RepositorioEjemplares(pDBContext);
            this.iRepositorioAutores = new RepositorioAutores(pDBContext);
            this.iRepositorioCategorias = new RepositorioCategorias(pDBContext);
            this.iRepositorioLibros = new RepositorioLibros(pDBContext);
            this.iRepositorioAdministrador = new RepositorioAdministrador(pDBContext);

        }


        public void Completar()
        {
            this.iDBContext.SaveChanges();
        }

        

        public void Dispose()
        {
            this.iDBContext.Dispose();
        }

        public void DeleteAll()
        {
            this.iDBContext.Prestamos.RemoveRange(iDBContext.Prestamos);
            this.iDBContext.Usuarios.RemoveRange(iDBContext.Usuarios);
            this.iDBContext.Ejemplares.RemoveRange(iDBContext.Ejemplares);
            this.iDBContext.Autores.RemoveRange(iDBContext.Autores);
            this.iDBContext.Categorias.RemoveRange(iDBContext.Categorias);
            this.iDBContext.Libros.RemoveRange(iDBContext.Libros);
            this.iDBContext.Administrador.RemoveRange(iDBContext.Administrador);

            Completar();
        }

    }
}
