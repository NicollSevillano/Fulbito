namespace GUI
{
    partial class Ayudaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayudaform));
            this.panelContenedor = new System.Windows.Forms.SplitContainer();
            this.lstPreguntas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelContenedor)).BeginInit();
            this.panelContenedor.Panel1.SuspendLayout();
            this.panelContenedor.Panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            // 
            // panelContenedor.Panel1
            // 
            this.panelContenedor.Panel1.Controls.Add(this.lstPreguntas);
            // 
            // panelContenedor.Panel2
            // 
            this.panelContenedor.Panel2.Controls.Add(this.button1);
            this.panelContenedor.Panel2.Controls.Add(this.txtRespuesta);
            this.panelContenedor.Size = new System.Drawing.Size(578, 420);
            this.panelContenedor.SplitterDistance = 192;
            this.panelContenedor.TabIndex = 3;
            // 
            // lstPreguntas
            // 
            this.lstPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPreguntas.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPreguntas.FormattingEnabled = true;
            this.lstPreguntas.ItemHeight = 18;
            this.lstPreguntas.Location = new System.Drawing.Point(0, 0);
            this.lstPreguntas.Name = "lstPreguntas";
            this.lstPreguntas.Size = new System.Drawing.Size(192, 420);
            this.lstPreguntas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRespuesta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(0, 0);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(382, 420);
            this.txtRespuesta.TabIndex = 1;
            // 
            // Ayudaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(578, 420);
            this.Controls.Add(this.panelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ayudaform";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.panelContenedor.Panel1.ResumeLayout(false);
            this.panelContenedor.Panel2.ResumeLayout(false);
            this.panelContenedor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelContenedor)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer panelContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.ListBox lstPreguntas;
    }
}