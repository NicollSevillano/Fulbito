namespace GUI
{
    partial class BitacoraEventosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitacoraEventosForm));
            this.labBitacoraEventos = new System.Windows.Forms.Label();
            this.dgvBitacoraEventos = new System.Windows.Forms.DataGridView();
            this.IdBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextoBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriticidadBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuloBitacoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellidoBE = new System.Windows.Forms.TextBox();
            this.txtNombreBE = new System.Windows.Forms.TextBox();
            this.labApellidoBE = new System.Windows.Forms.Label();
            this.LabNombreBE = new System.Windows.Forms.Label();
            this.cmbBitacoraEventosUsuarios = new System.Windows.Forms.ComboBox();
            this.numericCriticidad = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabBeventoscriticidad = new System.Windows.Forms.Label();
            this.LabBeventosUsuario = new System.Windows.Forms.Label();
            this.LabBeventosfechaFinal = new System.Windows.Forms.Label();
            this.LabBeventosfechaInicio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVolverbEventos = new System.Windows.Forms.Button();
            this.btnFiltrarBEvento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCriticidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labBitacoraEventos
            // 
            this.labBitacoraEventos.AutoSize = true;
            this.labBitacoraEventos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBitacoraEventos.Location = new System.Drawing.Point(12, 19);
            this.labBitacoraEventos.Name = "labBitacoraEventos";
            this.labBitacoraEventos.Size = new System.Drawing.Size(147, 19);
            this.labBitacoraEventos.TabIndex = 6;
            this.labBitacoraEventos.Text = "Bitácora de Eventos";
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
            this.UsuarioBitacoraE,
            this.ModuloBitacoraE});
            this.dgvBitacoraEventos.Location = new System.Drawing.Point(16, 53);
            this.dgvBitacoraEventos.Name = "dgvBitacoraEventos";
            this.dgvBitacoraEventos.ReadOnly = true;
            this.dgvBitacoraEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacoraEventos.Size = new System.Drawing.Size(772, 236);
            this.dgvBitacoraEventos.TabIndex = 7;
            this.dgvBitacoraEventos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacoraEventos_RowEnter);
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
            // ModuloBitacoraE
            // 
            this.ModuloBitacoraE.HeaderText = "Modulo";
            this.ModuloBitacoraE.Name = "ModuloBitacoraE";
            this.ModuloBitacoraE.ReadOnly = true;
            // 
            // txtApellidoBE
            // 
            this.txtApellidoBE.Enabled = false;
            this.txtApellidoBE.Location = new System.Drawing.Point(484, 320);
            this.txtApellidoBE.Name = "txtApellidoBE";
            this.txtApellidoBE.ReadOnly = true;
            this.txtApellidoBE.Size = new System.Drawing.Size(153, 20);
            this.txtApellidoBE.TabIndex = 30;
            // 
            // txtNombreBE
            // 
            this.txtNombreBE.Enabled = false;
            this.txtNombreBE.Location = new System.Drawing.Point(210, 320);
            this.txtNombreBE.Name = "txtNombreBE";
            this.txtNombreBE.ReadOnly = true;
            this.txtNombreBE.Size = new System.Drawing.Size(153, 20);
            this.txtNombreBE.TabIndex = 29;
            // 
            // labApellidoBE
            // 
            this.labApellidoBE.AutoSize = true;
            this.labApellidoBE.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellidoBE.Location = new System.Drawing.Point(410, 319);
            this.labApellidoBE.Name = "labApellidoBE";
            this.labApellidoBE.Size = new System.Drawing.Size(68, 19);
            this.labApellidoBE.TabIndex = 28;
            this.labApellidoBE.Text = "Apellido";
            // 
            // LabNombreBE
            // 
            this.LabNombreBE.AutoSize = true;
            this.LabNombreBE.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNombreBE.Location = new System.Drawing.Point(135, 319);
            this.LabNombreBE.Name = "LabNombreBE";
            this.LabNombreBE.Size = new System.Drawing.Size(69, 19);
            this.LabNombreBE.TabIndex = 27;
            this.LabNombreBE.Text = "Nombre";
            // 
            // cmbBitacoraEventosUsuarios
            // 
            this.cmbBitacoraEventosUsuarios.FormattingEnabled = true;
            this.cmbBitacoraEventosUsuarios.Location = new System.Drawing.Point(99, 433);
            this.cmbBitacoraEventosUsuarios.Name = "cmbBitacoraEventosUsuarios";
            this.cmbBitacoraEventosUsuarios.Size = new System.Drawing.Size(119, 21);
            this.cmbBitacoraEventosUsuarios.TabIndex = 26;
            // 
            // numericCriticidad
            // 
            this.numericCriticidad.Location = new System.Drawing.Point(394, 433);
            this.numericCriticidad.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCriticidad.Name = "numericCriticidad";
            this.numericCriticidad.Size = new System.Drawing.Size(38, 20);
            this.numericCriticidad.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(394, 383);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 383);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // LabBeventoscriticidad
            // 
            this.LabBeventoscriticidad.AutoSize = true;
            this.LabBeventoscriticidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventoscriticidad.Location = new System.Drawing.Point(301, 434);
            this.LabBeventoscriticidad.Name = "LabBeventoscriticidad";
            this.LabBeventoscriticidad.Size = new System.Drawing.Size(76, 19);
            this.LabBeventoscriticidad.TabIndex = 22;
            this.LabBeventoscriticidad.Text = "Criticidad";
            // 
            // LabBeventosUsuario
            // 
            this.LabBeventosUsuario.AutoSize = true;
            this.LabBeventosUsuario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventosUsuario.Location = new System.Drawing.Point(24, 434);
            this.LabBeventosUsuario.Name = "LabBeventosUsuario";
            this.LabBeventosUsuario.Size = new System.Drawing.Size(63, 19);
            this.LabBeventosUsuario.TabIndex = 21;
            this.LabBeventosUsuario.Text = "Usuario";
            // 
            // LabBeventosfechaFinal
            // 
            this.LabBeventosfechaFinal.AutoSize = true;
            this.LabBeventosfechaFinal.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventosfechaFinal.Location = new System.Drawing.Point(301, 384);
            this.LabBeventosfechaFinal.Name = "LabBeventosfechaFinal";
            this.LabBeventosfechaFinal.Size = new System.Drawing.Size(87, 19);
            this.LabBeventosfechaFinal.TabIndex = 20;
            this.LabBeventosfechaFinal.Text = "Fecha Final";
            // 
            // LabBeventosfechaInicio
            // 
            this.LabBeventosfechaInicio.AutoSize = true;
            this.LabBeventosfechaInicio.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBeventosfechaInicio.Location = new System.Drawing.Point(24, 384);
            this.LabBeventosfechaInicio.Name = "LabBeventosfechaInicio";
            this.LabBeventosfechaInicio.Size = new System.Drawing.Size(93, 19);
            this.LabBeventosfechaInicio.TabIndex = 19;
            this.LabBeventosfechaInicio.Text = "Fecha Inicio";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(303, 497);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 32);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(202, 497);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 32);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnVolverbEventos
            // 
            this.btnVolverbEventos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverbEventos.Location = new System.Drawing.Point(404, 497);
            this.btnVolverbEventos.Name = "btnVolverbEventos";
            this.btnVolverbEventos.Size = new System.Drawing.Size(89, 32);
            this.btnVolverbEventos.TabIndex = 32;
            this.btnVolverbEventos.Text = "Volver";
            this.btnVolverbEventos.UseVisualStyleBackColor = true;
            this.btnVolverbEventos.Click += new System.EventHandler(this.btnVolverbEventos_Click);
            // 
            // btnFiltrarBEvento
            // 
            this.btnFiltrarBEvento.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarBEvento.Location = new System.Drawing.Point(101, 497);
            this.btnFiltrarBEvento.Name = "btnFiltrarBEvento";
            this.btnFiltrarBEvento.Size = new System.Drawing.Size(89, 32);
            this.btnFiltrarBEvento.TabIndex = 31;
            this.btnFiltrarBEvento.Text = "Filtrar";
            this.btnFiltrarBEvento.UseVisualStyleBackColor = true;
            this.btnFiltrarBEvento.Click += new System.EventHandler(this.btnFiltrarBEvento_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(545, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BitacoraEventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVolverbEventos);
            this.Controls.Add(this.btnFiltrarBEvento);
            this.Controls.Add(this.txtApellidoBE);
            this.Controls.Add(this.txtNombreBE);
            this.Controls.Add(this.labApellidoBE);
            this.Controls.Add(this.LabNombreBE);
            this.Controls.Add(this.cmbBitacoraEventosUsuarios);
            this.Controls.Add(this.numericCriticidad);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LabBeventoscriticidad);
            this.Controls.Add(this.LabBeventosUsuario);
            this.Controls.Add(this.LabBeventosfechaFinal);
            this.Controls.Add(this.LabBeventosfechaInicio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBitacoraEventos);
            this.Controls.Add(this.labBitacoraEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BitacoraEventosForm";
            this.Text = "BitacoraEventos";
            this.Load += new System.EventHandler(this.BitacoraEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCriticidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBitacoraEventos;
        private System.Windows.Forms.DataGridView dgvBitacoraEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextoBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriticidadBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioBitacoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuloBitacoraE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtApellidoBE;
        private System.Windows.Forms.TextBox txtNombreBE;
        private System.Windows.Forms.Label labApellidoBE;
        private System.Windows.Forms.Label LabNombreBE;
        private System.Windows.Forms.ComboBox cmbBitacoraEventosUsuarios;
        private System.Windows.Forms.NumericUpDown numericCriticidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabBeventoscriticidad;
        private System.Windows.Forms.Label LabBeventosUsuario;
        private System.Windows.Forms.Label LabBeventosfechaFinal;
        private System.Windows.Forms.Label LabBeventosfechaInicio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVolverbEventos;
        private System.Windows.Forms.Button btnFiltrarBEvento;
    }
}