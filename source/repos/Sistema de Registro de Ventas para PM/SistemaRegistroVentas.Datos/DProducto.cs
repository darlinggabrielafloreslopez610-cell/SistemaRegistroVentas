using System;
using System.Data;
using System.Data.SqlClient;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Datos
{
    public class DProducto
    {
      

        public string Agregar(Producto Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand("producto_agregar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = Convert.ToDecimal(Obj.precio);
                comando.Parameters.Add("@stock", SqlDbType.Int).Value = Convert.ToInt32(Obj.stock);
                comando.Parameters.Add("@fecha_vencimiento", SqlDbType.Date).Value = Convert.ToDateTime(Obj.fecha_vencimiento);
                comando.Parameters.Add("@id_categoria", SqlDbType.Int).Value = Convert.ToInt32(Obj.id_categoria);

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo Agregar al registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return Rpta;
        }
        public string Modificar(Producto Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("producto_modificar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@idproducto", SqlDbType.Int).Value = Convert.ToInt32(Obj.id_producto);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = Convert.ToDecimal(Obj.precio);
                comando.Parameters.Add("@stock", SqlDbType.Int).Value = Convert.ToInt32(Obj.stock);
                comando.Parameters.Add("@fecha_vencimiento", SqlDbType.Date).Value = Convert.ToDateTime(Obj.fecha_vencimiento);
                comando.Parameters.Add("@id_categoria", SqlDbType.Int).Value = Convert.ToInt32(Obj.id_categoria);

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo modificar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return Rpta;
        }

        public DataTable Consultar()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("producto_consultar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure; 

                sqlCon.Open();
                SqlDataReader resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return tabla;
        }

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand("producto_Eliminar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@idproducto", SqlDbType.Int).Value = Id;

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return Rpta;
        }

        public DataTable Buscar(string texto)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand(
                    "SELECT id_producto, nombre, precio, stock, fecha_vencimiento, id_categoria " +
                    "FROM Producto WHERE nombre LIKE '%' + @texto + '%'",
                    sqlCon);

                comando.CommandType = CommandType.Text;
                comando.Parameters.Add("@texto", SqlDbType.VarChar).Value = texto;

                sqlCon.Open();

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
