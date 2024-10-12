using AppVentasEscritorio.Modales;
using AppVentasEscritorio.utilidades;
using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    public partial class form_agenda : Form

    {
        public form_agenda()
        {
            InitializeComponent();
            txtvalorrestante.TextChanged += (sender, e) => calcularcambio();
        }

        private void eventos_Load(object sender, EventArgs e)
        {
            //Pintar fecha actual
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            // comandos barra busqueda
            foreach (DataGridViewColumn columna in dgvdataEventos.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            //Que muestra por definido indice '0'
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            //Mostrar todos los Eventos 
            List<Evento> lista = new CN_Evento().Listar();
            if (lista != null && lista.Count > 0)
            {
                foreach (Evento item in lista)
                {
                    dgvdataEventos.Rows.Add(new object[] {
                        item.IdEvento,
                        item.FechaEvento,
                        item.DatosCliente,
                        item.Telefono,
                        item.Direccion,
                        item.DescripcionEvento,
                        item.ValorVenta,
                        item.ValorPagado,
                        item.ValorResta,
                        item.Estado == true ?1 : 0,
                        item.Estado == true ? "Activo" : "No Activo"
                    });
                }
            }
            else
            {
                Console.WriteLine("No hay Eventos para mostrar");
            }

            txtIdProducto.Text = "0";
            txtvalorproducto.Text = "0.00";
            txtvalorpagado.Text = "0.00";
            txtvalorrestante.Text = "0.00";
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal1 = new mdproductos())
            {
                var result = modal1.ShowDialog();

                if (result == DialogResult.OK)
                {

                    txtIdProducto.Text = modal1._Producto.IdProducto.ToString();
                    txtCodigo.Text = modal1._Producto.CodProducto;
                    txtDescripcion.Text = modal1._Producto.DetalleProducto;
                    txtvalorproducto.Text = modal1._Producto.PrecioVenta.ToString();
                    txtvalorpagado.Select();
                }
                else
                {
                    txtCodigo.Select();
                }
            }
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        { //funcionalidad para cuando se escriba el codigo y se de enter se muestre el producto como busqueda
            if (e.KeyData == Keys.Enter)
            {

                Producto pProducto = new CN_Producto().ListarProductos().Where(p => p.CodProducto == txtCodigo.Text && p.Estado == true).FirstOrDefault();

                if (pProducto != null)
                {
                    txtCodigo.BackColor = Color.Honeydew;
                    txtIdProducto.Text = pProducto.IdProducto.ToString();
                    txtDescripcion.Text = pProducto.DetalleProducto;
                    txtvalorproducto.Text = pProducto.PrecioVenta.ToString();
                    txtvalorpagado.Select();
                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtDescripcion.Text = "";
                    txtvalorproducto.Text = "0.00";
                }

            }
        }
        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            //Llamado de procedimiento almacenado para guardar productos
            string mensaje = string.Empty;

            Evento nuevoevento = new Evento()
            {
                FechaEvento = txtfecha.Text,
                DatosCliente = txtnombrecompleto.Text,
                Telefono = txttelefono.Text,
                Direccion = txtdireccion.Text,
                DescripcionEvento = txtdatosevento.Text,
                ValorVenta = decimal.Parse(txtvalorproducto.Text),
                ValorPagado = decimal.Parse(txtvalorpagado.Text),
                ValorResta = decimal.Parse(txtvalorrestante.Text),
                Estado = true,

            };
            LimpiarCampos();

        }
        private void LimpiarCampos()
        {
            txtfecha.Text = "Fecha del evento";
            txtnombrecompleto.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
            txtdatosevento.Text = "";
            txtIdProducto.Text = "0";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtvalorproducto.Text = "0.00";
            txtvalorpagado.Text = "0.00";
            txtvalorrestante.Text = "0.00";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            /*Este código registra cada celda de cada fila y comprueba si el texto de la celda contiene el texto de búsqueda. 
          * Si encuentra una coincidencia en alguna celda de la fila, se muestra esa fila; de lo contrario, se oculta.*/

            string textoBusqueda = txtbusqueda.Text.Trim().ToUpper();

            if (dgvdataEventos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdataEventos.Rows)
                {
                    bool mostrarFila = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            string valorCelda = cell.Value.ToString().Trim().ToUpper();

                            if (valorCelda.Contains(textoBusqueda))
                            {
                                mostrarFila = true;
                                break; // Salir del bucle interno si se encuentra una coincidencia
                            }
                        }
                    }

                    row.Visible = mostrarFila;
                }
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdataEventos.Rows)
            {
                row.Visible = true;
            }
        }
        private void calcularcambio()
        {

            if (string.IsNullOrWhiteSpace(txtvalorproducto.Text))
            {
                MessageBox.Show("El campo 'Total a Pagar' está vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtvalorpagado.Text))
            {
                txtvalorpagado.Text = "0.00"; // Asignar 0 si el campo 'Valor Abono' está vacío
            }

            if (!decimal.TryParse(txtvalorproducto.Text.Trim(), out decimal valorPagado))
            {
                MessageBox.Show("El valor de 'Total a Pagar' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtvalorpagado.Text.Trim(), out decimal valorAbono))
            {
                MessageBox.Show("El valor de 'Valor Abono' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal resta = valorPagado - valorAbono;
            txtvalorrestante.Text = resta.ToString("N2");
        }

        private void txtvalorpagado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void txtvalorproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
