using System.Data;
using SistemaRegistroVentas.Datos;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Negocio
{
    public class NProveedores
    {
        public static DataTable Consultar()
        {
            DProveedores Datos = new DProveedores();

            return Datos.Consultar();
        }

        public static string Agregar(
            string nombre_empresa,
            string direccion,
            string telefono,
            string correo_electronico,
            string cedula)
        {
            DProveedores Datos = new DProveedores();

            Proveedores Obj = new Proveedores();

            Obj.nombre_empresa = nombre_empresa;
            Obj.direccion = direccion;
            Obj.telefono = telefono;
            Obj.correo_electronico = correo_electronico;
            Obj.cedula = cedula;

            return Datos.Agregar(Obj);
        }

        public static string Modificar(
            string id_proveedor,
            string nombre_empresa,
            string direccion,
            string telefono,
            string correo_electronico,
            string cedula)
        {
            DProveedores Datos = new DProveedores();

            Proveedores Obj = new Proveedores();

            Obj.id_proveedor = id_proveedor;
            Obj.nombre_empresa = nombre_empresa;
            Obj.direccion = direccion;
            Obj.telefono = telefono;
            Obj.correo_electronico = correo_electronico;
            Obj.cedula = cedula;

            return Datos.Modificar(Obj);
        }

        public static string Eliminar(int id_proveedor)
        {
            DProveedores Datos = new DProveedores();

            return Datos.Eliminar(id_proveedor);
        }
    }
}
