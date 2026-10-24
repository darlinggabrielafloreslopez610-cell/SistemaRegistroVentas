using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroVentas.Entidades
{
    public class DetalleVenta
    {
        public string id_detalle_Venta { get; set; }

        public string nombre_producto { get; set; }

        public string cantidad { get; set; }
        public string precio_unitario { get; set; }

        public string subtotal { get; set; }

        public string id_venta { get; set; }

        public string id_producto { get; set; }

        public string descuento_aplicado { get; set; }

    }
}
