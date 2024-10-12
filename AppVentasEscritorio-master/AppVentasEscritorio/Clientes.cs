using AppVentasEscritorio.utilidades; // Importa tipos definidos en el espacio de nombres AppVentasEscritorio.utilidades
using CapaEntidad; // Importa tipos definidos en el espacio de nombres CapaEntidad
using CapaNegocios; // Importa tipos definidos en el espacio de nombres CapaNegocios
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    public partial class Form_Clientes : Form // Declaración de la clase Detalle_Ventas que hereda de Form
    {
        public Form_Clientes() // Constructor de la clase Detalle_Ventas
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }
        private void Detalle_Ventas_Load(object sender, EventArgs e)
        {
            // Configuración del ComboBox cboestadodeuda
            cbodestadodeuda.Items.Add(new OpcionCombo() { Texto = "Cancelo" });
            cbodestadodeuda.Items.Add(new OpcionCombo() { Texto = "Abono" });

            cbodestadodeuda.DisplayMember = "Texto";



            // comandos barra busqueda
            foreach (DataGridViewColumn columna in dgvdatacliente.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnselecionar") //se omite el boton
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            //Que muestra por definido indice '0'
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";

            List<Cliente> ListaClientes = new CN_Cliente().ListarClientes();

            foreach (Cliente item in ListaClientes)
            {
                dgvdatacliente.Rows.Add(new object[] {"", item.IdCliente,item.NombreCompleto, item.Telefono,item.Correo,
                    item.Estado == true ?1 : 0,
                    item.Estado == true ? "Abono" : "Cancelo"
                });
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Agregar una nueva fila al DataGridView con los datos proporcionados
            dgvdatacliente.Rows.Add(new object[] {"",txtid.Text,txtnombrecompleto.Text,txttelefono.Text,txtcorreo.Text,
                ((OpcionCombo)cbodestadodeuda.SelectedItem).Texto.ToString(),
             });

            limpiar(); // Limpiar los campos después de guardar
        }

        // Método para limpiar los campos del formulario
        private void limpiar()
        {
            txtnombrecompleto.Text = "";
            txttelefono.Text = "";
            txtcorreo.Text = "";
            cbodestadodeuda.SelectedItem = "Abono";
        }

        private void dgvdatacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comandos para enmarcar barra izquierda 
            if (dgvdatacliente.Columns[e.ColumnIndex].Name == "btnselecionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                   /* txtindice.Text = indice.ToString();
                    txtid.Text = dgvdatacliente.Rows[indice].Cells["IdCliente"].Value.ToString();
                    txtnombrecompleto.Text = dgvdatacliente.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txttelefono.Text = dgvdatacliente.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtcorreo.Text = dgvdatacliente.Rows[indice].Cells["Correo"].Value.ToString();

                    foreach (OpcionCombo oc in cbodestadodeuda.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdatacliente.Rows[indice].Cells["EstadoDeuda"].Value))
                        {
                            int indice_combo = cbodestadodeuda.Items.IndexOf(oc);
                            cbodestadodeuda.SelectedIndex = indice_combo;
                            break;

                        }
                        
                    }*/
                }
                else
                {
                    MessageBox.Show("Accion No Valida (Programa BETA).", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvdatacliente_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // pinta un icono en la casilla del boton del Data denominado como columna '0'

            if (e.RowIndex < 0) // rechaza el indice 0 que es la cabecera de Dgvdata
                return;

            if (e.ColumnIndex == 0)
            {
                // Realiza el pintado estándar de la celda
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtén las dimensiones de la imagen
                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;

                // Calcula las coordenadas para centrar la imagen dentro de la celda
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // Dibuja la imagen en la celda
                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }
    }
}

