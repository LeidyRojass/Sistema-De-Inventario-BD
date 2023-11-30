using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Inventario_BD.NEW.CLASES
{
    internal class CONECTAR
    {
        string db;
        string servidor;
        string usuario;
        string contraseña;
        string ssl;

        public CONECTAR()
        {
            this.db = "SistemadeInventarios";
            this.servidor = "localhost";
            this.usuario = "root";
            this.contraseña = "";
            this.ssl = "None";
        }

        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "Database=" + db +
                    "; Data Source=" + servidor +
                    "; User Id=" + usuario +
                    "; Password=" + contraseña +
                    "; SSL Mode=" + ssl + ";";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }
    }
}
