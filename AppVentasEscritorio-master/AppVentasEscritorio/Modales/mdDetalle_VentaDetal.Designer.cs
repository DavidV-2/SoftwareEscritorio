using System.Windows.Forms;

namespace AppVentasEscritorio.Modales
{
    partial class mdDetalle_VentaDetal
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
            this.txtbusquedadetal = new System.Windows.Forms.TextBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtnumeroconsecutivo = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndescargarfactura = new FontAwesome.Sharp.IconButton();
            this.boxventadetal = new System.Windows.Forms.GroupBox();
            this.dgvdataDetalleDetal = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.bntclosed = new FontAwesome.Sharp.IconButton();
            this.boxventadetal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataDetalleDetal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbusquedadetal
            // 
            this.txtbusquedadetal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbusquedadetal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusquedadetal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbusquedadetal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusquedadetal.ForeColor = System.Drawing.Color.Black;
            this.txtbusquedadetal.Location = new System.Drawing.Point(12, 63);
            this.txtbusquedadetal.Name = "txtbusquedadetal";
            this.txtbusquedadetal.Size = new System.Drawing.Size(119, 21);
            this.txtbusquedadetal.TabIndex = 84;
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
            this.btnbuscar.Location = new System.Drawing.Point(143, 59);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(73, 27);
            this.btnbuscar.TabIndex = 89;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 88;
            this.label1.Text = "Consecutivo:";
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
            this.btnlimpiar.Location = new System.Drawing.Point(227, 59);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(79, 27);
            this.btnlimpiar.TabIndex = 87;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtnumeroconsecutivo
            // 
            this.txtnumeroconsecutivo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtnumeroconsecutivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumeroconsecutivo.Cursor = System.Windows.Forms.Cursors.No;
            this.txtnumeroconsecutivo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeroconsecutivo.ForeColor = System.Drawing.Color.Black;
            this.txtnumeroconsecutivo.Location = new System.Drawing.Point(92, 39);
            this.txtnumeroconsecutivo.Name = "txtnumeroconsecutivo";
            this.txtnumeroconsecutivo.Size = new System.Drawing.Size(39, 21);
            this.txtnumeroconsecutivo.TabIndex = 91;
            this.txtnumeroconsecutivo.Visible = false;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMontoTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMontoTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.ForeColor = System.Drawing.Color.Black;
            this.txtMontoTotal.Location = new System.Drawing.Point(269, 144);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(105, 21);
            this.txtMontoTotal.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(188, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Total Venta:";
            // 
            // btndescargarfactura
            // 
            this.btndescargarfactura.BackColor = System.Drawing.Color.Gainsboro;
            this.btndescargarfactura.Cursor = System.Windows.Forms.Cursors.No;
            this.btndescargarfactura.Enabled = false;
            this.btndescargarfactura.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btndescargarfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescargarfactura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargarfactura.ForeColor = System.Drawing.Color.Black;
            this.btndescargarfactura.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btndescargarfactura.IconColor = System.Drawing.Color.Black;
            this.btndescargarfactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndescargarfactura.IconSize = 20;
            this.btndescargarfactura.Location = new System.Drawing.Point(319, 58);
            this.btndescargarfactura.Name = "btndescargarfactura";
            this.btndescargarfactura.Padding = new System.Windows.Forms.Padding(1);
            this.btndescargarfactura.Size = new System.Drawing.Size(30, 27);
            this.btndescargarfactura.TabIndex = 95;
            this.btndescargarfactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargarfactura.UseVisualStyleBackColor = false;
            // 
            // boxventadetal
            // 
            this.boxventadetal.BackColor = System.Drawing.Color.White;
            this.boxventadetal.Controls.Add(this.bntclosed);
            this.boxventadetal.Controls.Add(this.txtnumeroconsecutivo);
            this.boxventadetal.Controls.Add(this.txtbusquedadetal);
            this.boxventadetal.Controls.Add(this.btndescargarfactura);
            this.boxventadetal.Controls.Add(this.btnlimpiar);
            this.boxventadetal.Controls.Add(this.label1);
            this.boxventadetal.Controls.Add(this.btnbuscar);
            this.boxventadetal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxventadetal.Location = new System.Drawing.Point(12, 21);
            this.boxventadetal.Name = "boxventadetal";
            this.boxventadetal.Size = new System.Drawing.Size(362, 109);
            this.boxventadetal.TabIndex = 97;
            this.boxventadetal.TabStop = false;
            this.boxventadetal.Text = "Detalle Venta Detal";
            // 
            // dgvdataDetalleDetal
            // 
            this.dgvdataDetalleDetal.AllowUserToAddRows = false;
            this.dgvdataDetalleDetal.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvdataDetalleDetal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataDetalleDetal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.SubTotal});
            this.dgvdataDetalleDetal.Location = new System.Drawing.Point(12, 174);
            this.dgvdataDetalleDetal.Name = "dgvdataDetalleDetal";
            this.dgvdataDetalleDetal.ReadOnly = true;
            this.dgvdataDetalleDetal.Size = new System.Drawing.Size(362, 234);
            this.dgvdataDetalleDetal.TabIndex = 104;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.Gainsboro;
            this.txtfecha.Cursor = System.Windows.Forms.Cursors.No;
            this.txtfecha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.ForeColor = System.Drawing.Color.Black;
            this.txtfecha.Location = new System.Drawing.Point(12, 147);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(105, 21);
            this.txtfecha.TabIndex = 105;
            // 
            // bntclosed
            // 
            this.bntclosed.BackColor = System.Drawing.Color.Gainsboro;
            this.bntclosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntclosed.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bntclosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntclosed.ForeColor = System.Drawing.Color.Black;
            this.bntclosed.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.bntclosed.IconColor = System.Drawing.Color.Black;
            this.bntclosed.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bntclosed.IconSize = 18;
            this.bntclosed.Location = new System.Drawing.Point(319, 13);
            this.bntclosed.Name = "bntclosed";
            this.bntclosed.Size = new System.Drawing.Size(38, 23);
            this.bntclosed.TabIndex = 96;
            this.bntclosed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntclosed.UseVisualStyleBackColor = false;
            this.bntclosed.Click += new System.EventHandler(this.bntclosed_Click);
            // 
            // mdDetalle_VentaDetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 420);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.dgvdataDetalleDetal);
            this.Controls.Add(this.boxventadetal);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label2);
            this.Name = "mdDetalle_VentaDetal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdDetalle_VentaDetal";
            this.boxventadetal.ResumeLayout(false);
            this.boxventadetal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataDetalleDetal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtbusquedadetal;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        public System.Windows.Forms.TextBox txtnumeroconsecutivo;
        public System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btndescargarfactura;
        private System.Windows.Forms.GroupBox boxventadetal;
        private DataGridView dgvdataDetalleDetal;
        public TextBox txtfecha;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton bntclosed;
    }
}