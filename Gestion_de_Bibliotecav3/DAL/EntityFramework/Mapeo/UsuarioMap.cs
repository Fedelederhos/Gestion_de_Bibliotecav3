using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo
{
    public class UsuarioMap
    {
        private ModelBuilder modelBuilder;
        public UsuarioMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void MapClass()
        {

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(usuario => usuario.ID);
                entity.Property(usuario => usuario.ID)
                      .ValueGeneratedOnAdd();
                entity.Property(usuario => usuario.DNI)
                      .IsRequired();
                entity.Property(usuario => usuario.Nombre)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(usuario => usuario.Score)
                      .IsRequired();
                entity.Property(usuario => usuario.Direccion)
                      .IsRequired()
                      .HasMaxLength(200);
                entity.Property(usuario => usuario.Telefono)
                      .IsRequired();
                entity.Property(usuario => usuario.Email)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(usuario => usuario.LibrosPrestados)
                      .IsRequired();
            });



            /*
            this.HasKey(usuario => usuario.ID);

            this.Property(usuario => usuario.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(usuario => usuario.DNI)
                .IsRequired();

            this.Property(usuario => usuario.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(usuario => usuario.Score)
                .IsRequired();

            this.Property(usuario => usuario.Direccion)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(usuario => usuario.Telefono)
                .IsRequired();

            this.Property(usuario => usuario.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(usuario => usuario.LibrosPrestados)
                .IsRequired();*/
        }
    }
}
