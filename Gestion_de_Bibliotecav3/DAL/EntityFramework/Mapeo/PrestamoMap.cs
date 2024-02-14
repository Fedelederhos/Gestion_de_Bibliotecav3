using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo
{
    public class PrestamoMap
    {
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }


        private ModelBuilder modelBuilder;

        public PrestamoMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void MapClass()
        {

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(prestamo => prestamo.ID);

                entity.Property(prestamo => prestamo.ID)
                      .ValueGeneratedOnAdd();

                entity.Property(prestamo => prestamo.FechaEntrega)
                      .IsRequired();

                entity.Property(prestamo => prestamo.FechaVencimiento)
                      .IsRequired();

                entity.Property(prestamo => prestamo.FechaDevolucion);

                entity.HasOne(prestamo => prestamo.Ejemplar) //OneToMany
                      .WithMany(editorial => editorial.Prestamos)
                      .HasForeignKey(prestamo => prestamo.EjemplarID);

                entity.HasOne(prestamo => prestamo.Usuario) //OneToMany
                      .WithMany(usuario => usuario.Prestamo)
                      .HasForeignKey(prestamo => prestamo.UsuarioID);

                entity.HasOne(prestamo => prestamo.Notificacion)
                      .WithOne(n => n.IPrestamo)
                      .HasForeignKey<Notificacion>(n => n.PrestamoID);
            });
        }
    }
}
