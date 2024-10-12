using System;

namespace AppVentasEscritorio
{
    partial class form_detalle_ventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdataDetalleVentas = new System.Windows.Forms.DataGridView();
            this.DetalleProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.barrasuperior = new System.Windows.Forms.Label();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstadoDeuda = new System.Windows.Forms.TextBox();
            this.txtNumeroConsecutivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDatosCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspecificaciones = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.txtValorPagado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguargarcambios = new FontAwesome.Sharp.IconButton();
            this.btndescargarfactura = new FontAwesome.Sharp.IconButton();
            this.txtValorResta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVentaDetal = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataDetalleVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre:";
            // 
            // dgvdataDetalleVentas
            // 
            this.dgvdataDetalleVentas.AllowUserToAddRows = false;
            this.dgvdataDetalleVentas.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvdataDetalleVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataDetalleVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdataDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataDetalleVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleProducto,
            this.ValorProducto,
            this.Cantidad});
            this.dgvdataDetalleVentas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvdataDetalleVentas.Location = new System.Drawing.Point(12, 184);
            this.dgvdataDetalleVentas.MultiSelect = false;
            this.dgvdataDetalleVentas.Name = "dgvdataDetalleVentas";
            this.dgvdataDetalleVentas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataDetalleVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdataDetalleVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdataDetalleVentas.RowTemplate.Height = 28;
            this.dgvdataDetalleVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdataDetalleVentas.Size = new System.Drawing.Size(614, 233);
            this.dgvdataDetalleVentas.TabIndex = 40;
            // 
            // DetalleProducto
            // 
            this.DetalleProducto.HeaderText = "DetalleProducto";
            this.DetalleProducto.Name = "DetalleProducto";
            this.DetalleProducto.ReadOnly = true;
            this.DetalleProducto.Width = 310;
            // 
            // ValorProducto
            // 
            this.ValorProducto.HeaderText = "ValorProducto";
            this.ValorProducto.Name = "ValorProducto";
            this.ValorProducto.ReadOnly = true;
            this.ValorProducto.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiar.IconSize = 15;
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar.Location = new System.Drawing.Point(718, 30);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(79, 24);
            this.btnlimpiar.TabIndex = 39;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtbusqueda.Location = new System.Drawing.Point(265, 34);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(339, 20);
            this.txtbusqueda.TabIndex = 37;
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.Transparent;
            this.barrasuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barrasuperior.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barrasuperior.Location = new System.Drawing.Point(12, 9);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(811, 70);
            this.barrasuperior.TabIndex = 35;
            this.barrasuperior.Text = "Detalle de Ventas:";
            this.barrasuperior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 15;
            this.btnbuscar.Location = new System.Drawing.Point(635, 30);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(77, 24);
            this.btnbuscar.TabIndex = 82;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtEstadoDeuda);
            this.groupBox1.Controls.Add(this.txtNumeroConsecutivo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDatosCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEspecificaciones);
            this.groupBox1.Controls.Add(this.lbl8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 96);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // txtEstadoDeuda
            // 
            this.txtEstadoDeuda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEstadoDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoDeuda.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEstadoDeuda.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoDeuda.ForeColor = System.Drawing.Color.Black;
            this.txtEstadoDeuda.Location = new System.Drawing.Point(643, 49);
            this.txtEstadoDeuda.Name = "txtEstadoDeuda";
            this.txtEstadoDeuda.Size = new System.Drawing.Size(142, 21);
            this.txtEstadoDeuda.TabIndex = 85;
            // 
            // txtNumeroConsecutivo
            // 
            this.txtNumeroConsecutivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumeroConsecutivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroConsecutivo.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNumeroConsecutivo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroConsecutivo.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroConsecutivo.Location = new System.Drawing.Point(253, 22);
            this.txtNumeroConsecutivo.Name = "txtNumeroConsecutivo";
            this.txtNumeroConsecutivo.Size = new System.Drawing.Size(54, 21);
            this.txtNumeroConsecutivo.TabIndex = 84;
            this.txtNumeroConsecutivo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(669, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Estado Deuda:";
            // 
            // txtDatosCliente
            // 
            this.txtDatosCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatosCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatosCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosCliente.ForeColor = System.Drawing.Color.Black;
            this.txtDatosCliente.Location = new System.Drawing.Point(16, 49);
            this.txtDatosCliente.Name = "txtDatosCliente";
            this.txtDatosCliente.Size = new System.Drawing.Size(291, 21);
            this.txtDatosCliente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Completo:";
            // 
            // txtEspecificaciones
            // 
            this.txtEspecificaciones.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEspecificaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspecificaciones.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecificaciones.ForeColor = System.Drawing.Color.Black;
            this.txtEspecificaciones.Location = new System.Drawing.Point(327, 49);
            this.txtEspecificaciones.Name = "txtEspecificaciones";
            this.txtEspecificaciones.Size = new System.Drawing.Size(297, 20);
            this.txtEspecificaciones.TabIndex = 12;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(324, 25);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(121, 17);
            this.lbl8.TabIndex = 13;
            this.lbl8.Text = "Especificaciones:";
            // 
            // txtValorPagado
            // 
            this.txtValorPagado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPagado.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValorPagado.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagado.ForeColor = System.Drawing.Color.Black;
            this.txtValorPagado.Location = new System.Drawing.Point(654, 275);
            this.txtValorPagado.Name = "txtValorPagado";
            this.txtValorPagado.Size = new System.Drawing.Size(143, 21);
            this.txtValorPagado.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(671, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "Valor Abonado";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMontoTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMontoTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.ForeColor = System.Drawing.Color.Black;
            this.txtMontoTotal.Location = new System.Drawing.Point(654, 217);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(143, 21);
            this.txtMontoTotal.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(681, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Monto Total";
            // 
            // btnguargarcambios
            // 
            this.btnguargarcambios.BackColor = System.Drawing.Color.Gainsboro;
            this.btnguargarcambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnguargarcambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguargarcambios.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnguargarcambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguargarcambios.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguargarcambios.ForeColor = System.Drawing.Color.Black;
            this.btnguargarcambios.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnguargarcambios.IconColor = System.Drawing.Color.Black;
            this.btnguargarcambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguargarcambios.IconSize = 25;
            this.btnguargarcambios.Location = new System.Drawing.Point(655, 377);
            this.btnguargarcambios.Name = "btnguargarcambios";
            this.btnguargarcambios.Padding = new System.Windows.Forms.Padding(1);
            this.btnguargarcambios.Size = new System.Drawing.Size(43, 32);
            this.btnguargarcambios.TabIndex = 79;
            this.btnguargarcambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguargarcambios.UseVisualStyleBackColor = false;
            // 
            // btndescargarfactura
            // 
            this.btndescargarfactura.BackColor = System.Drawing.Color.Gainsboro;
            this.btndescargarfactura.Cursor = System.Windows.Forms.Cursors.No;
            this.btndescargarfactura.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btndescargarfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescargarfactura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargarfactura.ForeColor = System.Drawing.Color.Black;
            this.btndescargarfactura.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btndescargarfactura.IconColor = System.Drawing.Color.Black;
            this.btndescargarfactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndescargarfactura.IconSize = 25;
            this.btndescargarfactura.Location = new System.Drawing.Point(707, 377);
            this.btndescargarfactura.Name = "btndescargarfactura";
            this.btndescargarfactura.Padding = new System.Windows.Forms.Padding(1);
            this.btndescargarfactura.Size = new System.Drawing.Size(41, 32);
            this.btndescargarfactura.TabIndex = 82;
            this.btndescargarfactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargarfactura.UseVisualStyleBackColor = false;
            this.btndescargarfactura.Click += new System.EventHandler(this.btndescargarfactura_Click);
            this.btndescargarfactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btndescargarfactura_KeyPress);
            // 
            // txtValorResta
            // 
            this.txtValorResta.BackColor = System.Drawing.Color.Gainsboro;
            this.txtValorResta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorResta.Cursor = System.Windows.Forms.Cursors.No;
            this.txtValorResta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorResta.ForeColor = System.Drawing.Color.Black;
            this.txtValorResta.Location = new System.Drawing.Point(654, 332);
            this.txtValorResta.Name = "txtValorResta";
            this.txtValorResta.Size = new System.Drawing.Size(143, 21);
            this.txtValorResta.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(681, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Valor Resta";
            // 
            // btnVentaDetal
            // 
            this.btnVentaDetal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVentaDetal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaDetal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVentaDetal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaDetal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaDetal.ForeColor = System.Drawing.Color.Black;
            this.btnVentaDetal.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            this.btnVentaDetal.IconColor = System.Drawing.Color.Black;
            this.btnVentaDetal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentaDetal.IconSize = 28;
            this.btnVentaDetal.Location = new System.Drawing.Point(754, 377);
            this.btnVentaDetal.Name = "btnVentaDetal";
            this.btnVentaDetal.Padding = new System.Windows.Forms.Padding(1);
            this.btnVentaDetal.Size = new System.Drawing.Size(43, 32);
            this.btnVentaDetal.TabIndex = 95;
            this.btnVentaDetal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaDetal.UseVisualStyleBackColor = false;
            this.btnVentaDetal.Click += new System.EventHandler(this.btnVentaDetal_Click_1);
            this.btnVentaDetal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnVentaDetal_KeyPress);
            // 
            // form_detalle_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 433);
            this.Controls.Add(this.btnVentaDetal);
            this.Controls.Add(this.txtValorResta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndescargarfactura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnguargarcambios);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.dgvdataDetalleVentas);
            this.Name = "form_detalle_ventas";
            this.Text = "form_detalle_ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataDetalleVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EventHandler clientes_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdataDetalleVentas;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label barrasuperior;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDatosCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEspecificaciones;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnguargarcambios;
        private FontAwesome.Sharp.IconButton btndescargarfactura;
        public System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtValorPagado;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNumeroConsecutivo;
        public System.Windows.Forms.TextBox txtEstadoDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        public System.Windows.Forms.TextBox txtValorResta;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnVentaDetal;
    }
}