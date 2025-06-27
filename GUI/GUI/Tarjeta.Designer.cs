namespace GUI
{
    partial class TarjetaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarjetaForm));
            this.lbTarjeta = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lbMes = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.txtcvc = new System.Windows.Forms.TextBox();
            this.lbCv = new System.Windows.Forms.Label();
            this.btnPagarTarjeta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTarjeta
            // 
            this.lbTarjeta.AutoSize = true;
            this.lbTarjeta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjeta.Location = new System.Drawing.Point(32, 56);
            this.lbTarjeta.Name = "lbTarjeta";
            this.lbTarjeta.Size = new System.Drawing.Size(140, 19);
            this.lbTarjeta.TabIndex = 0;
            this.lbTarjeta.Text = "Número de tarjeta";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(178, 52);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(183, 27);
            this.txtnumero.TabIndex = 1;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(23, 115);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(37, 19);
            this.lbMes.TabIndex = 2;
            this.lbMes.Text = "Mes";
            // 
            // txtmes
            // 
            this.txtmes.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmes.Location = new System.Drawing.Point(66, 111);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(43, 27);
            this.txtmes.TabIndex = 3;
            this.txtmes.TextChanged += new System.EventHandler(this.txtmes_TextChanged);
            // 
            // txtano
            // 
            this.txtano.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtano.Location = new System.Drawing.Point(196, 111);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(43, 27);
            this.txtano.TabIndex = 5;
            this.txtano.TextChanged += new System.EventHandler(this.txtano_TextChanged);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(153, 115);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(39, 19);
            this.lbAno.TabIndex = 4;
            this.lbAno.Text = "Año";
            // 
            // txtcvc
            // 
            this.txtcvc.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcvc.Location = new System.Drawing.Point(328, 111);
            this.txtcvc.Name = "txtcvc";
            this.txtcvc.Size = new System.Drawing.Size(61, 27);
            this.txtcvc.TabIndex = 7;
            this.txtcvc.TextChanged += new System.EventHandler(this.txtcvc_TextChanged);
            // 
            // lbCv
            // 
            this.lbCv.AutoSize = true;
            this.lbCv.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCv.Location = new System.Drawing.Point(285, 115);
            this.lbCv.Name = "lbCv";
            this.lbCv.Size = new System.Drawing.Size(42, 19);
            this.lbCv.TabIndex = 6;
            this.lbCv.Text = "CVC";
            // 
            // btnPagarTarjeta
            // 
            this.btnPagarTarjeta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarTarjeta.Location = new System.Drawing.Point(157, 191);
            this.btnPagarTarjeta.Name = "btnPagarTarjeta";
            this.btnPagarTarjeta.Size = new System.Drawing.Size(114, 41);
            this.btnPagarTarjeta.TabIndex = 8;
            this.btnPagarTarjeta.Text = "Pagar";
            this.btnPagarTarjeta.UseVisualStyleBackColor = true;
            this.btnPagarTarjeta.Click += new System.EventHandler(this.btnPagarTarjeta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(103, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TarjetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(427, 255);
            this.Controls.Add(this.btnPagarTarjeta);
            this.Controls.Add(this.txtcvc);
            this.Controls.Add(this.lbCv);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbTarjeta);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TarjetaForm";
            this.Text = "Tarjeta";
            this.Load += new System.EventHandler(this.Tarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTarjeta;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.TextBox txtcvc;
        private System.Windows.Forms.Label lbCv;
        private System.Windows.Forms.Button btnPagarTarjeta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}