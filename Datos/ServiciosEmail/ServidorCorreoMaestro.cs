using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Datos.ServiciosEmail
{
    public abstract class ServidorCorreoMaestro
    {
        private SmtpClient smtpCliente;
        protected string enviarEmail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void inicializarSmtpCliente()
        {
            smtpCliente = new SmtpClient();
            smtpCliente.Credentials = new NetworkCredential(enviarEmail, password);
            smtpCliente.Host = host;
            smtpCliente.Port = port;
            smtpCliente.EnableSsl = ssl;
        }

        public void sendEmail(string asunto, string cuerpo, List<string> destinatario)
        {
            var enviarMensaje = new MailMessage();

            try
            {
                enviarMensaje.From = new MailAddress(enviarEmail);
                foreach (string mail in destinatario)
                {
                    enviarMensaje.To.Add(mail);
                }
                enviarMensaje.Subject = asunto;
                enviarMensaje.Body = cuerpo;
                enviarMensaje.Priority = MailPriority.Normal;
                smtpCliente.Send(enviarMensaje);
            }
            catch (Exception ex) { }
            finally
            {
                enviarMensaje.Dispose();
                smtpCliente.Dispose();
            }
        }
    }
}
