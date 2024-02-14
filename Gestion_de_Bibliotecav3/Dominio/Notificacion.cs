using Gestion_de_Bibliotecav3.DAL;
using System;
using System.Net;
using System.Net.Mail;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Notificacion
    {
        private int iID;
        private DateTime iFechaHoraEnvio;
        private Prestamo iPrestamo;

        public int PrestamoID { get; set; }
        //private readonly ISmtpClient smtpClient; // Cambiando a la interfaz MailKit

        public Notificacion() { }
        public Notificacion(Prestamo pPrestamo) // Cambiando el tipo de parámetro
        {
            iFechaHoraEnvio = DateTime.Now;
            iPrestamo = pPrestamo;
        }

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public DateTime FechaHoraEnvio
        {
            get { return this.iFechaHoraEnvio; }
            set { this.iFechaHoraEnvio = value; }
        }

        public Prestamo IPrestamo
        {
            get { return this.iPrestamo; }
            set { this.iPrestamo = value; }
        }

        public void EnviarNotificacionDeVencimiento(Usuario pUsuario)
        {
            // Verificar si el préstamo tiene un usuario asociado
            if (iPrestamo.Usuario != null)
            {
                // Cuerpo del correo
                string cuerpoCorreo = $"Hola {pUsuario.Nombre},\n\n" +
                                      $"Queremos recordarte que el préstamo con ID {iPrestamo.ID} está próximo a vencer.\n" +
                                      $"Detalles del préstamo:\n" +
                                      $"- Fecha de entrega: {iPrestamo.FechaEntrega}\n" +
                                      $"- Fecha de vencimiento: {iPrestamo.FechaVencimiento}\n" +
                                      $"- Libro prestado: {iPrestamo.Ejemplar.Libro.Nombre}\n\n" +
                                      $"No responder a este correo.\n\n" +
                                      $"Gracias por utilizar nuestra biblioteca.";
                String fromAddress = "Email...";
                String address = pUsuario.Email;

                SmtpClient email = new SmtpClient
                {
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential(fromAddress, "Contraseña...")
                };

                String asunto = "Vencimiento de Prestamo";
                String body = cuerpoCorreo;

                try
                {
                    email.Send(fromAddress, address, asunto, body);
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine("Error al enviar el correo: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El préstamo no tiene un usuario asociado, no se puede enviar el correo.");
            }
        }

    }
}

