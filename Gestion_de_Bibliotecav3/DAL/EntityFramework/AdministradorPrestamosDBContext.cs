using Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Migraciones;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(coneccion());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Mapeo(modelBuilder);
        }

        private string coneccion()
        {
            // Lee el contenido del archivo config.json
            string jsonFilePath = "config.json";
            string json = File.ReadAllText(jsonFilePath);

            // Deserializa el contenido del archivo JSON en un objeto dynamic
            dynamic config = JsonConvert.DeserializeObject(json);

            // Obtiene la cadena de conexión del objeto dynamic
            string connectionString = config.ConnectionString;
            return connectionString;
        }

        private void Mapeo(ModelBuilder modelBuilder)
        {
            AutorMap autorMap = new AutorMap(modelBuilder);
            autorMap.MapClass();

            CategoriaMap categoriaMap = new CategoriaMap(modelBuilder);
            categoriaMap.MapClass();


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
