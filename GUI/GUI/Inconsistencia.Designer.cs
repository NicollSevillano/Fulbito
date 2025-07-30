namespace GUI
{
    partial class Inconsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inconsistencia));
            this.lbInconsistencias = new System.Windows.Forms.Label();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.btnRestaurarInc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInconsistencias
            // 
            this.lbInconsistencias.AutoSize = true;
            this.lbInconsistencias.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInconsistencias.Location = new System.Drawing.Point(12, 9);
            this.lbInconsistencias.Name = "lbInconsistencias";
            this.lbInconsistencias.Size = new System.Drawing.Size(198, 19);
            this.lbInconsistencias.TabIndex = 0;
            this.lbInconsistencias.Text = "Inconsistencias en la BD";
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecalcular.Location = new System.Drawing.Point(27, 52);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(153, 38);
            this.btnRecalcular.TabIndex = 1;
            this.btnRecalcular.Text = "Recalcular";
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestaurarInc
            // 
            this.btnRestaurarInc.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarInc.Location = new System.Drawing.Point(215, 52);
            this.btnRestaurarInc.Name = "btnRestaurarInc";
            this.btnRestaurarInc.Size = new System.Drawing.Size(153, 38);
            this.btnRestaurarInc.TabIndex = 2;
            this.btnRestaurarInc.Text = "Restaurar BD";
            this.btnRestaurarInc.UseVisualStyleBackColor = true;
            this.btnRestaurarInc.Click += new System.EventHandler(this.btnRestaurarInc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 201);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(234, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Inconsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(387, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRestaurarInc);
            this.Controls.Add(this.btnRecalcular);
            this.Controls.Add(this.lbInconsistencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inconsistencia";
            this.Text = "Inconsistencia";
            this.Load += new System.EventHandler(this.Inconsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInconsistencias;
        private System.Windows.Forms.Button btnRecalcular;
        private System.Windows.Forms.Button btnRestaurarInc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}