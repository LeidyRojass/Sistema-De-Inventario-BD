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
    public partial class PRODUCTOS : Form
    {
        CMetodosProducto metodosProductos;
        DataTable datos;
        int idProducto = 0;
        public PRODUCTOS()
        {
            InitializeComponent();
        }

        private void BTBUSCAR_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProductos = new CMetodosProducto();
            datos = metodosProductos.BuscarProducto(TBMOSTRAR.Text.Trim());
            FormatoTablaProductos(datos);
            LimpiarCampos();
        }

        private void BTELIMINAR_Click(object sender, EventArgs e)
        {
            if (idProducto != 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string resultado = metodosProductos.EliminarProducto(idProducto);
                    MessageBox.Show(resultado);

                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarProductos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto antes de intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            this.MostrarProductos();
            this.MostrarProveedores(CBPROVEEDOR);
            this.MostrarProveedores(CBMODPROVEEDOR);
            this.MostrarCategorias(CBCATEGORIA);
            this.MostrarCategorias(CBMODCATEGORIA);
        }


        private void BTMOSTRAR_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProductos();
        }
        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idProducto = Convert.ToInt32(DGVMOSTRARPROD.Rows[e.RowIndex].Cells["ID PRODUCTO"].Value.ToString().Trim());
                TBMODID.Text = DGVMOSTRARPROD.Rows[e.RowIndex].Cells["ID PRODUCTO"].Value.ToString().Trim();
                TBMODPRODUCTO.Text = DGVMOSTRARPROD.Rows[e.RowIndex].Cells["PRODUCTO"].Value.ToString().Trim();
                TBMODSTOCK.Text = DGVMOSTRARPROD.Rows[e.RowIndex].Cells["STOCK"].Value.ToString().Trim();
                TBMODPRECIO.Text = DGVMOSTRARPROD.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString().Trim();
                CBMODPROVEEDOR.SelectedIndex = Convert.ToInt32(DGVMOSTRARPROD.Rows[e.RowIndex].Cells["ID PROVEEDOR"].Value.ToString().Trim());
                CBMODCATEGORIA.SelectedIndex = Convert.ToInt32(DGVMOSTRARPROD.Rows[e.RowIndex].Cells["ID CATEGORIA"].Value.ToString().Trim());
            }
        }
        private void LimpiarCampos()
        {
            idProducto = 0;

            TBIDPRODUCTO.Text = "";
            TBPRODUCTO.Text = "";
            TBSTOCK.Text = "";
            TBPRECIO.Text = "";
            CBPROVEEDOR.SelectedIndex = 0;
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void MostrarProductos()
        {
            metodosProductos = new CMetodosProducto();
            datos = metodosProductos.ObtenerProductos();
            FormatoTablaProductos(datos);
        }
        private void MostrarCategorias(ComboBox CBCATEGORIA)
        {
            List<ClaseCategoria> datos = metodosProductos.ObtenerCategorias();
            CBCATEGORIA.Items.Add("Selecciona una opción");
            foreach (ClaseCategoria dato in datos)
            {
                CBCATEGORIA.Items.Add(dato.idCategoria + "," + dato.nombreCategoria);
            }
            CBCATEGORIA.SelectedIndex = 0;
        }
        private void MostrarProveedores(ComboBox CBProveedor)
        {
            List<ClaseProveedores> datos = metodosProductos.ObtenerProveedores();
            CBPROVEEDOR.Items.Add("Selecciona una opción");
            foreach (ClaseProveedores dato in datos)
            {
                CBPROVEEDOR.Items.Add(dato.idProveedor + "," + dato.nombreProveedor);
            }
            CBPROVEEDOR.SelectedIndex = 0;
        }
        public void FormatoTablaProductos(DataTable datos)
        {
            try
            {
                datos.Columns["idProducto"].ColumnName = "ID PRODUCTO";
                datos.Columns["nombreProducto"].ColumnName = "PRODUCTO";
                datos.Columns["stockProducto"].ColumnName = "STOCK";
                datos.Columns["precioProducto"].ColumnName = "PRECIO";
                datos.Columns["idProveedor"].ColumnName = "ID PROVEEDOR";
                datos.Columns["idCategoria"].ColumnName = "ID CATEGORIA";

                DGVMOSTRARPROD.DataSource = datos;
                DGVMOSTRARPROD.Columns["ID PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROD.Columns["PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROD.Columns["STOCK"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROD.Columns["PRECIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROD.Columns["ID PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVMOSTRARPROD.Columns["ID CATEGORIA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //txtTotalProductos.Text = "Total de productos: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTACTUALIZAR_Click(object sender, EventArgs e)
        {
            string idProducto = TBMODID.Text.Trim();
            string nomProducto = TBMODPRODUCTO.Text.Trim();
            string stock = TBMODSTOCK.Text.Trim();
            string precio = TBMODPRECIO.Text.Trim();


            string cadenaProveedores = CBMODPROVEEDOR.SelectedItem.ToString();
            string cadenaCategorias = CBMODCATEGORIA.SelectedItem.ToString();

            if (CBMODPROVEEDOR.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            if (CBMODCATEGORIA.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            else
            {
                string[] valoresProveedores = cadenaProveedores.Split(',');
                string idProveedor = valoresProveedores[0].Trim();

                string[] valoresCategorias = cadenaCategorias.Split(',');
                string idCategoria = valoresCategorias[0].Trim();

                ClaseProductos actualizarProducto = new ClaseProductos(idProducto, nomProducto, stock,  idProveedor, idCategoria);
                string resultado = metodosProductos.ValidarProducto(actualizarProducto);
                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.ActualizarProducto(actualizarProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                actualizarProducto = null;
            }
        }

        private void BTAGREGAR_Click(object sender, EventArgs e)
        {
            // string idProducto = tbIdProducto.Text.Trim();
            string nombreProducto = TBPRODUCTO.Text.Trim();
            string stock = TBSTOCK.Text.Trim();
            string precio = TBPRECIO.Text.Trim();

            string cadenaProveedores = CBPROVEEDOR.SelectedItem.ToString();
            string cadenaCategorias = CBCATEGORIA.SelectedItem.ToString();

            if (CBPROVEEDOR.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            else
            {
                string[] valoresProveedores = cadenaProveedores.Split(',');
                string idProveedor = valoresProveedores[0].Trim();

                string[] valoresCategorias = cadenaCategorias.Split(',');
                string idCategoria = valoresCategorias[0].Trim();

                ClaseProductos nuevoProducto = new ClaseProductos("", nombreProducto, stock, precio, idProveedor, idCategoria);

                string resultado = metodosProductos.ValidarProducto(nuevoProducto);

                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.AgregarProducto(nuevoProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                nuevoProducto = null;
            }
        }
    }
}
