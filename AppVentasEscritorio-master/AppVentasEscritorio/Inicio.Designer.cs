using System;
using System.Windows.Forms;

namespace AppVentasEscritorio
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.titulopantalla = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.botonusuario = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.menu_detalle_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_agenda = new FontAwesome.Sharp.IconMenuItem();
            this.menu_productos = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.Menu_Acercade = new FontAwesome.Sharp.IconMenuItem();
            this.bntSalir = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulopantalla
            // 
            this.titulopantalla.AutoSize = true;
            this.titulopantalla.BackColor = System.Drawing.Color.Gainsboro;
            this.titulopantalla.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopantalla.Location = new System.Drawing.Point(12, 9);
            this.titulopantalla.Name = "titulopantalla";
            this.titulopantalla.Size = new System.Drawing.Size(197, 36);
            this.titulopantalla.TabIndex = 2;
            this.titulopantalla.Text = "Foto Correa";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 124);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1259, 445);
            this.contenedor.TabIndex = 3;
            // 
            // botonusuario
            // 
            this.botonusuario.AutoSize = true;
            this.botonusuario.BackColor = System.Drawing.Color.Gainsboro;
            this.botonusuario.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.botonusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonusuario.Location = new System.Drawing.Point(943, 21);
            this.botonusuario.Name = "botonusuario";
            this.botonusuario.Size = new System.Drawing.Size(87, 19);
            this.botonusuario.TabIndex = 5;
            this.botonusuario.Text = "USUARIO:";
            this.botonusuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblusuario.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblusuario.Location = new System.Drawing.Point(1036, 24);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(64, 16);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.Gainsboro;
            this.menutitulo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menutitulo.GripMargin = new System.Windows.Forms.Padding(5);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1259, 62);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menutitulo";
            this.menutitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // menu_detalle_ventas
            // 
            this.menu_detalle_ventas.AutoSize = false;
            this.menu_detalle_ventas.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_detalle_ventas.IconChar = FontAwesome.Sharp.IconChar.Tarp;
            this.menu_detalle_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_detalle_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_detalle_ventas.IconSize = 45;
            this.menu_detalle_ventas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_detalle_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_detalle_ventas.Name = "menu_detalle_ventas";
            this.menu_detalle_ventas.Size = new System.Drawing.Size(165, 60);
            this.menu_detalle_ventas.Text = "Detalle Ventas";
            this.menu_detalle_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_detalle_ventas.Click += new System.EventHandler(this.detalle_ventas_Click);
            // 
            // menu_agenda
            // 
            this.menu_agenda.AutoSize = false;
            this.menu_agenda.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_agenda.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.menu_agenda.IconColor = System.Drawing.Color.Black;
            this.menu_agenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_agenda.IconSize = 45;
            this.menu_agenda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_agenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_agenda.Name = "menu_agenda";
            this.menu_agenda.Size = new System.Drawing.Size(165, 60);
            this.menu_agenda.Text = "Agenda";
            this.menu_agenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_agenda.Click += new System.EventHandler(this.menu_agenda_Click);
            // 
            // menu_productos
            // 
            this.menu_productos.AutoSize = false;
            this.menu_productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategorias,
            this.submenuproductos});
            this.menu_productos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_productos.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.menu_productos.IconColor = System.Drawing.Color.Black;
            this.menu_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_productos.IconSize = 45;
            this.menu_productos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_productos.Name = "menu_productos";
            this.menu_productos.Size = new System.Drawing.Size(165, 60);
            this.menu_productos.Text = "Productos";
            this.menu_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategorias
            // 
            this.submenucategorias.Name = "submenucategorias";
            this.submenucategorias.Size = new System.Drawing.Size(150, 24);
            this.submenucategorias.Text = "Categorias";
            this.submenucategorias.Click += new System.EventHandler(this.submenucategorias_Click);
            // 
            // submenuproductos
            // 
            this.submenuproductos.Name = "submenuproductos";
            this.submenuproductos.Size = new System.Drawing.Size(150, 24);
            this.submenuproductos.Text = "Productos";
            this.submenuproductos.Click += new System.EventHandler(this.submenuproductos_Click);
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.IconSize = 45;
            this.menu_clientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(122, 60);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_clientes.Click += new System.EventHandler(this.menu_clientes_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ventas,
            this.menu_detalle_ventas,
            this.menu_agenda,
            this.menu_productos,
            this.menu_clientes,
            this.menu_usuarios,
            this.Menu_Acercade});
            this.menu.Location = new System.Drawing.Point(0, 62);
            this.menu.Margin = new System.Windows.Forms.Padding(5);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(1);
            this.menu.Size = new System.Drawing.Size(1259, 62);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menu_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_ventas.IconSize = 45;
            this.menu_ventas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(165, 60);
            this.menu_ventas.Text = "Ventas";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_ventas.Click += new System.EventHandler(this.menu_ventas_Click);
            // 
            // menu_usuarios
            // 
            this.menu_usuarios.AutoSize = false;
            this.menu_usuarios.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menu_usuarios.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menu_usuarios.IconColor = System.Drawing.Color.Black;
            this.menu_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuarios.IconSize = 45;
            this.menu_usuarios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuarios.Name = "menu_usuarios";
            this.menu_usuarios.Size = new System.Drawing.Size(122, 60);
            this.menu_usuarios.Text = "Usuarios";
            this.menu_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_usuarios.Click += new System.EventHandler(this.menu_usuarios_Click);
            // 
            // Menu_Acercade
            // 
            this.Menu_Acercade.AutoSize = false;
            this.Menu_Acercade.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Menu_Acercade.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.Menu_Acercade.IconColor = System.Drawing.Color.Black;
            this.Menu_Acercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Acercade.IconSize = 45;
            this.Menu_Acercade.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Menu_Acercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Acercade.Name = "Menu_Acercade";
            this.Menu_Acercade.Size = new System.Drawing.Size(122, 60);
            this.Menu_Acercade.Text = "Acercade";
            this.Menu_Acercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Acercade.Click += new System.EventHandler(this.Menu_Acercade_Click);
            // 
            // bntSalir
            // 
            this.bntSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.bntSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.bntSalir.IconColor = System.Drawing.Color.Black;
            this.bntSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntSalir.IconSize = 30;
            this.bntSalir.Location = new System.Drawing.Point(1171, 11);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.bntSalir.Size = new System.Drawing.Size(45, 41);
            this.bntSalir.TabIndex = 7;
            this.bntSalir.UseVisualStyleBackColor = false;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 569);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.botonusuario);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.titulopantalla);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOTO CORREA";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        #endregion
        private System.Windows.Forms.Label titulopantalla;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.Label botonusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem menu_detalle_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_agenda;
        private FontAwesome.Sharp.IconMenuItem menu_productos;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_usuarios;
        private ToolStripMenuItem submenucategorias;
        private ToolStripMenuItem submenuproductos;
        private FontAwesome.Sharp.IconButton bntSalir;
        private FontAwesome.Sharp.IconMenuItem Menu_Acercade;
    }
}

