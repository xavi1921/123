using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Fecha_Pagos
    {
        public int IdPago { get; set; }
        public string CedulaCliente { get; set; }
        public int IdInstalacion { get; set; }
        public DateTime FechaPago { get; set; }
        public bool PlazoVencido { get; set; }
        public string Observaciones { get; set; }
    }
}
