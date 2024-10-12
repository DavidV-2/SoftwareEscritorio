using CapaEntidad;
using CapaNegocios;
using System;
using System.IO; // servicio pdf
using System.Windows.Forms;
using iTextSharp.text; // servicio pdf
using iTextSharp.text.pdf; // servicio pdf
using iTextSharp.tool.xml; // servicio pdf
using Document = iTextSharp.text.Document;
using AppVentasEscritorio.Modales; // servicio pdf


namespace AppVentasEscritorio
{
    public partial class form_detalle_ventas : Form
    {
        public form_detalle_ventas()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Obtener la venta usando el texto de búsqueda
            Venta vVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            // Verificar si la venta tiene datos de cliente
            if (!string.IsNullOrEmpty(vVenta.DatosCliente))
            {
                // Asignar los valores a los controles del formulario
                txtNumeroConsecutivo.Text = vVenta.NumeroConsecutivo;
                txtDatosCliente.Text = vVenta.DatosCliente;
                txtEspecificaciones.Text = vVenta.Especificaciones;
                txtEstadoDeuda.Text = vVenta.EstadoDeuda;

                dgvdataDetalleVentas.Rows.Clear();
                foreach (Detalle_Venta dv in vVenta.dvDetalleVenta)
                {
                    dgvdataDetalleVentas.Rows.Add(new object[] { dv.pProducto.DetalleProducto, dv.pProducto.PrecioVenta, dv.Cantidad });
                }
                txtMontoTotal.Text = vVenta.SubTotal.ToString("N2");
                txtValorPagado.Text = vVenta.ValorPagado.ToString("N2");
                txtValorResta.Text = vVenta.ValorResta.ToString("N2");
            }
            else
            {

                MessageBox.Show("No hay Venta Registrada con el Nombre, Favor verificar nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;           
            }
            txtDatosCliente.Select();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtDatosCliente.Text = "";
            txtNumeroConsecutivo.Text = "";
            txtDatosCliente.Text = "";
            txtEspecificaciones.Text = "";
            txtEstadoDeuda.Text = "";
            txtMontoTotal.Text = "";
            dgvdataDetalleVentas.Rows.Clear();
        }

        private void btndescargarfactura_Click(object sender, EventArgs e) // Genera Factura PDF CON HTML
        {/*

            // Verificar si el campo "txtNumeroConsecutivo" está vacío
            if (string.IsNullOrEmpty(txtNumeroConsecutivo.Text))
            {
                MessageBox.Show("No se encontraron Resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Leer la plantilla HTML y reemplazar los marcadores de posición con los datos reales
            string Texto_Html = Properties.Resources.PlantillaCompra;
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", "Factura"); // Asumiendo que es un valor fijo, ajustar según sea necesario
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNumeroConsecutivo.Text);

            // Generar filas para la tabla de datos en la factura
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdataDetalleVentas.Rows)
            {
                filas += "<tr>";
                filas += $"<td>{row.Cells["Descripcion"].Value}</td>";
                filas += $"<td>{row.Cells["ValorVenta"].Value}</td>";
                filas += $"<td>{row.Cells["ValorPagado"].Value}</td>";
                filas += $"<td>{row.Cells["ValorResta"].Value}</td>";
                filas += $"<td>{row.Cells["Cantidad"].Value}</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);

            // Guardar el archivo PDF generado
            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = $"FacturaN_{txtNumeroConsecutivo.Text}.pdf",
                Filter = "Pdf Files|*.pdf"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Agregar el logotipo del negocio si está disponible
                        byte[] byteImage = new CN_Negocio().ObtenerLogo(out bool obtenido);
                        if (obtenido && byteImage != null)
                        {
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                            img.ScaleToFit(60, 60);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top - 60);
                            pdfDoc.Add(img);
                        }

                        // Analizar el HTML en el documento PDF
                        using (StringReader sr = new StringReader(Texto_Html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Factura Generada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }*/
        }

        private void btnVentaDetal_Click_1(object sender, EventArgs e)
        {
            using (var modal1 = new mdDetalle_VentaDetal())
            {
                var result = modal1.ShowDialog();

                if (result == DialogResult.OK)
                {

                }
                else
                {
                }
            }
        }

        private void btndescargarfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnVentaDetal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= false;
        }
    }
}

