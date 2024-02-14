using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AdministradorPrestamosDBContext iDBContext;

        private bool iDisposedValue = false;

        public UnitOfWork(AdministradorPrestamosDBContext pDBContext)
        {
            if (pDBContext == null)
            {
                throw new NotImplementedException();
            }

            this.iDBContext = pDBContext;
            this.RepositorioPrestamos = new RepositorioPrestamos(pDBContext);
            this.RepositorioUsuarios = new RepositorioUsuarios(pDBContext);
            this.RepositorioEjemplares = new RepositorioEjemplares(pDBContext);
        }

        public IRepositorioPrestamos RepositorioPrestamos { get; private set; }

        public IRepositorioUsuarios RepositorioUsuarios { get; private set; }

        public IRepositorioEjemplares RepositorioEjemplares { get; private set; }

        public void Completar()
        {
            this.iDBContext.SaveChanges();
        }

        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDBContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
