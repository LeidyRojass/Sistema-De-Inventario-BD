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
    public partial class PROVEEDORES : Form
    {
        CMetodosProveedor metodosProveedor;
        DataTable datos;
        int idProveedor = 0;
        public PROVEEDORES()
        {
            InitializeComponent();
        }

        private void BTMOSTRAR_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
        }

        private void BTBUSCAR_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProveedor = new CMetodosProveedor();
            datos = metodosProveedor.BuscarProveedor(TBMOSTRAR.Text.Trim());
            FormatoTablaProveedores(datos);
            LimpiarCampos();
        }

        public void MostrarProveedores()
        {
            metodosProveedor = new CMetodosProveedor();
            datos = metodosProveedor.ObtenerProveedores();
            FormatoTablaProveedores(datos);
        }

        private void BTELIMINAR_Click(object sender, EventArgs e)
        {
            if (idProveedor != 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string resultado = metodosProveedor.EliminarProveedor(idProveedor);
                    MessageBox.Show(resultado);

                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarProveedores();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un proveedor antes de intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nombreProveedor = TBMODPROVEEDOR.Text;
            string telefProveedor = TBMODTELEFONO.Text;
            string direccionProveedor = TBMODDIRECCION.Text;

            ClaseProveedores actualizarProveedor = new ClaseProveedores (nombreProveedor, telefProveedor, direccionProveedor);

            string resultado = metodosProveedor.ValidarProveedor(actualizarProveedor);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedor.ActualizarProveedor(idProveedor, actualizarProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            actualizarProveedor = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreProveedor = TBNOMBRE.Text;
            string telefProveedor = TBTELEFONO.Text;
            string direccionProveedor = TBDIRECCION.Text;


            ClaseProveedores nuevoProveedor = new ClaseProveedores(nombreProveedor, telefProveedor , direccionProveedor);

            string resultado = metodosProveedor.ValidarProveedor(nuevoProveedor);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedor.AgregarProveedor(nuevoProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            nuevoProveedor = null;
        }

        private void PROVEEDORES_Load(object sender, EventArgs e)
        {
            this.MostrarProveedores();
        }

        public void FormatoTablaProveedores(DataTable datos)
        {
            try
            {
                datos.Columns["idProveedor"].ColumnName = "ID";
                datos.Columns["nombreProveedor"].ColumnName = "NOMBRE";
                datos.Columns["telefProveedor"].ColumnName = "TELEFONO";
                datos.Columns["direccionProveedor"].ColumnName = "DIRECCION";
 
                DGVMOSTRARPROV.DataSource = datos;
                DGVMOSTRARPROV.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROV.Columns["NOMBRE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROV.Columns["TELEFONO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROV.Columns["DIRECCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //txtTotalProveedores.Text = "Total de proveedores: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            idProveedor = 0;

            TBNOMBRE.Text = "";
            TBTELEFONO.Text = "";
            TBDIRECCION.Text = "";


            TBMODPROVEEDOR.Text = "";
            TBMODTELEFONO.Text = "";
            TBMODDIRECCION.Text = "";

        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idProveedor = Convert.ToInt32(DGVMOSTRARPROV.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                TBMODPROVEEDOR.Text = DGVMOSTRARPROV.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString().Trim();
                TBMODTELEFONO.Text = DGVMOSTRARPROV.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString().Trim();
                TBMODDIRECCION.Text = DGVMOSTRARPROV.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString().Trim();
            }
        }
    }
}
