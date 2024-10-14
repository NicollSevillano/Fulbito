namespace GUI
{
    partial class CambiarClaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarClaveForm));
            this.btnCambiarC = new System.Windows.Forms.Button();
            this.txtContraseñaC = new System.Windows.Forms.TextBox();
            this.txtContraseñaN = new System.Windows.Forms.TextBox();
            this.labConfirmarC = new System.Windows.Forms.Label();
            this.labContraseñaN = new System.Windows.Forms.Label();
            this.labCC = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiarC
            // 
            this.btnCambiarC.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarC.Location = new System.Drawing.Point(139, 233);
            this.btnCambiarC.Name = "btnCambiarC";
            this.btnCambiarC.Size = new System.Drawing.Size(156, 38);
            this.btnCambiarC.TabIndex = 11;
            this.btnCambiarC.Text = "Cambiar clave";
            this.btnCambiarC.UseVisualStyleBackColor = true;
            this.btnCambiarC.Click += new System.EventHandler(this.btnCambiarC_Click);
            // 
            // txtContraseñaC
            // 
            this.txtContraseñaC.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaC.Location = new System.Drawing.Point(219, 168);
            this.txtContraseñaC.Name = "txtContraseñaC";
            this.txtContraseñaC.PasswordChar = '*';
            this.txtContraseñaC.Size = new System.Drawing.Size(136, 27);
            this.txtContraseñaC.TabIndex = 10;
            // 
            // txtContraseñaN
            // 
            this.txtContraseñaN.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaN.Location = new System.Drawing.Point(219, 104);
            this.txtContraseñaN.Name = "txtContraseñaN";
            this.txtContraseñaN.PasswordChar = '*';
            this.txtContraseñaN.Size = new System.Drawing.Size(136, 27);
            this.txtContraseñaN.TabIndex = 9;
            // 
            // labConfirmarC
            // 
            this.labConfirmarC.AutoSize = true;
            this.labConfirmarC.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirmarC.Location = new System.Drawing.Point(34, 172);
            this.labConfirmarC.Name = "labConfirmarC";
            this.labConfirmarC.Size = new System.Drawing.Size(167, 19);
            this.labConfirmarC.TabIndex = 8;
            this.labConfirmarC.Text = "Confirmar contraseña ";
            // 
            // labContraseñaN
            // 
            this.labContraseñaN.AutoSize = true;
            this.labContraseñaN.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labContraseñaN.Location = new System.Drawing.Point(34, 108);
            this.labContraseñaN.Name = "labContraseñaN";
            this.labContraseñaN.Size = new System.Drawing.Size(136, 19);
            this.labContraseñaN.TabIndex = 7;
            this.labContraseñaN.Text = "Contraseña nueva";
            // 
            // labCC
            // 
            this.labCC.AutoSize = true;
            this.labCC.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCC.Location = new System.Drawing.Point(146, 36);
            this.labCC.Name = "labCC";
            this.labCC.Size = new System.Drawing.Size(161, 29);
            this.labCC.TabIndex = 6;
            this.labCC.Text = "Cambiar clave";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(358, 261);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 41);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.oculto;
            this.pictureBox3.Location = new System.Drawing.Point(381, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.oculto;
            this.pictureBox2.Location = new System.Drawing.Point(381, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(89, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // CambiarClaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(461, 314);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCambiarC);
            this.Controls.Add(this.txtContraseñaC);
            this.Controls.Add(this.txtContraseñaN);
            this.Controls.Add(this.labConfirmarC);
            this.Controls.Add(this.labContraseñaN);
            this.Controls.Add(this.labCC);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarClaveForm";
            this.Text = "CambiarClave";
            this.Load += new System.EventHandler(this.CambiarClave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarC;
        private System.Windows.Forms.TextBox txtContraseñaC;
        private System.Windows.Forms.TextBox txtContraseñaN;
        private System.Windows.Forms.Label labConfirmarC;
        private System.Windows.Forms.Label labContraseñaN;
        private System.Windows.Forms.Label labCC;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}