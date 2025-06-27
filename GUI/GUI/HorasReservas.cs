using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be;
using Bll;
using Mapper;

namespace GUI
{
    public partial class HorasReservas: Form
    {
        public HorasReservas()
        {
            InitializeComponent();
        }
        BllReserva blReserva;
        BllCancha blCancha;
        List<BeCancha> lCancha;
        List<BeReserva> lReserva;
        private void HorasReservas_Load(object sender, EventArgs e)
        {
            blReserva = new BllReserva();
            lReserva = blReserva.Consulta();
            blCancha = new BllCancha();
            lCancha = blCancha.Consulta();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DateTime dtp = dateTimePicker1.Value.Date;
            foreach (BeReserva rs in lReserva)
            {
                DateTime fecha = rs.Fecha.Date;
                if (fecha == dtp)
                {
                    dataGridView1.Rows.Add(rs.id, rs.Cancha.Nombre, rs.Cliente.Nombre, rs.Fecha.ToShortDateString(), rs.Hora.ToString(), rs.Pagado ? "Sí" : "No");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
