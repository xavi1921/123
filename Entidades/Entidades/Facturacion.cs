using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Facturacion
    {
        public int idFacturacion { get; set; }

        public string cedulaCliente { get; set; }

        public string cedulaEmpleado { get; set; }

        public int idContrato { get; set; }

        public int idCorteReconexion { get; set; }

        public DateTime fechaPago { get; set; }

        public double totalPago { get; set; }
    }
}
