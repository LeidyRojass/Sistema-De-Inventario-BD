using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Inventario_BD.NEW.CLASES
{
    public class ClaseCategoria
    {
        public int idCategoria { get; set; }
        public string nombreCategoria { get; set; }

        public ClaseCategoria()
        {
            // Constructor sin parámetros
        }
        public ClaseCategoria(int idCategoria, string nombreCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
        }
    }
}
