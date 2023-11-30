using Sistema_De_Inventario_BD.New.METODOS;
using Sistema_De_Inventario_BD.NEW.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Inventario_BD.New.VISTA
{
    public partial class EMPLEADOS : Form
    {
        CMetodosEmpleado metodosEmpleados;
        DataTable datos;
        int idEmpleado = 0;
        public EMPLEADOS()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = TBMODNOMBRE.Text;
            string telefEmpleado = TBMODTELEFONO.Text;
            string direccionEmpleado = TBMODESTADO.Text;
            string estado = TBESTADO.Text;

            ClaseEmpleados actualizarEmpleado = new ClaseEmpleados(nombreEmpleado, telefEmpleado, direccionEmpleado, estado);

            string resultado = metodosEmpleados.ValidarEmpleado(actualizarEmpleado);
            if (resultado.Equals("OK"))
            {
                resultado = metodosEmpleados.ActualizarEmpleado(idEmpleado, actualizarEmpleado);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarEmpleados();
            actualizarEmpleado = null;
        }

        private void EMPLEADOS_Load(object sender, EventArgs e)
        {
            this.MostrarEmpleados();
        }

        public void MostrarEmpleados()
        {
            metodosEmpleados = new CMetodosEmpleado();
            datos = metodosEmpleados.ObtenerEmpleados();
            FormatoTablaEmpleados(datos);
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void FormatoTablaEmpleados(DataTable datos)
        {
            try
            {
                datos.Columns["idEmpleado"].ColumnName = "ID";
                datos.Columns["nombreEmpleado"].ColumnName = "EMPLEADO";
                datos.Columns["telefEmpleado"].ColumnName = "NUMERO CONTACTO";
                datos.Columns["direccionEmpleado"].ColumnName = "DIRECCION";
                datos.Columns["estado"].ColumnName = "ESTADO";

                DGVMOSTRAREMPLEADO.DataSource = datos;
                DGVMOSTRAREMPLEADO.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRAREMPLEADO.Columns["EMPLEADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRAREMPLEADO.Columns["TELEFONO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRAREMPLEADO.Columns["DIRECCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRAREMPLEADO.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //txtTotalProveedores.Text = "Total de proveedores: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            idEmpleado = 0;

            TBNOMBRE.Text = "";
            TBTELEFONO.Text = "";
            TBDIRECCION.Text = "";
            TBESTADO.Text = "";

            TBMODNOMBRE.Text = "";
            TBMODTELEFONO.Text = "";
            TBMODDIRECCION.Text = "";
            TBMODESTADO.Text = "";
        }
        private void DGVEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idEmpleado = Convert.ToInt32(DGVMOSTRAREMPLEADO.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                TBMODNOMBRE.Text = DGVMOSTRAREMPLEADO.Rows[e.RowIndex].Cells["EMPLEADO"].Value.ToString().Trim();
                TBMODTELEFONO.Text = DGVMOSTRAREMPLEADO.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString().Trim();
                TBMODDIRECCION.Text = DGVMOSTRAREMPLEADO.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString().Trim();
                TBMODESTADO.Text = DGVMOSTRAREMPLEADO.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString().Trim();
            }
        }

        private void BTELIMINAR_Click(object sender, EventArgs e)
        {
            if (idEmpleado != 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string resultado = metodosEmpleados.EliminarEmpleado(idEmpleado);
                    MessageBox.Show(resultado);

                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado antes de intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTAGREGAR_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = TBNOMBRE.Text;
            string telefonoEmpleado = TBTELEFONO.Text;
            string direccionEmpleado = TBDIRECCION.Text;
            string estado = TBESTADO.Text;

            ClaseEmpleados nuevoEmpleado = new ClaseEmpleados(nombreEmpleado, telefonoEmpleado, direccionEmpleado, estado);

            string resultado = metodosEmpleados.ValidarEmpleado(nuevoEmpleado);
            {
                resultado = metodosEmpleados.AgregarEmpleado(nuevoEmpleado);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarEmpleados();
            nuevoEmpleado = null;
        }

        private void BTBUSCAR_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosEmpleados = new CMetodosEmpleado();
            datos = metodosEmpleados.BuscarEmpleado(BTBUSCAR.Text.Trim());
            FormatoTablaEmpleados(datos);
            LimpiarCampos();
        }

        private void BTMOSTRAR_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarEmpleados();
        }
    }
}
