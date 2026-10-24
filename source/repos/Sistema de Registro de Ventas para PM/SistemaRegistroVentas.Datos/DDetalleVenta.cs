using System;
using System.Data;
using System.Data.SqlClient;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Datos
{
    public class DDetalleVenta
    {
        public DataTable Consultar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand(
                    "detalleventa_consultar", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

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

        public string Agregar(DetalleVenta Obj)
        {
            string Rpta = "";

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand(
                    "detalleventa_agregar", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value =
                    Obj.nombre_producto;

                comando.Parameters.Add("@cantidad", SqlDbType.Int).Value =
                    Convert.ToInt32(Obj.cantidad);

                comando.Parameters.Add("@precio_unitario", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(Obj.precio_unitario);

                comando.Parameters.Add("@subtotal", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(Obj.subtotal);

                comando.Parameters.Add("@descuento_aplicado", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(Obj.descuento_aplicado);

                comando.Parameters.Add("@id_venta", SqlDbType.Int).Value =
                    Convert.ToInt32(Obj.id_venta);

                comando.Parameters.Add("@id_producto", SqlDbType.Int).Value =
                    Convert.ToInt32(Obj.id_producto);

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo ingresar el detalle";
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
    }
}