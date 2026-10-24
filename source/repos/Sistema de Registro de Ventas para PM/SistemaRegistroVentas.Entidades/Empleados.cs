using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroVentas.Entidades
{
    public class Empleados
    {
        public string id_Empleado { get; set; }

        public string nombre { get; set; }

        public string telefono { get; set; }
        public string cargo { get; set; }

        public string fecha_contratacion { get; set; }

        public string salario { get; set; }

        public string estado { get; set; }

    }
}
