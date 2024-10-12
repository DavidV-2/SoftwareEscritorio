namespace AppVentasEscritorio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.fotocorrea = new System.Windows.Forms.Label();
            this.NroDocumento = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.btningresar = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 256);
            this.label1.TabIndex = 0;
            // 
            // fotocorrea
            // 
            this.fotocorrea.AutoSize = true;
            this.fotocorrea.BackColor = System.Drawing.Color.Transparent;
            this.fotocorrea.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fotocorrea.ForeColor = System.Drawing.Color.Black;
            this.fotocorrea.Location = new System.Drawing.Point(6, 211);
            this.fotocorrea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fotocorrea.Name = "fotocorrea";
            this.fotocorrea.Size = new System.Drawing.Size(224, 31);
            this.fotocorrea.TabIndex = 1;
            this.fotocorrea.Text = "FOTO CORREA";
            // 
            // NroDocumento
            // 
            this.NroDocumento.AutoSize = true;
            this.NroDocumento.Location = new System.Drawing.Point(245, 19);
            this.NroDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.Size = new System.Drawing.Size(85, 13);
            this.NroDocumento.TabIndex = 5;
            this.NroDocumento.Text = "Nro Documento:";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(245, 69);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(64, 13);
            this.Contraseña.TabIndex = 6;
            this.Contraseña.Text = "Contraseña:";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningresar.FlatAppearance.BorderSize = 2;
            this.btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btningresar.IconColor = System.Drawing.Color.Black;
            this.btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btningresar.IconSize = 21;
            this.btningresar.Location = new System.Drawing.Point(263, 130);
            this.btningresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(89, 31);
            this.btningresar.TabIndex = 7;
            this.btningresar.Text = "Ingresar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btningresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatAppearance.BorderSize = 2;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 21;
            this.btncancelar.Location = new System.Drawing.Point(356, 130);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(86, 31);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logo.ErrorImage = null;
            this.logo.Image = global::AppVentasEscritorio.Properties.Resources.file;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(209, 183);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocumento.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.Black;
            this.txtdocumento.Location = new System.Drawing.Point(245, 35);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(216, 21);
            this.txtdocumento.TabIndex = 53;
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.Gainsboro;
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.Black;
            this.txtclave.Location = new System.Drawing.Point(245, 85);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(216, 21);
            this.txtclave.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.NroDocumento);
            this.Controls.Add(this.fotocorrea);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fotocorrea;
        private System.Windows.Forms.Label NroDocumento;
        private System.Windows.Forms.Label Contraseña;
        private FontAwesome.Sharp.IconButton btningresar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}