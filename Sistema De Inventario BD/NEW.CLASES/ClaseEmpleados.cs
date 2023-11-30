using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Inventario_BD.NEW.CLASES
{
    public class ClaseEmpleados
    {
        public string idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string direccionEmpleado { get; set; }
        public string telefEmpleado { get; set; }
        public string estado { get; set; }

        public ClaseEmpleados(string idEmpleado, string nombreEmpleado, string direccionEmpleado, string telefEmpleado, string estado ) 
        {
            this.idEmpleado = idEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.direccionEmpleado = direccionEmpleado;
            this.telefEmpleado = telefEmpleado;
            this.estado = estado;
        }

        public ClaseEmpleados(string nombreEmpleado, string direccionEmpleado, string telefEmpleado)
        {
            this.nombreEmpleado = nombreEmpleado;
            this.direccionEmpleado = direccionEmpleado;
            this.telefEmpleado = telefEmpleado;
        }

        public ClaseEmpleados(string nombreEmpleado, string direccionEmpleado, string telefEmpleado, string estado) 
        {
            this.nombreEmpleado = nombreEmpleado;
            this.direccionEmpleado = direccionEmpleado;
            this.telefEmpleado = telefEmpleado;
            this.estado = estado;
        } 
    }
}
