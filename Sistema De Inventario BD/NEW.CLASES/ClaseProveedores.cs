using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Inventario_BD.NEW.CLASES
{
    public class ClaseProveedores
    {
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string telefProveedor { get; set; }
        public string direccionProveedor { get; set; }

        public ClaseProveedores(int idProveedor, string nombreProveedor)
        {
            this.idProveedor = idProveedor;
            this.nombreProveedor = nombreProveedor;
        }

        public ClaseProveedores(int idProveedor, string nombreProveedor, string telefProveedor, string direccionProveedor)
        {
            this.idProveedor = idProveedor;
            this.nombreProveedor = nombreProveedor;
            this.telefProveedor = telefProveedor;
            this.direccionProveedor = direccionProveedor;
        }

        public ClaseProveedores(string nombreProveedor, string telefProveedor, string direccionProveedor)
        {
            this.nombreProveedor = nombreProveedor;
            this.telefProveedor = telefProveedor;
            this.direccionProveedor = direccionProveedor;
        }

    }
}
