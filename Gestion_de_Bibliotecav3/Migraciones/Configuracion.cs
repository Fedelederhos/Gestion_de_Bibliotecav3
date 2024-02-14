using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Gestion_de_Bibliotecav3.Migraciones
{
    internal sealed class Configuracion // : DbMigrationsConfiguration<Gestion_de_Bibliotecav3.DAL.EntityFramework.AdministradorPrestamosDBContext>
    {
        public Configuracion()
        {
            //AutomaticMigrationsEnabled = false;
            //ContextKey = "Gestion_de_Biblioteca.DAL.EntityFramework.AdministradorPrestamosDBContext";
        }
        /*
        protected override void OnConfiguring(AdministradorPrestamosDBContext optionsBuilder) //VER
        {
            // Utilizando MySQL
            //optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        }

        protected override void Seed(Gestion_de_Bibliotecav3.DAL.EntityFramework.AdministradorPrestamosDBContext pContext)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }*/
    }
}
