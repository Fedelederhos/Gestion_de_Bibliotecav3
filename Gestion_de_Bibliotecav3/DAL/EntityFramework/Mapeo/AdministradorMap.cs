using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo
{
    public class AdministradorMap
    {
        private ModelBuilder modelBuilder;
        public AdministradorMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void MapClass()
        {

            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(admin => admin.Usuario);
                entity.Property(admin => admin.Contrasenia)
                      .IsRequired();
            });
        }
    }
}
