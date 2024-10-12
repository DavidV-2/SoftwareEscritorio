namespace AppVentasEscritorio
{
    partial class FormCategorias
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
            this.dgvcategoria = new System.Windows.Forms.DataGridView();
            this.Selec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.barrasuperior = new System.Windows.Forms.Label();
            this.txtindicecategoria = new System.Windows.Forms.TextBox();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.btnmodificar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcategoria
            // 
            this.dgvcategoria.AllowUserToAddRows = false;
            this.dgvcategoria.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvcategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selec,
            this.IdCategoria,
            this.Detalle,
            this.EstadoValor,
            this.Estado});
            this.dgvcategoria.Location = new System.Drawing.Point(310, 108);
            this.dgvcategoria.MultiSelect = false;
            this.dgvcategoria.Name = "dgvcategoria";
            this.dgvcategoria.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvcategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcategoria.RowTemplate.Height = 28;
            this.dgvcategoria.Size = new System.Drawing.Size(393, 203);
            this.dgvcategoria.TabIndex = 62;
            this.dgvcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategoria_CellContentClick);
            this.dgvcategoria.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvcategoria_CellPainting);
            // 
            // Selec
            // 
            this.Selec.HeaderText = "";
            this.Selec.Name = "Selec";
            this.Selec.ReadOnly = true;
            this.Selec.Width = 30;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdCategoria.Visible = false;
            this.IdCategoria.Width = 40;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 180;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Buscar por:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(681, 54);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(38, 23);
            this.btnlimpiar.TabIndex = 46;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscar.IconSize = 18;
            this.btnbuscar.Location = new System.Drawing.Point(634, 54);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 22);
            this.btnbuscar.TabIndex = 52;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtbusqueda.Location = new System.Drawing.Point(463, 55);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(165, 20);
            this.txtbusqueda.TabIndex = 44;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.White;
            this.cbobusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobusqueda.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.ForeColor = System.Drawing.Color.Black;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(326, 54);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(131, 23);
            this.cbobusqueda.TabIndex = 43;
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.White;
            this.barrasuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barrasuperior.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barrasuperior.Location = new System.Drawing.Point(250, 15);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(484, 80);
            this.barrasuperior.TabIndex = 42;
            this.barrasuperior.Text = "Lista de Categorias";
            // 
            // txtindicecategoria
            // 
            this.txtindicecategoria.Location = new System.Drawing.Point(174, 59);
            this.txtindicecategoria.Name = "txtindicecategoria";
            this.txtindicecategoria.Size = new System.Drawing.Size(24, 20);
            this.txtindicecategoria.TabIndex = 96;
            this.txtindicecategoria.Text = "-1";
            this.txtindicecategoria.Visible = false;
            // 
            // txtdetalle
            // 
            this.txtdetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtdetalle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetalle.ForeColor = System.Drawing.Color.Black;
            this.txtdetalle.Location = new System.Drawing.Point(20, 91);
            this.txtdetalle.Multiline = true;
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(208, 34);
            this.txtdetalle.TabIndex = 91;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.BackColor = System.Drawing.Color.White;
            this.lbldescripcion.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbldescripcion.Location = new System.Drawing.Point(23, 64);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(88, 18);
            this.lbldescripcion.TabIndex = 90;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 20;
            this.btneliminar.Location = new System.Drawing.Point(20, 281);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(208, 30);
            this.btneliminar.TabIndex = 87;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 86;
            this.label3.Text = "Detalle Categoria";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 20;
            this.btnguardar.Location = new System.Drawing.Point(20, 206);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(208, 30);
            this.btnguardar.TabIndex = 89;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(204, 59);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(24, 20);
            this.txtidcategoria.TabIndex = 83;
            this.txtidcategoria.Text = "0";
            this.txtidcategoria.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 328);
            this.label5.TabIndex = 95;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 328);
            this.label2.TabIndex = 101;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.White;
            this.cboestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboestado.ForeColor = System.Drawing.Color.Black;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(20, 150);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(114, 23);
            this.cboestado.TabIndex = 103;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.White;
            this.lblestado.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblestado.Location = new System.Drawing.Point(22, 128);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(50, 16);
            this.lblestado.TabIndex = 102;
            this.lblestado.Text = "Estado:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.btnmodificar.IconColor = System.Drawing.Color.Black;
            this.btnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmodificar.IconSize = 20;
            this.btnmodificar.Location = new System.Drawing.Point(20, 243);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(208, 30);
            this.btnmodificar.TabIndex = 104;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(140, 150);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(88, 29);
            this.iconButton1.TabIndex = 105;
            this.iconButton1.Text = "LIMPIAR";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 328);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtindicecategoria);
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtidcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.label2);
            this.Name = "FormCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcategoria;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label barrasuperior;
        private System.Windows.Forms.TextBox txtindicecategoria;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.Label lbldescripcion;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtidcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label lblestado;
        private FontAwesome.Sharp.IconButton btnmodificar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewButtonColumn Selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}