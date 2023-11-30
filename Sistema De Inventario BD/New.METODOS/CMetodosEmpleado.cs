using MySql.Data.MySqlClient;
using Sistema_De_Inventario_BD.New.VISTA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_De_Inventario_BD.NEW.CLASES;

namespace Sistema_De_Inventario_BD.New.METODOS
{
    internal class CMetodosEmpleado
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerEmpleados()
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerEmpleados", sqlConexion); // Cambiado a "ObtenerEmpleados"
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex )
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public string AgregarEmpleado(ClaseEmpleados empleado) // Cambiado a "AgregarEmpleado"
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("AgregarEmpleado", sqlConexion); // Cambiado a "AgregarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombreEmpleado", MySqlDbType.VarChar).Value = empleado.nombreEmpleado;
                comando.Parameters.Add("@telefEmpleado", MySqlDbType.VarChar).Value = empleado.telefEmpleado;
                comando.Parameters.Add("@direccionEmpleado", MySqlDbType.VarChar).Value = empleado.direccionEmpleado;
                comando.Parameters.Add("@estado", MySqlDbType.VarChar).Value = empleado.estado;
                sqlConexion.Open();
                if (comando.ExecuteNonQuery() > 1)
                {
                    respuesta = "SE INSERTÓ CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO INSERTAR EL REGISTRO";
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public DataTable BuscarEmpleado(string nombre) // Cambiado a "BuscarEmpleado"
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarEmpleado", sqlConexion); // Cambiado a "BuscarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@empleado", MySqlDbType.VarChar).Value = nombre.Trim();
                sqlConexion.Open();
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
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public string EliminarEmpleado(int idEmpleado) // Cambiado a "EliminarEmpleado"
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("EliminarEmpleado", sqlConexion); // Cambiado a "EliminarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idEmpleado;

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() > 1)
                {
                    respuesta = "SE ELIMINÓ CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO ELIMINAR EL REGISTRO";
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public string ActualizarEmpleado(int idEmpleado, ClaseEmpleados empleado) // Cambiado a "ActualizarEmpleado"
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarEmpleado", sqlConexion); // Cambiado a "ActualizarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idEmpleado;
                comando.Parameters.Add("@nombreEmpleado", MySqlDbType.VarChar).Value = empleado.nombreEmpleado;
                comando.Parameters.Add("@telefEmpleado", MySqlDbType.VarChar).Value = empleado.telefEmpleado;
                comando.Parameters.Add("@direccionEmpleado", MySqlDbType.VarChar).Value = empleado.direccionEmpleado;
                comando.Parameters.Add("@estado", MySqlDbType.VarChar).Value = empleado.estado;
                sqlConexion.Open();
                if (comando.ExecuteNonQuery() > 1)
                {
                    respuesta = "SE ACTUALIZÓ CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO ACTUALIZAR EL REGISTRO";
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public string ValidarEmpleado(ClaseEmpleados empleado) // Cambiado a "ValidarEmpleado"
        {
            string resultado = null;

            if (empleado.nombreEmpleado.Equals("") || empleado.telefEmpleado.Equals("") || empleado.direccionEmpleado.Equals("") || empleado.estado.Equals(""))
            {
                resultado = "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }
    }
}
