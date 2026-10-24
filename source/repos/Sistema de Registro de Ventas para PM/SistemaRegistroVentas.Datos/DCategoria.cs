using System;
using System.Data;
using System.Data.SqlClient;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Datos
{
    public class DCategoria
    {
        public string Agregar(Categoria Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_agregar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre_Categoria;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar al registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return Rpta;
        }

        public string Modificar(Categoria Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("categoria_Modificar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.Idcategoria;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre_Categoria;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                sqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Modificar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
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
                SqlCommand comando = new SqlCommand("categoria_Eliminar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                sqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return Rpta;
        }

        
        public DataTable Consultar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection sqlCon =
                Conexion.getInstancia().CrearConexion())
            {
                SqlCommand comando =
                    new SqlCommand("categoria_Consultar", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();

                SqlDataReader resultado =
                    comando.ExecuteReader();

                tabla.Load(resultado);
            }

            return tabla;
        }

    }
}