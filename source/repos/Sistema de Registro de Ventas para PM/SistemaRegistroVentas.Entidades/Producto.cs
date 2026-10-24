using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroVentas.Entidades
{
    public class Producto
    {
        public string id_producto { get; set; }

        public string nombre { get; set; }

        public string precio  { get; set; }

        public string stock { get; set; }

        public string fecha_vencimiento { get; set; }

        public string id_categoria { get; set; }

        
    }
}

