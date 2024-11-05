namespace GUI
{
    partial class Alquilarform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alquilarform));
            this.cmbClienteAlquiler = new System.Windows.Forms.ComboBox();
            this.lbClienteAlquiler = new System.Windows.Forms.Label();
            this.labInsumoAlquiler = new System.Windows.Forms.Label();
            this.cmbInsumoAlquiler = new System.Windows.Forms.ComboBox();
            this.labCantidad = new System.Windows.Forms.Label();
            this.txtCantidadAlquiler = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insumo_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHora_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFechaAlquilar = new System.Windows.Forms.TextBox();
            this.labFechaAlquilar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClienteAlquiler
            // 
            this.cmbClienteAlquiler.FormattingEnabled = true;
            this.cmbClienteAlquiler.Location = new System.Drawing.Point(675, 23);
            this.cmbClienteAlquiler.Name = "cmbClienteAlquiler";
            this.cmbClienteAlquiler.Size = new System.Drawing.Size(121, 21);
            this.cmbClienteAlquiler.TabIndex = 0;
            // 
            // lbClienteAlquiler
            // 
            this.lbClienteAlquiler.AutoSize = true;
            this.lbClienteAlquiler.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteAlquiler.Location = new System.Drawing.Point(577, 22);
            this.lbClienteAlquiler.Name = "lbClienteAlquiler";
            this.lbClienteAlquiler.Size = new System.Drawing.Size(58, 19);
            this.lbClienteAlquiler.TabIndex = 1;
            this.lbClienteAlquiler.Text = "Cliente";
            // 
            // labInsumoAlquiler
            // 
            this.labInsumoAlquiler.AutoSize = true;
            this.labInsumoAlquiler.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInsumoAlquiler.Location = new System.Drawing.Point(577, 67);
            this.labInsumoAlquiler.Name = "labInsumoAlquiler";
            this.labInsumoAlquiler.Size = new System.Drawing.Size(61, 19);
            this.labInsumoAlquiler.TabIndex = 2;
            this.labInsumoAlquiler.Text = "Insumo";
            // 
            // cmbInsumoAlquiler
            // 
            this.cmbInsumoAlquiler.FormattingEnabled = true;
            this.cmbInsumoAlquiler.Location = new System.Drawing.Point(675, 68);
            this.cmbInsumoAlquiler.Name = "cmbInsumoAlquiler";
            this.cmbInsumoAlquiler.Size = new System.Drawing.Size(121, 21);
            this.cmbInsumoAlquiler.TabIndex = 3;
            // 
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidad.Location = new System.Drawing.Point(577, 149);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(72, 19);
            this.labCantidad.TabIndex = 4;
            this.labCantidad.Text = "Cantidad";
            // 
            // txtCantidadAlquiler
            // 
            this.txtCantidadAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadAlquiler.Location = new System.Drawing.Point(675, 146);
            this.txtCantidadAlquiler.Name = "txtCantidadAlquiler";
            this.txtCantidadAlquiler.Size = new System.Drawing.Size(121, 24);
            this.txtCantidadAlquiler.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Alquiler,
            this.Cliente_Alquiler,
            this.Insumo_Alquiler,
            this.fechaHora_Alquiler,
            this.Cantidad_Alquiler});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 406);
            this.dataGridView1.TabIndex = 6;
            // 
            // Id_Alquiler
            // 
            this.Id_Alquiler.FillWeight = 38.07107F;
            this.Id_Alquiler.HeaderText = "Id";
            this.Id_Alquiler.Name = "Id_Alquiler";
            this.Id_Alquiler.ReadOnly = true;
            // 
            // Cliente_Alquiler
            // 
            this.Cliente_Alquiler.FillWeight = 115.4822F;
            this.Cliente_Alquiler.HeaderText = "Cliente";
            this.Cliente_Alquiler.Name = "Cliente_Alquiler";
            this.Cliente_Alquiler.ReadOnly = true;
            // 
            // Insumo_Alquiler
            // 
            this.Insumo_Alquiler.FillWeight = 115.4822F;
            this.Insumo_Alquiler.HeaderText = "Insumo";
            this.Insumo_Alquiler.Name = "Insumo_Alquiler";
            this.Insumo_Alquiler.ReadOnly = true;
            // 
            // fechaHora_Alquiler
            // 
            this.fechaHora_Alquiler.FillWeight = 115.4822F;
            this.fechaHora_Alquiler.HeaderText = "Fecha - Hora";
            this.fechaHora_Alquiler.Name = "fechaHora_Alquiler";
            this.fechaHora_Alquiler.ReadOnly = true;
            // 
            // Cantidad_Alquiler
            // 
            this.Cantidad_Alquiler.FillWeight = 115.4822F;
            this.Cantidad_Alquiler.HeaderText = "Cantidad";
            this.Cantidad_Alquiler.Name = "Cantidad_Alquiler";
            this.Cantidad_Alquiler.ReadOnly = true;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquilar.Location = new System.Drawing.Point(695, 182);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(101, 30);
            this.btnAlquilar.TabIndex = 7;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(695, 227);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 30);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(589, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtFechaAlquilar
            // 
            this.txtFechaAlquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAlquilar.Location = new System.Drawing.Point(675, 104);
            this.txtFechaAlquilar.Name = "txtFechaAlquilar";
            this.txtFechaAlquilar.Size = new System.Drawing.Size(121, 24);
            this.txtFechaAlquilar.TabIndex = 11;
            // 
            // labFechaAlquilar
            // 
            this.labFechaAlquilar.AutoSize = true;
            this.labFechaAlquilar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFechaAlquilar.Location = new System.Drawing.Point(577, 107);
            this.labFechaAlquilar.Name = "labFechaAlquilar";
            this.labFechaAlquilar.Size = new System.Drawing.Size(49, 19);
            this.labFechaAlquilar.TabIndex = 10;
            this.labFechaAlquilar.Text = "Fecha";
            // 
            // Alquilarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(808, 434);
            this.Controls.Add(this.txtFechaAlquilar);
            this.Controls.Add(this.labFechaAlquilar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCantidadAlquiler);
            this.Controls.Add(this.labCantidad);
            this.Controls.Add(this.cmbInsumoAlquiler);
            this.Controls.Add(this.labInsumoAlquiler);
            this.Controls.Add(this.lbClienteAlquiler);
            this.Controls.Add(this.cmbClienteAlquiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alquilarform";
            this.Text = "Alquiler de insumos";
            this.Load += new System.EventHandler(this.Alquilarform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClienteAlquiler;
        private System.Windows.Forms.Label lbClienteAlquiler;
        private System.Windows.Forms.Label labInsumoAlquiler;
        private System.Windows.Forms.ComboBox cmbInsumoAlquiler;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.TextBox txtCantidadAlquiler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo_Alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHora_Alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Alquiler;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFechaAlquilar;
        private System.Windows.Forms.Label labFechaAlquilar;
    }
}