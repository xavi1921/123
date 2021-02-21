using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Empleado
    {
        public string Cedula_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int ID_Tipo_Empleado { get; set; }
        public DateTime Fecha_Contrato { get; set; }
        public string Contraseña { get; set; }
    }
}
