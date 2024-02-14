using Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Migraciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class AdministradorPrestamosDBContext : DbContext
    {
        /*public AdministradorPrestamosDBContext() : base("Gestion_De_Biblioteca")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AdministradorPrestamosDBContext, Configuracion>());
        }*/

        public DbSet<Prestamo> Prestamos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Ejemplar> Ejemplares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;database=tallerc#;user=root;password=Martolomeo23$");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Mapeo(modelBuilder);
        }

        private void Mapeo(ModelBuilder modelBuilder)
        {
            AutorMap autorMap = new AutorMap(modelBuilder);
            autorMap.MapClass();

            CategoriaMap categoriaMap = new CategoriaMap(modelBuilder);
            categoriaMap.MapClass();

            EditorialMap editorialMap = new EditorialMap(modelBuilder);
            editorialMap.MapClass();

            EjemplarMap ejemplarMap = new EjemplarMap(modelBuilder);
            ejemplarMap.MapClass();

            LibroMap libroMap = new LibroMap(modelBuilder);
            libroMap.MapClass();

            PrestamoMap prestamoMap = new PrestamoMap(modelBuilder);
            prestamoMap.MapClass();

            UsuarioMap usuarioMap = new UsuarioMap(modelBuilder);
            usuarioMap.MapClass();
        }


    }
}
