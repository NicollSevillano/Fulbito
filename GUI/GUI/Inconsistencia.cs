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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DigitoVerificador dv = new DigitoVerificador();

                StringBuilder sb = new StringBuilder();

                string[] tablas = { "Cliente", "Cancha", "Reserva" };

                foreach (var tabla in tablas)
                {
                    dv.RecalcularTablas(tabla);

                    dv.RecalcularTablaVertical(tabla);

                    var inconsistencias = dv.VerificarTabla(tabla);

                    if (inconsistencias.Count == 0)
                        sb.AppendLine($"Tabla: {tabla}, Integridad OK");
                    else
                        foreach (var msg in inconsistencias)
                            sb.AppendLine($"Tabla: {tabla}, {msg}");
                }

                textBox1.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error al verificar la integridad: " + ex.Message;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
