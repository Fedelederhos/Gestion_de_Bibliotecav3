using Gestion_de_Bibliotecav3.DAL.EntityFramework;

namespace Gestion_de_Bibliotecav3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VariablesGlobales.duracionPrestamoBase = 5;
            VariablesGlobales.puntosParaDiaExtra = 5;
            VariablesGlobales.puntosPorDiaDeMora = 2;
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            var context = new AdministradorPrestamosDBContext();
            context.Database.EnsureCreated();
        }
    }
}