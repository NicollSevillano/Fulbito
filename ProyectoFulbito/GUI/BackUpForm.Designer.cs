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
            this.txtBackUp = new System.Windows.Forms.TextBox();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pictureBoxRestore = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackUp = new System.Windows.Forms.PictureBox();
            this.labRespaldo = new System.Windows.Forms.Label();
            this.labRestaurar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackUp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBackUp
            // 
            this.txtBackUp.Location = new System.Drawing.Point(27, 83);
            this.txtBackUp.Name = "txtBackUp";
            this.txtBackUp.Size = new System.Drawing.Size(324, 20);
            this.txtBackUp.TabIndex = 3;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.Location = new System.Drawing.Point(27, 132);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(88, 36);
            this.btnBackUp.TabIndex = 4;
            this.btnBackUp.Text = "Realizar";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(27, 265);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(324, 20);
            this.txtRestore.TabIndex = 6;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(27, 308);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(88, 36);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "Realizar";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pictureBoxRestore
            // 
            this.pictureBoxRestore.Image = global::GUI.Properties.Resources.restore;
            this.pictureBoxRestore.Location = new System.Drawing.Point(370, 249);
            this.pictureBoxRestore.Name = "pictureBoxRestore";
            this.pictureBoxRestore.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestore.TabIndex = 1;
            this.pictureBoxRestore.TabStop = false;
            this.pictureBoxRestore.Click += new System.EventHandler(this.pictureBoxRestore_Click);
            // 
            // pictureBoxBackUp
            // 
            this.pictureBoxBackUp.Image = global::GUI.Properties.Resources.respaldo;
            this.pictureBoxBackUp.Location = new System.Drawing.Point(370, 68);
            this.pictureBoxBackUp.Name = "pictureBoxBackUp";
            this.pictureBoxBackUp.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxBackUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackUp.TabIndex = 0;
            this.pictureBoxBackUp.TabStop = false;
            this.pictureBoxBackUp.Click += new System.EventHandler(this.pictureBoxBackUp_Click);
            // 
            // labRespaldo
            // 
            this.labRespaldo.AutoSize = true;
            this.labRespaldo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRespaldo.Location = new System.Drawing.Point(27, 35);
            this.labRespaldo.Name = "labRespaldo";
            this.labRespaldo.Size = new System.Drawing.Size(77, 19);
            this.labRespaldo.TabIndex = 8;
            this.labRespaldo.Text = "Respaldo:";
            // 
            // labRestaurar
            // 
            this.labRestaurar.AutoSize = true;
            this.labRestaurar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRestaurar.Location = new System.Drawing.Point(27, 223);
            this.labRestaurar.Name = "labRestaurar";
            this.labRestaurar.Size = new System.Drawing.Size(79, 19);
            this.labRestaurar.TabIndex = 9;
            this.labRestaurar.Text = "Restaurar:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(391, 347);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 36);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(498, 395);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.labRestaurar);
            this.Controls.Add(this.labRespaldo);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.txtBackUp);
            this.Controls.Add(this.pictureBoxRestore);
            this.Controls.Add(this.pictureBoxBackUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackUpForm";
            this.Text = "BackUpForm";
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackUp;
        private System.Windows.Forms.PictureBox pictureBoxRestore;
        private System.Windows.Forms.TextBox txtBackUp;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label labRespaldo;
        private System.Windows.Forms.Label labRestaurar;
        private System.Windows.Forms.Button btnVolver;
    }
}