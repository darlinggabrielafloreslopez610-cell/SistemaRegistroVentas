using System;
using System.Data;
using System.Data.SqlClient;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Datos
{
    public class DCompra
    {
        public string Agregar(Compra Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand("compra_agregar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@fecha_compra", SqlDbType.Date).Value =
                    Convert.ToDateTime(Obj.fecha_Compra);

                comando.Parameters.Add("@total_compra", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(Obj.total_Compra);

                comando.Parameters.Add("@id_empleado", SqlDbType.Int).Value =
                    Convert.ToInt32(Obj.id_Empleado);

                comando.Parameters.Add("@id_proveedor", SqlDbType.Int).Value =
                    Convert.ToInt32(Obj.id_Proveedor);

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo agregar la compra";
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

        public DataTable Consultar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand("compra_consultar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
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

            return tabla;
        }
    }
}
