using System;
using System.Data;
using System.Data.SqlClient;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Datos
{
    public class DProveedores
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
                    "proveedores_consultar", sqlCon);

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

        public string Agregar(Proveedores Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand(
                    "proveedores_agregar", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nombre_empresa", SqlDbType.VarChar)
                    .Value = Obj.nombre_empresa;

                comando.Parameters.Add("@direccion", SqlDbType.VarChar)
                    .Value = Obj.direccion;

                comando.Parameters.Add("@telefono", SqlDbType.VarChar)
                    .Value = Obj.telefono;

                comando.Parameters.Add("@correo_electronico", SqlDbType.VarChar)
                    .Value = Obj.correo_electronico;

                comando.Parameters.Add("@cedula", SqlDbType.VarChar)
                    .Value = Obj.cedula;

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo agregar el proveedor";
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

        public string Modificar(Proveedores Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand(
                    "proveedores_Modificar", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id_proveedor", SqlDbType.Int)
                    .Value = Convert.ToInt32(Obj.id_proveedor);

                comando.Parameters.Add("@nombre_empresa", SqlDbType.VarChar)
                    .Value = Obj.nombre_empresa;

                comando.Parameters.Add("@direccion", SqlDbType.VarChar)
                    .Value = Obj.direccion;

                comando.Parameters.Add("@telefono", SqlDbType.VarChar)
                    .Value = Obj.telefono;

                comando.Parameters.Add("@correo_electronico", SqlDbType.VarChar)
                    .Value = Obj.correo_electronico;

                comando.Parameters.Add("@cedula", SqlDbType.VarChar)
                    .Value = Obj.cedula;

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo actualizar el proveedor";
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

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand(
                    "proveedores_eliminar", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id_proveedor", SqlDbType.Int)
                    .Value = Id;

                sqlCon.Open();

                Rpta = comando.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo eliminar el proveedor";
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
