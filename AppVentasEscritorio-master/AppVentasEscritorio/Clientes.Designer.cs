namespace AppVentasEscritorio
{
    partial class Form_Clientes
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.cbodestadodeuda = new System.Windows.Forms.ComboBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.lbl_columna = new System.Windows.Forms.Label();
            this.listadeclientes = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvdatacliente = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.btnselecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatacliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl3.Location = new System.Drawing.Point(16, 143);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 16);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Telefono:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.White;
            this.nombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(16, 85);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(112, 16);
            this.nombre.TabIndex = 7;
            this.nombre.Text = "Nombre Completo:";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtnombrecompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombrecompleto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecompleto.ForeColor = System.Drawing.Color.Black;
            this.txtnombrecompleto.Location = new System.Drawing.Point(14, 104);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(212, 21);
            this.txtnombrecompleto.TabIndex = 8;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.White;
            this.lbl12.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl12.Location = new System.Drawing.Point(16, 304);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(89, 16);
            this.lbl12.TabIndex = 12;
            this.lbl12.Text = "Estado Deuda:";
            // 
            // cbodestadodeuda
            // 
            this.cbodestadodeuda.BackColor = System.Drawing.Color.Gainsboro;
            this.cbodestadodeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbodestadodeuda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodestadodeuda.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbodestadodeuda.ForeColor = System.Drawing.Color.Black;
            this.cbodestadodeuda.FormattingEnabled = true;
            this.cbodestadodeuda.Location = new System.Drawing.Point(14, 325);
            this.cbodestadodeuda.Name = "cbodestadodeuda";
            this.cbodestadodeuda.Size = new System.Drawing.Size(212, 23);
            this.cbodestadodeuda.TabIndex = 13;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 20;
            this.btnguardar.Location = new System.Drawing.Point(14, 373);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(213, 30);
            this.btnguardar.TabIndex = 40;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btneditar.IconColor = System.Drawing.Color.Black;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 20;
            this.btneditar.Location = new System.Drawing.Point(14, 409);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(213, 30);
            this.btneditar.TabIndex = 40;
            this.btneditar.Text = "EDITAR";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // lbl_columna
            // 
            this.lbl_columna.BackColor = System.Drawing.Color.White;
            this.lbl_columna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_columna.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_columna.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_columna.Location = new System.Drawing.Point(0, 0);
            this.lbl_columna.Name = "lbl_columna";
            this.lbl_columna.Size = new System.Drawing.Size(242, 535);
            this.lbl_columna.TabIndex = 3;
            this.lbl_columna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listadeclientes
            // 
            this.listadeclientes.BackColor = System.Drawing.Color.White;
            this.listadeclientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listadeclientes.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadeclientes.Location = new System.Drawing.Point(248, 9);
            this.listadeclientes.Name = "listadeclientes";
            this.listadeclientes.Size = new System.Drawing.Size(722, 55);
            this.listadeclientes.TabIndex = 21;
            this.listadeclientes.Text = "Lista de Clientes";
            this.listadeclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.Gainsboro;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.Black;
            this.txttelefono.Location = new System.Drawing.Point(14, 165);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(212, 21);
            this.txttelefono.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "DETALLE CLIENTE";
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
            this.btneliminar.Location = new System.Drawing.Point(14, 445);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(213, 30);
            this.btneliminar.TabIndex = 40;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(16, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.Black;
            this.txtcorreo.Location = new System.Drawing.Point(14, 223);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(212, 21);
            this.txtcorreo.TabIndex = 44;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(203, 59);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(24, 20);
            this.txtid.TabIndex = 48;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // dgvdatacliente
            // 
            this.dgvdatacliente.AllowUserToAddRows = false;
            this.dgvdatacliente.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatacliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatacliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnselecionar,
            this.IdCliente,
            this.NombreCompleto,
            this.Telefono,
            this.Correo,
            this.EstadoValor,
            this.EstadoDeuda});
            this.dgvdatacliente.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvdatacliente.Location = new System.Drawing.Point(248, 70);
            this.dgvdatacliente.MultiSelect = false;
            this.dgvdatacliente.Name = "dgvdatacliente";
            this.dgvdatacliente.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatacliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatacliente.RowTemplate.Height = 28;
            this.dgvdatacliente.Size = new System.Drawing.Size(722, 453);
            this.dgvdatacliente.TabIndex = 19;
            this.dgvdatacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatacliente_CellContentClick);
            this.dgvdatacliente.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdatacliente_CellPainting);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(925, 25);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(38, 21);
            this.btnlimpiar.TabIndex = 78;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.UseVisualStyleBackColor = false;
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
            this.btnbuscar.Location = new System.Drawing.Point(878, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 21);
            this.btnbuscar.TabIndex = 77;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtbusqueda.Location = new System.Drawing.Point(626, 25);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(246, 21);
            this.txtbusqueda.TabIndex = 76;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.cbobusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbobusqueda.ForeColor = System.Drawing.Color.Black;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(489, 24);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(131, 23);
            this.cbobusqueda.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(411, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Buscar por:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(173, 59);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(24, 20);
            this.txtindice.TabIndex = 48;
            this.txtindice.Text = "0";
            this.txtindice.Visible = false;
            // 
            // btnselecionar
            // 
            this.btnselecionar.HeaderText = "";
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.ReadOnly = true;
            this.btnselecionar.Width = 30;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 160;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // EstadoDeuda
            // 
            this.EstadoDeuda.HeaderText = "Estado Deuda";
            this.EstadoDeuda.Name = "EstadoDeuda";
            this.EstadoDeuda.ReadOnly = true;
            this.EstadoDeuda.Width = 120;
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 535);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.dgvdatacliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.listadeclientes);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cbodestadodeuda);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl_columna);
            this.Name = "Form_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Clientes";
            this.Load += new System.EventHandler(this.Detalle_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatacliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.ComboBox cbodestadodeuda;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private System.Windows.Forms.Label lbl_columna;
        private System.Windows.Forms.Label listadeclientes;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvdatacliente;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.DataGridViewButtonColumn btnselecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDeuda;
    }
}