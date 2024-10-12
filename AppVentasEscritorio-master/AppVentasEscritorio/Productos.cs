using AppVentasEscritorio.utilidades;
using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    public partial class form_productos : Form
    {
        public form_productos()
        {
            InitializeComponent();
        }

        private void form_productos_Load(object sender, EventArgs e)
        {
            // Configurar el ComboBox de cbocategoria basado en las columnas del DataGridView

            // comandos barra busqueda
            foreach (DataGridViewColumn columna in dgvdataproductos.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnselec") //se omite el boton
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            //metodo Que muestra por definido indice '0'
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            // Configuración del ComboBox cbodisponible
            cbodisponible.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Disponible" });
            cbodisponible.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Disponible" });
            cbodisponible.DisplayMember = "Texto";
            cbodisponible.ValueMember = "Valor";
            cbodisponible.SelectedIndex = 0;

            // Configuracion cbocategoria
            List<Categoria> lista = new CN_Categoria().Listar();

            foreach (Categoria item in lista)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Detalle });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 1;


            // Cargar lista de Productos
            List<Producto> listaProductos = new CN_Producto().ListarProductos();

            foreach (Producto item in listaProductos)
            {
                dgvdataproductos.Rows.Add(new object[] {"",item.IdProducto, item.CodProducto,item.DetalleProducto,item.PrecioVenta,
                    item.cCategoria.IdCategoria,
                    item.cCategoria.Detalle,
                    item.Estado == true ?1 : 0,
                    item.Estado == true ? "Disponible" : "No Disponible"

                });
            }
        }
        private void limpiar()
        {
            txtIdProducto.Text = "";
            txtindiceproductos.Text = "-1";
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtprecioventa.Text = "";
            cbocategoria.SelectedIndex = 1;
            cbodisponible.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Llamado de procedimiento almacenado para guardar productos
            string mensaje = string.Empty;

            // Validación de entrada para evitar FormatException
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text) ||
                string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                cbocategoria.SelectedItem == null ||
                cbodisponible.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intento de conversión segura
            int idProducto;
            decimal precioVenta;

            if (!int.TryParse(txtIdProducto.Text, out idProducto))
            {
                MessageBox.Show("El campo IdProducto debe ser un número entero válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioVenta))
            {
                MessageBox.Show("El campo Precio de Venta debe ser un número decimal válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creación del objeto Producto y llamada al método de registro
            Producto objproducto = new Producto()
            {
                IdProducto = idProducto,
                CodProducto = txtcodigo.Text,
                DetalleProducto = txtdescripcion.Text,
                PrecioVenta = precioVenta,
                cCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbodisponible.SelectedItem).Valor) == 1 ? true : false
            };

            int idproducto = new CN_Producto().RegistrarProducto(objproducto, out mensaje);

            if (idproducto != 0)
            {
                dgvdataproductos.Rows.Add(new object[] {
            "",
            idproducto,
            txtcodigo.Text,
            txtdescripcion.Text,
            txtprecioventa.Text,
            ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString(),
            ((OpcionCombo)cbodisponible.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cbodisponible.SelectedItem).Texto.ToString()
        });
            }

            limpiar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Validación de entrada
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text) ||
                string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                cbocategoria.SelectedItem == null ||
                cbodisponible.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de editar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir los valores
            int idProducto;
            decimal precioVenta;

            if (!int.TryParse(txtIdProducto.Text, out idProducto))
            {
                MessageBox.Show("El campo IdProducto debe ser un número entero válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioVenta))
            {
                MessageBox.Show("El campo Precio de Venta debe ser un número decimal válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto Producto
            Producto objproducto = new Producto()
            {
                IdProducto = idProducto,
                CodProducto = txtcodigo.Text,
                DetalleProducto = txtdescripcion.Text,
                PrecioVenta = precioVenta,
                cCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbodisponible.SelectedItem).Valor) == 1 ? true : false
            };

            // Llamada al método de edición
            bool resultado = new CN_Producto().EditarProducto(objproducto, out mensaje);

            // Verificar resultado de la edición
            if (resultado)
            {
                // Actualizar la fila en el DataGridView
                DataGridViewRow row = dgvdataproductos.Rows[Convert.ToInt32(txtindiceproductos.Text)];
                row.Cells["IdProducto"].Value = txtIdProducto.Text;
                row.Cells["Codigo"].Value = txtcodigo.Text;
                row.Cells["Descripcion"].Value = txtdescripcion.Text;
                row.Cells["IdCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString();
                row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString();
                row.Cells["EstadoValor"].Value = ((OpcionCombo)cbodisponible.SelectedItem).Valor.ToString();
                row.Cells["Estado"].Value = ((OpcionCombo)cbodisponible.SelectedItem).Texto.ToString();

                // Limpiar los controles del formulario después de editar
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al editar el PRODUCTO: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox tiene un valor numérico válido
            if (int.TryParse(txtIdProducto.Text, out int idproducto) && idproducto != 0)
            {
                // Confirmar la eliminación con un MessageBox
                if (MessageBox.Show("¿Desea eliminar el Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto objproducto = new Producto()
                    {
                        IdProducto = idproducto
                    };

                    // Llamar al método Eliminar del controlador de negocio (CN_Usuario)
                    bool respuesta = new CN_Producto().EliminarProducto(objproducto, out mensaje);

                    // Procesar la respuesta del método Eliminar
                    if (respuesta)
                    {
                        // Eliminar la fila del DataGridView
                        dgvdataproductos.Rows.RemoveAt(Convert.ToInt32(txtindiceproductos.Text)); // Aquí asumo que txtindice contiene el índice a eliminar
                        MessageBox.Show("Producto eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiar();
                    }

                    else
                    {
                        // Mostrar mensaje de error si la eliminación no fue exitosa
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar un Id de Producto válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvdataproductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdataproductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdataproductos.Rows)
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
            foreach (DataGridViewRow row in dgvdataproductos.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvdataproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comandos para enmarcar barra izquierda 
            if (dgvdataproductos.Columns[e.ColumnIndex].Name == "btnselec")//siempre deben ir nombres correctos de las columnas
            {
                int indiceproductos = e.RowIndex;

                if (indiceproductos >= 0)
                {
                    txtindiceproductos.Text = indiceproductos.ToString();
                    txtIdProducto.Text = dgvdataproductos.Rows[indiceproductos].Cells["IdProducto"].Value.ToString();
                    txtcodigo.Text = dgvdataproductos.Rows[indiceproductos].Cells["Codigo"].Value.ToString();
                    txtdescripcion.Text = dgvdataproductos.Rows[indiceproductos].Cells["Descripcion"].Value.ToString();
                    txtprecioventa.Text = dgvdataproductos.Rows[indiceproductos].Cells["PrecioVenta"].Value.ToString();

                    foreach (OpcionCombo oc in cbocategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdataproductos.Rows[indiceproductos].Cells["IdCategoria"].Value))
                        {
                            int indiceproductos_combo = cbocategoria.Items.IndexOf(oc);
                            cbocategoria.SelectedIndex = indiceproductos_combo;
                            break;

                        }
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
