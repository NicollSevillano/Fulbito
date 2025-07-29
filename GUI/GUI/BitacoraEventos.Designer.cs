namespace GUI
{
    partial class BitacoraEventosform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitacoraEventosform));
            this.dgvBitacoraEventos = new System.Windows.Forms.DataGridView();
            this.LabBeventosfechaInicio = new System.Windows.Forms.Label();
            this.LabBeventosfechaFinal = new System.Windows.Forms.Label();
            this.LabBeventosUsuario = new System.Windows.Forms.Label();
            this.LabBeventoscriticidad = new System.Windows.Forms.Label();
            this.labBitacoraEventos = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericCriticidad = new System.Windows.Forms.NumericUpDown();
            this.cmbBitacoraEventosUsuarios = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFiltrarBEvento = new System.Windows.Forms.Button();
            this.btnVolverbEventos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.LabNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.labApellido = new System.Windows.Forms.Label();
            this.txtNombreBE = new System.Windows.Forms.TextBox();
            this.txtApellidoBE = new System.Windows.Forms.TextBox();
            this.IdBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextoBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriticidadBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCriticidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBitacoraEventos
            // 
            this.dgvBitacoraEventos.AllowUserToAddRows = false;
            this.dgvBitacoraEventos.AllowUserToDeleteRows = false;
            this.dgvBitacoraEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacoraEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacoraEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoraEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBitacoraE,
            this.FechaBitacoraE,
            this.TextoBitacoraE,
            this.CriticidadBitacoraE,
            this.UsuarioBitacoraE});
            this.dgvBitacoraEventos.Location = new System.Drawing.Point(12, 44);
            this.dgvBitacoraEventos.Name = "dgvBitacoraEventos";
            this.dgvBitacoraEventos.ReadOnly = true;
            this.dgvBitacoraEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacoraEventos.Size = new System.Drawing.Size(702, 236);
            this.dgvBitacoraEventos.TabIndex = 0;
            this.dgvBitacoraEventos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacoraEventos_RowEnter);
            // 
            // LabBeventosfechaInicio
            // 
            this.LabBeventosfechaInicio.AutoSize = true;
            this.LabBeventosfechaInicio.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventosfechaInicio.Location = new System.Drawing.Point(22, 371);
            this.LabBeventosfechaInicio.Name = "LabBeventosfechaInicio";
            this.LabBeventosfechaInicio.Size = new System.Drawing.Size(93, 19);
            this.LabBeventosfechaInicio.TabIndex = 1;
            this.LabBeventosfechaInicio.Text = "Fecha Inicio";
            // 
            // LabBeventosfechaFinal
            // 
            this.LabBeventosfechaFinal.AutoSize = true;
            this.LabBeventosfechaFinal.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventosfechaFinal.Location = new System.Drawing.Point(299, 371);
            this.LabBeventosfechaFinal.Name = "LabBeventosfechaFinal";
            this.LabBeventosfechaFinal.Size = new System.Drawing.Size(87, 19);
            this.LabBeventosfechaFinal.TabIndex = 2;
            this.LabBeventosfechaFinal.Text = "Fecha Final";
            // 
            // LabBeventosUsuario
            // 
            this.LabBeventosUsuario.AutoSize = true;
            this.LabBeventosUsuario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventosUsuario.Location = new System.Drawing.Point(22, 421);
            this.LabBeventosUsuario.Name = "LabBeventosUsuario";
            this.LabBeventosUsuario.Size = new System.Drawing.Size(63, 19);
            this.LabBeventosUsuario.TabIndex = 3;
            this.LabBeventosUsuario.Text = "Usuario";
            // 
            // LabBeventoscriticidad
            // 
            this.LabBeventoscriticidad.AutoSize = true;
            this.LabBeventoscriticidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventoscriticidad.Location = new System.Drawing.Point(299, 421);
            this.LabBeventoscriticidad.Name = "LabBeventoscriticidad";
            this.LabBeventoscriticidad.Size = new System.Drawing.Size(76, 19);
            this.LabBeventoscriticidad.TabIndex = 4;
            this.LabBeventoscriticidad.Text = "Criticidad";
            // 
            // labBitacoraEventos
            // 
            this.labBitacoraEventos.AutoSize = true;
            this.labBitacoraEventos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBitacoraEventos.Location = new System.Drawing.Point(12, 9);
            this.labBitacoraEventos.Name = "labBitacoraEventos";
            this.labBitacoraEventos.Size = new System.Drawing.Size(147, 19);
            this.labBitacoraEventos.TabIndex = 5;
            this.labBitacoraEventos.Text = "Bitácora de Eventos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 370);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(392, 370);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // numericCriticidad
            // 
            this.numericCriticidad.Location = new System.Drawing.Point(392, 420);
            this.numericCriticidad.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCriticidad.Name = "numericCriticidad";
            this.numericCriticidad.Size = new System.Drawing.Size(38, 20);
            this.numericCriticidad.TabIndex = 8;
            // 
            // cmbBitacoraEventosUsuarios
            // 
            this.cmbBitacoraEventosUsuarios.FormattingEnabled = true;
            this.cmbBitacoraEventosUsuarios.Location = new System.Drawing.Point(97, 420);
            this.cmbBitacoraEventosUsuarios.Name = "cmbBitacoraEventosUsuarios";
            this.cmbBitacoraEventosUsuarios.Size = new System.Drawing.Size(119, 21);
            this.cmbBitacoraEventosUsuarios.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(521, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnFiltrarBEvento
            // 
            this.btnFiltrarBEvento.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarBEvento.Location = new System.Drawing.Point(123, 469);
            this.btnFiltrarBEvento.Name = "btnFiltrarBEvento";
            this.btnFiltrarBEvento.Size = new System.Drawing.Size(89, 32);
            this.btnFiltrarBEvento.TabIndex = 11;
            this.btnFiltrarBEvento.Text = "Filtrar";
            this.btnFiltrarBEvento.UseVisualStyleBackColor = true;
            this.btnFiltrarBEvento.Click += new System.EventHandler(this.btnFiltrarBEvento_Click);
            // 
            // btnVolverbEventos
            // 
            this.btnVolverbEventos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverbEventos.Location = new System.Drawing.Point(426, 469);
            this.btnVolverbEventos.Name = "btnVolverbEventos";
            this.btnVolverbEventos.Size = new System.Drawing.Size(89, 32);
            this.btnVolverbEventos.TabIndex = 12;
            this.btnVolverbEventos.Text = "Volver";
            this.btnVolverbEventos.UseVisualStyleBackColor = true;
            this.btnVolverbEventos.Click += new System.EventHandler(this.btnVolverbEventos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(224, 469);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 32);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNombre.Location = new System.Drawing.Point(43, 312);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(69, 19);
            this.LabNombre.TabIndex = 14;
            this.LabNombre.Text = "Nombre";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(325, 469);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 32);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(318, 312);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(68, 19);
            this.labApellido.TabIndex = 16;
            this.labApellido.Text = "Apellido";
            // 
            // txtNombreBE
            // 
            this.txtNombreBE.Enabled = false;
            this.txtNombreBE.Location = new System.Drawing.Point(118, 313);
            this.txtNombreBE.Name = "txtNombreBE";
            this.txtNombreBE.ReadOnly = true;
            this.txtNombreBE.Size = new System.Drawing.Size(153, 20);
            this.txtNombreBE.TabIndex = 17;
            // 
            // txtApellidoBE
            // 
            this.txtApellidoBE.Enabled = false;
            this.txtApellidoBE.Location = new System.Drawing.Point(392, 313);
            this.txtApellidoBE.Name = "txtApellidoBE";
            this.txtApellidoBE.ReadOnly = true;
            this.txtApellidoBE.Size = new System.Drawing.Size(153, 20);
            this.txtApellidoBE.TabIndex = 18;
            // 
            // IdBitacoraE
            // 
            this.IdBitacoraE.HeaderText = "Id";
            this.IdBitacoraE.Name = "IdBitacoraE";
            this.IdBitacoraE.ReadOnly = true;
            // 
            // FechaBitacoraE
            // 
            this.FechaBitacoraE.HeaderText = "Fecha y Hora";
            this.FechaBitacoraE.Name = "FechaBitacoraE";
            this.FechaBitacoraE.ReadOnly = true;
            // 
            // TextoBitacoraE
            // 
            this.TextoBitacoraE.HeaderText = "Texto";
            this.TextoBitacoraE.Name = "TextoBitacoraE";
            this.TextoBitacoraE.ReadOnly = true;
            // 
            // CriticidadBitacoraE
            // 
            this.CriticidadBitacoraE.HeaderText = "Criticidad";
            this.CriticidadBitacoraE.Name = "CriticidadBitacoraE";
            this.CriticidadBitacoraE.ReadOnly = true;
            // 
            // UsuarioBitacoraE
            // 
            this.UsuarioBitacoraE.HeaderText = "Usuario";
            this.UsuarioBitacoraE.Name = "UsuarioBitacoraE";
            this.UsuarioBitacoraE.ReadOnly = true;
            // 
            // BitacoraEventosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(726, 513);
            this.Controls.Add(this.txtApellidoBE);
            this.Controls.Add(this.txtNombreBE);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.LabNombre);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVolverbEventos);
            this.Controls.Add(this.btnFiltrarBEvento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbBitacoraEventosUsuarios);
            this.Controls.Add(this.numericCriticidad);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labBitacoraEventos);
            this.Controls.Add(this.LabBeventoscriticidad);
            this.Controls.Add(this.LabBeventosUsuario);
            this.Controls.Add(this.LabBeventosfechaFinal);
            this.Controls.Add(this.LabBeventosfechaInicio);
            this.Controls.Add(this.dgvBitacoraEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BitacoraEventosform";
            this.Text = "Bitacora de Eventos";
            this.Load += new System.EventHandler(this.BitacoraEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCriticidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacoraEventos;
        private System.Windows.Forms.Label LabBeventosfechaInicio;
        private System.Windows.Forms.Label LabBeventosfechaFinal;
        private System.Windows.Forms.Label LabBeventosUsuario;
        private System.Windows.Forms.Label LabBeventoscriticidad;
        private System.Windows.Forms.Label labBitacoraEventos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericCriticidad;
        private System.Windows.Forms.ComboBox cmbBitacoraEventosUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFiltrarBEvento;
        private System.Windows.Forms.Button btnVolverbEventos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.TextBox txtNombreBE;
        private System.Windows.Forms.TextBox txtApellidoBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextoBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriticidadBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioBitacoraE;
    }
}