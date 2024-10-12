using AppVentasEscritorio.utilidades;
using CapaDato;
using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            // Configuración del ComboBox cboestado
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            // Configuracion CBO ROL
            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;

            // comandos barra busqueda
            foreach (DataGridViewColumn columna in dgvdatausuario.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnselecionar") //se omite el boton
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            //Que muestra por definido indice '0'
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


            //Mostrar todos los usuarios 
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvdatausuario.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ?1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Llamado de procedimiento almacenado para guardar usuarios

            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };
            int idUsuarioResultado = new CN_Usuario().Registrar(objusuario, out mensaje);

            if (idUsuarioResultado != 0)
            {
                dgvdatausuario.Rows.Add(new object[] { "",idUsuarioResultado,txtdocumento.Text,txtnombrecompleto.Text,txtcorreo.Text,txtclave.Text,
                ((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                });

            }

            limpiar();

        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Verificar si objusuario no es null y si tiene un IdUsuario válido

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };
            // Aquí deberías proceder con la lógica de edición del usuario
            bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);
            if (objusuario.IdUsuario != 0)
            {
                if (resultado)
                {
                    // Realizar acciones adicionales después de la edición exitosa
                    // Por ejemplo, actualizar la fila en el DataGridView
                    DataGridViewRow row = dgvdatausuario.Rows[Convert.ToInt32(txtindiceusuarios.Text)];
                    row.Cells["IdUsuario"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Clave"].Value = txtclave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cborol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    // Limpiar los controles del formulario después de editar
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al editar el usuario: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El objeto de usuario no está correctamente inicializado o no tiene un IdUsuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox tiene un valor numérico válido
            if (int.TryParse(txtid.Text, out int idUsuario) && idUsuario != 0)
            {
                // Confirmar la eliminación con un MessageBox
                if (MessageBox.Show("¿Desea eliminar el Usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = idUsuario
                    };

                    // Llamar al método Eliminar del controlador de negocio (CN_Usuario)
                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    // Procesar la respuesta del método Eliminar
                    if (respuesta)
                    {
                        // Eliminar la fila del DataGridView
                        dgvdatausuario.Rows.RemoveAt(Convert.ToInt32(txtindiceusuarios.Text)); // Aquí asumo que txtindice contiene el índice a eliminar
                        MessageBox.Show("Usuario eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Mostrar mensaje de error si la eliminación no fue exitosa
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe ingresar un Id de Usuario válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void limpiar()
        {
            txtid.Text = "";
            txtindiceusuarios.Text = "-1";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfclave.Text = "";
            cborol.SelectedItem = 0;
            cboestado.SelectedIndex = 0;
        }
        private void dgvdatausuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvdatausuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comandos para enmarcar barra izquierda 
            if (dgvdatausuario.Columns[e.ColumnIndex].Name == "btnselecionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindiceusuarios.Text = indice.ToString();
                    txtid.Text = dgvdatausuario.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtdocumento.Text = dgvdatausuario.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdatausuario.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdatausuario.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdatausuario.Rows[indice].Cells["Clave"].Value.ToString();
                    txtconfclave.Text = dgvdatausuario.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdatausuario.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice_combo;
                            break;

                        }
                    }

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdatausuario.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;

                        }
                    }
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdatausuario.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        { // opciones de busqueda y clasificacion por columna
            string columnafiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdatausuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdatausuario.Rows)
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
