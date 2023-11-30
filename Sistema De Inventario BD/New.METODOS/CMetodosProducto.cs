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
    public class CMetodosProducto
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();
        ClaseProductos producto;
        string nomProducto;

        public DataTable ObtenerProductos()
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Productos", sqlConexion);
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

        public List<ClaseProveedores> ObtenerProveedores()
        {
            List<ClaseProveedores> listaProveedores = new List<ClaseProveedores>();

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Proveedor", sqlConexion);
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaProveedores.Add(
                        new ClaseProveedores(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                        )
                    );
                }

                return listaProveedores;
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

        public List<ClaseCategoria> ObtenerCategorias()
        {
            List<ClaseCategoria> listaCategorias = new List<ClaseCategoria>();

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Categoria", sqlConexion);
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaCategorias.Add(
                        new ClaseCategoria(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                        )
                    );
                }

                return listaCategorias;
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

        public string ValidarProducto(ClaseProductos producto)
        {
            string resultado = null;

            if (producto.nombreProducto.Equals("") || producto.stockProducto.Equals("") || producto.precioProducto.Equals(""))
            {
                resultado = "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }

        public string AgregarProducto(ClaseProductos producto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombreProducto", MySqlDbType.VarChar).Value = producto.nombreProducto;
                comando.Parameters.Add("@precioProducto", MySqlDbType.Decimal).Value = producto.precioProducto;
                comando.Parameters.Add("@stockProducto", MySqlDbType.Int32).Value = producto.stockProducto;
                comando.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = producto.idCategoria;
                comando.Parameters.Add("@idProveedor", MySqlDbType.Int32).Value = producto.idProveedor;

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() == 1)
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

        public string ActualizarProducto(ClaseProductos producto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idProducto_actualizar", MySqlDbType.Int32).Value = Convert.ToInt32(producto.idProducto);
                comando.Parameters.Add("@nombreProducto", MySqlDbType.VarChar).Value = producto.nombreProducto;
                comando.Parameters.Add("@stockProducto", MySqlDbType.Int32).Value = Convert.ToInt32(producto.stockProducto);
                comando.Parameters.Add("@precioProducto", MySqlDbType.Double).Value = Convert.ToDouble(producto.precioProducto);
                comando.Parameters.Add("@idProveedor", MySqlDbType.Int32).Value = Convert.ToInt32(producto.idProveedor);
                comando.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = Convert.ToInt32(producto.idCategoria);

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

        public string EliminarProducto(int idProducto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("EliminarProducto", sqlConexion); // Asegúrate de que el procedimiento almacenado sea el correcto
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProducto;

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
        public DataTable BuscarProducto(string nombreProducto)
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@producto", MySqlDbType.VarChar).Value = nombreProducto.Trim();
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

        public ClaseProductos BuscarProductoVenta(string codigo)
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProductoVenta", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    producto = new ClaseProductos(
                        resultado.GetString(0),
                        resultado.GetString(1),
                        resultado.GetString(2),
                        resultado.GetString(3),
                        resultado.GetString(4)
                    );
                }

                return producto;
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

        public string ObtenerNombreProducto(string codigo)
        {
            try
            {
                sqlConexion = new CONECTAR().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerNombreProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    nomProducto = resultado.GetString(0);
                }

                return nomProducto;
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
    }
}
