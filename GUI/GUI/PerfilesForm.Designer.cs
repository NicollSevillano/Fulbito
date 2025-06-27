namespace GUI
{
    partial class PerfilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilesForm));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labPerfil = new System.Windows.Forms.Label();
            this.lbNombrePerfil = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbPermiso = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboIdioma1 = new Controles.ComboIdioma();
            this.btnModificarperfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(645, 259);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(113, 41);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar perfil";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(645, 135);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(133, 41);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear perfil";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(645, 321);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 41);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Asignar permiso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Lista de perfiles:"});
            this.listBox1.Location = new System.Drawing.Point(12, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 342);
            this.listBox1.TabIndex = 4;
            // 
            // labPerfil
            // 
            this.labPerfil.AutoSize = true;
            this.labPerfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPerfil.Location = new System.Drawing.Point(12, 12);
            this.labPerfil.Name = "labPerfil";
            this.labPerfil.Size = new System.Drawing.Size(114, 19);
            this.labPerfil.TabIndex = 5;
            this.labPerfil.Text = "Usuario actual:";
            // 
            // lbNombrePerfil
            // 
            this.lbNombrePerfil.AutoSize = true;
            this.lbNombrePerfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePerfil.Location = new System.Drawing.Point(136, 12);
            this.lbNombrePerfil.Name = "lbNombrePerfil";
            this.lbNombrePerfil.Size = new System.Drawing.Size(147, 19);
            this.lbNombrePerfil.TabIndex = 6;
            this.lbNombrePerfil.Text = "nombre del usuario";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(12, 55);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(58, 19);
            this.lbPerfil.TabIndex = 7;
            this.lbPerfil.Text = "Perfiles";
            // 
            // lbPermiso
            // 
            this.lbPermiso.AutoSize = true;
            this.lbPermiso.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermiso.Location = new System.Drawing.Point(186, 55);
            this.lbPermiso.Name = "lbPermiso";
            this.lbPermiso.Size = new System.Drawing.Size(70, 19);
            this.lbPermiso.TabIndex = 8;
            this.lbPermiso.Text = "Permisos";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Lista de permisos:"});
            this.listBox2.Location = new System.Drawing.Point(190, 84);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 342);
            this.listBox2.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(368, 84);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(264, 342);
            this.treeView1.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(645, 383);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 41);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(645, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // comboIdioma1
            // 
            this.comboIdioma1.Location = new System.Drawing.Point(505, 12);
            this.comboIdioma1.Name = "comboIdioma1";
            this.comboIdioma1.Size = new System.Drawing.Size(116, 22);
            this.comboIdioma1.TabIndex = 13;
            // 
            // btnModificarperfil
            // 
            this.btnModificarperfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarperfil.Location = new System.Drawing.Point(645, 197);
            this.btnModificarperfil.Name = "btnModificarperfil";
            this.btnModificarperfil.Size = new System.Drawing.Size(133, 41);
            this.btnModificarperfil.TabIndex = 14;
            this.btnModificarperfil.Text = "Modificar perfil";
            this.btnModificarperfil.UseVisualStyleBackColor = true;
            this.btnModificarperfil.Click += new System.EventHandler(this.btnModificarperfil_Click);
            // 
            // PerfilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Controls.Add(this.btnModificarperfil);
            this.Controls.Add(this.comboIdioma1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbPermiso);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.lbNombrePerfil);
            this.Controls.Add(this.labPerfil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBorrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerfilesForm";
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.RegistroReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labPerfil;
        private System.Windows.Forms.Label lbNombrePerfil;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label lbPermiso;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controles.ComboIdioma comboIdioma1;
        private System.Windows.Forms.Button btnModificarperfil;
    }
}