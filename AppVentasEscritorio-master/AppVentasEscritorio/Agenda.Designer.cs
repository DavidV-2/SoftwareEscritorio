namespace AppVentasEscritorio
{
    partial class form_agenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvalorrestante = new System.Windows.Forms.TextBox();
            this.lblabono = new System.Windows.Forms.Label();
            this.txtvalorpagado = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdatosevento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtvalorproducto = new System.Windows.Forms.TextBox();
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.dgvdataEventos = new System.Windows.Forms.DataGridView();
            this.IdEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorResta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxinfocliente = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataEventos)).BeginInit();
            this.groupBoxinfocliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(589, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 55;
            this.label8.Text = "Valor Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(903, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Valor Restante:";
            // 
            // txtvalorrestante
            // 
            this.txtvalorrestante.BackColor = System.Drawing.Color.Gainsboro;
            this.txtvalorrestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalorrestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtvalorrestante.ForeColor = System.Drawing.Color.Black;
            this.txtvalorrestante.Location = new System.Drawing.Point(897, 211);
            this.txtvalorrestante.Name = "txtvalorrestante";
            this.txtvalorrestante.Size = new System.Drawing.Size(127, 21);
            this.txtvalorrestante.TabIndex = 53;
            // 
            // lblabono
            // 
            this.lblabono.AutoSize = true;
            this.lblabono.BackColor = System.Drawing.Color.White;
            this.lblabono.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblabono.Location = new System.Drawing.Point(761, 189);
            this.lblabono.Name = "lblabono";
            this.lblabono.Size = new System.Drawing.Size(104, 19);
            this.lblabono.TabIndex = 52;
            this.lblabono.Text = "Valor Pagado:";
            // 
            // txtvalorpagado
            // 
            this.txtvalorpagado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtvalorpagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalorpagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtvalorpagado.ForeColor = System.Drawing.Color.Black;
            this.txtvalorpagado.Location = new System.Drawing.Point(748, 211);
            this.txtvalorpagado.Name = "txtvalorpagado";
            this.txtvalorpagado.Size = new System.Drawing.Size(127, 21);
            this.txtvalorpagado.TabIndex = 51;
            this.txtvalorpagado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvalorpagado_KeyDown);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(490, 13);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(24, 22);
            this.txtIdProducto.TabIndex = 47;
            this.txtIdProducto.Visible = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarproducto.ForeColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(132, 39);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(33, 21);
            this.btnbuscarproducto.TabIndex = 44;
            this.btnbuscarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarproducto.UseVisualStyleBackColor = false;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.Gainsboro;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.Black;
            this.txttelefono.Location = new System.Drawing.Point(446, 62);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(196, 21);
            this.txttelefono.TabIndex = 52;
            // 
            // txtdatosevento
            // 
            this.txtdatosevento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdatosevento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdatosevento.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatosevento.ForeColor = System.Drawing.Color.Black;
            this.txtdatosevento.Location = new System.Drawing.Point(956, 63);
            this.txtdatosevento.Multiline = true;
            this.txtdatosevento.Name = "txtdatosevento";
            this.txtdatosevento.Size = new System.Drawing.Size(233, 93);
            this.txtdatosevento.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Fecha Evento:";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtnombrecompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombrecompleto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecompleto.ForeColor = System.Drawing.Color.Black;
            this.txtnombrecompleto.Location = new System.Drawing.Point(117, 62);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(313, 21);
            this.txtnombrecompleto.TabIndex = 51;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.Black;
            this.txtdireccion.Location = new System.Drawing.Point(648, 62);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(271, 21);
            this.txtdireccion.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(989, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Detalles del Evento:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(171, 39);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(343, 21);
            this.txtDescripcion.TabIndex = 71;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(14, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(112, 21);
            this.txtCodigo.TabIndex = 72;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtvalorproducto
            // 
            this.txtvalorproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtvalorproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorproducto.ForeColor = System.Drawing.Color.Black;
            this.txtvalorproducto.Location = new System.Drawing.Point(583, 211);
            this.txtvalorproducto.Name = "txtvalorproducto";
            this.txtvalorproducto.Size = new System.Drawing.Size(127, 21);
            this.txtvalorproducto.TabIndex = 73;
            this.txtvalorproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorproducto_KeyPress);
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Location = new System.Drawing.Point(462, 13);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(22, 22);
            this.txtIdEvento.TabIndex = 75;
            this.txtIdEvento.Visible = false;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.Gainsboro;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfecha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.ForeColor = System.Drawing.Color.Black;
            this.txtfecha.Location = new System.Drawing.Point(8, 63);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(101, 21);
            this.txtfecha.TabIndex = 76;
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
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardar.IconSize = 25;
            this.btnguardar.Location = new System.Drawing.Point(1078, 185);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(111, 47);
            this.btnguardar.TabIndex = 83;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // dgvdataEventos
            // 
            this.dgvdataEventos.AllowUserToAddRows = false;
            this.dgvdataEventos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdataEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEvento,
            this.FechaEvento,
            this.DatosCliente,
            this.Telefono,
            this.Direccion,
            this.DescripcionEvento,
            this.ValorVenta,
            this.ValorPagado,
            this.ValorResta,
            this.EstadoValor,
            this.Estado});
            this.dgvdataEventos.Location = new System.Drawing.Point(12, 335);
            this.dgvdataEventos.MultiSelect = false;
            this.dgvdataEventos.Name = "dgvdataEventos";
            this.dgvdataEventos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdataEventos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdataEventos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdataEventos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdataEventos.RowTemplate.Height = 28;
            this.dgvdataEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdataEventos.Size = new System.Drawing.Size(1177, 211);
            this.dgvdataEventos.TabIndex = 81;
            // 
            // IdEvento
            // 
            this.IdEvento.HeaderText = "IdEvento";
            this.IdEvento.Name = "IdEvento";
            this.IdEvento.ReadOnly = true;
            this.IdEvento.Visible = false;
            // 
            // FechaEvento
            // 
            this.FechaEvento.HeaderText = "FechaEvento";
            this.FechaEvento.Name = "FechaEvento";
            this.FechaEvento.ReadOnly = true;
            this.FechaEvento.Width = 120;
            // 
            // DatosCliente
            // 
            this.DatosCliente.HeaderText = "DatosCliente";
            this.DatosCliente.Name = "DatosCliente";
            this.DatosCliente.ReadOnly = true;
            this.DatosCliente.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 140;
            // 
            // DescripcionEvento
            // 
            this.DescripcionEvento.HeaderText = "DescripcionEvento";
            this.DescripcionEvento.Name = "DescripcionEvento";
            this.DescripcionEvento.ReadOnly = true;
            this.DescripcionEvento.Width = 230;
            // 
            // ValorVenta
            // 
            this.ValorVenta.HeaderText = "ValorVenta";
            this.ValorVenta.Name = "ValorVenta";
            this.ValorVenta.ReadOnly = true;
            this.ValorVenta.Width = 110;
            // 
            // ValorPagado
            // 
            this.ValorPagado.HeaderText = "ValorPagado";
            this.ValorPagado.Name = "ValorPagado";
            this.ValorPagado.ReadOnly = true;
            this.ValorPagado.Width = 110;
            // 
            // ValorResta
            // 
            this.ValorResta.HeaderText = "ValorResta";
            this.ValorResta.Name = "ValorResta";
            this.ValorResta.ReadOnly = true;
            this.ValorResta.Width = 110;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 40;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
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
            this.btnbuscar.Location = new System.Drawing.Point(1092, 301);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 23);
            this.btnbuscar.TabIndex = 31;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtbusqueda.Location = new System.Drawing.Point(764, 301);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(310, 24);
            this.txtbusqueda.TabIndex = 30;
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
            this.btnlimpiar.Location = new System.Drawing.Point(1139, 301);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(38, 23);
            this.btnlimpiar.TabIndex = 32;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.cbobusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobusqueda.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.ForeColor = System.Drawing.Color.Black;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(634, 301);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(124, 23);
            this.cbobusqueda.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(559, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Buscar por:";
            // 
            // groupBoxinfocliente
            // 
            this.groupBoxinfocliente.BackColor = System.Drawing.Color.White;
            this.groupBoxinfocliente.Controls.Add(this.label12);
            this.groupBoxinfocliente.Controls.Add(this.label2);
            this.groupBoxinfocliente.Controls.Add(this.txtfecha);
            this.groupBoxinfocliente.Controls.Add(this.txtdireccion);
            this.groupBoxinfocliente.Controls.Add(this.label5);
            this.groupBoxinfocliente.Controls.Add(this.label3);
            this.groupBoxinfocliente.Controls.Add(this.txttelefono);
            this.groupBoxinfocliente.Controls.Add(this.txtnombrecompleto);
            this.groupBoxinfocliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBoxinfocliente.Location = new System.Drawing.Point(12, 41);
            this.groupBoxinfocliente.Name = "groupBoxinfocliente";
            this.groupBoxinfocliente.Size = new System.Drawing.Size(938, 115);
            this.groupBoxinfocliente.TabIndex = 88;
            this.groupBoxinfocliente.TabStop = false;
            this.groupBoxinfocliente.Text = "Informacion Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(448, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(115, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre Completo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.txtIdProducto);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtIdEvento);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 82);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 270);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(1233, 298);
            this.label1.TabIndex = 84;
            this.label1.Text = "Eventos Registrados";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(1233, 270);
            this.label4.TabIndex = 90;
            this.label4.Text = "Nuevo Evento";
            // 
            // form_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1233, 568);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxinfocliente);
            this.Controls.Add(this.txtdatosevento);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtvalorproducto);
            this.Controls.Add(this.txtvalorpagado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtvalorrestante);
            this.Controls.Add(this.lblabono);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.dgvdataEventos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "form_agenda";
            this.Text = "Form_Agenda";
            this.Load += new System.EventHandler(this.eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataEventos)).EndInit();
            this.groupBoxinfocliente.ResumeLayout(false);
            this.groupBoxinfocliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdatosevento;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.Label lblabono;
        private System.Windows.Forms.TextBox txtvalorpagado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvalorrestante;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtvalorproducto;
        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.TextBox txtfecha;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.DataGridView dgvdataEventos;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxinfocliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorResta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}