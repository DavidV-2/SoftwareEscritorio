using AppVentasEscritorio.utilidades;
using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppVentasEscritorio.Modales
{
    public partial class mdproductos : Form
    {
        public Producto _Producto { get; set; }
        public mdproductos()
        {
            InitializeComponent();
        }

        private void mdproductos_Load(object sender, EventArgs e)
        {
            // comandos barra busqueda
            foreach (DataGridViewColumn columna in dgvdataproducto.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            //metodo Que muestra por definido indice '0'
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            // Cargar lista de Productos
            List<Producto> listaProductos = new CN_Producto().ListarProductos();

            foreach (Producto item in listaProductos)
            {
                dgvdataproducto.Rows.Add(new object[] {
                    item.IdProducto,
                    item.CodProducto,
                    item.DetalleProducto,
                    item.cCategoria.Detalle,
                    item.PrecioVenta,
                });
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdataproducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdataproducto.Rows)
                {

                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdataproducto.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvdataproducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // al dar doble click en el producto el modal desaparecera

            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum > 0)
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgvdataproducto.Rows[iRow].Cells["IdProducto"].Value.ToString()),
                    CodProducto = dgvdataproducto.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    DetalleProducto = dgvdataproducto.Rows[iRow].Cells["Descripcion"].Value.ToString(),
                    PrecioVenta = Convert.ToDecimal(dgvdataproducto.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
