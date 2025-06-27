namespace GUI
{
    partial class GReservasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GReservasForm));
            this.labDni = new System.Windows.Forms.Label();
            this.labCancha = new System.Windows.Forms.Label();
            this.labHorario = new System.Windows.Forms.Label();
            this.cmbCancha = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnDisponibilidad = new System.Windows.Forms.Button();
            this.labFecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.ColumnaIdR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCanchaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaClienteR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaHorarioR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnSalirR = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labRojo = new System.Windows.Forms.Label();
            this.labVerde = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labAmarillo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labDni
            // 
            this.labDni.AutoSize = true;
            this.labDni.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDni.Location = new System.Drawing.Point(345, 282);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(58, 19);
            this.labDni.TabIndex = 0;
            this.labDni.Text = "Cliente";
            // 
            // labCancha
            // 
            this.labCancha.AutoSize = true;
            this.labCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCancha.Location = new System.Drawing.Point(22, 36);
            this.labCancha.Name = "labCancha";
            this.labCancha.Size = new System.Drawing.Size(61, 19);
            this.labCancha.TabIndex = 2;
            this.labCancha.Text = "Cancha";
            // 
            // labHorario
            // 
            this.labHorario.AutoSize = true;
            this.labHorario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHorario.Location = new System.Drawing.Point(22, 116);
            this.labHorario.Name = "labHorario";
            this.labHorario.Size = new System.Drawing.Size(66, 19);
            this.labHorario.TabIndex = 3;
            this.labHorario.Text = "Horario";
            // 
            // cmbCancha
            // 
            this.cmbCancha.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCancha.FormattingEnabled = true;
            this.cmbCancha.Location = new System.Drawing.Point(119, 32);
            this.cmbCancha.Name = "cmbCancha";
            this.cmbCancha.Size = new System.Drawing.Size(175, 26);
            this.cmbCancha.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 25);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(1046, 95);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(96, 33);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibilidad.Location = new System.Drawing.Point(26, 344);
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.Size = new System.Drawing.Size(148, 37);
            this.btnDisponibilidad.TabIndex = 13;
            this.btnDisponibilidad.Text = "Ver disponibilidad";
            this.btnDisponibilidad.UseVisualStyleBackColor = true;
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(22, 78);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(49, 19);
            this.labFecha.TabIndex = 15;
            this.labFecha.Text = "Fecha";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(598, 434);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 31);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar Cliente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaIdR,
            this.ColumnaCanchaR,
            this.ColumnaClienteR,
            this.ColumnaFechaR,
            this.ColumnaHorarioR,
            this.Column2});
            this.dgvReservas.Location = new System.Drawing.Point(352, 36);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(647, 229);
            this.dgvReservas.TabIndex = 17;
            // 
            // ColumnaIdR
            // 
            this.ColumnaIdR.FillWeight = 60.9137F;
            this.ColumnaIdR.HeaderText = "Id";
            this.ColumnaIdR.Name = "ColumnaIdR";
            this.ColumnaIdR.ReadOnly = true;
            // 
            // ColumnaCanchaR
            // 
            this.ColumnaCanchaR.FillWeight = 107.8173F;
            this.ColumnaCanchaR.HeaderText = "Cancha";
            this.ColumnaCanchaR.Name = "ColumnaCanchaR";
            this.ColumnaCanchaR.ReadOnly = true;
            // 
            // ColumnaClienteR
            // 
            this.ColumnaClienteR.FillWeight = 107.8173F;
            this.ColumnaClienteR.HeaderText = "Cliente";
            this.ColumnaClienteR.Name = "ColumnaClienteR";
            this.ColumnaClienteR.ReadOnly = true;
            // 
            // ColumnaFechaR
            // 
            this.ColumnaFechaR.FillWeight = 107.8173F;
            this.ColumnaFechaR.HeaderText = "Fecha";
            this.ColumnaFechaR.Name = "ColumnaFechaR";
            this.ColumnaFechaR.ReadOnly = true;
            // 
            // ColumnaHorarioR
            // 
            this.ColumnaHorarioR.FillWeight = 107.8173F;
            this.ColumnaHorarioR.HeaderText = "Horario";
            this.ColumnaHorarioR.Name = "ColumnaHorarioR";
            this.ColumnaHorarioR.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 107.8173F;
            this.Column2.HeaderText = "Pagado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(1046, 130);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(96, 33);
            this.btnCobrar.TabIndex = 23;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click_1);
            // 
            // btnSalirR
            // 
            this.btnSalirR.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirR.Location = new System.Drawing.Point(1005, 200);
            this.btnSalirR.Name = "btnSalirR";
            this.btnSalirR.Size = new System.Drawing.Size(137, 33);
            this.btnSalirR.TabIndex = 25;
            this.btnSalirR.Text = "Salir";
            this.btnSalirR.UseVisualStyleBackColor = true;
            this.btnSalirR.Click += new System.EventHandler(this.btnSalirR_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(1005, 165);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(137, 33);
            this.btnCancelarReserva.TabIndex = 26;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(26, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(294, 182);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora entrada";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora salida";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Reservas ";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(442, 278);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(128, 26);
            this.cmbClientes.TabIndex = 31;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // txtInformacion
            // 
            this.txtInformacion.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacion.Location = new System.Drawing.Point(352, 341);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(227, 131);
            this.txtInformacion.TabIndex = 32;
            this.txtInformacion.Text = "Seleccione un cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Información del cliente";
            // 
            // labRojo
            // 
            this.labRojo.AutoSize = true;
            this.labRojo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRojo.Location = new System.Drawing.Point(674, 336);
            this.labRojo.Name = "labRojo";
            this.labRojo.Size = new System.Drawing.Size(86, 18);
            this.labRojo.TabIndex = 34;
            this.labRojo.Text = "Rojo: Debe ";
            // 
            // labVerde
            // 
            this.labVerde.AutoSize = true;
            this.labVerde.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVerde.Location = new System.Drawing.Point(674, 293);
            this.labVerde.Name = "labVerde";
            this.labVerde.Size = new System.Drawing.Size(103, 18);
            this.labVerde.TabIndex = 35;
            this.labVerde.Text = "Verde: Pagado";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.rojo;
            this.pictureBox3.Location = new System.Drawing.Point(634, 336);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 18);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.verde;
            this.pictureBox1.Location = new System.Drawing.Point(634, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 18);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(899, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.amarillo;
            this.pictureBox4.Location = new System.Drawing.Point(634, 377);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 18);
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // labAmarillo
            // 
            this.labAmarillo.AutoSize = true;
            this.labAmarillo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAmarillo.Location = new System.Drawing.Point(674, 377);
            this.labAmarillo.Name = "labAmarillo";
            this.labAmarillo.Size = new System.Drawing.Size(182, 18);
            this.labAmarillo.TabIndex = 41;
            this.labAmarillo.Text = "Amarillo: reserva cancelada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 43;
            this.button1.Text = "Ver reservas hechas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1154, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labAmarillo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labVerde);
            this.Controls.Add(this.labRojo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnSalirR);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.btnDisponibilidad);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbCancha);
            this.Controls.Add(this.labHorario);
            this.Controls.Add(this.labCancha);
            this.Controls.Add(this.labDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GReservasForm";
            this.Text = "Reservas ";
            this.Load += new System.EventHandler(this.GReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDni;
        private System.Windows.Forms.Label labCancha;
        private System.Windows.Forms.Label labHorario;
        private System.Windows.Forms.ComboBox cmbCancha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnDisponibilidad;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnSalirR;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaIdR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCanchaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClienteR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaHorarioR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label labRojo;
        private System.Windows.Forms.Label labVerde;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labAmarillo;
        private System.Windows.Forms.Button button1;
    }
}