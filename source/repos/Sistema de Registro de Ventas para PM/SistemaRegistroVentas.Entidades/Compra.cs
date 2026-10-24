using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroVentas.Entidades
{
    public class Compra
    {
        public string id_Compra { get; set; }

        public string fecha_Compra { get; set; }

        public string total_Compra { get; set; }

        public string id_Empleado { get; set; }

        public string id_Proveedor { get; set; }
    }
}
