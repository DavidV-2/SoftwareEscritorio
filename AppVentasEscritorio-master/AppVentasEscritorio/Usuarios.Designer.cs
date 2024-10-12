namespace AppVentasEscritorio
{
    partial class Form_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_columna = new System.Windows.Forms.Label();
            this.listadeclientes = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtconfclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.lbldocumento = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.dgvdatausuario = new System.Windows.Forms.DataGridView();
            this.btnselecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.lblrol = new System.Windows.Forms.Label();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnmodificar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.txtindiceusuarios = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatausuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_columna
            // 
            this.lbl_columna.BackColor = System.Drawing.Color.White;
            this.lbl_columna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_columna.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_columna.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_columna.Location = new System.Drawing.Point(0, 0);
            this.lbl_columna.Name = "lbl_columna";
            this.lbl_columna.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_columna.Size = new System.Drawing.Size(242, 586);
            this.lbl_columna.TabIndex = 3;
            this.lbl_columna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listadeclientes
            // 
            this.listadeclientes.BackColor = System.Drawing.Color.White;
            this.listadeclientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listadeclientes.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadeclientes.Location = new System.Drawing.Point(248, 4);
            this.listadeclientes.Name = "listadeclientes";
            this.listadeclientes.Padding = new System.Windows.Forms.Padding(2);
            this.listadeclientes.Size = new System.Drawing.Size(772, 55);
            this.listadeclientes.TabIndex = 21;
            this.listadeclientes.Text = "Lista de Usuarios";
            this.listadeclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(200, 51);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(24, 20);
            this.txtid.TabIndex = 61;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // txtconfclave
            // 
            this.txtconfclave.BackColor = System.Drawing.Color.Gainsboro;
            this.txtconfclave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfclave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfclave.ForeColor = System.Drawing.Color.Black;
            this.txtconfclave.Location = new System.Drawing.Point(12, 298);
            this.txtconfclave.Name = "txtconfclave";
            this.txtconfclave.PasswordChar = '*';
            this.txtconfclave.Size = new System.Drawing.Size(212, 21);
            this.txtconfclave.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(14, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "DETALLE USUARIOS";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.Black;
            this.txtcorreo.Location = new System.Drawing.Point(12, 192);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(212, 21);
            this.txtcorreo.TabIndex = 54;
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.Gainsboro;
            this.cboestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboestado.ForeColor = System.Drawing.Color.Black;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(12, 405);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(114, 23);
            this.cboestado.TabIndex = 53;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.Transparent;
            this.lblestado.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblestado.Location = new System.Drawing.Point(14, 383);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(50, 16);
            this.lblestado.TabIndex = 52;
            this.lblestado.Text = "Estado:";
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocumento.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.Black;
            this.txtdocumento.Location = new System.Drawing.Point(12, 88);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(212, 21);
            this.txtdocumento.TabIndex = 51;
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.BackColor = System.Drawing.Color.Transparent;
            this.lbldocumento.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldocumento.Location = new System.Drawing.Point(14, 69);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(98, 16);
            this.lbldocumento.TabIndex = 50;
            this.lbldocumento.Text = "Nro Documento:";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblcorreo.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblcorreo.Location = new System.Drawing.Point(14, 172);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(50, 16);
            this.lblcorreo.TabIndex = 49;
            this.lblcorreo.Text = "Correo:";
            // 
            // dgvdatausuario
            // 
            this.dgvdatausuario.AllowUserToAddRows = false;
            this.dgvdatausuario.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatausuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatausuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatausuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnselecionar,
            this.IdUsuario,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.dgvdatausuario.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvdatausuario.Location = new System.Drawing.Point(248, 69);
            this.dgvdatausuario.MultiSelect = false;
            this.dgvdatausuario.Name = "dgvdatausuario";
            this.dgvdatausuario.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatausuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatausuario.RowTemplate.Height = 28;
            this.dgvdatausuario.Size = new System.Drawing.Size(772, 517);
            this.dgvdatausuario.TabIndex = 62;
            this.dgvdatausuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatausuario_CellContentClick);
            this.dgvdatausuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdatausuario_CellPainting);
            // 
            // btnselecionar
            // 
            this.btnselecionar.HeaderText = "";
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.ReadOnly = true;
            this.btnselecionar.Width = 30;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 30;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Documento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Documento.Width = 120;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreCompleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 180;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 40;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado Valor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // cborol
            // 
            this.cborol.BackColor = System.Drawing.Color.Gainsboro;
            this.cborol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cborol.ForeColor = System.Drawing.Color.Black;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(12, 353);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(212, 23);
            this.cborol.TabIndex = 64;
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.BackColor = System.Drawing.Color.Transparent;
            this.lblrol.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblrol.Location = new System.Drawing.Point(14, 332);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(31, 16);
            this.lblrol.TabIndex = 63;
            this.lblrol.Text = "Rol:";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtnombrecompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombrecompleto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecompleto.ForeColor = System.Drawing.Color.Black;
            this.txtnombrecompleto.Location = new System.Drawing.Point(12, 145);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(212, 21);
            this.txtnombrecompleto.TabIndex = 66;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblnombre.Location = new System.Drawing.Point(16, 123);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(112, 16);
            this.lblnombre.TabIndex = 65;
            this.lblnombre.Text = "Nombre Completo:";
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.Gainsboro;
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.Black;
            this.txtclave.Location = new System.Drawing.Point(12, 248);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(212, 21);
            this.txtclave.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(14, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(434, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Buscar por:";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.cbobusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbobusqueda.ForeColor = System.Drawing.Color.Black;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(512, 21);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(131, 23);
            this.cbobusqueda.TabIndex = 70;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtbusqueda.Location = new System.Drawing.Point(649, 22);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(267, 21);
            this.txtbusqueda.TabIndex = 71;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiarbuscador.IconSize = 18;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(969, 22);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(38, 21);
            this.btnlimpiarbuscador.TabIndex = 73;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscar.IconSize = 18;
            this.btnbuscar.Location = new System.Drawing.Point(922, 22);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 21);
            this.btnbuscar.TabIndex = 72;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 20;
            this.btneliminar.Location = new System.Drawing.Point(12, 537);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(213, 30);
            this.btneliminar.TabIndex = 56;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.btnmodificar.IconColor = System.Drawing.Color.Black;
            this.btnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmodificar.IconSize = 20;
            this.btnmodificar.Location = new System.Drawing.Point(12, 495);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(213, 30);
            this.btnmodificar.TabIndex = 57;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnagregar.IconColor = System.Drawing.Color.Black;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.IconSize = 20;
            this.btnagregar.Location = new System.Drawing.Point(12, 457);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(213, 30);
            this.btnagregar.TabIndex = 58;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtindiceusuarios
            // 
            this.txtindiceusuarios.BackColor = System.Drawing.Color.White;
            this.txtindiceusuarios.Location = new System.Drawing.Point(170, 51);
            this.txtindiceusuarios.Name = "txtindiceusuarios";
            this.txtindiceusuarios.Size = new System.Drawing.Size(24, 20);
            this.txtindiceusuarios.TabIndex = 74;
            this.txtindiceusuarios.Text = "-1";
            this.txtindiceusuarios.Visible = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 20;
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar.Location = new System.Drawing.Point(132, 404);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 29);
            this.btnlimpiar.TabIndex = 75;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click_1);
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 586);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtindiceusuarios);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.cborol);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.dgvdatausuario);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtconfclave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.lbldocumento);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.listadeclientes);
            this.Controls.Add(this.lbl_columna);
            this.Name = "Form_Usuarios";
            this.Text = "Form_Usuarios";
            this.Load += new System.EventHandler(this.Form_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatausuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_columna;
        private System.Windows.Forms.Label listadeclientes;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtconfclave;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcorreo;
        private FontAwesome.Sharp.IconButton btnmodificar;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.DataGridView dgvdatausuario;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.DataGridViewButtonColumn btnselecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtindiceusuarios;
        private FontAwesome.Sharp.IconButton btnlimpiar;
    }
}