namespace GUI
{
    partial class InsumosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsumosForm));
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.labInsumos = new System.Windows.Forms.Label();
            this.labProveedor = new System.Windows.Forms.Label();
            this.txtObservacioneInsumo = new System.Windows.Forms.TextBox();
            this.labCantidadActualInsumos = new System.Windows.Forms.Label();
            this.labNombreInsumos = new System.Windows.Forms.Label();
            this.txtProveedorInsumo = new System.Windows.Forms.TextBox();
            this.txtCantidadActualInsumo = new System.Windows.Forms.TextBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.btnBorrarInsumos = new System.Windows.Forms.Button();
            this.btnModificarInsumos = new System.Windows.Forms.Button();
            this.btnAgregarInsumos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rbFiltroEstado = new System.Windows.Forms.RadioButton();
            this.rbFiltroProveedor = new System.Windows.Forms.RadioButton();
            this.cmbFiltroEstadoInsumo = new System.Windows.Forms.ComboBox();
            this.cmbFiltroProveedorInsumo = new System.Windows.Forms.ComboBox();
            this.btnFiltrarInsumo = new System.Windows.Forms.Button();
            this.labNombre = new System.Windows.Forms.Label();
            this.txtFiltroNombreInsumo = new System.Windows.Forms.TextBox();
            this.EstadoInsumo = new System.Windows.Forms.Label();
            this.btnCambiarEstadoInsumo = new System.Windows.Forms.Button();
            this.LabObservInsumos = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtCantidadInsumo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IdInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantActualInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionesInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInsumos,
            this.NombreInsumos,
            this.CantidadInsumos,
            this.CantActualInsumos,
            this.ProveedorInsumos,
            this.EstadoInsumos,
            this.ObservacionesInsumos,
            this.Column1});
            this.dgvInsumos.Location = new System.Drawing.Point(12, 54);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.ReadOnly = true;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(928, 200);
            this.dgvInsumos.TabIndex = 6;
            this.dgvInsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellClick);
            // 
            // labInsumos
            // 
            this.labInsumos.AutoSize = true;
            this.labInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInsumos.Location = new System.Drawing.Point(15, 12);
            this.labInsumos.Name = "labInsumos";
            this.labInsumos.Size = new System.Drawing.Size(137, 19);
            this.labInsumos.TabIndex = 5;
            this.labInsumos.Text = "Estado de insumos";
            // 
            // labProveedor
            // 
            this.labProveedor.AutoSize = true;
            this.labProveedor.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProveedor.Location = new System.Drawing.Point(27, 389);
            this.labProveedor.Name = "labProveedor";
            this.labProveedor.Size = new System.Drawing.Size(84, 19);
            this.labProveedor.TabIndex = 32;
            this.labProveedor.Text = "Proveedor";
            // 
            // txtObservacioneInsumo
            // 
            this.txtObservacioneInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacioneInsumo.Location = new System.Drawing.Point(31, 485);
            this.txtObservacioneInsumo.Multiline = true;
            this.txtObservacioneInsumo.Name = "txtObservacioneInsumo";
            this.txtObservacioneInsumo.Size = new System.Drawing.Size(277, 113);
            this.txtObservacioneInsumo.TabIndex = 20;
            // 
            // labCantidadActualInsumos
            // 
            this.labCantidadActualInsumos.AutoSize = true;
            this.labCantidadActualInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidadActualInsumos.Location = new System.Drawing.Point(27, 349);
            this.labCantidadActualInsumos.Name = "labCantidadActualInsumos";
            this.labCantidadActualInsumos.Size = new System.Drawing.Size(121, 19);
            this.labCantidadActualInsumos.TabIndex = 31;
            this.labCantidadActualInsumos.Text = "Cantidad Actual";
            // 
            // labNombreInsumos
            // 
            this.labNombreInsumos.AutoSize = true;
            this.labNombreInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreInsumos.Location = new System.Drawing.Point(27, 269);
            this.labNombreInsumos.Name = "labNombreInsumos";
            this.labNombreInsumos.Size = new System.Drawing.Size(69, 19);
            this.labNombreInsumos.TabIndex = 30;
            this.labNombreInsumos.Text = "Nombre";
            // 
            // txtProveedorInsumo
            // 
            this.txtProveedorInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorInsumo.Location = new System.Drawing.Point(154, 385);
            this.txtProveedorInsumo.Name = "txtProveedorInsumo";
            this.txtProveedorInsumo.Size = new System.Drawing.Size(161, 27);
            this.txtProveedorInsumo.TabIndex = 29;
            // 
            // txtCantidadActualInsumo
            // 
            this.txtCantidadActualInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadActualInsumo.Location = new System.Drawing.Point(154, 345);
            this.txtCantidadActualInsumo.Name = "txtCantidadActualInsumo";
            this.txtCantidadActualInsumo.Size = new System.Drawing.Size(161, 27);
            this.txtCantidadActualInsumo.TabIndex = 28;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInsumo.Location = new System.Drawing.Point(154, 265);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(161, 27);
            this.txtNombreInsumo.TabIndex = 27;
            // 
            // btnBorrarInsumos
            // 
            this.btnBorrarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarInsumos.Location = new System.Drawing.Point(347, 311);
            this.btnBorrarInsumos.Name = "btnBorrarInsumos";
            this.btnBorrarInsumos.Size = new System.Drawing.Size(121, 36);
            this.btnBorrarInsumos.TabIndex = 26;
            this.btnBorrarInsumos.Text = "Borrar";
            this.btnBorrarInsumos.UseVisualStyleBackColor = true;
            this.btnBorrarInsumos.Click += new System.EventHandler(this.btnBorrarInsumos_Click);
            // 
            // btnModificarInsumos
            // 
            this.btnModificarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInsumos.Location = new System.Drawing.Point(347, 355);
            this.btnModificarInsumos.Name = "btnModificarInsumos";
            this.btnModificarInsumos.Size = new System.Drawing.Size(121, 36);
            this.btnModificarInsumos.TabIndex = 25;
            this.btnModificarInsumos.Text = "Modificar";
            this.btnModificarInsumos.UseVisualStyleBackColor = true;
            this.btnModificarInsumos.Click += new System.EventHandler(this.btnModificarInsumos_Click);
            // 
            // btnAgregarInsumos
            // 
            this.btnAgregarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumos.Location = new System.Drawing.Point(347, 267);
            this.btnAgregarInsumos.Name = "btnAgregarInsumos";
            this.btnAgregarInsumos.Size = new System.Drawing.Size(121, 36);
            this.btnAgregarInsumos.TabIndex = 24;
            this.btnAgregarInsumos.Text = "Agregar";
            this.btnAgregarInsumos.UseVisualStyleBackColor = true;
            this.btnAgregarInsumos.Click += new System.EventHandler(this.btnAgregarInsumos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.rbFiltroEstado);
            this.groupBox1.Controls.Add(this.rbFiltroProveedor);
            this.groupBox1.Controls.Add(this.cmbFiltroEstadoInsumo);
            this.groupBox1.Controls.Add(this.cmbFiltroProveedorInsumo);
            this.groupBox1.Controls.Add(this.btnFiltrarInsumo);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(555, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 151);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(130, 104);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 36);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rbFiltroEstado
            // 
            this.rbFiltroEstado.AutoSize = true;
            this.rbFiltroEstado.Location = new System.Drawing.Point(17, 67);
            this.rbFiltroEstado.Name = "rbFiltroEstado";
            this.rbFiltroEstado.Size = new System.Drawing.Size(72, 23);
            this.rbFiltroEstado.TabIndex = 14;
            this.rbFiltroEstado.TabStop = true;
            this.rbFiltroEstado.Text = "Estado";
            this.rbFiltroEstado.UseVisualStyleBackColor = true;
            this.rbFiltroEstado.CheckedChanged += new System.EventHandler(this.rbFiltroEstado_CheckedChanged);
            // 
            // rbFiltroProveedor
            // 
            this.rbFiltroProveedor.AutoSize = true;
            this.rbFiltroProveedor.Checked = true;
            this.rbFiltroProveedor.Location = new System.Drawing.Point(17, 27);
            this.rbFiltroProveedor.Name = "rbFiltroProveedor";
            this.rbFiltroProveedor.Size = new System.Drawing.Size(102, 23);
            this.rbFiltroProveedor.TabIndex = 13;
            this.rbFiltroProveedor.TabStop = true;
            this.rbFiltroProveedor.Text = "Proveedor";
            this.rbFiltroProveedor.UseVisualStyleBackColor = true;
            this.rbFiltroProveedor.CheckedChanged += new System.EventHandler(this.rbFiltroProveedor_CheckedChanged);
            // 
            // cmbFiltroEstadoInsumo
            // 
            this.cmbFiltroEstadoInsumo.FormattingEnabled = true;
            this.cmbFiltroEstadoInsumo.Items.AddRange(new object[] {
            "Verde",
            "Amarillo",
            "Rojo"});
            this.cmbFiltroEstadoInsumo.Location = new System.Drawing.Point(164, 65);
            this.cmbFiltroEstadoInsumo.Name = "cmbFiltroEstadoInsumo";
            this.cmbFiltroEstadoInsumo.Size = new System.Drawing.Size(180, 27);
            this.cmbFiltroEstadoInsumo.TabIndex = 11;
            // 
            // cmbFiltroProveedorInsumo
            // 
            this.cmbFiltroProveedorInsumo.FormattingEnabled = true;
            this.cmbFiltroProveedorInsumo.Location = new System.Drawing.Point(164, 25);
            this.cmbFiltroProveedorInsumo.Name = "cmbFiltroProveedorInsumo";
            this.cmbFiltroProveedorInsumo.Size = new System.Drawing.Size(180, 27);
            this.cmbFiltroProveedorInsumo.TabIndex = 10;
            // 
            // btnFiltrarInsumo
            // 
            this.btnFiltrarInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarInsumo.Location = new System.Drawing.Point(240, 104);
            this.btnFiltrarInsumo.Name = "btnFiltrarInsumo";
            this.btnFiltrarInsumo.Size = new System.Drawing.Size(104, 36);
            this.btnFiltrarInsumo.TabIndex = 12;
            this.btnFiltrarInsumo.Text = "Filtrar";
            this.btnFiltrarInsumo.UseVisualStyleBackColor = true;
            this.btnFiltrarInsumo.Click += new System.EventHandler(this.btnFiltrarInsumo_Click);
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(590, 31);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(147, 19);
            this.labNombre.TabIndex = 13;
            this.labNombre.Text = "Nombre de insumo";
            // 
            // txtFiltroNombreInsumo
            // 
            this.txtFiltroNombreInsumo.Location = new System.Drawing.Point(759, 28);
            this.txtFiltroNombreInsumo.Name = "txtFiltroNombreInsumo";
            this.txtFiltroNombreInsumo.Size = new System.Drawing.Size(181, 20);
            this.txtFiltroNombreInsumo.TabIndex = 14;
            this.txtFiltroNombreInsumo.TextChanged += new System.EventHandler(this.txtFiltroNombreInsumo_TextChanged);
            // 
            // EstadoInsumo
            // 
            this.EstadoInsumo.AutoSize = true;
            this.EstadoInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoInsumo.Location = new System.Drawing.Point(27, 429);
            this.EstadoInsumo.Name = "EstadoInsumo";
            this.EstadoInsumo.Size = new System.Drawing.Size(53, 19);
            this.EstadoInsumo.TabIndex = 35;
            this.EstadoInsumo.Text = "Precio";
            // 
            // btnCambiarEstadoInsumo
            // 
            this.btnCambiarEstadoInsumo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoInsumo.Location = new System.Drawing.Point(347, 399);
            this.btnCambiarEstadoInsumo.Name = "btnCambiarEstadoInsumo";
            this.btnCambiarEstadoInsumo.Size = new System.Drawing.Size(121, 45);
            this.btnCambiarEstadoInsumo.TabIndex = 36;
            this.btnCambiarEstadoInsumo.Text = "Cambiar estado";
            this.btnCambiarEstadoInsumo.UseVisualStyleBackColor = true;
            // 
            // LabObservInsumos
            // 
            this.LabObservInsumos.AutoSize = true;
            this.LabObservInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabObservInsumos.Location = new System.Drawing.Point(27, 460);
            this.LabObservInsumos.Name = "LabObservInsumos";
            this.LabObservInsumos.Size = new System.Drawing.Size(110, 19);
            this.LabObservInsumos.TabIndex = 37;
            this.LabObservInsumos.Text = "Observaciones";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(836, 562);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 36);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCantidadInsumo
            // 
            this.txtCantidadInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadInsumo.Location = new System.Drawing.Point(154, 305);
            this.txtCantidadInsumo.Name = "txtCantidadInsumo";
            this.txtCantidadInsumo.Size = new System.Drawing.Size(161, 27);
            this.txtCantidadInsumo.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 429);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // IdInsumos
            // 
            this.IdInsumos.FillWeight = 35.533F;
            this.IdInsumos.HeaderText = "ID";
            this.IdInsumos.Name = "IdInsumos";
            this.IdInsumos.ReadOnly = true;
            // 
            // NombreInsumos
            // 
            this.NombreInsumos.FillWeight = 110.7445F;
            this.NombreInsumos.HeaderText = "Nombre";
            this.NombreInsumos.Name = "NombreInsumos";
            this.NombreInsumos.ReadOnly = true;
            // 
            // CantidadInsumos
            // 
            this.CantidadInsumos.FillWeight = 110.7445F;
            this.CantidadInsumos.HeaderText = "Cantidad";
            this.CantidadInsumos.Name = "CantidadInsumos";
            this.CantidadInsumos.ReadOnly = true;
            // 
            // CantActualInsumos
            // 
            this.CantActualInsumos.HeaderText = "Cantidad actual";
            this.CantActualInsumos.Name = "CantActualInsumos";
            this.CantActualInsumos.ReadOnly = true;
            // 
            // ProveedorInsumos
            // 
            this.ProveedorInsumos.FillWeight = 110.7445F;
            this.ProveedorInsumos.HeaderText = "Proveedor";
            this.ProveedorInsumos.Name = "ProveedorInsumos";
            this.ProveedorInsumos.ReadOnly = true;
            // 
            // EstadoInsumos
            // 
            this.EstadoInsumos.FillWeight = 110.7445F;
            this.EstadoInsumos.HeaderText = "Estado";
            this.EstadoInsumos.Name = "EstadoInsumos";
            this.EstadoInsumos.ReadOnly = true;
            // 
            // ObservacionesInsumos
            // 
            this.ObservacionesInsumos.FillWeight = 110.7445F;
            this.ObservacionesInsumos.HeaderText = "Observaciones";
            this.ObservacionesInsumos.Name = "ObservacionesInsumos";
            this.ObservacionesInsumos.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(154, 425);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(161, 27);
            this.txtPrecio.TabIndex = 41;
            // 
            // InsumosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(952, 606);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadInsumo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.LabObservInsumos);
            this.Controls.Add(this.btnCambiarEstadoInsumo);
            this.Controls.Add(this.EstadoInsumo);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.txtObservacioneInsumo);
            this.Controls.Add(this.txtFiltroNombreInsumo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labProveedor);
            this.Controls.Add(this.labCantidadActualInsumos);
            this.Controls.Add(this.labNombreInsumos);
            this.Controls.Add(this.txtProveedorInsumo);
            this.Controls.Add(this.txtCantidadActualInsumo);
            this.Controls.Add(this.txtNombreInsumo);
            this.Controls.Add(this.btnBorrarInsumos);
            this.Controls.Add(this.btnModificarInsumos);
            this.Controls.Add(this.btnAgregarInsumos);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.labInsumos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsumosForm";
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.InsumosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Label labInsumos;
        private System.Windows.Forms.Label labProveedor;
        private System.Windows.Forms.TextBox txtObservacioneInsumo;
        private System.Windows.Forms.Label labCantidadActualInsumos;
        private System.Windows.Forms.Label labNombreInsumos;
        private System.Windows.Forms.TextBox txtProveedorInsumo;
        private System.Windows.Forms.TextBox txtCantidadActualInsumo;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Button btnBorrarInsumos;
        private System.Windows.Forms.Button btnModificarInsumos;
        private System.Windows.Forms.Button btnAgregarInsumos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFiltroEstadoInsumo;
        private System.Windows.Forms.ComboBox cmbFiltroProveedorInsumo;
        private System.Windows.Forms.Button btnFiltrarInsumo;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox txtFiltroNombreInsumo;
        private System.Windows.Forms.Label EstadoInsumo;
        private System.Windows.Forms.Button btnCambiarEstadoInsumo;
        private System.Windows.Forms.Label LabObservInsumos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtCantidadInsumo;
        private System.Windows.Forms.RadioButton rbFiltroEstado;
        private System.Windows.Forms.RadioButton rbFiltroProveedor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantActualInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionesInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}