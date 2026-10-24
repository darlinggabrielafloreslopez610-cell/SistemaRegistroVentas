using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroVentas.Datos
{
        public class Conexion
        {
            private string Base;
            private string Servidor;
            private string Usuario;
            private string Clave;
            private bool Seguridad;
            private static Conexion con = null;


            private Conexion()
            {
                this.Base = "SistemaRegistroDeVentasBD";
                this.Servidor = ".";
                this.Usuario = "usuario";
                this.Clave = "contraseña";
                this.Seguridad = true;

            }

            public SqlConnection CrearConexion()
            {

                SqlConnection cadena = new SqlConnection();

                try
                {
                    cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";

                    if (this.Seguridad)
                        cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                    else
                        cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;


                }
                catch (Exception ex)
                {

                    cadena = null;

                }
                return cadena;
            }

            public static Conexion getInstancia()
            {
                if (con == null)
                {
                    con = new Conexion();
                }
                return con;
            }

        }
    }





