namespace GUI
{
    partial class AlquilarInsumos
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
            this.stock1 = new Controles.Stock();
            this.SuspendLayout();
            // 
            // stock1
            // 
            this.stock1.Location = new System.Drawing.Point(26, 163);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(186, 53);
            this.stock1.TabIndex = 0;
            // 
            // AlquilarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stock1);
            this.Name = "AlquilarInsumos";
            this.Text = "AlquilarInsumos";
            this.Load += new System.EventHandler(this.AlquilarInsumos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Stock stock1;
    }
}