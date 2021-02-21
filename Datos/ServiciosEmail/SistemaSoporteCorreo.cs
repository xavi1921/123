using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ServiciosEmail
{
    class SistemaSoporteCorreo:ServidorCorreoMaestro
    {
        public SistemaSoporteCorreo()
        {
            enviarEmail = "SoporteSistemaFONET@gmail.com";
            password = "xavi1921";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializarSmtpCliente();
        }
    }
}
