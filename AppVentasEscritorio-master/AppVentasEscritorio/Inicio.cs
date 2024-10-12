using AppVentasEscritorio.Modales;
using CapaEntidad;
using CapaNegocios; 
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    public partial class Inicio : Form // Declaración de la clase Inicio que hereda de Form
    {
        // Variables estáticas para almacenar el usuario actual, el menú activo y el formulario activo
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        // Constructor de la clase Inicio que recibe un objeto Usuario

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        // Método que se ejecuta cuando se carga el formulario
        private void Inicio_Load(object sender, EventArgs e)
        {
            // Obtener los permisos del usuario actual desde la base de datos
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            // Interar sobre los elementos del menú
            foreach (IconMenuItem iconMenu in menu.Items)
            {
                // Verificar si el nombre del elemento de menú está presente en los permisos del usuario
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);

                // Si el usuario tiene permiso, mostrar el elemento de menú; de lo contrario, ocultarlo
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

            // Mostrar el nombre del usuario actual en un label
            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        // Manejadores de eventos para clics en los elementos del menú, cada uno abre un formulario específico

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            // Si hay un menú activo, establece su color de fondo a blanco
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            // Establece el color de fondo del menú actual a plateado y actualiza el menú activo
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            // Si hay un formulario activo, ciérralo
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            // Establece el formulario recibido como parámetro como formulario activo
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            // Agrega el formulario al contenedor y lo muestra
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menu_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menu_ventas, new frm_ventas(usuarioActual));
        }
        private void detalle_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menu_detalle_ventas, new form_detalle_ventas());
        }

        private void menu_agenda_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menu_agenda, new form_agenda());
        }

        private void menu_clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Form_Clientes());
        }
        private void menu_usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Form_Usuarios());
        }

        private void submenuproductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menu_productos, new form_productos());
        }
        private void submenucategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menu_productos, new FormCategorias());
        }
        private void Menu_Acercade_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Salir?", "Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes) {
                this.Close();
            }
            
        }

        
    }
}

