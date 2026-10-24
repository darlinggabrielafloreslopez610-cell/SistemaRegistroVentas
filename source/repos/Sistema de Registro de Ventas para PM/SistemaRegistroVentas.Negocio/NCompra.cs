using System;
using System.Data;
using SistemaRegistroVentas.Datos;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Negocio
{
    public class NCompra
    {
        public static DataTable Consultar()
        {
            DCompra Datos = new DCompra();
            return Datos.Consultar();
        }

        public static string Agregar(
            string FechaCompra,
            string TotalCompra,
            string IdEmpleado,
            string IdProveedor)
        {
            DCompra Datos = new DCompra();
            Compra Obj = new Compra();

            Obj.fecha_Compra = FechaCompra;
            Obj.total_Compra = TotalCompra;
            Obj.id_Empleado = IdEmpleado;
            Obj.id_Proveedor = IdProveedor;

            return Datos.Agregar(Obj);
        }
    }
}