using AppVentasEscritorio.Modales; // Importa el espacio de nombres para modales
using AppVentasEscritorio.utilidades; // Importa utilidades
using CapaEntidad; // Importa capa de entidad
using CapaNegocios; // Importa capa de negocios
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Color = System.Drawing.Color; // Alias para la clase Color

namespace AppVentasEscritorio
{
    public partial class frm_ventas : Form
    {
        private Usuario _Usuario; // Variable para almacenar el usuario logueado
        private Venta _Venta; // Variable para almacenar la venta

        // Constructor para inicializar el formulario con un usuario
        public frm_ventas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // Constructor para inicializar el formulario con una venta
        public frm_ventas(Venta oVenta = null)
        {
            _Venta = oVenta;
            InitializeComponent(); // Inicializa los componentes del formulario

            // Eventos para actualizar el total cuando cambian ciertos campos
            txtconteounidad.ValueChanged += (sender, e) => ActualizarTotal();
            txtvalorunidad.TextChanged += (sender, e) => ActualizarTotal();
            txtValorVenta.TextChanged += (sender, e) => CalcularTotal();
            txtValorResta.TextChanged += (sender, e) => calcularcambio();
            txtdiario.TextChanged += (sender, e) => SumarVentaDiaria();
        }

        // Evento que se ejecuta al cargar el formulario
        private void Ventas_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            dateTimePicker1.Value = DateTime.Now; // Establecer la fecha actual
            dateTimePicker1.Visible = true; // Hacer visible el DateTimePicker
            txtIdProducto.Text = "0"; // Establecer el ID del producto en 0
            txtvalorunidad.Text = "0.00"; // Establecer el valor de la unidad en 0.00

        }
        private void ConfigurarControles()
        {
            // Configuración del ComboBox para el estado de deuda
            cbodestadodeuda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Abono" });
            cbodestadodeuda.Items.Add(new OpcionCombo() { Valor = 1, Texto = "No Abono" });
            cbodestadodeuda.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Cancelo" });
            cbodestadodeuda.DisplayMember = "Texto";
            cbodestadodeuda.ValueMember = "Valor";
            cbodestadodeuda.SelectedIndex = 0; // Selecciona el primer ítem

            // Configuración del ComboBox para el producto
            List<ProductoDetal> lista = new CN_ProductoDetal().Listar(); // Lista de productos

            // Agregar elementos al ComboBox cboproductodetal
            foreach (ProductoDetal item in lista)
            {
                cboproductodetal.Items.Add(new OpcionCombo() { Valor = item.IdProducto, Texto = item.Producto });
            }
            // Configurar DisplayMember, ValueMember y SelectedIndex
            if (cboproductodetal.Items.Count > 0)
            {
                cboproductodetal.DisplayMember = "Texto";
                cboproductodetal.ValueMember = "Valor";
                cboproductodetal.SelectedIndex = 0;  // Establecer el primer ítem como seleccionado inicialmente

                if (cboproductodetal.SelectedItem is OpcionCombo opcionSeleccionada)
                {
                    var productoSeleccionado = lista.FirstOrDefault(p => p.IdProducto == (int)opcionSeleccionada.Valor);
                    if (productoSeleccionado != null)
                    {
                        txtIdProductoDetal.Text = productoSeleccionado.IdProducto.ToString();
                        txtvalorunidad.Text = productoSeleccionado.PrecioVenta.ToString("N2");
                    }
                }
            }
            else
            {
                // Manejar caso donde no hay elementos en el ComboBox
                MessageBox.Show("No hay productos disponibles para seleccionar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Evento para manejar la selección de un producto en el ComboBox
            cboproductodetal.SelectedIndexChanged += (sender, e) =>
            {
                if (cboproductodetal.SelectedItem is OpcionCombo opcionSeleccionada)
                {
                    var productoSeleccionado = lista.FirstOrDefault(p => p.IdProducto == (int)opcionSeleccionada.Valor);
                    if (productoSeleccionado != null)
                    {
                        txtIdProductoDetal.Text = productoSeleccionado.IdProducto.ToString();
                        txtvalorunidad.Text = productoSeleccionado.PrecioVenta.ToString("N2");
                    }
                }
            };

            // Inicialización de componentes
            dateTimePicker1.Text = DateTime.Now.ToString(""); // Establece la fecha actual
            dateTimePicker1.Visible = true; // Hace visible el DateTimePicker
            txtIdProducto.Text = "0"; // Establece el ID del producto en 0
            txtvalorunidad.Text = "0.00"; // Establece el valor de la unidad en 0.00
        }
        // Evento para manejar el botón de guardar detalle de venta
        private void btnguardarsqldetal_Click(object sender, EventArgs e)
        {
            // Validación para asegurarse de que hay productos a guardar
            if (dgvdataventadetal.Rows.Count < 1)
            {
                MessageBox.Show("No hay Productos a Guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear DataTable para el detalle de venta
            DataTable Detalle_Venta_Detal = new DataTable();
            Detalle_Venta_Detal.Columns.Add("IdProductoDetal", typeof(int));
            Detalle_Venta_Detal.Columns.Add("Producto", typeof(string));
            Detalle_Venta_Detal.Columns.Add("Unidades", typeof(int));
            Detalle_Venta_Detal.Columns.Add("Total", typeof(decimal));

            // Llenar el DataTable con los datos del DataGridView 
            foreach (DataGridViewRow row in dgvdataventadetal.Rows)
            {
                try
                {
                    int IdProductoDetal = Convert.ToInt32(row.Cells["IdProductoDetal"].Value);
                    Detalle_Venta_Detal.Rows.Add(
                        new object[] {
                            Convert.ToInt32(row.Cells["IdProductoDetal"].Value),
                            row.Cells["Producto"].Value.ToString(),
                            Convert.ToInt32(row.Cells["Unidades"].Value),
                            Convert.ToDecimal(row.Cells["Total"].Value)
                        });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar los datos de la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Obtener el número consecutivo para la venta
            int idcorrelativo = new CN_Venta_Detal().ObtenerCorrelativo();
            string numeroconsecutivo = string.Format("{0:00000}", idcorrelativo);

            // Crear una nueva instancia de ProductoDetal y Venta_Detal
            ProductoDetal producto = new ProductoDetal()
            {
                IdProducto = Convert.ToInt32(dgvdataventadetal.Rows[0].Cells["IdProductoDetal"].Value),
                Producto = dgvdataventadetal.Rows[0].Cells["Producto"].Value.ToString(),
            };

            Venta_Detal vVentaDetal = new Venta_Detal()
            {
                IdProducto = txtIdProductoDetal.Text,
                pdProducto = producto,
                Cantidad = Convert.ToInt32(txtconteounidad.Text),
                PrecioVenta = Convert.ToDecimal(txtdiario.Text),
                NumeroConsecutivo = numeroconsecutivo,
            };

            // Registrar la venta y manejar la respuesta
            string mensaje = string.Empty;
            bool respuesta = new CN_Venta_Detal().Registrar(vVentaDetal, Detalle_Venta_Detal, out mensaje);

            if (respuesta)
            {
                // Mostrar mensaje de éxito y preguntar si se quiere copiar el número consecutivo al portapapeles
                var result = MessageBox.Show("Numero de Venta Generado: \n" + numeroconsecutivo + "\n\n¿Desea copiar al portapapeles?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroconsecutivo);

                // Resetear campos y limpiar el DataGridView
                txtvalorunidad.Text = "0.00";
                txttotalpago.Text = "0.00";
                txtdiario.Text = "0.00";
                cboproductodetal.SelectedIndex = 0;
                txtconteounidad.Value = 1;
                dgvdataventadetal.Rows.Clear();
                ActualizarTotal();
                SumarVentaDiaria();
            }
            else
            {
                MessageBox.Show($"Error al procesar la venta: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        // Evento para agregar un producto al detalle de la venta
        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal PrecioVenta = 0;
            bool producto_existe = false;
            // Verifica si se ha seleccionado un producto mediante su Id
            if (int.Parse(txtIdProductoDetal.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Verifica si se ha seleccionado un producto en el ComboBox
            if (cboproductodetal.SelectedItem == null || !(cboproductodetal.SelectedItem is OpcionCombo))
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifica que el valor de venta tenga el formato correcto
            if (!decimal.TryParse(txtvalorunidad.Text, out PrecioVenta))
            {
                MessageBox.Show("ValorVenta - Formato cadena incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            // Verifica si ya existe el producto en el DataGridView 'dgvdataVentaMasiva'
            foreach (DataGridViewRow fila in dgvdataVentaMasiva.Rows)
            {
                if (fila.Cells["IdProductoDetal"].Value.ToString() == txtIdProductoDetal.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            // Verificar si el producto ya existe en el DataGridView
            foreach (DataGridViewRow fila in dgvdataVentaMasiva.Rows)
            {
                if (fila.Cells["IdProductoDetal"].Value.ToString() == txtIdProductoDetal.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            // Si no existe, agregar el producto al DataGridView
            if (!producto_existe)
            {
                dgvdataventadetal.Rows.Add(new object[]
                {
                    txtIdProductoDetal.Text,
                    ((OpcionCombo)cboproductodetal.SelectedItem).Texto,
                    txtconteounidad.Value.ToString(),
                    (txtconteounidad.Value * PrecioVenta).ToString("N2")
                });
                ActualizarTotal();
                SumarVentaDiaria();
                limpiar();
            }
        }
        private void limpiar()
        {
            // Método para limpiar los campos relacionados con el detalle de venta
            txtvalorunidad.Text = "0.00";
            txttotalpago.Text = "0.00";
            txtconteounidad.Value = 1;
            cboproductodetal.SelectedIndex = 0;
        }

        private void dgvdataventadetal_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Evento para personalizar la apariencia de las celdas en el DataGridView 'dgvdataventadetal'

            if (e.RowIndex < 0) // Ignora la cabecera del DataGridView
                return;

            // Pinta un icono en la celda de la columna 'btneliminardet'
            if (e.ColumnIndex == 4)
            {
                // Realiza el pintado estándar de la celda
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtiene las dimensiones de la imagen de eliminación
                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;

                // Calcula las coordenadas para centrar la imagen dentro de la celda
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // Dibuja la imagen en la celda
                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdataventadetal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento que maneja el clic en contenido de celda en 'dgvdataventadetal'

            if (dgvdataventadetal.Columns[e.ColumnIndex].Name == "btneliminardet")
            {
                // Verifica si se hizo clic en el botón de eliminar
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    // Elimina la fila correspondiente al índice seleccionado
                    dgvdataventadetal.Rows.RemoveAt(indice);
                    SumarVentaDiaria(); // Actualiza el total de ventas diarias
                }
            }
        }

        // Método para agregar una venta masiva
        private void bntagregarventa_Click(object sender, EventArgs e)
        {
            // Variables locales para los valores de venta
            decimal ValorVenta = 0;
            decimal ValorPagado = 0;
            decimal ValorResta = 0;
            bool producto_existe = false;

            // Verifica si se ha seleccionado un producto mediante su Id
            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifica que el valor de venta tenga el formato correcto
            if (!decimal.TryParse(txtValorProducto.Text, out ValorVenta))
            {
                MessageBox.Show("ValorVenta - Formato cadena incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValorAbono.Select();
                return;
            }

            // Verifica si ya existe el producto en el DataGridView 'dgvdataVentaMasiva'
            foreach (DataGridViewRow fila in dgvdataVentaMasiva.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            // Si el producto no existe, lo agrega al DataGridView 'dgvdataVentaMasiva'
            if (!producto_existe)
            {
                dgvdataVentaMasiva.Rows.Add(new object[]
                {
            txtIdProducto.Text,
            txtCodProducto.Text,
            txtDetalleProducto.Text,
            txtDatosCliente.Text,
            txttelefono.Text,
            txtEspecificaciones.Text,
            ValorVenta.ToString("N2"),
            ValorPagado.ToString("N2"),
            ValorResta.ToString("N2"),
            (txtcantidad.Value * ValorVenta).ToString("N2"),
            txtcantidad.Value.ToString(),
            ((OpcionCombo)cbodestadodeuda.SelectedItem).Texto.ToString()
                });

                CalcularTotal(); // Calcula el total de la venta masiva
                limpiarProductos(); // Limpia los campos relacionados con los productos
                txtCodProducto.Select(); // Establece el foco en el campo de código de producto
            }
        }

        // Método para calcular el total de la venta masiva
        private void CalcularTotal()
        {
            decimal Subtotal = 0;

            if (dgvdataVentaMasiva.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdataVentaMasiva.Rows)
                {
                    Subtotal += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }

            txtValorVenta.Text = Subtotal.ToString("N2"); // Muestra el subtotal en el campo de texto correspondiente
        }

        // Método para sumar las ventas diarias
        private void SumarVentaDiaria()
        {
            decimal TotalVenta = 0;

            try
            {
                if (dgvdataventadetal.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvdataventadetal.Rows)
                    {
                        // Verificar si el valor de la celda "Total" no es null antes de intentar convertirlo
                        if (row.Cells["Total"].Value != null)
                        {
                            TotalVenta += Convert.ToDecimal(row.Cells["Total"].Value.ToString());
                        }
                    }
                }
                txtdiario.Text = TotalVenta.ToString("N2"); // Muestra el total de ventas diarias en el campo correspondiente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al sumar ventas diarias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos relacionados con los productos
        private void limpiarProductos()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtDetalleProducto.Text = "";
            txtValorProducto.Text = "0.00";
            cbodestadodeuda.SelectedIndex = 0;
            txtcantidad.Value = 1;
        }

        // Evento para buscar productos mediante un formulario modal
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (var modal1 = new mdproductos())
            {
                var result = modal1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Actualiza los campos con la información del producto seleccionado
                    txtIdProducto.Text = modal1._Producto.IdProducto.ToString();
                    txtCodProducto.Text = modal1._Producto.CodProducto;
                    txtDetalleProducto.Text = modal1._Producto.DetalleProducto;
                    txtValorProducto.Text = modal1._Producto.PrecioVenta.ToString();
                    txtcantidad.Select(); // Establece el foco en el campo de cantidad
                }
                else
                {
                    txtCodProducto.Select(); // Establece el foco en el campo de código de producto
                }
            }
        }

        // Evento para personalizar la apariencia de las celdas en el DataGridView 'dgvdataVentaMasiva'
        private void dgvdataVentaMasiva_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) // Ignora la cabecera del DataGridView
                return;

            // Pinta un icono en la celda de la columna 'btneliminar'
            if (e.ColumnIndex == 12)
            {
                // Realiza el pintado estándar de la celda
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtiene las dimensiones de la imagen de eliminación
                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;

                // Calcula las coordenadas para centrar la imagen dentro de la celda
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // Dibuja la imagen en la celda
                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        // Evento que maneja el clic en contenido de celda en 'dgvdataVentaMasiva'
        private void dgvdataVentaMasiva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdataVentaMasiva.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                // Verifica si se hizo clic en el botón de eliminar
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    // Elimina la fila correspondiente al índice seleccionado
                    dgvdataVentaMasiva.Rows.RemoveAt(indice);
                    CalcularTotal(); // Calcula el total de la venta masiva
                }
            }
        }

        // Evento para registrar la venta masiva
        private void btnregistar_Click_1(object sender, EventArgs e)
        {
            // Verifica que se hayan ingresado productos en la venta masiva
            if (dgvdataVentaMasiva.Rows.Count < 1)
            {
                MessageBox.Show("Debe Ingresar Productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crea un DataTable para almacenar el detalle de la venta
            DataTable Detalle_Venta = new DataTable();
            Detalle_Venta.Columns.Add("IdProducto", typeof(int));
            Detalle_Venta.Columns.Add("CodProducto", typeof(string));
            Detalle_Venta.Columns.Add("DetalleProducto", typeof(string));
            Detalle_Venta.Columns.Add("DatosCliente", typeof(string));
            Detalle_Venta.Columns.Add("Telefono", typeof(string));
            Detalle_Venta.Columns.Add("Especificaciones", typeof(string));
            Detalle_Venta.Columns.Add("ValorVenta", typeof(decimal));
            Detalle_Venta.Columns.Add("ValorPagado", typeof(decimal));
            Detalle_Venta.Columns.Add("ValorResta", typeof(decimal));
            Detalle_Venta.Columns.Add("SubTotal", typeof(decimal));
            Detalle_Venta.Columns.Add("Cantidad", typeof(int));
            Detalle_Venta.Columns.Add("EstadoDeuda", typeof(string));

            // Recolectar datos de DataGridView
            foreach (DataGridViewRow row in dgvdataVentaMasiva.Rows)
            {

                Detalle_Venta.Rows.Add(
                    new object[] {
                        Convert.ToInt32(row.Cells["IdProducto"].Value),
                        row.Cells["CodProducto"].Value.ToString(),
                        row.Cells["DetalleProducto"].Value.ToString(),
                        row.Cells["DatosCliente"].Value.ToString(),
                        row.Cells["Telefono"].Value.ToString(),
                        row.Cells["Especificaciones"].Value.ToString(),
                        Convert.ToDecimal(row.Cells["ValorProducto"].Value),
                        Convert.ToDecimal(row.Cells["ValorPagado"].Value),
                        Convert.ToDecimal(row.Cells["ValorResta"].Value),
                        Convert.ToDecimal(row.Cells["SubTotal"].Value),
                        Convert.ToInt32(row.Cells["Cantidad"].Value),
                        row.Cells["EstadoDeuda"].Value.ToString(),
                });
            }
            // Obtener el correlativo para la venta
            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroconsecutivo = string.Format("{0:00000}", idcorrelativo);

            // Crear objeto Producto desde el primer producto en la grilla
            Producto producto = new Producto()
            {
                IdProducto = Convert.ToInt32(dgvdataVentaMasiva.Rows[0].Cells["IdProducto"].Value),
                CodProducto = dgvdataVentaMasiva.Rows[0].Cells["CodProducto"].Value.ToString(),
                DetalleProducto = dgvdataVentaMasiva.Rows[0].Cells["DetalleProducto"].Value.ToString(),
            };

            Venta vVentamasiva = new Venta()
            {
                IdProducto = txtIdProducto.Text,
                pProducto = producto,
                DatosCliente = txtDatosCliente.Text,
                Telefono = txttelefono.Text,
                Especificaciones = txtEspecificaciones.Text,
                ValorVenta = Convert.ToDecimal(txtValorProducto.Text),
                ValorPagado = Convert.ToDecimal(txtValorAbono.Text),
                ValorResta = Convert.ToDecimal(txtValorResta.Text),
                SubTotal = Convert.ToDecimal(txtValorVenta.Text),
                Cantidad = Convert.ToInt32(txtcantidad.Text),
                EstadoDeuda = ((OpcionCombo)cbodestadodeuda.SelectedItem).Texto,
                NumeroConsecutivo = numeroconsecutivo,

            };
            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().RegistrarVentaMasiva(vVentamasiva, Detalle_Venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de Venta Generado: \n" + numeroconsecutivo + "\n\n¿Desea copiar al portapapeles?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroconsecutivo);

                txtIdProducto.Text = "0";
                txtCodProducto.Text = "";
                txtDetalleProducto.Text = "";
                txtValorProducto.Text = "0.00";
                txtValorAbono.Text = "0.00";
                txtValorResta.Text = "0.00";
                txtValorVenta.Text = "0.00";
                cbodestadodeuda.SelectedIndex = 0;
                txtcantidad.Value = 1;
                dgvdataVentaMasiva.Rows.Clear();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Desabilitar comandos o campos
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Validar que el sender sea un TextBox
            if (textBox == null)
                return;

            // Si el TextBox es uno de los que deben permitir solo números y punto decimal
            if (textBox == txtValorAbono || textBox == txtValorResta || textBox == txtvalorunidad)
            {
                // Permitir dígitos y punto decimal
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
                {
                    // Verificar que no haya más de un punto decimal
                    if (e.KeyChar == '.' && textBox.Text.Contains('.'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false; // Permitir teclas de control (como Backspace)
                }
                else
                {
                    e.Handled = true; // Bloquear cualquier otro carácter
                }
            }
            else
            {
                e.Handled = true; // Bloquear entrada de texto para otros TextBox
            }
        }
        private void calcularcambio()
        {

            if (string.IsNullOrWhiteSpace(txtValorVenta.Text))
            {
                MessageBox.Show("El campo 'Total a Pagar' está vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValorAbono.Text))
            {
                txtValorAbono.Text = "0.00"; // Asignar 0 si el campo 'Valor Abono' está vacío
            }

            if (!decimal.TryParse(txtValorVenta.Text.Trim(), out decimal valorPagado))
            {
                MessageBox.Show("El valor de 'Total a Pagar' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtValorAbono.Text.Trim(), out decimal valorAbono))
            {
                MessageBox.Show("El valor de 'Valor Abono' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal resta = valorPagado - valorAbono;
            txtValorResta.Text = resta.ToString("N2");
        }

        private void ActualizarTotal()
        {
            int cantidad = (int)txtconteounidad.Value;

            if (!decimal.TryParse(txtvalorunidad.Text.Trim(), out decimal valorunidad))
            {
                MessageBox.Show("El valor de 'Valor De Producto' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal Resultado = cantidad * valorunidad;
            txttotalpago.Text = Resultado.ToString("N2");
        }
        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void txtvalorunidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ActualizarTotal();
            }
        }

        private void txtCodProducto_KeyDown_1(object sender, KeyEventArgs e)
        {
            //funcionalidad para cuando se escriba el codigo y se de enter se muestre el producto como busqueda
            if (e.KeyData == Keys.Enter)
            {

                Producto pProducto = new CN_Producto().ListarProductos().Where(p => p.CodProducto == txtCodProducto.Text && p.Estado == true).FirstOrDefault();

                if (pProducto != null)
                {
                    txtCodProducto.BackColor = Color.Honeydew;
                    txtIdProducto.Text = pProducto.IdProducto.ToString();
                    txtDetalleProducto.Text = pProducto.DetalleProducto;
                    txtValorProducto.Text = pProducto.PrecioVenta.ToString();
                    txtValorAbono.Select();
                }
                else
                {
                    txtCodProducto.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtDetalleProducto.Text = "";
                }

            }
        }

        private void txtValorProducto_KeyPress(object sender, KeyPressEventArgs e)
        { //Bloquea el control para evitar que se escriba
            e.Handled = false;
        }

        private void txtdiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}
