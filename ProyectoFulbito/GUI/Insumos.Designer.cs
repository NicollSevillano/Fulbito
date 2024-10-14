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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantActualInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionesInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labInsumos = new System.Windows.Forms.Label();
            this.labProveedor = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labCantidadInsumos = new System.Windows.Forms.Label();
            this.labNombreInsumos = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBorrarInsumos = new System.Windows.Forms.Button();
            this.btnModificarInsumos = new System.Windows.Forms.Button();
            this.btnAgregarInsumos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.btnFiltrarInsumo = new System.Windows.Forms.Button();
            this.labNombre = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.EstadoInsumo = new System.Windows.Forms.Label();
            this.btnCambiarEstadoInsumo = new System.Windows.Forms.Button();
            this.LabObservInsumos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInsumos,
            this.fechaHoraInsumos,
            this.NombreInsumos,
            this.CantidadInsumos,
            this.CantActualInsumos,
            this.ProveedorInsumos,
            this.EstadoInsumos,
            this.ObservacionesInsumos});
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(928, 231);
            this.dataGridView1.TabIndex = 6;
            // 
            // IdInsumos
            // 
            this.IdInsumos.FillWeight = 35.533F;
            this.IdInsumos.HeaderText = "ID";
            this.IdInsumos.Name = "IdInsumos";
            this.IdInsumos.ReadOnly = true;
            // 
            // fechaHoraInsumos
            // 
            this.fechaHoraInsumos.FillWeight = 110.7445F;
            this.fechaHoraInsumos.HeaderText = "Fecha-Hora";
            this.fechaHoraInsumos.Name = "fechaHoraInsumos";
            this.fechaHoraInsumos.ReadOnly = true;
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
            this.labProveedor.Location = new System.Drawing.Point(29, 381);
            this.labProveedor.Name = "labProveedor";
            this.labProveedor.Size = new System.Drawing.Size(84, 19);
            this.labProveedor.TabIndex = 32;
            this.labProveedor.Text = "Proveedor";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 486);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(277, 113);
            this.textBox5.TabIndex = 20;
            // 
            // labCantidadInsumos
            // 
            this.labCantidadInsumos.AutoSize = true;
            this.labCantidadInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidadInsumos.Location = new System.Drawing.Point(29, 339);
            this.labCantidadInsumos.Name = "labCantidadInsumos";
            this.labCantidadInsumos.Size = new System.Drawing.Size(72, 19);
            this.labCantidadInsumos.TabIndex = 31;
            this.labCantidadInsumos.Text = "Cantidad";
            // 
            // labNombreInsumos
            // 
            this.labNombreInsumos.AutoSize = true;
            this.labNombreInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreInsumos.Location = new System.Drawing.Point(29, 297);
            this.labNombreInsumos.Name = "labNombreInsumos";
            this.labNombreInsumos.Size = new System.Drawing.Size(69, 19);
            this.labNombreInsumos.TabIndex = 30;
            this.labNombreInsumos.Text = "Nombre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 381);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 340);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 27;
            // 
            // btnBorrarInsumos
            // 
            this.btnBorrarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarInsumos.Location = new System.Drawing.Point(351, 333);
            this.btnBorrarInsumos.Name = "btnBorrarInsumos";
            this.btnBorrarInsumos.Size = new System.Drawing.Size(121, 36);
            this.btnBorrarInsumos.TabIndex = 26;
            this.btnBorrarInsumos.Text = "Borrar";
            this.btnBorrarInsumos.UseVisualStyleBackColor = true;
            // 
            // btnModificarInsumos
            // 
            this.btnModificarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInsumos.Location = new System.Drawing.Point(351, 377);
            this.btnModificarInsumos.Name = "btnModificarInsumos";
            this.btnModificarInsumos.Size = new System.Drawing.Size(121, 36);
            this.btnModificarInsumos.TabIndex = 25;
            this.btnModificarInsumos.Text = "Modificar";
            this.btnModificarInsumos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarInsumos
            // 
            this.btnAgregarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumos.Location = new System.Drawing.Point(351, 289);
            this.btnAgregarInsumos.Name = "btnAgregarInsumos";
            this.btnAgregarInsumos.Size = new System.Drawing.Size(121, 36);
            this.btnAgregarInsumos.TabIndex = 24;
            this.btnAgregarInsumos.Text = "Agregar";
            this.btnAgregarInsumos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBoxNombre);
            this.groupBox1.Controls.Add(this.btnFiltrarInsumo);
            this.groupBox1.Controls.Add(this.labNombre);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(545, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 183);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(186, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 27);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 27);
            this.comboBox1.TabIndex = 10;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNombre.Location = new System.Drawing.Point(16, 65);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(168, 23);
            this.checkBoxNombre.TabIndex = 8;
            this.checkBoxNombre.Text = "Nombre proveedor";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarInsumo
            // 
            this.btnFiltrarInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarInsumo.Location = new System.Drawing.Point(262, 141);
            this.btnFiltrarInsumo.Name = "btnFiltrarInsumo";
            this.btnFiltrarInsumo.Size = new System.Drawing.Size(104, 36);
            this.btnFiltrarInsumo.TabIndex = 12;
            this.btnFiltrarInsumo.Text = "Filtrar";
            this.btnFiltrarInsumo.UseVisualStyleBackColor = true;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(16, 34);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(147, 19);
            this.labNombre.TabIndex = 13;
            this.labNombre.Text = "Nombre de insumo";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstado.Location = new System.Drawing.Point(16, 104);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(73, 23);
            this.checkBoxEstado.TabIndex = 6;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 27);
            this.textBox4.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(374, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(140, 422);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(161, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // EstadoInsumo
            // 
            this.EstadoInsumo.AutoSize = true;
            this.EstadoInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoInsumo.Location = new System.Drawing.Point(29, 423);
            this.EstadoInsumo.Name = "EstadoInsumo";
            this.EstadoInsumo.Size = new System.Drawing.Size(54, 19);
            this.EstadoInsumo.TabIndex = 35;
            this.EstadoInsumo.Text = "Estado";
            // 
            // btnCambiarEstadoInsumo
            // 
            this.btnCambiarEstadoInsumo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoInsumo.Location = new System.Drawing.Point(351, 421);
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
            this.LabObservInsumos.Location = new System.Drawing.Point(20, 464);
            this.LabObservInsumos.Name = "LabObservInsumos";
            this.LabObservInsumos.Size = new System.Drawing.Size(110, 19);
            this.LabObservInsumos.TabIndex = 37;
            this.LabObservInsumos.Text = "Observaciones";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(807, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InsumosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(952, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabObservInsumos);
            this.Controls.Add(this.btnCambiarEstadoInsumo);
            this.Controls.Add(this.EstadoInsumo);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labProveedor);
            this.Controls.Add(this.labCantidadInsumos);
            this.Controls.Add(this.labNombreInsumos);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBorrarInsumos);
            this.Controls.Add(this.btnModificarInsumos);
            this.Controls.Add(this.btnAgregarInsumos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labInsumos);
            this.Name = "InsumosForm";
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.InsumosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantActualInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionesInsumos;
        private System.Windows.Forms.Label labInsumos;
        private System.Windows.Forms.Label labProveedor;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labCantidadInsumos;
        private System.Windows.Forms.Label labNombreInsumos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBorrarInsumos;
        private System.Windows.Forms.Button btnModificarInsumos;
        private System.Windows.Forms.Button btnAgregarInsumos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.Button btnFiltrarInsumo;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label EstadoInsumo;
        private System.Windows.Forms.Button btnCambiarEstadoInsumo;
        private System.Windows.Forms.Label LabObservInsumos;
        private System.Windows.Forms.Button button1;
    }
}