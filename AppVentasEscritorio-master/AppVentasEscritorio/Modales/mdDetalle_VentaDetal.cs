using CapaEntidad;
using CapaNegocios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppVentasEscritorio.Modales
{
    public partial class mdDetalle_VentaDetal : Form
    {
        public mdDetalle_VentaDetal()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Obtener los detalles de venta según el número consecutivo
            Venta_Detal vdVentaDetal = new CN_Venta_Detal().ObtenerVentaDetal(txtbusquedadetal.Text);
            
            if (!string.IsNullOrEmpty(vdVentaDetal.NumeroConsecutivo))
            {
                txtnumeroconsecutivo.Text = vdVentaDetal.NumeroConsecutivo;
                txtfecha.Text = vdVentaDetal.FechaRegistro;
                
                dgvdataDetalleDetal.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevos elementos

                foreach (Detalle_VentaDetal dc in vdVentaDetal.dvdDetalleDetal) {
                    dgvdataDetalleDetal.Rows.Add(new object[] { dc.pdProducto.Producto, dc.Cantidad, dc.SubTotal });
                }
                txtMontoTotal.Text = vdVentaDetal.SubTotal.ToString("N2");
            }
            else
            {
                MessageBox.Show("No se encontró ninguna venta registrada con el número consecutivo proporcionado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtbusquedadetal.Select();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumeroconsecutivo.Text = "";
            txtfecha.Text = "";
            txtbusquedadetal.Text = "";
            txtMontoTotal.Text= "0.00";
            dgvdataDetalleDetal.Rows.Clear();
        }

        private void bntclosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
