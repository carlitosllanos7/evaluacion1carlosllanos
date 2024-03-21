using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.Modelos
{
    public class Empleados
    {
        
        public int IdEmpleado { get; set; }
        public int IdPersona { get; set; }
        public string Puesto { get; set; }
        public string Salario { get; set; }
        public string FechaContratacion { get; set; }
    }
}
