using System.Data;
using SistemaRegistroVentas.Datos;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Negocio
{
    public class NVenta
    {
      
        public static string Agregar(
            string fecha,
            string total,
            string metodo_pago,
            string impuesto,
            string descuento,
            string id_cliente,
            string id_empleado)
        {
            DVenta Datos = new DVenta();

            Venta Obj = new Venta();

            Obj.fecha = fecha;
            Obj.total = total;
            Obj.metodo_pago = metodo_pago;
            Obj.impuesto = impuesto;
            Obj.descuento = descuento;
            Obj.id_cliente = id_cliente;
            Obj.id_empleado = id_empleado;

            return Datos.Agregar(Obj);
        }
    }
}
