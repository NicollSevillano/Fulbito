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
            this.btnPagarTarjeta = new System.Windows.Forms.Button();
            this.txtcvc = new System.Windows.Forms.TextBox();
            this.lbCv = new System.Windows.Forms.Label();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.lbMes = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lbTarjeta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagarTarjeta
            // 
            this.btnPagarTarjeta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarTarjeta.Location = new System.Drawing.Point(169, 200);
            this.btnPagarTarjeta.Name = "btnPagarTarjeta";
            this.btnPagarTarjeta.Size = new System.Drawing.Size(114, 34);
            this.btnPagarTarjeta.TabIndex = 18;
            this.btnPagarTarjeta.Text = "Pagar";
            this.btnPagarTarjeta.UseVisualStyleBackColor = true;
            this.btnPagarTarjeta.Click += new System.EventHandler(this.btnPagarTarjeta_Click);
            // 
            // txtcvc
            // 
            this.txtcvc.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcvc.Location = new System.Drawing.Point(340, 113);
            this.txtcvc.Name = "txtcvc";
            this.txtcvc.Size = new System.Drawing.Size(61, 27);
            this.txtcvc.TabIndex = 17;
            this.txtcvc.TextChanged += new System.EventHandler(this.txtcvc_TextChanged);
            // 
            // lbCv
            // 
            this.lbCv.AutoSize = true;
            this.lbCv.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCv.Location = new System.Drawing.Point(297, 117);
            this.lbCv.Name = "lbCv";
            this.lbCv.Size = new System.Drawing.Size(42, 19);
            this.lbCv.TabIndex = 16;
            this.lbCv.Text = "CVC";
            // 
            // txtano
            // 
            this.txtano.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtano.Location = new System.Drawing.Point(208, 113);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(43, 27);
            this.txtano.TabIndex = 15;
            this.txtano.TextChanged += new System.EventHandler(this.txtano_TextChanged);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(165, 117);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(39, 19);
            this.lbAno.TabIndex = 14;
            this.lbAno.Text = "Año";
            // 
            // txtmes
            // 
            this.txtmes.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmes.Location = new System.Drawing.Point(78, 113);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(43, 27);
            this.txtmes.TabIndex = 13;
            this.txtmes.TextChanged += new System.EventHandler(this.txtmes_TextChanged);
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(35, 117);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(37, 19);
            this.lbMes.TabIndex = 12;
            this.lbMes.Text = "Mes";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(190, 54);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(183, 27);
            this.txtnumero.TabIndex = 11;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // lbTarjeta
            // 
            this.lbTarjeta.AutoSize = true;
            this.lbTarjeta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjeta.Location = new System.Drawing.Point(44, 58);
            this.lbTarjeta.Name = "lbTarjeta";
            this.lbTarjeta.Size = new System.Drawing.Size(140, 19);
            this.lbTarjeta.TabIndex = 10;
            this.lbTarjeta.Text = "Número de tarjeta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(115, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TarjetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(431, 266);
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
            this.Name = "TarjetaForm";
            this.Text = "Tarjeta";
            this.Load += new System.EventHandler(this.Tarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagarTarjeta;
        private System.Windows.Forms.TextBox txtcvc;
        private System.Windows.Forms.Label lbCv;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lbTarjeta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}