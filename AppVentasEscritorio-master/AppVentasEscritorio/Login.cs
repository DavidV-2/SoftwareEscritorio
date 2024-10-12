using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            logo = new PictureBox();
            logo.Height = 200;
            logo.Width = 200;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {

                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
