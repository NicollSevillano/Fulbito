namespace GUI
{
    partial class BackUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpForm));
            this.labRespaldo = new System.Windows.Forms.Label();
            this.lblRestaurar = new System.Windows.Forms.Label();
            this.txtBackUp = new System.Windows.Forms.TextBox();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pictureBoxRestore = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackUp = new System.Windows.Forms.PictureBox();
            this.btnVolverBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackUp)).BeginInit();
            this.SuspendLayout();
            // 
            // labRespaldo
            // 
            this.labRespaldo.AutoSize = true;
            this.labRespaldo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRespaldo.Location = new System.Drawing.Point(12, 27);
            this.labRespaldo.Name = "labRespaldo";
            this.labRespaldo.Size = new System.Drawing.Size(77, 19);
            this.labRespaldo.TabIndex = 0;
            this.labRespaldo.Text = "Respaldo:";
            // 
            // lblRestaurar
            // 
            this.lblRestaurar.AutoSize = true;
            this.lblRestaurar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurar.Location = new System.Drawing.Point(12, 162);
            this.lblRestaurar.Name = "lblRestaurar";
            this.lblRestaurar.Size = new System.Drawing.Size(79, 19);
            this.lblRestaurar.TabIndex = 1;
            this.lblRestaurar.Text = "Restaurar:";
            // 
            // txtBackUp
            // 
            this.txtBackUp.Location = new System.Drawing.Point(15, 67);
            this.txtBackUp.Name = "txtBackUp";
            this.txtBackUp.Size = new System.Drawing.Size(324, 20);
            this.txtBackUp.TabIndex = 2;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.Location = new System.Drawing.Point(15, 108);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(88, 36);
            this.btnBackUp.TabIndex = 3;
            this.btnBackUp.Text = "Realizar";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(15, 202);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(324, 20);
            this.txtRestore.TabIndex = 5;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(16, 242);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(88, 36);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Realizar";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pictureBoxRestore
            // 
            this.pictureBoxRestore.Image = global::GUI.Properties.Resources.restore;
            this.pictureBoxRestore.Location = new System.Drawing.Point(344, 188);
            this.pictureBoxRestore.Name = "pictureBoxRestore";
            this.pictureBoxRestore.Size = new System.Drawing.Size(75, 49);
            this.pictureBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestore.TabIndex = 7;
            this.pictureBoxRestore.TabStop = false;
            this.pictureBoxRestore.Click += new System.EventHandler(this.pictureBoxRestore_Click);
            // 
            // pictureBoxBackUp
            // 
            this.pictureBoxBackUp.Image = global::GUI.Properties.Resources.respaldo;
            this.pictureBoxBackUp.Location = new System.Drawing.Point(344, 51);
            this.pictureBoxBackUp.Name = "pictureBoxBackUp";
            this.pictureBoxBackUp.Size = new System.Drawing.Size(75, 49);
            this.pictureBoxBackUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackUp.TabIndex = 4;
            this.pictureBoxBackUp.TabStop = false;
            this.pictureBoxBackUp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVolverBack
            // 
            this.btnVolverBack.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverBack.Location = new System.Drawing.Point(331, 292);
            this.btnVolverBack.Name = "btnVolverBack";
            this.btnVolverBack.Size = new System.Drawing.Size(88, 36);
            this.btnVolverBack.TabIndex = 8;
            this.btnVolverBack.Text = "Volver";
            this.btnVolverBack.UseVisualStyleBackColor = true;
            this.btnVolverBack.Click += new System.EventHandler(this.btnVolverBack_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(429, 340);
            this.Controls.Add(this.btnVolverBack);
            this.Controls.Add(this.pictureBoxRestore);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.pictureBoxBackUp);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.txtBackUp);
            this.Controls.Add(this.lblRestaurar);
            this.Controls.Add(this.labRespaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackUpForm";
            this.Text = "Back up";
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRespaldo;
        private System.Windows.Forms.Label lblRestaurar;
        private System.Windows.Forms.TextBox txtBackUp;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.PictureBox pictureBoxBackUp;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.PictureBox pictureBoxRestore;
        private System.Windows.Forms.Button btnVolverBack;
    }
}