using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroVentas.Entidades
{
    public class Venta
    {
        public string  fecha { get; set; }

        public string total { get; set; }

        public string metodo_pago { get; set; }

        public string impuesto { get; set; }

        public string descuento { get; set; }

        public string id_cliente { get; set; }

        public string id_empleado { get; set; }

        public string NumeroFactura { get; set; }

    }
}
