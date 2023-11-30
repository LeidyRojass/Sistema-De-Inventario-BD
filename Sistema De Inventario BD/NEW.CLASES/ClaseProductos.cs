using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Inventario_BD.NEW.CLASES
{
    public class ClaseProductos
    {
        public string idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string stockProducto { get; set; }
        public string precioProducto { get; set; }
        public string idProveedor { get; set; }
        public string idCategoria { get; set; }

        public ClaseProductos(string idProducto, string nombreProducto, string stockProducto, string precioProducto, string idProveedor, string idCategoria)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.stockProducto = stockProducto;
            this.precioProducto = precioProducto;
            this.idProveedor = idProveedor;
            this.idCategoria = idCategoria;
        }

        public ClaseProductos(string idProducto, string nombreProducto, string stockProducto, string precioProducto, string idProveedor)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.stockProducto = stockProducto;
            this.precioProducto = precioProducto;
            this.idProveedor = idProveedor;
        }

        public ClaseProductos(string idProducto, string nombreProducto, string stockProducto, string precioProducto)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.stockProducto = stockProducto;
            this.precioProducto = precioProducto;
        }

        public ClaseProductos(string idProducto, string nombreProducto, string stockProducto)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.stockProducto = stockProducto;
        }

        public ClaseProductos(string idProducto, string nombreProducto)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
        }
    }
}
