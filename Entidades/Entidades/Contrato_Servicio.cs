using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Contrato_Servicio
    {
        public int IdContrato { get; set; }
        public string CedulaCliente { get; set; }
        public int IdPlanMegas { get; set; }
        public int IdInstalacion { get; set; }
    }
}
