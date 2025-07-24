using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Inconsistencia : Form
    {
        public Inconsistencia()
        {
            InitializeComponent();
            this.FormClosing += Inconsistencia_FormClosing;
            CargarInconsistencias();
        }

        private void Inconsistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!reparada)
            {
                MessageBox.Show("Debe reparar la integridad antes de cerrar la aplicación.");
                e.Cancel = true;
            }
        }

        bool reparada = false;

        public void CargarInconsistencias()
        {
            DigitoVerificador dv = new DigitoVerificador();
            StringBuilder sb = new StringBuilder();
            string[] tablas = { "Cliente", "Cancha", "Reserva" };

            foreach (var tabla in tablas)
            {
                var inconsistencias = dv.VerificarTabla(tabla);
                if (inconsistencias.Count == 0)
                    sb.AppendLine($"Tabla: {tabla}, Integridad OK");
                else
                    foreach (var msg in inconsistencias)
                        sb.AppendLine($"Tabla: {tabla}, {msg}");
            }
            textBox1.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DigitoVerificador dv = new DigitoVerificador();
                string[] tablas = { "Cliente", "Cancha", "Reserva" };

                foreach (var tabla in tablas)
                {
                    dv.RecalcularTablas(tabla);
                    dv.RecalcularTablaVertical(tabla);
                }

                StringBuilder sb = new StringBuilder();
                bool hayErrores = false;
                foreach (var tabla in tablas)
                {
                    var inconsistencias = dv.VerificarTabla(tabla);
                    if (inconsistencias.Count == 0)
                        sb.AppendLine($"Tabla: {tabla}, Integridad OK");
                    else
                    {
                        hayErrores = true;
                        foreach (var msg in inconsistencias)
                            sb.AppendLine($"Tabla: {tabla}, {msg}");
                    }
                }
                textBox1.Text = sb.ToString();

                if (!hayErrores)
                {
                    reparada = true;
                    MessageBox.Show("Integridad reparada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    reparada = false;
                    MessageBox.Show("Aún existen inconsistencias en la base de datos. Por favor, verifique los datos o consulte a un administrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recalcular la integridad: " + ex.Message);
            }
        }
    }

}
