namespace GUI
{
    partial class AlquilarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquilarInsumos));
            this.labTitulo = new System.Windows.Forms.Label();
            this.txtInfoInsumo = new System.Windows.Forms.TextBox();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labInfo = new System.Windows.Forms.Label();
            this.labCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.labInsumo = new System.Windows.Forms.Label();
            this.cmbInsumo = new System.Windows.Forms.ComboBox();
            this.pbInsumo = new System.Windows.Forms.PictureBox();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.stock1 = new Controles.Stock();
            this.labHoras = new System.Windows.Forms.Label();
            this.nuHoras = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(12, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(236, 19);
            this.labTitulo.TabIndex = 1;
            this.labTitulo.Text = "Selecciona los insumos a alquilar";
            // 
            // txtInfoInsumo
            // 
            this.txtInfoInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoInsumo.Location = new System.Drawing.Point(335, 49);
            this.txtInfoInsumo.Multiline = true;
            this.txtInfoInsumo.Name = "txtInfoInsumo";
            this.txtInfoInsumo.ReadOnly = true;
            this.txtInfoInsumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfoInsumo.Size = new System.Drawing.Size(266, 220);
            this.txtInfoInsumo.TabIndex = 20;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquilar.Location = new System.Drawing.Point(496, 366);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(105, 34);
            this.btnAlquilar.TabIndex = 21;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(515, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.Location = new System.Drawing.Point(335, 27);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(125, 19);
            this.labInfo.TabIndex = 35;
            this.labInfo.Text = "Ver información";
            // 
            // labCliente
            // 
            this.labCliente.AutoSize = true;
            this.labCliente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCliente.Location = new System.Drawing.Point(335, 278);
            this.labCliente.Name = "labCliente";
            this.labCliente.Size = new System.Drawing.Size(58, 19);
            this.labCliente.TabIndex = 36;
            this.labCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(418, 275);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(183, 24);
            this.cmbCliente.TabIndex = 37;
            // 
            // labInsumo
            // 
            this.labInsumo.AutoSize = true;
            this.labInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInsumo.Location = new System.Drawing.Point(12, 52);
            this.labInsumo.Name = "labInsumo";
            this.labInsumo.Size = new System.Drawing.Size(61, 19);
            this.labInsumo.TabIndex = 38;
            this.labInsumo.Text = "Insumo";
            // 
            // cmbInsumo
            // 
            this.cmbInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInsumo.FormattingEnabled = true;
            this.cmbInsumo.Location = new System.Drawing.Point(94, 49);
            this.cmbInsumo.Name = "cmbInsumo";
            this.cmbInsumo.Size = new System.Drawing.Size(139, 27);
            this.cmbInsumo.TabIndex = 39;
            // 
            // pbInsumo
            // 
            this.pbInsumo.Location = new System.Drawing.Point(16, 92);
            this.pbInsumo.Name = "pbInsumo";
            this.pbInsumo.Size = new System.Drawing.Size(300, 259);
            this.pbInsumo.TabIndex = 41;
            this.pbInsumo.TabStop = false;
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumo.Location = new System.Drawing.Point(219, 381);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(97, 34);
            this.btnAgregarInsumo.TabIndex = 43;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.UseVisualStyleBackColor = true;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // stock1
            // 
            this.stock1.CantidadSeleccionada = 0;
            this.stock1.Location = new System.Drawing.Point(16, 373);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(161, 50);
            this.stock1.TabIndex = 42;
            // 
            // labHoras
            // 
            this.labHoras.AutoSize = true;
            this.labHoras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoras.Location = new System.Drawing.Point(335, 316);
            this.labHoras.Name = "labHoras";
            this.labHoras.Size = new System.Drawing.Size(51, 19);
            this.labHoras.TabIndex = 44;
            this.labHoras.Text = "Horas";
            // 
            // nuHoras
            // 
            this.nuHoras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuHoras.Location = new System.Drawing.Point(431, 314);
            this.nuHoras.Name = "nuHoras";
            this.nuHoras.Size = new System.Drawing.Size(66, 27);
            this.nuHoras.TabIndex = 45;
            // 
            // AlquilarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(613, 454);
            this.Controls.Add(this.nuHoras);
            this.Controls.Add(this.labHoras);
            this.Controls.Add(this.btnAgregarInsumo);
            this.Controls.Add(this.stock1);
            this.Controls.Add(this.pbInsumo);
            this.Controls.Add(this.cmbInsumo);
            this.Controls.Add(this.labInsumo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.labCliente);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.txtInfoInsumo);
            this.Controls.Add(this.labTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlquilarInsumos";
            this.Text = "AlquilarInsumos";
            this.Load += new System.EventHandler(this.AlquilarInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.TextBox txtInfoInsumo;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Label labCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label labInsumo;
        private System.Windows.Forms.ComboBox cmbInsumo;
        private System.Windows.Forms.PictureBox pbInsumo;
        private Controles.Stock stock1;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.Label labHoras;
        private System.Windows.Forms.NumericUpDown nuHoras;
    }
}