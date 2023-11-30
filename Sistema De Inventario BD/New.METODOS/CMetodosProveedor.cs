using MySql.Data.MySqlClient;
using Sistema_De_Inventario_BD.New.VISTA;
using Sistema_De_Inventario_BD.NEW.CLASES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Inventario_BD.New.METODOS
{
    internal class CMetodosProveedor
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerProveedores()
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
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

        public string AgregarProveedor(ClaseProveedores proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("AgregarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombreProveedor", MySqlDbType.VarChar).Value = proveedor.nombreProveedor;
                comando.Parameters.Add("@telefProveedor", MySqlDbType.VarChar).Value = proveedor.telefProveedor;
                comando.Parameters.Add("@direccionProveedor", MySqlDbType.VarChar).Value = proveedor.direccionProveedor;

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

        public DataTable BuscarProveedor(string nombre)
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = nombre.Trim();
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

        public string EliminarProveedor(int idProveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("EliminarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProveedor;

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
        public string ActualizarProveedor(int idProveedor, ClaseProveedores proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProveedor;
                comando.Parameters.Add("@nombreProveedor", MySqlDbType.VarChar).Value = proveedor.nombreProveedor;
                comando.Parameters.Add("@telefProveedor", MySqlDbType.VarChar).Value = proveedor.telefProveedor;
                comando.Parameters.Add("@direccionProveedor", MySqlDbType.VarChar).Value = proveedor.direccionProveedor;

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

        public string ValidarProveedor(ClaseProveedores proveedor)
        {
            string resultado = null;

            if (proveedor.nombreProveedor.Equals("") || proveedor.telefProveedor.Equals("") || proveedor.direccionProveedor.Equals(""))
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
