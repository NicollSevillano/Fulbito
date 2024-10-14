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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.labFecha = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbCancha = new System.Windows.Forms.ComboBox();
            this.labHorario = new System.Windows.Forms.Label();
            this.labCancha = new System.Windows.Forms.Label();
            this.labDni = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.ColumnaIdR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCanchaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaClienteR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaHorarioR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnSalirR = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnDisponibilidad = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(119, 70);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(128, 20);
            this.txtDni.TabIndex = 30;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(119, 152);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(128, 20);
            this.txtHorario.TabIndex = 29;
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(22, 109);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(49, 19);
            this.labFecha.TabIndex = 28;
            this.labFecha.Text = "Fecha";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(259, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // cmbCancha
            // 
            this.cmbCancha.FormattingEnabled = true;
            this.cmbCancha.Location = new System.Drawing.Point(119, 28);
            this.cmbCancha.Name = "cmbCancha";
            this.cmbCancha.Size = new System.Drawing.Size(128, 21);
            this.cmbCancha.TabIndex = 25;
            // 
            // labHorario
            // 
            this.labHorario.AutoSize = true;
            this.labHorario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHorario.Location = new System.Drawing.Point(22, 150);
            this.labHorario.Name = "labHorario";
            this.labHorario.Size = new System.Drawing.Size(66, 19);
            this.labHorario.TabIndex = 24;
            this.labHorario.Text = "Horario";
            // 
            // labCancha
            // 
            this.labCancha.AutoSize = true;
            this.labCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCancha.Location = new System.Drawing.Point(22, 27);
            this.labCancha.Name = "labCancha";
            this.labCancha.Size = new System.Drawing.Size(61, 19);
            this.labCancha.TabIndex = 23;
            this.labCancha.Text = "Cancha";
            // 
            // labDni
            // 
            this.labDni.AutoSize = true;
            this.labDni.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDni.Location = new System.Drawing.Point(22, 68);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(39, 19);
            this.labDni.TabIndex = 22;
            this.labDni.Text = "DNI";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ColumnaHorarioR});
            this.dgvReservas.Location = new System.Drawing.Point(12, 203);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(536, 297);
            this.dgvReservas.TabIndex = 31;
            // 
            // ColumnaIdR
            // 
            this.ColumnaIdR.FillWeight = 32.99492F;
            this.ColumnaIdR.HeaderText = "Id";
            this.ColumnaIdR.Name = "ColumnaIdR";
            this.ColumnaIdR.ReadOnly = true;
            // 
            // ColumnaCanchaR
            // 
            this.ColumnaCanchaR.FillWeight = 116.7513F;
            this.ColumnaCanchaR.HeaderText = "Cancha";
            this.ColumnaCanchaR.Name = "ColumnaCanchaR";
            this.ColumnaCanchaR.ReadOnly = true;
            // 
            // ColumnaClienteR
            // 
            this.ColumnaClienteR.FillWeight = 116.7513F;
            this.ColumnaClienteR.HeaderText = "Cliente";
            this.ColumnaClienteR.Name = "ColumnaClienteR";
            this.ColumnaClienteR.ReadOnly = true;
            // 
            // ColumnaFechaR
            // 
            this.ColumnaFechaR.FillWeight = 116.7513F;
            this.ColumnaFechaR.HeaderText = "Fecha";
            this.ColumnaFechaR.Name = "ColumnaFechaR";
            this.ColumnaFechaR.ReadOnly = true;
            // 
            // ColumnaHorarioR
            // 
            this.ColumnaHorarioR.FillWeight = 116.7513F;
            this.ColumnaHorarioR.HeaderText = "Horario";
            this.ColumnaHorarioR.Name = "ColumnaHorarioR";
            this.ColumnaHorarioR.ReadOnly = true;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(571, 408);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(148, 42);
            this.btnCancelarReserva.TabIndex = 37;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnSalirR
            // 
            this.btnSalirR.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirR.Location = new System.Drawing.Point(612, 458);
            this.btnSalirR.Name = "btnSalirR";
            this.btnSalirR.Size = new System.Drawing.Size(107, 42);
            this.btnSalirR.TabIndex = 36;
            this.btnSalirR.Text = "Salir";
            this.btnSalirR.UseVisualStyleBackColor = true;
            this.btnSalirR.Click += new System.EventHandler(this.btnSalirR_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(612, 358);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(107, 42);
            this.btnCobrar.TabIndex = 35;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(571, 258);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(148, 42);
            this.btnRegistrar.TabIndex = 34;
            this.btnRegistrar.Text = "Registrar Cliente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibilidad.Location = new System.Drawing.Point(571, 208);
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.Size = new System.Drawing.Size(148, 42);
            this.btnDisponibilidad.TabIndex = 33;
            this.btnDisponibilidad.Text = "Ver disponibilidad";
            this.btnDisponibilidad.UseVisualStyleBackColor = true;
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(612, 308);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(107, 42);
            this.btnReservar.TabIndex = 32;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(519, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // GReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(728, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnSalirR);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnDisponibilidad);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbCancha);
            this.Controls.Add(this.labHorario);
            this.Controls.Add(this.labCancha);
            this.Controls.Add(this.labDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GReservasForm";
            this.Text = "GReservas";
            this.Load += new System.EventHandler(this.GReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbCancha;
        private System.Windows.Forms.Label labHorario;
        private System.Windows.Forms.Label labCancha;
        private System.Windows.Forms.Label labDni;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaIdR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCanchaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClienteR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaHorarioR;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnSalirR;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnDisponibilidad;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}