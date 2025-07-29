namespace GUI
{
    partial class ReporteInteligente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteInteligente));
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.labDesde = new System.Windows.Forms.Label();
            this.labHasta = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.labHistoricoAlquiler = new System.Windows.Forms.Label();
            this.labCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.labHistoricoClientes = new System.Windows.Forms.Label();
            this.chartClientes = new LiveCharts.WinForms.CartesianChart();
            this.chartGanancias = new LiveCharts.WinForms.CartesianChart();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.labFormato = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnClienteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMesC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(566, 94);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(103, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(566, 132);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(103, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // labDesde
            // 
            this.labDesde.AutoSize = true;
            this.labDesde.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDesde.Location = new System.Drawing.Point(509, 95);
            this.labDesde.Name = "labDesde";
            this.labDesde.Size = new System.Drawing.Size(51, 19);
            this.labDesde.TabIndex = 2;
            this.labDesde.Text = "Desde";
            // 
            // labHasta
            // 
            this.labHasta.AutoSize = true;
            this.labHasta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHasta.Location = new System.Drawing.Point(509, 133);
            this.labHasta.Name = "labHasta";
            this.labHasta.Size = new System.Drawing.Size(48, 19);
            this.labHasta.TabIndex = 3;
            this.labHasta.Text = "Hasta";
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(552, 416);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(139, 53);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.AllowUserToAddRows = false;
            this.dgvAlquileres.AllowUserToDeleteRows = false;
            this.dgvAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.columnCliente,
            this.columnFechaHora,
            this.columnTotal});
            this.dgvAlquileres.Location = new System.Drawing.Point(12, 34);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.ReadOnly = true;
            this.dgvAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlquileres.Size = new System.Drawing.Size(434, 239);
            this.dgvAlquileres.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(569, 176);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 32);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // labHistoricoAlquiler
            // 
            this.labHistoricoAlquiler.AutoSize = true;
            this.labHistoricoAlquiler.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHistoricoAlquiler.Location = new System.Drawing.Point(12, 9);
            this.labHistoricoAlquiler.Name = "labHistoricoAlquiler";
            this.labHistoricoAlquiler.Size = new System.Drawing.Size(146, 19);
            this.labHistoricoAlquiler.TabIndex = 8;
            this.labHistoricoAlquiler.Text = "Histórico Alquileres";
            // 
            // labCliente
            // 
            this.labCliente.AutoSize = true;
            this.labCliente.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCliente.Location = new System.Drawing.Point(479, 50);
            this.labCliente.Name = "labCliente";
            this.labCliente.Size = new System.Drawing.Size(58, 19);
            this.labCliente.TabIndex = 9;
            this.labCliente.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(543, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 27);
            this.textBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(505, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.columnClienteC,
            this.columnMesC,
            this.columnTotalC});
            this.dgvClientes.Location = new System.Drawing.Point(723, 34);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(350, 214);
            this.dgvClientes.TabIndex = 13;
            // 
            // labHistoricoClientes
            // 
            this.labHistoricoClientes.AutoSize = true;
            this.labHistoricoClientes.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHistoricoClientes.Location = new System.Drawing.Point(719, 9);
            this.labHistoricoClientes.Name = "labHistoricoClientes";
            this.labHistoricoClientes.Size = new System.Drawing.Size(132, 19);
            this.labHistoricoClientes.TabIndex = 14;
            this.labHistoricoClientes.Text = "Histórico Clientes";
            // 
            // chartClientes
            // 
            this.chartClientes.Location = new System.Drawing.Point(723, 268);
            this.chartClientes.Name = "chartClientes";
            this.chartClientes.Size = new System.Drawing.Size(350, 201);
            this.chartClientes.TabIndex = 15;
            this.chartClientes.Text = "cartesianChart2";
            // 
            // chartGanancias
            // 
            this.chartGanancias.Location = new System.Drawing.Point(12, 279);
            this.chartGanancias.Name = "chartGanancias";
            this.chartGanancias.Size = new System.Drawing.Size(434, 190);
            this.chartGanancias.TabIndex = 16;
            this.chartGanancias.Text = "cartesianChart1";
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(566, 380);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(121, 21);
            this.cmbFormato.TabIndex = 17;
            // 
            // labFormato
            // 
            this.labFormato.AutoSize = true;
            this.labFormato.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFormato.Location = new System.Drawing.Point(479, 379);
            this.labFormato.Name = "labFormato";
            this.labFormato.Size = new System.Drawing.Size(70, 19);
            this.labFormato.TabIndex = 18;
            this.labFormato.Text = "Formato";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 38.57868F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // columnCliente
            // 
            this.columnCliente.FillWeight = 120.4738F;
            this.columnCliente.HeaderText = "Cliente";
            this.columnCliente.Name = "columnCliente";
            this.columnCliente.ReadOnly = true;
            // 
            // columnFechaHora
            // 
            this.columnFechaHora.FillWeight = 120.4738F;
            this.columnFechaHora.HeaderText = "Fecha y Hora";
            this.columnFechaHora.Name = "columnFechaHora";
            this.columnFechaHora.ReadOnly = true;
            // 
            // columnTotal
            // 
            this.columnTotal.FillWeight = 120.4738F;
            this.columnTotal.HeaderText = "Total";
            this.columnTotal.Name = "columnTotal";
            this.columnTotal.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 60.9137F;
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // columnClienteC
            // 
            this.columnClienteC.FillWeight = 119.5432F;
            this.columnClienteC.HeaderText = "Cliente";
            this.columnClienteC.Name = "columnClienteC";
            this.columnClienteC.ReadOnly = true;
            // 
            // columnMesC
            // 
            this.columnMesC.HeaderText = "Mes";
            this.columnMesC.Name = "columnMesC";
            this.columnMesC.ReadOnly = true;
            // 
            // columnTotalC
            // 
            this.columnTotalC.FillWeight = 119.5432F;
            this.columnTotalC.HeaderText = "Total";
            this.columnTotalC.Name = "columnTotalC";
            this.columnTotalC.ReadOnly = true;
            // 
            // ReporteInteligente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1085, 495);
            this.Controls.Add(this.labFormato);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.chartGanancias);
            this.Controls.Add(this.chartClientes);
            this.Controls.Add(this.labHistoricoClientes);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labCliente);
            this.Controls.Add(this.labHistoricoAlquiler);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvAlquileres);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.labHasta);
            this.Controls.Add(this.labDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteInteligente";
            this.Text = "Reporte Inteligente";
            this.Load += new System.EventHandler(this.ReporteInteligente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label labDesde;
        private System.Windows.Forms.Label labHasta;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label labHistoricoAlquiler;
        private System.Windows.Forms.Label labCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label labHistoricoClientes;
        private LiveCharts.WinForms.CartesianChart chartClientes;
        private LiveCharts.WinForms.CartesianChart chartGanancias;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.Label labFormato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnClienteC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMesC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalC;
    }
}