using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Corte_Reconexion
    {
        public int IdCorteReconexion { get; set; }
        public string CedulaCliente { get; set; }
        public DateTime FechaCorte { get; set; }
        public DateTime FechaReconexion{ get; set; }
        public string Observaciones { get; set; }
    }
}
