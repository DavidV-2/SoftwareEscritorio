namespace AppVentasEscritorio
{
    partial class frm_ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblregistarventa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxinfocliente = new System.Windows.Forms.GroupBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDatosCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecificaciones = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxinfoventa = new System.Windows.Forms.GroupBox();
            this.cbodestadodeuda = new System.Windows.Forms.ComboBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorProducto = new System.Windows.Forms.TextBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtDetalleProducto = new System.Windows.Forms.TextBox();
            this.txtValorResta = new System.Windows.Forms.TextBox();
            this.txtValorAbono = new System.Windows.Forms.TextBox();
            this.bntagregarventa = new FontAwesome.Sharp.IconButton();
            this.dgvdataVentaMasiva = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorResta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.boxventadetal = new System.Windows.Forms.GroupBox();
            this.txtIdProductoDetal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotalpago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvalorunidad = new System.Windows.Forms.TextBox();
            this.txtconteounidad = new System.Windows.Forms.NumericUpDown();
            this.cboproductodetal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.btnguardarsqldetal = new FontAwesome.Sharp.IconButton();
            this.dgvdataventadetal = new System.Windows.Forms.DataGridView();
            this.IdProductoDetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminardet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_columna = new System.Windows.Forms.Label();
            this.btnregistar = new FontAwesome.Sharp.IconButton();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiario = new System.Windows.Forms.TextBox();
            this.groupBoxinfocliente.SuspendLayout();
            this.groupBoxinfoventa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataVentaMasiva)).BeginInit();
            this.boxventadetal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtconteounidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataventadetal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblregistarventa
            // 
            this.lblregistarventa.AutoSize = true;
            this.lblregistarventa.BackColor = System.Drawing.Color.White;
            this.lblregistarventa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblregistarventa.Location = new System.Drawing.Point(12, 12);
            this.lblregistarventa.Name = "lblregistarventa";
            this.lblregistarventa.Size = new System.Drawing.Size(229, 23);
            this.lblregistarventa.TabIndex = 23;
            this.lblregistarventa.Text = "REGISTRO DE VENTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cod.Producto:";
            // 
            // groupBoxinfocliente
            // 
            this.groupBoxinfocliente.BackColor = System.Drawing.Color.White;
            this.groupBoxinfocliente.Controls.Add(this.txttelefono);
            this.groupBoxinfocliente.Controls.Add(this.label12);
            this.groupBoxinfocliente.Controls.Add(this.txtDatosCliente);
            this.groupBoxinfocliente.Controls.Add(this.label2);
            this.groupBoxinfocliente.Controls.Add(this.txtEspecificaciones);
            this.groupBoxinfocliente.Controls.Add(this.lbl8);
            this.groupBoxinfocliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBoxinfocliente.Location = new System.Drawing.Point(368, 46);
            this.groupBoxinfocliente.Name = "groupBoxinfocliente";
            this.groupBoxinfocliente.Size = new System.Drawing.Size(976, 109);
            this.groupBoxinfocliente.TabIndex = 25;
            this.groupBoxinfocliente.TabStop = false;
            this.groupBoxinfocliente.Text = "Informacion Cliente";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.Gainsboro;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.Black;
            this.txttelefono.Location = new System.Drawing.Point(332, 63);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(194, 21);
            this.txttelefono.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(326, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Telefono:";
            // 
            // txtDatosCliente
            // 
            this.txtDatosCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatosCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatosCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosCliente.ForeColor = System.Drawing.Color.Black;
            this.txtDatosCliente.Location = new System.Drawing.Point(16, 63);
            this.txtDatosCliente.Multiline = true;
            this.txtDatosCliente.Name = "txtDatosCliente";
            this.txtDatosCliente.Size = new System.Drawing.Size(302, 20);
            this.txtDatosCliente.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre Completo:";
            // 
            // txtEspecificaciones
            // 
            this.txtEspecificaciones.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEspecificaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspecificaciones.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecificaciones.ForeColor = System.Drawing.Color.Black;
            this.txtEspecificaciones.Location = new System.Drawing.Point(549, 63);
            this.txtEspecificaciones.Name = "txtEspecificaciones";
            this.txtEspecificaciones.Size = new System.Drawing.Size(421, 20);
            this.txtEspecificaciones.TabIndex = 12;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.White;
            this.lbl8.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(561, 38);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(118, 18);
            this.lbl8.TabIndex = 13;
            this.lbl8.Text = "Especificaciones:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(1136, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // groupBoxinfoventa
            // 
            this.groupBoxinfoventa.BackColor = System.Drawing.Color.White;
            this.groupBoxinfoventa.Controls.Add(this.cbodestadodeuda);
            this.groupBoxinfoventa.Controls.Add(this.txtCodProducto);
            this.groupBoxinfoventa.Controls.Add(this.label9);
            this.groupBoxinfoventa.Controls.Add(this.label1);
            this.groupBoxinfoventa.Controls.Add(this.txtcantidad);
            this.groupBoxinfoventa.Controls.Add(this.label11);
            this.groupBoxinfoventa.Controls.Add(this.txtValorProducto);
            this.groupBoxinfoventa.Controls.Add(this.btnbuscar);
            this.groupBoxinfoventa.Controls.Add(this.label4);
            this.groupBoxinfoventa.Controls.Add(this.txtIdProducto);
            this.groupBoxinfoventa.Controls.Add(this.txtDetalleProducto);
            this.groupBoxinfoventa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBoxinfoventa.Location = new System.Drawing.Point(368, 161);
            this.groupBoxinfoventa.Name = "groupBoxinfoventa";
            this.groupBoxinfoventa.Size = new System.Drawing.Size(885, 93);
            this.groupBoxinfoventa.TabIndex = 26;
            this.groupBoxinfoventa.TabStop = false;
            this.groupBoxinfoventa.Text = "Registrar Producto";
            // 
            // cbodestadodeuda
            // 
            this.cbodestadodeuda.BackColor = System.Drawing.Color.Gainsboro;
            this.cbodestadodeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbodestadodeuda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodestadodeuda.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbodestadodeuda.ForeColor = System.Drawing.Color.Black;
            this.cbodestadodeuda.FormattingEnabled = true;
            this.cbodestadodeuda.Location = new System.Drawing.Point(757, 52);
            this.cbodestadodeuda.Name = "cbodestadodeuda";
            this.cbodestadodeuda.Size = new System.Drawing.Size(110, 23);
            this.cbodestadodeuda.TabIndex = 48;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProducto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCodProducto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.ForeColor = System.Drawing.Color.Black;
            this.txtCodProducto.Location = new System.Drawing.Point(13, 58);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(109, 21);
            this.txtCodProducto.TabIndex = 81;
            this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(765, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Estado Deuda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcantidad.Location = new System.Drawing.Point(694, 51);
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(43, 26);
            this.txtcantidad.TabIndex = 78;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(463, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 22);
            this.label11.TabIndex = 77;
            this.label11.Text = "$";
            // 
            // txtValorProducto
            // 
            this.txtValorProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorProducto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValorProducto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProducto.ForeColor = System.Drawing.Color.Black;
            this.txtValorProducto.Location = new System.Drawing.Point(489, 57);
            this.txtValorProducto.Name = "txtValorProducto";
            this.txtValorProducto.Size = new System.Drawing.Size(109, 21);
            this.txtValorProducto.TabIndex = 76;
            this.txtValorProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProducto_KeyPress);
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
            this.btnbuscar.Location = new System.Drawing.Point(128, 57);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 22);
            this.btnbuscar.TabIndex = 73;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(431, 28);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(24, 26);
            this.txtIdProducto.TabIndex = 46;
            this.txtIdProducto.Visible = false;
            // 
            // txtDetalleProducto
            // 
            this.txtDetalleProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDetalleProducto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDetalleProducto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleProducto.ForeColor = System.Drawing.Color.Black;
            this.txtDetalleProducto.Location = new System.Drawing.Point(164, 56);
            this.txtDetalleProducto.Name = "txtDetalleProducto";
            this.txtDetalleProducto.Size = new System.Drawing.Size(291, 21);
            this.txtDetalleProducto.TabIndex = 40;
            // 
            // txtValorResta
            // 
            this.txtValorResta.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorResta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorResta.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValorResta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorResta.ForeColor = System.Drawing.Color.Black;
            this.txtValorResta.Location = new System.Drawing.Point(1062, 521);
            this.txtValorResta.Name = "txtValorResta";
            this.txtValorResta.Size = new System.Drawing.Size(124, 21);
            this.txtValorResta.TabIndex = 74;
            // 
            // txtValorAbono
            // 
            this.txtValorAbono.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorAbono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAbono.ForeColor = System.Drawing.Color.Black;
            this.txtValorAbono.Location = new System.Drawing.Point(801, 524);
            this.txtValorAbono.Name = "txtValorAbono";
            this.txtValorAbono.Size = new System.Drawing.Size(124, 21);
            this.txtValorAbono.TabIndex = 33;
            this.txtValorAbono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            this.txtValorAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // bntagregarventa
            // 
            this.bntagregarventa.BackColor = System.Drawing.Color.Gainsboro;
            this.bntagregarventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntagregarventa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bntagregarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntagregarventa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.bntagregarventa.ForeColor = System.Drawing.Color.Black;
            this.bntagregarventa.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.bntagregarventa.IconColor = System.Drawing.Color.Black;
            this.bntagregarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntagregarventa.IconSize = 25;
            this.bntagregarventa.Location = new System.Drawing.Point(1259, 183);
            this.bntagregarventa.Name = "bntagregarventa";
            this.bntagregarventa.Padding = new System.Windows.Forms.Padding(1);
            this.bntagregarventa.Size = new System.Drawing.Size(85, 53);
            this.bntagregarventa.TabIndex = 78;
            this.bntagregarventa.Text = "AGREGAR";
            this.bntagregarventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntagregarventa.UseVisualStyleBackColor = false;
            this.bntagregarventa.Click += new System.EventHandler(this.bntagregarventa_Click);
            // 
            // dgvdataVentaMasiva
            // 
            this.dgvdataVentaMasiva.AllowUserToAddRows = false;
            this.dgvdataVentaMasiva.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvdataVentaMasiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataVentaMasiva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdataVentaMasiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataVentaMasiva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.CodProducto,
            this.DetalleProducto,
            this.DatosCliente,
            this.Telefono,
            this.Especificaciones,
            this.ValorProducto,
            this.ValorPagado,
            this.ValorResta,
            this.SubTotal,
            this.Cantidad,
            this.EstadoDeuda,
            this.btneliminar});
            this.dgvdataVentaMasiva.Location = new System.Drawing.Point(368, 260);
            this.dgvdataVentaMasiva.MultiSelect = false;
            this.dgvdataVentaMasiva.Name = "dgvdataVentaMasiva";
            this.dgvdataVentaMasiva.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataVentaMasiva.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdataVentaMasiva.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdataVentaMasiva.RowTemplate.Height = 28;
            this.dgvdataVentaMasiva.Size = new System.Drawing.Size(976, 245);
            this.dgvdataVentaMasiva.TabIndex = 27;
            this.dgvdataVentaMasiva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdataVentaMasiva_CellContentClick);
            this.dgvdataVentaMasiva.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdataVentaMasiva_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 15;
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "CodProducto";
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Visible = false;
            // 
            // DetalleProducto
            // 
            this.DetalleProducto.HeaderText = "DetalleProducto";
            this.DetalleProducto.Name = "DetalleProducto";
            this.DetalleProducto.ReadOnly = true;
            this.DetalleProducto.Width = 117;
            // 
            // DatosCliente
            // 
            this.DatosCliente.HeaderText = "Datos Cliente";
            this.DatosCliente.Name = "DatosCliente";
            this.DatosCliente.ReadOnly = true;
            this.DatosCliente.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Visible = false;
            // 
            // Especificaciones
            // 
            this.Especificaciones.HeaderText = "Especificaciones";
            this.Especificaciones.Name = "Especificaciones";
            this.Especificaciones.ReadOnly = true;
            this.Especificaciones.Width = 250;
            // 
            // ValorProducto
            // 
            this.ValorProducto.HeaderText = "ValorProducto";
            this.ValorProducto.Name = "ValorProducto";
            this.ValorProducto.ReadOnly = true;
            // 
            // ValorPagado
            // 
            this.ValorPagado.HeaderText = "ValorPagado";
            this.ValorPagado.Name = "ValorPagado";
            this.ValorPagado.ReadOnly = true;
            this.ValorPagado.Visible = false;
            this.ValorPagado.Width = 90;
            // 
            // ValorResta
            // 
            this.ValorResta.HeaderText = "ValorResta";
            this.ValorResta.Name = "ValorResta";
            this.ValorResta.ReadOnly = true;
            this.ValorResta.Visible = false;
            this.ValorResta.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 90;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Unid.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // EstadoDeuda
            // 
            this.EstadoDeuda.HeaderText = "Estado Deuda";
            this.EstadoDeuda.Name = "EstadoDeuda";
            this.EstadoDeuda.ReadOnly = true;
            this.EstadoDeuda.Width = 90;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Width = 30;
            // 
            // boxventadetal
            // 
            this.boxventadetal.BackColor = System.Drawing.Color.White;
            this.boxventadetal.Controls.Add(this.txtIdProductoDetal);
            this.boxventadetal.Controls.Add(this.label8);
            this.boxventadetal.Controls.Add(this.label7);
            this.boxventadetal.Controls.Add(this.txttotalpago);
            this.boxventadetal.Controls.Add(this.label6);
            this.boxventadetal.Controls.Add(this.txtvalorunidad);
            this.boxventadetal.Controls.Add(this.txtconteounidad);
            this.boxventadetal.Controls.Add(this.cboproductodetal);
            this.boxventadetal.Controls.Add(this.label5);
            this.boxventadetal.Controls.Add(this.btnagregar);
            this.boxventadetal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxventadetal.Location = new System.Drawing.Point(16, 53);
            this.boxventadetal.Name = "boxventadetal";
            this.boxventadetal.Size = new System.Drawing.Size(335, 201);
            this.boxventadetal.TabIndex = 31;
            this.boxventadetal.TabStop = false;
            this.boxventadetal.Text = "Venta Detal";
            // 
            // txtIdProductoDetal
            // 
            this.txtIdProductoDetal.Location = new System.Drawing.Point(280, 31);
            this.txtIdProductoDetal.Name = "txtIdProductoDetal";
            this.txtIdProductoDetal.Size = new System.Drawing.Size(24, 26);
            this.txtIdProductoDetal.TabIndex = 59;
            this.txtIdProductoDetal.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Total Pago:";
            // 
            // txttotalpago
            // 
            this.txttotalpago.BackColor = System.Drawing.Color.Gainsboro;
            this.txttotalpago.Cursor = System.Windows.Forms.Cursors.No;
            this.txttotalpago.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpago.ForeColor = System.Drawing.Color.Black;
            this.txttotalpago.Location = new System.Drawing.Point(120, 156);
            this.txttotalpago.Name = "txttotalpago";
            this.txttotalpago.Size = new System.Drawing.Size(153, 21);
            this.txttotalpago.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Valor Unidad:";
            // 
            // txtvalorunidad
            // 
            this.txtvalorunidad.BackColor = System.Drawing.Color.Gainsboro;
            this.txtvalorunidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalorunidad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorunidad.ForeColor = System.Drawing.Color.Black;
            this.txtvalorunidad.Location = new System.Drawing.Point(120, 116);
            this.txtvalorunidad.Name = "txtvalorunidad";
            this.txtvalorunidad.Size = new System.Drawing.Size(153, 21);
            this.txtvalorunidad.TabIndex = 38;
            this.txtvalorunidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvalorunidad_KeyDown);
            // 
            // txtconteounidad
            // 
            this.txtconteounidad.BackColor = System.Drawing.Color.Gainsboro;
            this.txtconteounidad.Location = new System.Drawing.Point(120, 72);
            this.txtconteounidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtconteounidad.Name = "txtconteounidad";
            this.txtconteounidad.Size = new System.Drawing.Size(40, 26);
            this.txtconteounidad.TabIndex = 36;
            this.txtconteounidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboproductodetal
            // 
            this.cboproductodetal.BackColor = System.Drawing.Color.Gainsboro;
            this.cboproductodetal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboproductodetal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproductodetal.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cboproductodetal.ForeColor = System.Drawing.Color.Black;
            this.cboproductodetal.FormattingEnabled = true;
            this.cboproductodetal.Location = new System.Drawing.Point(120, 32);
            this.cboproductodetal.Name = "cboproductodetal";
            this.cboproductodetal.Size = new System.Drawing.Size(153, 24);
            this.cboproductodetal.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Producto:";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnagregar.IconColor = System.Drawing.Color.Black;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.IconSize = 28;
            this.btnagregar.Location = new System.Drawing.Point(280, 146);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Padding = new System.Windows.Forms.Padding(1);
            this.btnagregar.Size = new System.Drawing.Size(36, 31);
            this.btnagregar.TabIndex = 58;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnguardarsqldetal
            // 
            this.btnguardarsqldetal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnguardarsqldetal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarsqldetal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnguardarsqldetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarsqldetal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarsqldetal.ForeColor = System.Drawing.Color.Black;
            this.btnguardarsqldetal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardarsqldetal.IconColor = System.Drawing.Color.Black;
            this.btnguardarsqldetal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardarsqldetal.IconSize = 28;
            this.btnguardarsqldetal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardarsqldetal.Location = new System.Drawing.Point(230, 516);
            this.btnguardarsqldetal.Name = "btnguardarsqldetal";
            this.btnguardarsqldetal.Padding = new System.Windows.Forms.Padding(1);
            this.btnguardarsqldetal.Size = new System.Drawing.Size(121, 34);
            this.btnguardarsqldetal.TabIndex = 58;
            this.btnguardarsqldetal.Text = "Registrar Ventas";
            this.btnguardarsqldetal.UseVisualStyleBackColor = false;
            this.btnguardarsqldetal.Click += new System.EventHandler(this.btnguardarsqldetal_Click);
            // 
            // dgvdataventadetal
            // 
            this.dgvdataventadetal.AllowUserToAddRows = false;
            this.dgvdataventadetal.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvdataventadetal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataventadetal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdataventadetal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataventadetal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProductoDetal,
            this.producto,
            this.Unidades,
            this.Total,
            this.btneliminardet});
            this.dgvdataventadetal.Location = new System.Drawing.Point(21, 260);
            this.dgvdataventadetal.MultiSelect = false;
            this.dgvdataventadetal.Name = "dgvdataventadetal";
            this.dgvdataventadetal.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataventadetal.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdataventadetal.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdataventadetal.RowTemplate.Height = 28;
            this.dgvdataventadetal.Size = new System.Drawing.Size(330, 245);
            this.dgvdataventadetal.TabIndex = 32;
            this.dgvdataventadetal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdataventadetal_CellContentClick);
            this.dgvdataventadetal.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdataventadetal_CellPainting);
            // 
            // IdProductoDetal
            // 
            this.IdProductoDetal.HeaderText = "IdProductoDetal";
            this.IdProductoDetal.Name = "IdProductoDetal";
            this.IdProductoDetal.ReadOnly = true;
            this.IdProductoDetal.Visible = false;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 95;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unid";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            this.Unidades.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 90;
            // 
            // btneliminardet
            // 
            this.btneliminardet.HeaderText = "";
            this.btneliminardet.Name = "btneliminardet";
            this.btneliminardet.ReadOnly = true;
            this.btneliminardet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminardet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminardet.Width = 40;
            // 
            // lbl_columna
            // 
            this.lbl_columna.BackColor = System.Drawing.Color.White;
            this.lbl_columna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_columna.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_columna.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_columna.Location = new System.Drawing.Point(0, 0);
            this.lbl_columna.Name = "lbl_columna";
            this.lbl_columna.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_columna.Size = new System.Drawing.Size(1383, 569);
            this.lbl_columna.TabIndex = 48;
            this.lbl_columna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnregistar
            // 
            this.btnregistar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnregistar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnregistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistar.ForeColor = System.Drawing.Color.Black;
            this.btnregistar.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnregistar.IconColor = System.Drawing.Color.Black;
            this.btnregistar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistar.IconSize = 25;
            this.btnregistar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnregistar.Location = new System.Drawing.Point(1220, 511);
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Padding = new System.Windows.Forms.Padding(1);
            this.btnregistar.Size = new System.Drawing.Size(124, 34);
            this.btnregistar.TabIndex = 76;
            this.btnregistar.Text = "RESGISTRAR";
            this.btnregistar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistar.UseVisualStyleBackColor = false;
            this.btnregistar.Click += new System.EventHandler(this.btnregistar_Click_1);
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorVenta.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValorVenta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenta.ForeColor = System.Drawing.Color.Black;
            this.txtValorVenta.Location = new System.Drawing.Point(550, 524);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(124, 21);
            this.txtValorVenta.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.Location = new System.Drawing.Point(691, 525);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 80;
            this.label13.Text = "Valor Pagado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.Location = new System.Drawing.Point(941, 523);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 19);
            this.label14.TabIndex = 75;
            this.label14.Text = "Valor Resta:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label15.Location = new System.Drawing.Point(447, 526);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 19);
            this.label15.TabIndex = 78;
            this.label15.Text = "Total Pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(29, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 82;
            this.label3.Text = "Total";
            // 
            // txtdiario
            // 
            this.txtdiario.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdiario.Cursor = System.Windows.Forms.Cursors.No;
            this.txtdiario.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiario.ForeColor = System.Drawing.Color.Black;
            this.txtdiario.Location = new System.Drawing.Point(88, 526);
            this.txtdiario.Name = "txtdiario";
            this.txtdiario.Size = new System.Drawing.Size(124, 21);
            this.txtdiario.TabIndex = 81;
            this.txtdiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiario_KeyPress);
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdiario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.btnguardarsqldetal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bntagregarventa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtValorAbono);
            this.Controls.Add(this.txtValorResta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBoxinfoventa);
            this.Controls.Add(this.btnregistar);
            this.Controls.Add(this.boxventadetal);
            this.Controls.Add(this.groupBoxinfocliente);
            this.Controls.Add(this.lblregistarventa);
            this.Controls.Add(this.dgvdataVentaMasiva);
            this.Controls.Add(this.dgvdataventadetal);
            this.Controls.Add(this.lbl_columna);
            this.Name = "frm_ventas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBoxinfocliente.ResumeLayout(false);
            this.groupBoxinfocliente.PerformLayout();
            this.groupBoxinfoventa.ResumeLayout(false);
            this.groupBoxinfoventa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataVentaMasiva)).EndInit();
            this.boxventadetal.ResumeLayout(false);
            this.boxventadetal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtconteounidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataventadetal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Declaración generada automáticamente en el archivo Form1.Designer.cs
        private System.Windows.Forms.TextBox txtValorAbono;
        private System.Windows.Forms.Label lblregistarventa;
        private System.Windows.Forms.GroupBox groupBoxinfocliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxinfoventa;
        private System.Windows.Forms.TextBox txtDatosCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspecificaciones;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.DataGridView dgvdataVentaMasiva;
        private System.Windows.Forms.GroupBox boxventadetal;
        private System.Windows.Forms.ComboBox cboproductodetal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtconteounidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvalorunidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvdataventadetal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetalleProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbodestadodeuda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_columna;
        private FontAwesome.Sharp.IconButton btnagregar;
        public System.Windows.Forms.TextBox txttotalpago;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtValorResta;
        private FontAwesome.Sharp.IconButton btnregistar;
        private System.Windows.Forms.TextBox txtValorProducto;
        private FontAwesome.Sharp.IconButton bntagregarventa;
        public System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnguardarsqldetal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtdiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorResta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDeuda;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.TextBox txtIdProductoDetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductoDetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminardet;
    }
}