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
            this.lbPermiso = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbNombrePerfil = new System.Windows.Forms.Label();
            this.labPerfil = new System.Windows.Forms.Label();
            this.btnModificarperfil = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.comboIdioma1 = new Controles.ComboIdioma();
            this.SuspendLayout();
            // 
            // lbPermiso
            // 
            this.lbPermiso.AutoSize = true;
            this.lbPermiso.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermiso.Location = new System.Drawing.Point(186, 52);
            this.lbPermiso.Name = "lbPermiso";
            this.lbPermiso.Size = new System.Drawing.Size(70, 19);
            this.lbPermiso.TabIndex = 12;
            this.lbPermiso.Text = "Permisos";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(12, 52);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(58, 19);
            this.lbPerfil.TabIndex = 11;
            this.lbPerfil.Text = "Perfiles";
            // 
            // lbNombrePerfil
            // 
            this.lbNombrePerfil.AutoSize = true;
            this.lbNombrePerfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePerfil.Location = new System.Drawing.Point(136, 9);
            this.lbNombrePerfil.Name = "lbNombrePerfil";
            this.lbNombrePerfil.Size = new System.Drawing.Size(147, 19);
            this.lbNombrePerfil.TabIndex = 10;
            this.lbNombrePerfil.Text = "nombre del usuario";
            // 
            // labPerfil
            // 
            this.labPerfil.AutoSize = true;
            this.labPerfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPerfil.Location = new System.Drawing.Point(12, 9);
            this.labPerfil.Name = "labPerfil";
            this.labPerfil.Size = new System.Drawing.Size(114, 19);
            this.labPerfil.TabIndex = 9;
            this.labPerfil.Text = "Usuario actual:";
            // 
            // btnModificarperfil
            // 
            this.btnModificarperfil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarperfil.Location = new System.Drawing.Point(647, 218);
            this.btnModificarperfil.Name = "btnModificarperfil";
            this.btnModificarperfil.Size = new System.Drawing.Size(133, 39);
            this.btnModificarperfil.TabIndex = 22;
            this.btnModificarperfil.Text = "Modificar perfil";
            this.btnModificarperfil.UseVisualStyleBackColor = true;
            this.btnModificarperfil.Click += new System.EventHandler(this.btnModificarperfil_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(647, 380);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 39);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(370, 77);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(264, 342);
            this.treeView1.TabIndex = 20;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Lista de permisos:"});
            this.listBox2.Location = new System.Drawing.Point(192, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 342);
            this.listBox2.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Lista de perfiles:"});
            this.listBox1.Location = new System.Drawing.Point(14, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 342);
            this.listBox1.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(647, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 39);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Asignar permiso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(647, 128);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(133, 39);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear perfil";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(647, 173);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(113, 39);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar perfil";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // comboIdioma1
            // 
            this.comboIdioma1.Location = new System.Drawing.Point(640, 12);
            this.comboIdioma1.Name = "comboIdioma1";
            this.comboIdioma1.Size = new System.Drawing.Size(134, 27);
            this.comboIdioma1.TabIndex = 23;
            // 
            // PerfilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(786, 426);
            this.Controls.Add(this.comboIdioma1);
            this.Controls.Add(this.btnModificarperfil);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lbPermiso);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.lbNombrePerfil);
            this.Controls.Add(this.labPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerfilesForm";
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.PerfilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPermiso;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label lbNombrePerfil;
        private System.Windows.Forms.Label labPerfil;
        private System.Windows.Forms.Button btnModificarperfil;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private Controles.ComboIdioma comboIdioma1;
    }
}