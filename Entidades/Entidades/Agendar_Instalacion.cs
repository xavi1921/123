using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Agendar_Instalacion
    {

        public int idInstalacion { get; set; }

        public string cedulaCliente { get; set; }
        public string cedulaEmpleado { get; set; }

        public DateTime fechaInstalacion { get; set; }

        public bool Instalado { get; set; }

        public string Observaciones { get; set; }

    }
}
