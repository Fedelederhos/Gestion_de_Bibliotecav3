using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.DAL
{
    public interface IRepositorioPrestamos : IRepository<Dominio.Prestamo>
    {
        // Operaciones de préstamos
        //Prestamo ObtenerPrestamoPorId(int prestamoId);
        //IEnumerable<Prestamo> ObtenerPrestamosPorUsuario(int usuarioId);
        //IEnumerable<Prestamo> ObtenerPrestamosProximosAVencer(DateTime fechaLimite);

        //void RegistrarPrestamo(Prestamo prestamo);
        //void RegistrarDevolucion(int prestamoId, DateTime fechaDevolucion);

        //// Operaciones de scoring
        //int ObtenerScoringUsuario(int usuarioId);
        //void ActualizarScoringUsuario(int usuarioId, int puntos);

        //// Operaciones de notificaciones
        //void EnviarNotificacionVencimientoPrestamo(int usuarioId);

        // Otras operaciones necesarias según tus requerimientos
    }
}
