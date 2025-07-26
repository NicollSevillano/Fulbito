using Servicios;
using System;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Inconsistencia : Form
    {
        private bool reparada = false;

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

        public void CargarInconsistencias()
        {
            StringBuilder sb = new StringBuilder();
            string[] tablas = { "Cliente", "Cancha", "Reserva" };
            DigitoVerificador dv = new DigitoVerificador();

            foreach (var tabla in tablas)
            {
                var errores = dv.VerificarTabla(tabla); // 👈 método correcto
                foreach (var err in errores)
                    sb.AppendLine($"Tabla: {tabla}, {err}");
            }

            textBox1.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] tablas = { "Cliente", "Cancha", "Reserva" };
                DigitoVerificador dv = new DigitoVerificador();

                foreach (var tabla in tablas)
                    dv.RecalcularTablaVertical(tabla);

                StringBuilder sb = new StringBuilder();
                bool hayErrores = false;

                foreach (var tabla in tablas)
                {
                    var errores = dv.VerificarTabla(tabla); 
                    foreach (var err in errores)
                    {
                        hayErrores = true;
                        sb.AppendLine($"Tabla: {tabla}, {err}");
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
