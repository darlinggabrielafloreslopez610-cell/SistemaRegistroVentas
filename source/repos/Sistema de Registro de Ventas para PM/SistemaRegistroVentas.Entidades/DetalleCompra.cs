using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroVentas.Entidades
{
    public class DetalleCompra
    {
        public string id_detalle_Compra { get; set; }

        public string nombre_producto { get; set; }

        public string cantidad_Compra { get; set; }
        public string precio_unitario { get; set; }

        public string subtotal { get; set; }
        public string id_Compra { get; set; }

        public string id_producto { get; set; }

    }
}
