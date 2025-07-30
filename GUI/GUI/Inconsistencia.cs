using Interface;
using ServicioClase;
using Servicios;
using System;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Inconsistencia : Form, ITraducible
    {
        private bool reparada = false;
        private int _idiomaId;

        public Inconsistencia(int idiomaId)
        {
            InitializeComponent();
            this._idiomaId = idiomaId;
            this.FormClosing += Inconsistencia_FormClosing;
            CargarInconsistencias();
        }

        private void Inconsistencia_Load(object sender, EventArgs e)
        {
            LanguageManager.Suscribir(this);
            LanguageManager.Actualizar(_idiomaId);
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
                var errores = dv.VerificarTabla(tabla);
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
                {
                    dv.RecalcularDVH(tabla);  // ✅ Ahora todo lo hace desde la clase DigitoVerificador
                    dv.RecalcularDVV(tabla);
                }

                if (!HayErrores(out string errores))
                {
                    reparada = true;
                    MessageBox.Show("Integridad reparada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    textBox1.Text = errores;
                    MessageBox.Show("Aún existen inconsistencias en la base de datos. Por favor, verifique los datos o consulte a un administrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recalcular la integridad: " + ex.Message);
            }
        }

        private bool HayErrores(out string erroresStr)
        {
            StringBuilder sb = new StringBuilder();
            bool hayErrores = false;

            string[] tablas = { "Cliente", "Cancha", "Reserva" };
            DigitoVerificador dv = new DigitoVerificador();

            foreach (var tabla in tablas)
            {
                var errores = dv.VerificarTabla(tabla);
                foreach (var err in errores)
                {
                    hayErrores = true;
                    sb.AppendLine($"Tabla: {tabla}, {err}");
                }
            }

            erroresStr = sb.ToString();
            return hayErrores;
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            btnRecalcular.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnRecalcular").Texto;
            btnRestaurarInc.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnRestaurarInc").Texto;
            lbInconsistencias.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbInconsistencias").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "Inconsistencia").Texto;
        }

        private void btnRestaurarInc_Click(object sender, EventArgs e)
        {
            // Queda pendiente si querés implementar lógica adicional.
        }
    }
}
