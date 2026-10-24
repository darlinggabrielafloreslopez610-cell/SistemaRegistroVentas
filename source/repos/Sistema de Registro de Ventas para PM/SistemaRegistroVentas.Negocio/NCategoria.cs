using System.Data;
using SistemaRegistroVentas.Datos;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Negocio
{
    public class NCategoria
    {
        public static DataTable Consultar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Consultar();
        }

        public static string Agregar(string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();

            Obj.Nombre_Categoria = Nombre;
            Obj.Descripcion = Descripcion;

            return Datos.Agregar(Obj);
        }

        public static string Modificar(
            int IdCategoria,
            string Nombre,
            string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();

            Obj.Idcategoria = IdCategoria;
            Obj.Nombre_Categoria = Nombre;
            Obj.Descripcion = Descripcion;

            return Datos.Modificar(Obj);
        }

        public static string Eliminar(int Id)
        {
            DCategoria Datos = new DCategoria();

            return Datos.Eliminar(Id);
        }
    }
}