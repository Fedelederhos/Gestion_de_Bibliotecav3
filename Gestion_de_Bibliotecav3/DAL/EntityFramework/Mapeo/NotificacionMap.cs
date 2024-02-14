using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo
{
    public class NotificacionMap
    {

        private ModelBuilder modelBuilder;

        public NotificacionMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void MapClass()
        {
            modelBuilder.Entity<Notificacion>(entity =>
            {
                entity.HasKey(n => n.ID);
                entity.Property(n => n.ID)
                      .ValueGeneratedOnAdd();
                entity.Property(n => n.FechaHoraEnvio);
                entity.Property(n => n.IPrestamo);
            });
        }



    }
}
