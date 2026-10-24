using System;
using System.Data;
using System.Data.SqlClient;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Datos
{
    public class DVenta
    {
        public DataTable Consultar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand("venta_consultar", sqlCon);
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

        public string Agregar(Venta Obj)
        {
            string Rpta = "";

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand("venta_agregar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@fecha", SqlDbType.Date).Value =
                    Convert.ToDateTime(Obj.fecha);

                comando.Parameters.Add("@total", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(Obj.total);

                comando.Parameters.Add("@metodo_pago", SqlDbType.VarChar).Value =
                    Obj.metodo_pago;

                comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(Obj.impuesto);

                comando.Parameters.Add("@descuento", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(Obj.descuento);

                comando.Parameters.Add("@id_cliente", SqlDbType.Int).Value =
                    Convert.ToInt32(Obj.id_cliente);

                comando.Parameters.Add("@id_empleado", SqlDbType.Int).Value =
                    Convert.ToInt32(Obj.id_empleado);

                sqlCon.Open();

                Rpta = comando.ExecuteScalar().ToString();
                 
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
