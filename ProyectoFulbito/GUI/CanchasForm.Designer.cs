namespace GUI
{
    partial class CanchasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanchasForm));
            this.dgvCanchas = new System.Windows.Forms.DataGridView();
            this.IdCanchas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionesCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labObservacionesCanchas = new System.Windows.Forms.Label();
            this.txtObservacionesCancha = new System.Windows.Forms.TextBox();
            this.btnFiltrarEstado = new System.Windows.Forms.Button();
            this.btnEstadoCancha = new System.Windows.Forms.Button();
            this.cmbEstadoCancha = new System.Windows.Forms.ComboBox();
            this.labEstadoCancha = new System.Windows.Forms.Label();
            this.txtCapacidadCancha = new System.Windows.Forms.TextBox();
            this.labCapacidadCancha = new System.Windows.Forms.Label();
            this.txtNombreCancha = new System.Windows.Forms.TextBox();
            this.labNombreCancha = new System.Windows.Forms.Label();
            this.txtPrecioCancha = new System.Windows.Forms.TextBox();
            this.labPrecioCancha = new System.Windows.Forms.Label();
            this.labDatosCanchas = new System.Windows.Forms.Label();
            this.btnModificarCancha = new System.Windows.Forms.Button();
            this.btnBajaCancha = new System.Windows.Forms.Button();
            this.btnAltaCancha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolverCanchas = new System.Windows.Forms.Button();
            this.Filtrogbox = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCancha = new System.Windows.Forms.Button();
            this.cmbFiltroEstadoCancha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanchas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Filtrogbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCanchas
            // 
            this.dgvCanchas.AllowUserToAddRows = false;
            this.dgvCanchas.AllowUserToDeleteRows = false;
            this.dgvCanchas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanchas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCanchas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanchas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCanchas,
            this.NombreCancha,
            this.PrecioCancha,
            this.CapacidadCancha,
            this.EstadoCancha,
            this.ObservacionesCancha});
            this.dgvCanchas.Location = new System.Drawing.Point(12, 23);
            this.dgvCanchas.Name = "dgvCanchas";
            this.dgvCanchas.ReadOnly = true;
            this.dgvCanchas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanchas.Size = new System.Drawing.Size(776, 288);
            this.dgvCanchas.TabIndex = 13;
            this.dgvCanchas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanchas_CellClick);
            // 
            // IdCanchas
            // 
            this.IdCanchas.FillWeight = 35.53299F;
            this.IdCanchas.HeaderText = "ID";
            this.IdCanchas.Name = "IdCanchas";
            this.IdCanchas.ReadOnly = true;
            // 
            // NombreCancha
            // 
            this.NombreCancha.FillWeight = 110.7445F;
            this.NombreCancha.HeaderText = "Nombre";
            this.NombreCancha.Name = "NombreCancha";
            this.NombreCancha.ReadOnly = true;
            // 
            // PrecioCancha
            // 
            this.PrecioCancha.FillWeight = 110.7445F;
            this.PrecioCancha.HeaderText = "Precio";
            this.PrecioCancha.Name = "PrecioCancha";
            this.PrecioCancha.ReadOnly = true;
            // 
            // CapacidadCancha
            // 
            this.CapacidadCancha.FillWeight = 110.7445F;
            this.CapacidadCancha.HeaderText = "Capacidad";
            this.CapacidadCancha.Name = "CapacidadCancha";
            this.CapacidadCancha.ReadOnly = true;
            // 
            // EstadoCancha
            // 
            this.EstadoCancha.FillWeight = 110.7445F;
            this.EstadoCancha.HeaderText = "Estado";
            this.EstadoCancha.Name = "EstadoCancha";
            this.EstadoCancha.ReadOnly = true;
            // 
            // ObservacionesCancha
            // 
            this.ObservacionesCancha.FillWeight = 110.7445F;
            this.ObservacionesCancha.HeaderText = "Observaciones";
            this.ObservacionesCancha.Name = "ObservacionesCancha";
            this.ObservacionesCancha.ReadOnly = true;
            // 
            // labObservacionesCanchas
            // 
            this.labObservacionesCanchas.AutoSize = true;
            this.labObservacionesCanchas.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labObservacionesCanchas.Location = new System.Drawing.Point(34, 551);
            this.labObservacionesCanchas.Name = "labObservacionesCanchas";
            this.labObservacionesCanchas.Size = new System.Drawing.Size(115, 19);
            this.labObservacionesCanchas.TabIndex = 25;
            this.labObservacionesCanchas.Text = "Observaciones:";
            // 
            // txtObservacionesCancha
            // 
            this.txtObservacionesCancha.Location = new System.Drawing.Point(31, 573);
            this.txtObservacionesCancha.Multiline = true;
            this.txtObservacionesCancha.Name = "txtObservacionesCancha";
            this.txtObservacionesCancha.Size = new System.Drawing.Size(287, 107);
            this.txtObservacionesCancha.TabIndex = 24;
            // 
            // btnFiltrarEstado
            // 
            this.btnFiltrarEstado.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarEstado.Location = new System.Drawing.Point(190, 80);
            this.btnFiltrarEstado.Name = "btnFiltrarEstado";
            this.btnFiltrarEstado.Size = new System.Drawing.Size(107, 37);
            this.btnFiltrarEstado.TabIndex = 23;
            this.btnFiltrarEstado.Text = "Filtrar";
            this.btnFiltrarEstado.UseVisualStyleBackColor = true;
            this.btnFiltrarEstado.Click += new System.EventHandler(this.btnFiltrarEstado_Click);
            // 
            // btnEstadoCancha
            // 
            this.btnEstadoCancha.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoCancha.Location = new System.Drawing.Point(324, 492);
            this.btnEstadoCancha.Name = "btnEstadoCancha";
            this.btnEstadoCancha.Size = new System.Drawing.Size(107, 46);
            this.btnEstadoCancha.TabIndex = 22;
            this.btnEstadoCancha.Text = "Cambiar estado";
            this.btnEstadoCancha.UseVisualStyleBackColor = true;
            this.btnEstadoCancha.Click += new System.EventHandler(this.btnEstadoCancha_Click);
            // 
            // cmbEstadoCancha
            // 
            this.cmbEstadoCancha.FormattingEnabled = true;
            this.cmbEstadoCancha.Location = new System.Drawing.Point(143, 506);
            this.cmbEstadoCancha.Name = "cmbEstadoCancha";
            this.cmbEstadoCancha.Size = new System.Drawing.Size(127, 21);
            this.cmbEstadoCancha.TabIndex = 19;
            // 
            // labEstadoCancha
            // 
            this.labEstadoCancha.AutoSize = true;
            this.labEstadoCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEstadoCancha.Location = new System.Drawing.Point(34, 505);
            this.labEstadoCancha.Name = "labEstadoCancha";
            this.labEstadoCancha.Size = new System.Drawing.Size(54, 19);
            this.labEstadoCancha.TabIndex = 18;
            this.labEstadoCancha.Text = "Estado";
            // 
            // txtCapacidadCancha
            // 
            this.txtCapacidadCancha.Location = new System.Drawing.Point(143, 466);
            this.txtCapacidadCancha.Name = "txtCapacidadCancha";
            this.txtCapacidadCancha.Size = new System.Drawing.Size(127, 20);
            this.txtCapacidadCancha.TabIndex = 30;
            // 
            // labCapacidadCancha
            // 
            this.labCapacidadCancha.AutoSize = true;
            this.labCapacidadCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCapacidadCancha.Location = new System.Drawing.Point(34, 465);
            this.labCapacidadCancha.Name = "labCapacidadCancha";
            this.labCapacidadCancha.Size = new System.Drawing.Size(82, 19);
            this.labCapacidadCancha.TabIndex = 29;
            this.labCapacidadCancha.Text = "Capacidad";
            // 
            // txtNombreCancha
            // 
            this.txtNombreCancha.Location = new System.Drawing.Point(143, 384);
            this.txtNombreCancha.Name = "txtNombreCancha";
            this.txtNombreCancha.Size = new System.Drawing.Size(127, 20);
            this.txtNombreCancha.TabIndex = 28;
            // 
            // labNombreCancha
            // 
            this.labNombreCancha.AutoSize = true;
            this.labNombreCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreCancha.Location = new System.Drawing.Point(34, 383);
            this.labNombreCancha.Name = "labNombreCancha";
            this.labNombreCancha.Size = new System.Drawing.Size(69, 19);
            this.labNombreCancha.TabIndex = 27;
            this.labNombreCancha.Text = "Nombre";
            // 
            // txtPrecioCancha
            // 
            this.txtPrecioCancha.Location = new System.Drawing.Point(143, 420);
            this.txtPrecioCancha.Name = "txtPrecioCancha";
            this.txtPrecioCancha.Size = new System.Drawing.Size(127, 20);
            this.txtPrecioCancha.TabIndex = 25;
            // 
            // labPrecioCancha
            // 
            this.labPrecioCancha.AutoSize = true;
            this.labPrecioCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrecioCancha.Location = new System.Drawing.Point(34, 419);
            this.labPrecioCancha.Name = "labPrecioCancha";
            this.labPrecioCancha.Size = new System.Drawing.Size(53, 19);
            this.labPrecioCancha.TabIndex = 23;
            this.labPrecioCancha.Text = "Precio";
            // 
            // labDatosCanchas
            // 
            this.labDatosCanchas.AutoSize = true;
            this.labDatosCanchas.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDatosCanchas.Location = new System.Drawing.Point(27, 332);
            this.labDatosCanchas.Name = "labDatosCanchas";
            this.labDatosCanchas.Size = new System.Drawing.Size(164, 22);
            this.labDatosCanchas.TabIndex = 21;
            this.labDatosCanchas.Text = "Datos de la cancha";
            // 
            // btnModificarCancha
            // 
            this.btnModificarCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCancha.Location = new System.Drawing.Point(324, 442);
            this.btnModificarCancha.Name = "btnModificarCancha";
            this.btnModificarCancha.Size = new System.Drawing.Size(107, 37);
            this.btnModificarCancha.TabIndex = 20;
            this.btnModificarCancha.Text = "Modificar";
            this.btnModificarCancha.UseVisualStyleBackColor = true;
            this.btnModificarCancha.Click += new System.EventHandler(this.btnModificarCancha_Click);
            // 
            // btnBajaCancha
            // 
            this.btnBajaCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaCancha.Location = new System.Drawing.Point(324, 399);
            this.btnBajaCancha.Name = "btnBajaCancha";
            this.btnBajaCancha.Size = new System.Drawing.Size(107, 37);
            this.btnBajaCancha.TabIndex = 19;
            this.btnBajaCancha.Text = "Baja";
            this.btnBajaCancha.UseVisualStyleBackColor = true;
            this.btnBajaCancha.Click += new System.EventHandler(this.btnBajaCancha_Click);
            // 
            // btnAltaCancha
            // 
            this.btnAltaCancha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCancha.Location = new System.Drawing.Point(324, 356);
            this.btnAltaCancha.Name = "btnAltaCancha";
            this.btnAltaCancha.Size = new System.Drawing.Size(107, 37);
            this.btnAltaCancha.TabIndex = 18;
            this.btnAltaCancha.Text = "Alta";
            this.btnAltaCancha.UseVisualStyleBackColor = true;
            this.btnAltaCancha.Click += new System.EventHandler(this.btnAltaCancha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(344, 551);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolverCanchas
            // 
            this.btnVolverCanchas.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCanchas.Location = new System.Drawing.Point(692, 643);
            this.btnVolverCanchas.Name = "btnVolverCanchas";
            this.btnVolverCanchas.Size = new System.Drawing.Size(107, 37);
            this.btnVolverCanchas.TabIndex = 32;
            this.btnVolverCanchas.Text = "Volver";
            this.btnVolverCanchas.UseVisualStyleBackColor = true;
            this.btnVolverCanchas.Click += new System.EventHandler(this.btnVolverCanchas_Click);
            // 
            // Filtrogbox
            // 
            this.Filtrogbox.Controls.Add(this.btnLimpiarCancha);
            this.Filtrogbox.Controls.Add(this.cmbFiltroEstadoCancha);
            this.Filtrogbox.Controls.Add(this.label1);
            this.Filtrogbox.Controls.Add(this.btnFiltrarEstado);
            this.Filtrogbox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrogbox.Location = new System.Drawing.Point(476, 356);
            this.Filtrogbox.Name = "Filtrogbox";
            this.Filtrogbox.Size = new System.Drawing.Size(303, 123);
            this.Filtrogbox.TabIndex = 33;
            this.Filtrogbox.TabStop = false;
            this.Filtrogbox.Text = "Filtrar";
            // 
            // btnLimpiarCancha
            // 
            this.btnLimpiarCancha.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCancha.Location = new System.Drawing.Point(77, 80);
            this.btnLimpiarCancha.Name = "btnLimpiarCancha";
            this.btnLimpiarCancha.Size = new System.Drawing.Size(107, 37);
            this.btnLimpiarCancha.TabIndex = 26;
            this.btnLimpiarCancha.Text = "Limpiar";
            this.btnLimpiarCancha.UseVisualStyleBackColor = true;
            this.btnLimpiarCancha.Click += new System.EventHandler(this.btnLimpiarCancha_Click);
            // 
            // cmbFiltroEstadoCancha
            // 
            this.cmbFiltroEstadoCancha.FormattingEnabled = true;
            this.cmbFiltroEstadoCancha.Items.AddRange(new object[] {
            "Disponible",
            "En mantenimiento",
            "No disponible"});
            this.cmbFiltroEstadoCancha.Location = new System.Drawing.Point(110, 34);
            this.cmbFiltroEstadoCancha.Name = "cmbFiltroEstadoCancha";
            this.cmbFiltroEstadoCancha.Size = new System.Drawing.Size(187, 27);
            this.cmbFiltroEstadoCancha.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Estado";
            // 
            // CanchasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(811, 697);
            this.Controls.Add(this.Filtrogbox);
            this.Controls.Add(this.labObservacionesCanchas);
            this.Controls.Add(this.btnVolverCanchas);
            this.Controls.Add(this.txtObservacionesCancha);
            this.Controls.Add(this.txtCapacidadCancha);
            this.Controls.Add(this.labCapacidadCancha);
            this.Controls.Add(this.btnEstadoCancha);
            this.Controls.Add(this.cmbEstadoCancha);
            this.Controls.Add(this.txtNombreCancha);
            this.Controls.Add(this.labEstadoCancha);
            this.Controls.Add(this.labNombreCancha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrecioCancha);
            this.Controls.Add(this.labPrecioCancha);
            this.Controls.Add(this.labDatosCanchas);
            this.Controls.Add(this.btnModificarCancha);
            this.Controls.Add(this.btnBajaCancha);
            this.Controls.Add(this.btnAltaCancha);
            this.Controls.Add(this.dgvCanchas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CanchasForm";
            this.Text = "CanchasForm";
            this.Load += new System.EventHandler(this.CanchasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanchas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Filtrogbox.ResumeLayout(false);
            this.Filtrogbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCanchas;
        private System.Windows.Forms.Label labObservacionesCanchas;
        private System.Windows.Forms.TextBox txtObservacionesCancha;
        private System.Windows.Forms.Button btnFiltrarEstado;
        private System.Windows.Forms.Button btnEstadoCancha;
        private System.Windows.Forms.ComboBox cmbEstadoCancha;
        private System.Windows.Forms.Label labEstadoCancha;
        private System.Windows.Forms.TextBox txtCapacidadCancha;
        private System.Windows.Forms.Label labCapacidadCancha;
        private System.Windows.Forms.TextBox txtNombreCancha;
        private System.Windows.Forms.Label labNombreCancha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrecioCancha;
        private System.Windows.Forms.Label labPrecioCancha;
        private System.Windows.Forms.Label labDatosCanchas;
        private System.Windows.Forms.Button btnModificarCancha;
        private System.Windows.Forms.Button btnBajaCancha;
        private System.Windows.Forms.Button btnAltaCancha;
        private System.Windows.Forms.Button btnVolverCanchas;
        private System.Windows.Forms.GroupBox Filtrogbox;
        private System.Windows.Forms.ComboBox cmbFiltroEstadoCancha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCanchas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionesCancha;
        private System.Windows.Forms.Button btnLimpiarCancha;
    }
}