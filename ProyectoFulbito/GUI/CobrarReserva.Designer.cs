namespace GUI
{
    partial class CobrarReservaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CobrarReservaForm));
            this.comboIdioma1 = new Controles.ComboIdioma();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btncPagar = new System.Windows.Forms.Button();
            this.lbNombreCobrar = new System.Windows.Forms.Label();
            this.lbClienteCobrar = new System.Windows.Forms.Label();
            this.listbCobrar = new System.Windows.Forms.ListBox();
            this.gpPago = new System.Windows.Forms.GroupBox();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.gpPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboIdioma1
            // 
            this.comboIdioma1.Location = new System.Drawing.Point(313, 12);
            this.comboIdioma1.Name = "comboIdioma1";
            this.comboIdioma1.Size = new System.Drawing.Size(134, 27);
            this.comboIdioma1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(342, 258);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 38);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btncPagar
            // 
            this.btncPagar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncPagar.Location = new System.Drawing.Point(225, 258);
            this.btncPagar.Name = "btncPagar";
            this.btncPagar.Size = new System.Drawing.Size(105, 38);
            this.btncPagar.TabIndex = 14;
            this.btncPagar.Text = "Pagar";
            this.btncPagar.UseVisualStyleBackColor = true;
            this.btncPagar.Click += new System.EventHandler(this.btncPagar_Click);
            // 
            // lbNombreCobrar
            // 
            this.lbNombreCobrar.AutoSize = true;
            this.lbNombreCobrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCobrar.Location = new System.Drawing.Point(81, 23);
            this.lbNombreCobrar.Name = "lbNombreCobrar";
            this.lbNombreCobrar.Size = new System.Drawing.Size(24, 19);
            this.lbNombreCobrar.TabIndex = 12;
            this.lbNombreCobrar.Text = "---";
            // 
            // lbClienteCobrar
            // 
            this.lbClienteCobrar.AutoSize = true;
            this.lbClienteCobrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteCobrar.Location = new System.Drawing.Point(12, 23);
            this.lbClienteCobrar.Name = "lbClienteCobrar";
            this.lbClienteCobrar.Size = new System.Drawing.Size(63, 19);
            this.lbClienteCobrar.TabIndex = 11;
            this.lbClienteCobrar.Text = "Cliente:";
            // 
            // listbCobrar
            // 
            this.listbCobrar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbCobrar.FormattingEnabled = true;
            this.listbCobrar.ItemHeight = 19;
            this.listbCobrar.Location = new System.Drawing.Point(12, 57);
            this.listbCobrar.Name = "listbCobrar";
            this.listbCobrar.Size = new System.Drawing.Size(207, 251);
            this.listbCobrar.TabIndex = 10;
            // 
            // gpPago
            // 
            this.gpPago.Controls.Add(this.rbDebito);
            this.gpPago.Controls.Add(this.rbEfectivo);
            this.gpPago.Controls.Add(this.rbTransferencia);
            this.gpPago.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPago.Location = new System.Drawing.Point(246, 79);
            this.gpPago.Name = "gpPago";
            this.gpPago.Size = new System.Drawing.Size(180, 139);
            this.gpPago.TabIndex = 13;
            this.gpPago.TabStop = false;
            this.gpPago.Text = "Tipos de pago";
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Location = new System.Drawing.Point(17, 103);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(151, 23);
            this.rbDebito.TabIndex = 5;
            this.rbDebito.Text = "Tarjeta de Débito";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Location = new System.Drawing.Point(17, 31);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(83, 23);
            this.rbEfectivo.TabIndex = 3;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.Location = new System.Drawing.Point(17, 67);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(120, 23);
            this.rbTransferencia.TabIndex = 4;
            this.rbTransferencia.Text = "Transferencia";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // CobrarReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(460, 330);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btncPagar);
            this.Controls.Add(this.lbNombreCobrar);
            this.Controls.Add(this.lbClienteCobrar);
            this.Controls.Add(this.listbCobrar);
            this.Controls.Add(this.gpPago);
            this.Controls.Add(this.comboIdioma1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CobrarReservaForm";
            this.Text = "CobrarReserva";
            this.Load += new System.EventHandler(this.CobrarReserva_Load);
            this.gpPago.ResumeLayout(false);
            this.gpPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ComboIdioma comboIdioma1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btncPagar;
        private System.Windows.Forms.Label lbNombreCobrar;
        private System.Windows.Forms.Label lbClienteCobrar;
        private System.Windows.Forms.ListBox listbCobrar;
        private System.Windows.Forms.GroupBox gpPago;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTransferencia;
    }
}