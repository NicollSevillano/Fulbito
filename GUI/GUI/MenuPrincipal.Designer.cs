namespace GUI
{
    partial class MenuPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasHechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCanchaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labNombreMp = new System.Windows.Forms.Label();
            this.labUsuarioMp = new System.Windows.Forms.Label();
            this.labRolMp = new System.Windows.Forms.Label();
            this.labPerfilMp = new System.Windows.Forms.Label();
            this.comboIdioma1 = new Controles.ComboIdioma();
            this.btnSalirm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.reservaToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.alquilerToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.clientesToolStripMenuItem,
            this.reservasHechasToolStripMenuItem});
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 24);
            this.toolStripMenuItem2.Text = "Reservar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.registrarClienteToolStripMenuItem.Text = "Registrar cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // reservasHechasToolStripMenuItem
            // 
            this.reservasHechasToolStripMenuItem.Name = "reservasHechasToolStripMenuItem";
            this.reservasHechasToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.reservasHechasToolStripMenuItem.Text = "Reservas hechas";
            this.reservasHechasToolStripMenuItem.Click += new System.EventHandler(this.reservasHechasToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitácoraToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.canchasToolStripMenuItem,
            this.insumosToolStripMenuItem,
            this.backUpToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.cambiosToolStripMenuItem});
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            this.cambiosToolStripMenuItem.Click += new System.EventHandler(this.cambiosToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // canchasToolStripMenuItem
            // 
            this.canchasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCanchaToolStripMenuItem});
            this.canchasToolStripMenuItem.Name = "canchasToolStripMenuItem";
            this.canchasToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.canchasToolStripMenuItem.Text = "Canchas";
            // 
            // registrarCanchaToolStripMenuItem
            // 
            this.registrarCanchaToolStripMenuItem.Name = "registrarCanchaToolStripMenuItem";
            this.registrarCanchaToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.registrarCanchaToolStripMenuItem.Text = "Registrar cancha";
            this.registrarCanchaToolStripMenuItem.Click += new System.EventHandler(this.registrarCanchaToolStripMenuItem_Click);
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.insumosToolStripMenuItem.Text = "Insumos";
            this.insumosToolStripMenuItem.Click += new System.EventHandler(this.insumosToolStripMenuItem_Click);
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.backUpToolStripMenuItem.Text = "BackUp";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
            // 
            // alquilerToolStripMenuItem
            // 
            this.alquilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumosToolStripMenuItem1});
            this.alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            this.alquilerToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.alquilerToolStripMenuItem.Text = "Alquiler";
            // 
            // insumosToolStripMenuItem1
            // 
            this.insumosToolStripMenuItem1.Name = "insumosToolStripMenuItem1";
            this.insumosToolStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.insumosToolStripMenuItem1.Text = "Insumos";
            this.insumosToolStripMenuItem1.Click += new System.EventHandler(this.insumosToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(105, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labNombreMp
            // 
            this.labNombreMp.AutoSize = true;
            this.labNombreMp.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreMp.Location = new System.Drawing.Point(12, 344);
            this.labNombreMp.Name = "labNombreMp";
            this.labNombreMp.Size = new System.Drawing.Size(74, 19);
            this.labNombreMp.TabIndex = 2;
            this.labNombreMp.Text = "Nombre:";
            // 
            // labUsuarioMp
            // 
            this.labUsuarioMp.AutoSize = true;
            this.labUsuarioMp.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioMp.Location = new System.Drawing.Point(91, 344);
            this.labUsuarioMp.Name = "labUsuarioMp";
            this.labUsuarioMp.Size = new System.Drawing.Size(29, 19);
            this.labUsuarioMp.TabIndex = 3;
            this.labUsuarioMp.Text = "----";
            // 
            // labRolMp
            // 
            this.labRolMp.AutoSize = true;
            this.labRolMp.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRolMp.Location = new System.Drawing.Point(189, 344);
            this.labRolMp.Name = "labRolMp";
            this.labRolMp.Size = new System.Drawing.Size(38, 19);
            this.labRolMp.TabIndex = 4;
            this.labRolMp.Text = "Rol:";
            // 
            // labPerfilMp
            // 
            this.labPerfilMp.AutoSize = true;
            this.labPerfilMp.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPerfilMp.Location = new System.Drawing.Point(233, 344);
            this.labPerfilMp.Name = "labPerfilMp";
            this.labPerfilMp.Size = new System.Drawing.Size(29, 19);
            this.labPerfilMp.TabIndex = 5;
            this.labPerfilMp.Text = "----";
            // 
            // comboIdioma1
            // 
            this.comboIdioma1.Location = new System.Drawing.Point(341, 40);
            this.comboIdioma1.Name = "comboIdioma1";
            this.comboIdioma1.Size = new System.Drawing.Size(115, 22);
            this.comboIdioma1.TabIndex = 6;
            // 
            // btnSalirm
            // 
            this.btnSalirm.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirm.Location = new System.Drawing.Point(368, 337);
            this.btnSalirm.Name = "btnSalirm";
            this.btnSalirm.Size = new System.Drawing.Size(88, 32);
            this.btnSalirm.TabIndex = 7;
            this.btnSalirm.Text = "Salir";
            this.btnSalirm.UseVisualStyleBackColor = true;
            this.btnSalirm.Click += new System.EventHandler(this.btnSalirm_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(468, 377);
            this.Controls.Add(this.btnSalirm);
            this.Controls.Add(this.comboIdioma1);
            this.Controls.Add(this.labPerfilMp);
            this.Controls.Add(this.labRolMp);
            this.Controls.Add(this.labUsuarioMp);
            this.Controls.Add(this.labNombreMp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipalForm";
            this.Text = "Menú principal ";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label labNombreMp;
        private System.Windows.Forms.Label labUsuarioMp;
        private System.Windows.Forms.Label labRolMp;
        private System.Windows.Forms.Label labPerfilMp;
        private Controles.ComboIdioma comboIdioma1;
        private System.Windows.Forms.Button btnSalirm;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCanchaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasHechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem1;
    }
}