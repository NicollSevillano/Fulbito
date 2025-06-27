using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Calendario : UserControl
    {
        public Calendario()
        {
            InitializeComponent();
        }
        DateTime dateTime;
        int horaInicio = 0;
        int horaFinal = 0;

        public void ConfiguracionHoras(int pInicial, int pFinal)
        {
            horaInicio = pInicial;
            horaFinal = pFinal;
            this.numericUpDown1.Value = pInicial;
        }
        
        private void Calendario_Load(object sender, EventArgs e)
        {

        }
        public DateTime escribirDia()
        {
            btnAsignar_Click(null, null);
            return dateTime;
        }
        public Button boton()
        {
            return this.btnAsignar;
        }
        public NumericUpDown numeric()
        {
            return this.numericUpDown1;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int hora = (int)numericUpDown1.Value;
            if (hora < horaInicio) numericUpDown1.Value = horaFinal;
            if (hora > horaFinal) numericUpDown1.Value = horaInicio;
        }


        private void btnAsignar_Click(object sender, EventArgs e)
        {
            DateTime asignar = this.monthCalendar1.SelectionStart;
            int hora = (int)this.numericUpDown1.Value;
            dateTime = new DateTime(asignar.Year, asignar.Month, asignar.Day, hora, 00, 00);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string completeDate = dateTimePicker1.Text;
            string[] date = completeDate.Split(':');
            if (int.Parse(date[0]) < horaInicio) date[0] = horaFinal.ToString();
            if (int.Parse(date[0]) == horaFinal && int.Parse(date[1]) == 59 && int.Parse(date[2]) > 58) { date[0] = horaInicio.ToString(); date[1] = "00"; date[2] = "00"; }
            string newDate = $"{date[0]}:{date[1]}:{date[2]}";
            dateTimePicker1.Text = newDate;
        }
    }
}
