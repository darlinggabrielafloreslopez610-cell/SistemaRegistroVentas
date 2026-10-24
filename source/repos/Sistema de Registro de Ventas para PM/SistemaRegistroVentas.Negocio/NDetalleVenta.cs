using System.Data;
using SistemaRegistroVentas.Datos;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Negocio
{
    public class NDetalleVenta
    {
       
        

        public static string Agregar(
            string nombre_producto,
            string cantidad,
            string precio_unitario,
            string subtotal,
            string descuento_aplicado,
            string id_venta,
            string id_producto)
        {
            DDetalleVenta Datos = new DDetalleVenta();

            DetalleVenta Obj = new DetalleVenta();

            Obj.nombre_producto = nombre_producto;
            Obj.cantidad = cantidad;
            Obj.precio_unitario = precio_unitario;
            Obj.subtotal = subtotal;
            Obj.descuento_aplicado = descuento_aplicado;
            Obj.id_venta = id_venta;
            Obj.id_producto = id_producto;

            return Datos.Agregar(Obj);
        }
    }
}