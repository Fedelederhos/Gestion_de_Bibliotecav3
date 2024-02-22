using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Context
{
    public class Context
    {
        protected static Context _instance;

        protected IUnitOfWork iUnitOfWork;

        protected User iUser;

        //Contructor
        protected Context()
        {
            iUnitOfWork = new UnitOfWork(new AdministradorPrestamosDBContext());
            iUser = null;
        }

        public IUnitOfWork UnitOfWork
        {
            get { return iUnitOfWork; }
        }

        public User User
        {
            get { return iUser; }
            set { iUser = value; }
        }
    }
}
