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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsumosForm));
            this.labInsumos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarInsumos = new System.Windows.Forms.Button();
            this.btnModificarInsumos = new System.Windows.Forms.Button();
            this.btnBorrarInsumos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labNombreInsumos = new System.Windows.Forms.Label();
            this.labCantidadInsumos = new System.Windows.Forms.Label();
            this.btnObservaciones = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupObservacionesInsumos = new System.Windows.Forms.GroupBox();
            this.labProveedor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.btnFiltrarInsumo = new System.Windows.Forms.Button();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantActualInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionesInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupObservacionesInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labInsumos
            // 
            this.labInsumos.AutoSize = true;
            this.labInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInsumos.Location = new System.Drawing.Point(11, 13);
            this.labInsumos.Name = "labInsumos";
            this.labInsumos.Size = new System.Drawing.Size(137, 19);
            this.labInsumos.TabIndex = 1;
            this.labInsumos.Text = "Estado de insumos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInsumos,
            this.NombreInsumos,
            this.CantidadInsumos,
            this.CantActualInsumos,
            this.ProveedorInsumos,
            this.EstadoInsumos,
            this.ObservacionesInsumos});
            this.dataGridView1.Location = new System.Drawing.Point(8, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(925, 231);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAgregarInsumos
            // 
            this.btnAgregarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumos.Location = new System.Drawing.Point(303, 298);
            this.btnAgregarInsumos.Name = "btnAgregarInsumos";
            this.btnAgregarInsumos.Size = new System.Drawing.Size(104, 36);
            this.btnAgregarInsumos.TabIndex = 13;
            this.btnAgregarInsumos.Text = "Agregar";
            this.btnAgregarInsumos.UseVisualStyleBackColor = true;
            this.btnAgregarInsumos.Click += new System.EventHandler(this.btnAgregarInsumos_Click);
            // 
            // btnModificarInsumos
            // 
            this.btnModificarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInsumos.Location = new System.Drawing.Point(303, 382);
            this.btnModificarInsumos.Name = "btnModificarInsumos";
            this.btnModificarInsumos.Size = new System.Drawing.Size(104, 36);
            this.btnModificarInsumos.TabIndex = 14;
            this.btnModificarInsumos.Text = "Modificar";
            this.btnModificarInsumos.UseVisualStyleBackColor = true;
            // 
            // btnBorrarInsumos
            // 
            this.btnBorrarInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarInsumos.Location = new System.Drawing.Point(303, 340);
            this.btnBorrarInsumos.Name = "btnBorrarInsumos";
            this.btnBorrarInsumos.Size = new System.Drawing.Size(104, 36);
            this.btnBorrarInsumos.TabIndex = 15;
            this.btnBorrarInsumos.Text = "Borrar";
            this.btnBorrarInsumos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 350);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 392);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 18;
            // 
            // labNombreInsumos
            // 
            this.labNombreInsumos.AutoSize = true;
            this.labNombreInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreInsumos.Location = new System.Drawing.Point(16, 306);
            this.labNombreInsumos.Name = "labNombreInsumos";
            this.labNombreInsumos.Size = new System.Drawing.Size(69, 19);
            this.labNombreInsumos.TabIndex = 20;
            this.labNombreInsumos.Text = "Nombre";
            // 
            // labCantidadInsumos
            // 
            this.labCantidadInsumos.AutoSize = true;
            this.labCantidadInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidadInsumos.Location = new System.Drawing.Point(16, 349);
            this.labCantidadInsumos.Name = "labCantidadInsumos";
            this.labCantidadInsumos.Size = new System.Drawing.Size(72, 19);
            this.labCantidadInsumos.TabIndex = 21;
            this.labCantidadInsumos.Text = "Cantidad";
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservaciones.Location = new System.Drawing.Point(291, 136);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(118, 46);
            this.btnObservaciones.TabIndex = 19;
            this.btnObservaciones.Text = "Agregar observaciones";
            this.btnObservaciones.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 26);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(277, 156);
            this.textBox5.TabIndex = 20;
            // 
            // groupObservacionesInsumos
            // 
            this.groupObservacionesInsumos.Controls.Add(this.textBox5);
            this.groupObservacionesInsumos.Controls.Add(this.btnObservaciones);
            this.groupObservacionesInsumos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupObservacionesInsumos.Location = new System.Drawing.Point(12, 424);
            this.groupObservacionesInsumos.Name = "groupObservacionesInsumos";
            this.groupObservacionesInsumos.Size = new System.Drawing.Size(415, 200);
            this.groupObservacionesInsumos.TabIndex = 13;
            this.groupObservacionesInsumos.TabStop = false;
            this.groupObservacionesInsumos.Text = "Observaciones";
            // 
            // labProveedor
            // 
            this.labProveedor.AutoSize = true;
            this.labProveedor.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProveedor.Location = new System.Drawing.Point(16, 392);
            this.labProveedor.Name = "labProveedor";
            this.labProveedor.Size = new System.Drawing.Size(84, 19);
            this.labProveedor.TabIndex = 22;
            this.labProveedor.Text = "Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(481, 505);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(246, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 27);
            this.textBox4.TabIndex = 14;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstado.Location = new System.Drawing.Point(16, 122);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(73, 23);
            this.checkBoxEstado.TabIndex = 6;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(16, 45);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(147, 19);
            this.labNombre.TabIndex = 13;
            this.labNombre.Text = "Nombre de insumo";
            // 
            // btnFiltrarInsumo
            // 
            this.btnFiltrarInsumo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarInsumo.Location = new System.Drawing.Point(302, 173);
            this.btnFiltrarInsumo.Name = "btnFiltrarInsumo";
            this.btnFiltrarInsumo.Size = new System.Drawing.Size(104, 36);
            this.btnFiltrarInsumo.TabIndex = 12;
            this.btnFiltrarInsumo.Text = "Filtrar";
            this.btnFiltrarInsumo.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNombre.Location = new System.Drawing.Point(16, 81);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(168, 23);
            this.checkBoxNombre.TabIndex = 8;
            this.checkBoxNombre.Text = "Nombre proveedor";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 27);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(247, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 27);
            this.comboBox2.TabIndex = 11;
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
            this.groupBox1.Location = new System.Drawing.Point(481, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 215);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
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
            // InsumosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(945, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labProveedor);
            this.Controls.Add(this.groupObservacionesInsumos);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsumosForm";
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.InsumosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupObservacionesInsumos.ResumeLayout(false);
            this.groupObservacionesInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labInsumos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarInsumos;
        private System.Windows.Forms.Button btnModificarInsumos;
        private System.Windows.Forms.Button btnBorrarInsumos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labNombreInsumos;
        private System.Windows.Forms.Label labCantidadInsumos;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupObservacionesInsumos;
        private System.Windows.Forms.Label labProveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Button btnFiltrarInsumo;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantActualInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionesInsumos;
    }
}