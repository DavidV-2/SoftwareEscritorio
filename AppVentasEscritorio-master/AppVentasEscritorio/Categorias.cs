using AppVentasEscritorio.utilidades;
using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            //Configuración del ComboBox cboestado

            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            // comandos barra busqueda
            foreach (DataGridViewColumn columna in dgvcategoria.Columns)
            {
                if (columna.Visible == true && columna.Name != "Selec") //se omite el boton
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            //Que muestra por definido indice '0'
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            // Cargar lista de Categorias
            List<Categoria> lista = new CN_Categoria().Listar();

            if (lista != null && lista.Count > 0)
            {
                foreach (Categoria item in lista)
                {
                    dgvcategoria.Rows.Add(new object[] {"",item.IdCategoria,
                    item.Detalle,
                    item.Estado == true ?1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                    });
                }
            }                
        }

        private void dgvcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comandos para enmarcar barra izquierda 
            if (dgvcategoria.Columns[e.ColumnIndex].Name == "Selec")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindicecategoria.Text = indice.ToString();
                    txtidcategoria.Text = dgvcategoria.Rows[indice].Cells["IdCategoria"].Value.ToString();
                    txtdetalle.Text = dgvcategoria.Rows[indice].Cells["Detalle"].Value.ToString();

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvcategoria.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;

                        }
                    }
                }
            }
        }

        private void dgvcategoria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnbuscarCategorias_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvcategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvcategoria.Rows)
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
            foreach (DataGridViewRow row in dgvcategoria.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entrada de usuario
                if (string.IsNullOrWhiteSpace(txtdetalle.Text))
                {
                    MessageBox.Show("Por favor, ingrese un detalle para la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamado de procedimiento almacenado para guardar
                string mensaje = string.Empty;
                Categoria objCategoria = new Categoria()
                {
                    Detalle = txtdetalle.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
                };
                int idCategoria = new CN_Categoria().RegistrarCategoria(objCategoria, out mensaje);

                if (idCategoria != 0)
                {
                    // Agregar la nueva categoría al DataGridView
                    dgvcategoria.Rows.Add("", idCategoria, txtdetalle.Text,
                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString());

                    // Limpiar campos después de guardar
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al intentar guardar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Verificar si objCategoria no es null y si tiene un IdCategoria válido

            Categoria objcategoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtidcategoria.Text),
                Detalle = txtdetalle.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };
            // Aquí deberías proceder con la lógica de edición
            bool resultado = new CN_Categoria().EditarCategoria(objcategoria, out mensaje);
            if (objcategoria.IdCategoria != 0)
            {
                if (resultado)
                {
                    // Realizar acciones adicionales después de la edición exitosa
                    // Por ejemplo, actualizar la fila en el DataGridView
                    DataGridViewRow row = dgvcategoria.Rows[Convert.ToInt32(txtindicecategoria.Text)];
                    row.Cells["IdCategoria"].Value = txtidcategoria.Text;
                    row.Cells["Detalle"].Value = txtdetalle.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    limpiar();
                }

                else
                {
                    MessageBox.Show("Error al editar Categoria: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox tiene un valor numérico válido
            if (Convert.ToInt32(txtidcategoria.Text) != 0)
            {
                // Confirmar la eliminación con un MessageBox
                if (MessageBox.Show("¿Desea eliminar el Categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria objcategoria = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txtidcategoria.Text),
                    };

                    // Llamar al método Eliminar del controlador de negocio (CN_Categoria)
                    bool respuesta = new CN_Categoria().EliminarCategoria(objcategoria, out mensaje);

                    // Procesar la respuesta del método Eliminar
                    if (respuesta)
                    {
                        // Eliminar la fila del DataGridView
                        dgvcategoria.Rows.RemoveAt(Convert.ToInt32(txtindicecategoria.Text)); // Aquí asumo que txtindice contiene el índice a eliminar
                        MessageBox.Show("Categoria eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        // Mostrar mensaje de error si la eliminación no fue exitosa
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un Id de Categoria válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtidcategoria.Text = "";
            txtindicecategoria.Text = "-1";
            txtdetalle.Text = "";
            cboestado.SelectedIndex = 0;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // opciones de busqueda y clasificacion por columna
            string columnafiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvcategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvcategoria.Rows)
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
    }
}
