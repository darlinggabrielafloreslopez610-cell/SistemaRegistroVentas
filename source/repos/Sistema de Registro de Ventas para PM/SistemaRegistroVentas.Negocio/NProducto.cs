using SistemaRegistroVentas.Datos;
using SistemaRegistroVentas.Entidades;
using System;
using System.Data;
using System.Reflection;

namespace SistemaRegistroVentas.Negocio
{
    public class NProducto
    {
        public static DataTable Consultar()
        {
            DProducto Datos = new DProducto();
            return Datos.Consultar();
          
        }


        public static string Eliminar(int IdProducto)
        {
            DProducto Datos = new DProducto();
            return Datos.Eliminar(IdProducto);
        }
        public static string Agregar(string Nombre, string Precio, string Stock, string Fecha_Vencimiento, string Id_Categoria)
        {
            DProducto Datos = new DProducto();
            Producto Obj = new Producto();

            Obj.nombre = Nombre;
            Obj.precio = Precio;
            Obj.stock = Stock;
            Obj.id_categoria = Id_Categoria;

            return Datos.Agregar(Obj);
        }

        public static string Modificar(int IdProducto, string Nombre, string Precio, string Stock, string Fecha_Vencimiento, string Id_Categoria)
        {
            DProducto Datos = new DProducto();
            Producto Obj = new Producto();

            Obj.id_producto = IdProducto.ToString();
            Obj.nombre = Nombre;
            Obj.precio = Precio;
            Obj.stock = Stock;
            Obj.id_categoria = Id_Categoria;

            return Datos.Modificar(Obj);
        }
        public static DataTable Buscar(string Texto)
        {
            DProducto Datos = new DProducto();
            return Datos.Buscar(Texto);
        }
    }
}