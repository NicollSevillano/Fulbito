namespace GUI
{
    partial class BitacoraCambiosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInsumoCambios = new System.Windows.Forms.DataGridView();
            this.labBitacoraCambios = new System.Windows.Forms.Label();
            this.cmbBitacoraEventosUsuarios = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.LabBcambiosNombre = new System.Windows.Forms.Label();
            this.LabBcambiosfechaFinal = new System.Windows.Forms.Label();
            this.LabBcambiosfechaInicio = new System.Windows.Forms.Label();
            this.btnFiltrarBCambios = new System.Windows.Forms.Button();
            this.btnLimpiarCambios = new System.Windows.Forms.Button();
            this.btnActivarCambios = new System.Windows.Forms.Button();
            this.btnVolverbCambios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodInsumo_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existe_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Act_BitacoraCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumoCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInsumoCambios
            // 
            this.dgvInsumoCambios.AllowUserToAddRows = false;
            this.dgvInsumoCambios.AllowUserToDeleteRows = false;
            this.dgvInsumoCambios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumoCambios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInsumoCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumoCambios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_BitacoraCambios,
            this.CodInsumo_BitacoraCambios,
            this.Fecha_BitacoraCambios,
            this.Nombre_BitacoraCambios,
            this.Existe_BitacoraCambios,
            this.Descrip_BitacoraCambios,
            this.Usuario_BitacoraCambios,
            this.Act_BitacoraCambios});
            this.dgvInsumoCambios.Location = new System.Drawing.Point(12, 57);
            this.dgvInsumoCambios.Name = "dgvInsumoCambios";
            this.dgvInsumoCambios.ReadOnly = true;
            this.dgvInsumoCambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumoCambios.Size = new System.Drawing.Size(814, 241);
            this.dgvInsumoCambios.TabIndex = 0;
            // 
            // labBitacoraCambios
            // 
            this.labBitacoraCambios.AutoSize = true;
            this.labBitacoraCambios.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBitacoraCambios.Location = new System.Drawing.Point(12, 19);
            this.labBitacoraCambios.Name = "labBitacoraCambios";
            this.labBitacoraCambios.Size = new System.Drawing.Size(154, 19);
            this.labBitacoraCambios.TabIndex = 7;
            this.labBitacoraCambios.Text = "Bitácora de Cambios";
            // 
            // cmbBitacoraEventosUsuarios
            // 
            this.cmbBitacoraEventosUsuarios.FormattingEnabled = true;
            this.cmbBitacoraEventosUsuarios.Location = new System.Drawing.Point(123, 428);
            this.cmbBitacoraEventosUsuarios.Name = "cmbBitacoraEventosUsuarios";
            this.cmbBitacoraEventosUsuarios.Size = new System.Drawing.Size(119, 21);
            this.cmbBitacoraEventosUsuarios.TabIndex = 34;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(147, 375);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpHasta.TabIndex = 32;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(147, 322);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpDesde.TabIndex = 31;
            // 
            // LabBcambiosNombre
            // 
            this.LabBcambiosNombre.AutoSize = true;
            this.LabBcambiosNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBcambiosNombre.Location = new System.Drawing.Point(40, 430);
            this.LabBcambiosNombre.Name = "LabBcambiosNombre";
            this.LabBcambiosNombre.Size = new System.Drawing.Size(69, 19);
            this.LabBcambiosNombre.TabIndex = 29;
            this.LabBcambiosNombre.Text = "Nombre";
            // 
            // LabBcambiosfechaFinal
            // 
            this.LabBcambiosfechaFinal.AutoSize = true;
            this.LabBcambiosfechaFinal.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBcambiosfechaFinal.Location = new System.Drawing.Point(40, 377);
            this.LabBcambiosfechaFinal.Name = "LabBcambiosfechaFinal";
            this.LabBcambiosfechaFinal.Size = new System.Drawing.Size(87, 19);
            this.LabBcambiosfechaFinal.TabIndex = 28;
            this.LabBcambiosfechaFinal.Text = "Fecha Final";
            // 
            // LabBcambiosfechaInicio
            // 
            this.LabBcambiosfechaInicio.AutoSize = true;
            this.LabBcambiosfechaInicio.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBcambiosfechaInicio.Location = new System.Drawing.Point(40, 324);
            this.LabBcambiosfechaInicio.Name = "LabBcambiosfechaInicio";
            this.LabBcambiosfechaInicio.Size = new System.Drawing.Size(93, 19);
            this.LabBcambiosfechaInicio.TabIndex = 27;
            this.LabBcambiosfechaInicio.Text = "Fecha Inicio";
            // 
            // btnFiltrarBCambios
            // 
            this.btnFiltrarBCambios.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarBCambios.Location = new System.Drawing.Point(303, 317);
            this.btnFiltrarBCambios.Name = "btnFiltrarBCambios";
            this.btnFiltrarBCambios.Size = new System.Drawing.Size(89, 32);
            this.btnFiltrarBCambios.TabIndex = 35;
            this.btnFiltrarBCambios.Text = "Filtrar";
            this.btnFiltrarBCambios.UseVisualStyleBackColor = true;
            this.btnFiltrarBCambios.Click += new System.EventHandler(this.btnFiltrarBCambios_Click);
            // 
            // btnLimpiarCambios
            // 
            this.btnLimpiarCambios.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCambios.Location = new System.Drawing.Point(303, 417);
            this.btnLimpiarCambios.Name = "btnLimpiarCambios";
            this.btnLimpiarCambios.Size = new System.Drawing.Size(89, 32);
            this.btnLimpiarCambios.TabIndex = 36;
            this.btnLimpiarCambios.Text = "Limpiar";
            this.btnLimpiarCambios.UseVisualStyleBackColor = true;
            this.btnLimpiarCambios.Click += new System.EventHandler(this.btnLimpiarCambios_Click);
            // 
            // btnActivarCambios
            // 
            this.btnActivarCambios.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarCambios.Location = new System.Drawing.Point(303, 367);
            this.btnActivarCambios.Name = "btnActivarCambios";
            this.btnActivarCambios.Size = new System.Drawing.Size(89, 32);
            this.btnActivarCambios.TabIndex = 37;
            this.btnActivarCambios.Text = "Activar";
            this.btnActivarCambios.UseVisualStyleBackColor = true;
            this.btnActivarCambios.Click += new System.EventHandler(this.btnActivarCambios_Click);
            // 
            // btnVolverbCambios
            // 
            this.btnVolverbCambios.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverbCambios.Location = new System.Drawing.Point(737, 426);
            this.btnVolverbCambios.Name = "btnVolverbCambios";
            this.btnVolverbCambios.Size = new System.Drawing.Size(89, 32);
            this.btnVolverbCambios.TabIndex = 39;
            this.btnVolverbCambios.Text = "Volver";
            this.btnVolverbCambios.UseVisualStyleBackColor = true;
            this.btnVolverbCambios.Click += new System.EventHandler(this.btnVolverbCambios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(444, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // id_BitacoraCambios
            // 
            this.id_BitacoraCambios.FillWeight = 45.68528F;
            this.id_BitacoraCambios.HeaderText = "Id";
            this.id_BitacoraCambios.Name = "id_BitacoraCambios";
            this.id_BitacoraCambios.ReadOnly = true;
            // 
            // CodInsumo_BitacoraCambios
            // 
            this.CodInsumo_BitacoraCambios.HeaderText = "Id Insumo";
            this.CodInsumo_BitacoraCambios.Name = "CodInsumo_BitacoraCambios";
            this.CodInsumo_BitacoraCambios.ReadOnly = true;
            // 
            // Fecha_BitacoraCambios
            // 
            this.Fecha_BitacoraCambios.HeaderText = "Fecha - Hora";
            this.Fecha_BitacoraCambios.Name = "Fecha_BitacoraCambios";
            this.Fecha_BitacoraCambios.ReadOnly = true;
            // 
            // Nombre_BitacoraCambios
            // 
            this.Nombre_BitacoraCambios.FillWeight = 127.3787F;
            this.Nombre_BitacoraCambios.HeaderText = "Nombre";
            this.Nombre_BitacoraCambios.Name = "Nombre_BitacoraCambios";
            this.Nombre_BitacoraCambios.ReadOnly = true;
            // 
            // Existe_BitacoraCambios
            // 
            this.Existe_BitacoraCambios.FillWeight = 127.3787F;
            this.Existe_BitacoraCambios.HeaderText = "Existe";
            this.Existe_BitacoraCambios.Name = "Existe_BitacoraCambios";
            this.Existe_BitacoraCambios.ReadOnly = true;
            // 
            // Descrip_BitacoraCambios
            // 
            this.Descrip_BitacoraCambios.FillWeight = 127.3787F;
            this.Descrip_BitacoraCambios.HeaderText = "Descripción";
            this.Descrip_BitacoraCambios.Name = "Descrip_BitacoraCambios";
            this.Descrip_BitacoraCambios.ReadOnly = true;
            // 
            // Usuario_BitacoraCambios
            // 
            this.Usuario_BitacoraCambios.HeaderText = "Usuario";
            this.Usuario_BitacoraCambios.Name = "Usuario_BitacoraCambios";
            this.Usuario_BitacoraCambios.ReadOnly = true;
            // 
            // Act_BitacoraCambios
            // 
            this.Act_BitacoraCambios.FillWeight = 44.79998F;
            this.Act_BitacoraCambios.HeaderText = "Act.";
            this.Act_BitacoraCambios.Name = "Act_BitacoraCambios";
            this.Act_BitacoraCambios.ReadOnly = true;
            // 
            // BitacoraCambiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(838, 473);
            this.Controls.Add(this.btnVolverbCambios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActivarCambios);
            this.Controls.Add(this.btnLimpiarCambios);
            this.Controls.Add(this.btnFiltrarBCambios);
            this.Controls.Add(this.cmbBitacoraEventosUsuarios);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.LabBcambiosNombre);
            this.Controls.Add(this.LabBcambiosfechaFinal);
            this.Controls.Add(this.LabBcambiosfechaInicio);
            this.Controls.Add(this.labBitacoraCambios);
            this.Controls.Add(this.dgvInsumoCambios);
            this.Name = "BitacoraCambiosForm";
            this.Text = "BitacoraCambios";
            this.Load += new System.EventHandler(this.BitacoraCambiosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumoCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInsumoCambios;
        private System.Windows.Forms.Label labBitacoraCambios;
        private System.Windows.Forms.ComboBox cmbBitacoraEventosUsuarios;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label LabBcambiosNombre;
        private System.Windows.Forms.Label LabBcambiosfechaFinal;
        private System.Windows.Forms.Label LabBcambiosfechaInicio;
        private System.Windows.Forms.Button btnFiltrarBCambios;
        private System.Windows.Forms.Button btnLimpiarCambios;
        private System.Windows.Forms.Button btnActivarCambios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolverbCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_BitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodInsumo_BitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_BitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_BitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existe_BitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_BitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_BitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act_BitacoraCambios;
    }
}