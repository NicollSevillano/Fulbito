namespace GUI
{
    partial class GUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUsuariosForm));
            this.lbDatosU = new System.Windows.Forms.Label();
            this.labDniU = new System.Windows.Forms.Label();
            this.labNombreU = new System.Windows.Forms.Label();
            this.labApellidoU = new System.Windows.Forms.Label();
            this.labEmailU = new System.Windows.Forms.Label();
            this.labUsuarioU = new System.Windows.Forms.Label();
            this.labContraseñaU = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.btnBorrarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnDesbloquearU = new System.Windows.Forms.Button();
            this.labFiltrarU = new System.Windows.Forms.Label();
            this.cbBloqueadosU = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalirU = new System.Windows.Forms.Button();
            this.btnCambiarCU = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ColumnaIdU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDniU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmailU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPerfilU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaUsuarioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaContraseñaU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBloqueadoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaActivoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPerfilU = new System.Windows.Forms.Button();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.labRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDatosU
            // 
            this.lbDatosU.AutoSize = true;
            this.lbDatosU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosU.Location = new System.Drawing.Point(45, 224);
            this.lbDatosU.Name = "lbDatosU";
            this.lbDatosU.Size = new System.Drawing.Size(127, 19);
            this.lbDatosU.TabIndex = 1;
            this.lbDatosU.Text = "Datos de usuario";
            // 
            // labDniU
            // 
            this.labDniU.AutoSize = true;
            this.labDniU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDniU.Location = new System.Drawing.Point(45, 271);
            this.labDniU.Name = "labDniU";
            this.labDniU.Size = new System.Drawing.Size(39, 19);
            this.labDniU.TabIndex = 2;
            this.labDniU.Text = "DNI";
            // 
            // labNombreU
            // 
            this.labNombreU.AutoSize = true;
            this.labNombreU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreU.Location = new System.Drawing.Point(45, 313);
            this.labNombreU.Name = "labNombreU";
            this.labNombreU.Size = new System.Drawing.Size(69, 19);
            this.labNombreU.TabIndex = 3;
            this.labNombreU.Text = "Nombre";
            // 
            // labApellidoU
            // 
            this.labApellidoU.AutoSize = true;
            this.labApellidoU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellidoU.Location = new System.Drawing.Point(45, 355);
            this.labApellidoU.Name = "labApellidoU";
            this.labApellidoU.Size = new System.Drawing.Size(68, 19);
            this.labApellidoU.TabIndex = 4;
            this.labApellidoU.Text = "Apellido";
            // 
            // labEmailU
            // 
            this.labEmailU.AutoSize = true;
            this.labEmailU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmailU.Location = new System.Drawing.Point(45, 397);
            this.labEmailU.Name = "labEmailU";
            this.labEmailU.Size = new System.Drawing.Size(47, 19);
            this.labEmailU.TabIndex = 5;
            this.labEmailU.Text = "Email";
            // 
            // labUsuarioU
            // 
            this.labUsuarioU.AutoSize = true;
            this.labUsuarioU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioU.Location = new System.Drawing.Point(45, 439);
            this.labUsuarioU.Name = "labUsuarioU";
            this.labUsuarioU.Size = new System.Drawing.Size(63, 19);
            this.labUsuarioU.TabIndex = 7;
            this.labUsuarioU.Text = "Usuario";
            // 
            // labContraseñaU
            // 
            this.labContraseñaU.AutoSize = true;
            this.labContraseñaU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labContraseñaU.Location = new System.Drawing.Point(45, 481);
            this.labContraseñaU.Name = "labContraseñaU";
            this.labContraseñaU.Size = new System.Drawing.Size(88, 19);
            this.labContraseñaU.TabIndex = 8;
            this.labContraseñaU.Text = "Contraseña";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(214, 271);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(145, 20);
            this.txtDni.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 313);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(214, 355);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(145, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 397);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(214, 439);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtUsuario.TabIndex = 14;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(214, 481);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(145, 20);
            this.txtContraseña.TabIndex = 15;
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarU.Location = new System.Drawing.Point(417, 231);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(105, 43);
            this.btnAgregarU.TabIndex = 16;
            this.btnAgregarU.Text = "Agregar";
            this.btnAgregarU.UseVisualStyleBackColor = true;
            this.btnAgregarU.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrarU
            // 
            this.btnBorrarU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarU.Location = new System.Drawing.Point(417, 280);
            this.btnBorrarU.Name = "btnBorrarU";
            this.btnBorrarU.Size = new System.Drawing.Size(105, 43);
            this.btnBorrarU.TabIndex = 17;
            this.btnBorrarU.Text = "Borrar";
            this.btnBorrarU.UseVisualStyleBackColor = true;
            this.btnBorrarU.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificarU
            // 
            this.btnModificarU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarU.Location = new System.Drawing.Point(417, 332);
            this.btnModificarU.Name = "btnModificarU";
            this.btnModificarU.Size = new System.Drawing.Size(105, 43);
            this.btnModificarU.TabIndex = 18;
            this.btnModificarU.Text = "Modificar";
            this.btnModificarU.UseVisualStyleBackColor = true;
            this.btnModificarU.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDesbloquearU
            // 
            this.btnDesbloquearU.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquearU.Location = new System.Drawing.Point(597, 313);
            this.btnDesbloquearU.Name = "btnDesbloquearU";
            this.btnDesbloquearU.Size = new System.Drawing.Size(100, 43);
            this.btnDesbloquearU.TabIndex = 19;
            this.btnDesbloquearU.Text = "Desbloquear";
            this.btnDesbloquearU.UseVisualStyleBackColor = true;
            this.btnDesbloquearU.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // labFiltrarU
            // 
            this.labFiltrarU.AutoSize = true;
            this.labFiltrarU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFiltrarU.Location = new System.Drawing.Point(593, 246);
            this.labFiltrarU.Name = "labFiltrarU";
            this.labFiltrarU.Size = new System.Drawing.Size(50, 19);
            this.labFiltrarU.TabIndex = 21;
            this.labFiltrarU.Text = "Filtrar";
            // 
            // cbBloqueadosU
            // 
            this.cbBloqueadosU.AutoSize = true;
            this.cbBloqueadosU.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBloqueadosU.Location = new System.Drawing.Point(597, 280);
            this.cbBloqueadosU.Name = "cbBloqueadosU";
            this.cbBloqueadosU.Size = new System.Drawing.Size(103, 22);
            this.cbBloqueadosU.TabIndex = 24;
            this.cbBloqueadosU.Text = "Bloqueados";
            this.cbBloqueadosU.UseVisualStyleBackColor = true;
            this.cbBloqueadosU.CheckedChanged += new System.EventHandler(this.cbBloqueados_CheckedChanged);
            this.cbBloqueadosU.TextChanged += new System.EventHandler(this.cbBloqueados_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(597, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalirU
            // 
            this.btnSalirU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirU.Location = new System.Drawing.Point(818, 491);
            this.btnSalirU.Name = "btnSalirU";
            this.btnSalirU.Size = new System.Drawing.Size(105, 43);
            this.btnSalirU.TabIndex = 20;
            this.btnSalirU.Text = "Salir";
            this.btnSalirU.UseVisualStyleBackColor = true;
            this.btnSalirU.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCambiarCU
            // 
            this.btnCambiarCU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarCU.Location = new System.Drawing.Point(417, 468);
            this.btnCambiarCU.Name = "btnCambiarCU";
            this.btnCambiarCU.Size = new System.Drawing.Size(105, 54);
            this.btnCambiarCU.TabIndex = 34;
            this.btnCambiarCU.Text = "Cambiar clave";
            this.btnCambiarCU.UseVisualStyleBackColor = true;
            this.btnCambiarCU.Click += new System.EventHandler(this.btnCambiarC_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaIdU,
            this.ColumnaDniU,
            this.ColumnaNombreU,
            this.ColumnaApellidoU,
            this.ColumnaEmailU,
            this.ColumnaPerfilU,
            this.ColumnaUsuarioU,
            this.ColumnaContraseñaU,
            this.ColumnaBloqueadoU,
            this.ColumnaActivoU});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(911, 194);
            this.dgvUsuarios.TabIndex = 35;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick_1);
            // 
            // ColumnaIdU
            // 
            this.ColumnaIdU.HeaderText = "Id";
            this.ColumnaIdU.Name = "ColumnaIdU";
            this.ColumnaIdU.ReadOnly = true;
            // 
            // ColumnaDniU
            // 
            this.ColumnaDniU.HeaderText = "DNI";
            this.ColumnaDniU.Name = "ColumnaDniU";
            this.ColumnaDniU.ReadOnly = true;
            // 
            // ColumnaNombreU
            // 
            this.ColumnaNombreU.HeaderText = "Nombre";
            this.ColumnaNombreU.Name = "ColumnaNombreU";
            this.ColumnaNombreU.ReadOnly = true;
            // 
            // ColumnaApellidoU
            // 
            this.ColumnaApellidoU.HeaderText = "Apellido";
            this.ColumnaApellidoU.Name = "ColumnaApellidoU";
            this.ColumnaApellidoU.ReadOnly = true;
            // 
            // ColumnaEmailU
            // 
            this.ColumnaEmailU.HeaderText = "Email";
            this.ColumnaEmailU.Name = "ColumnaEmailU";
            this.ColumnaEmailU.ReadOnly = true;
            // 
            // ColumnaPerfilU
            // 
            this.ColumnaPerfilU.HeaderText = "Rol";
            this.ColumnaPerfilU.Name = "ColumnaPerfilU";
            this.ColumnaPerfilU.ReadOnly = true;
            // 
            // ColumnaUsuarioU
            // 
            this.ColumnaUsuarioU.HeaderText = "Usuario";
            this.ColumnaUsuarioU.Name = "ColumnaUsuarioU";
            this.ColumnaUsuarioU.ReadOnly = true;
            // 
            // ColumnaContraseñaU
            // 
            this.ColumnaContraseñaU.HeaderText = "Contraseña";
            this.ColumnaContraseñaU.Name = "ColumnaContraseñaU";
            this.ColumnaContraseñaU.ReadOnly = true;
            // 
            // ColumnaBloqueadoU
            // 
            this.ColumnaBloqueadoU.HeaderText = "Bloqueado";
            this.ColumnaBloqueadoU.Name = "ColumnaBloqueadoU";
            this.ColumnaBloqueadoU.ReadOnly = true;
            // 
            // ColumnaActivoU
            // 
            this.ColumnaActivoU.HeaderText = "Activo";
            this.ColumnaActivoU.Name = "ColumnaActivoU";
            this.ColumnaActivoU.ReadOnly = true;
            // 
            // btnPerfilU
            // 
            this.btnPerfilU.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilU.Location = new System.Drawing.Point(818, 231);
            this.btnPerfilU.Name = "btnPerfilU";
            this.btnPerfilU.Size = new System.Drawing.Size(105, 43);
            this.btnPerfilU.TabIndex = 36;
            this.btnPerfilU.Text = "Perfiles";
            this.btnPerfilU.UseVisualStyleBackColor = true;
            this.btnPerfilU.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(417, 420);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(119, 21);
            this.cmbPerfiles.TabIndex = 37;
            // 
            // labRol
            // 
            this.labRol.AutoSize = true;
            this.labRol.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRol.Location = new System.Drawing.Point(413, 396);
            this.labRol.Name = "labRol";
            this.labRol.Size = new System.Drawing.Size(33, 19);
            this.labRol.TabIndex = 38;
            this.labRol.Text = "Rol";
            // 
            // GUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(935, 546);
            this.Controls.Add(this.labRol);
            this.Controls.Add(this.cmbPerfiles);
            this.Controls.Add(this.btnPerfilU);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.cbBloqueadosU);
            this.Controls.Add(this.btnCambiarCU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labFiltrarU);
            this.Controls.Add(this.btnSalirU);
            this.Controls.Add(this.btnDesbloquearU);
            this.Controls.Add(this.btnModificarU);
            this.Controls.Add(this.btnBorrarU);
            this.Controls.Add(this.btnAgregarU);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.labContraseñaU);
            this.Controls.Add(this.labUsuarioU);
            this.Controls.Add(this.labEmailU);
            this.Controls.Add(this.labApellidoU);
            this.Controls.Add(this.labNombreU);
            this.Controls.Add(this.labDniU);
            this.Controls.Add(this.lbDatosU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUsuariosForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.GUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDatosU;
        private System.Windows.Forms.Label labDniU;
        private System.Windows.Forms.Label labNombreU;
        private System.Windows.Forms.Label labApellidoU;
        private System.Windows.Forms.Label labEmailU;
        private System.Windows.Forms.Label labUsuarioU;
        private System.Windows.Forms.Label labContraseñaU;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAgregarU;
        private System.Windows.Forms.Button btnBorrarU;
        private System.Windows.Forms.Button btnModificarU;
        private System.Windows.Forms.Button btnDesbloquearU;
        private System.Windows.Forms.Label labFiltrarU;
        private System.Windows.Forms.CheckBox cbBloqueadosU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalirU;
        private System.Windows.Forms.Button btnCambiarCU;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnPerfilU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaIdU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDniU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEmailU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPerfilU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaUsuarioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaContraseñaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBloqueadoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaActivoU;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.Label labRol;
    }
}