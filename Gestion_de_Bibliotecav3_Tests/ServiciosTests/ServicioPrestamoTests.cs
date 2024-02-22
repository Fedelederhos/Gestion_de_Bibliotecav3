using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.Dominio;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3_Tests.ServiciosTests
{
    public class ServicioPrestamoTests
    {
        [Fact]
        public void EnviarNotificacion_Llega_Success()
        {
            // Arrange
            var mockRepoPrestamos = new Mock<IRepositorioPrestamos>();
            var mockPrestamo = new Mock<Prestamo>();
            mockPrestamo.SetupGet(p => p.Notificacion).Returns(false);
            mockPrestamo.SetupGet(p => p.Usuario.Email).Returns("usuario@dominio.com");
            var listaPrestamos = new List<Prestamo> { mockPrestamo.Object };
            mockRepoPrestamos.Setup(r => r.ProximosPrestamosAVencer(It.IsAny<DateTime>())).Returns(listaPrestamos);

            var servicioPrestamo = new ServicioPrestamo(mockRepoPrestamos.Object);

            // Act
            servicioPrestamo.EnviarNotificacion();

            // Assert
            mockPrestamo.VerifySet(p => p.Notificacion = true, Times.Once);
        }
    }
}
