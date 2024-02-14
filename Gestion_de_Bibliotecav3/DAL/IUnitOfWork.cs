using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositorioPrestamos RepositorioPrestamos { get; }

        IRepositorioUsuarios RepositorioUsuarios { get; }

        IRepositorioEjemplares RepositorioEjemplares { get; }

        void Completar();
    }
}
