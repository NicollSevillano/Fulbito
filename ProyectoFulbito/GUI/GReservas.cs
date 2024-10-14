using Be;
using Bll;
using Interface;
using ServicioClase;
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
    public partial class GReservasForm : Form, ITraducible
    {
        public GReservasForm()
        {
            InitializeComponent();
        }
        public SessionManager smanager;
        List<BeCliente> lCliente;
        List<BeCancha> lCancha;
        List<BeReserva> lReserva;
        BeReserva breserva = new BeReserva();
        BllReserva blReserva;
        BllCliente blCliente;
        GRegistrarClienteForm regisCliente;
        private void GReservas_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;
            dateTimePicker1.MinDate = fechaActual;
            monthCalendar1.MinDate = fechaActual;
            lCancha = new List<BeCancha>();
            blCliente = new BllCliente();
            blReserva = new BllReserva();
            lReserva = blReserva.Consulta();
            lCliente = blCliente.Consulta();
            regisCliente = new GRegistrarClienteForm();
            lCliente = blCliente.Consulta();
            ValidarCliente();
            Canchas();
        }
        private bool CargarTXT()
        {
            bool cargar = false;
            if (txtDni.Text == string.Empty)
            {
                cargar = true;
            }
            return cargar;
        }
        private bool ValidarCliente()
        {
            string dni = txtDni.Text;
            if (lCliente.Exists(x => x.DNI == dni))
            {
                btnRegistrar.Enabled = false;
                return true;
            }
            else
            {
                btnRegistrar.Enabled = true;
                return false;
            }

        }
        private void Canchas()
        {
            cmbCancha.Items.Clear();
            BllCancha blCancha = new BllCancha();
            lCancha = blCancha.Consulta();
            foreach (BeCancha l in lCancha)
            {
                cmbCancha.Items.Add(l.Nombre);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (ValidarCliente())
            {
                BeCancha bcancha1 = ObtenerCancha();
                BeCliente bcliente1 = ObtenerCliente();

                BeReserva reserva;
                reserva = new BeReserva(bcancha1, bcliente1, DateTime.Parse(dateTimePicker1.Text), TimeSpan.Parse(txtHorario.Text));
                blReserva.Alta(reserva);
                lReserva = blReserva.Consulta();
                Refrescar();
                LogBitacora.AgregarEvento("Reserva de cancha", 3, SessionManager.getInstance.usuario);
                MessageBox.Show("No se olvide de pagar la reserva!!");
            }
            else
            {
                MessageBox.Show("Debe registrar al cliente para reservar");
            }
        }
        private BeCancha ObtenerCancha()
        {
            string aux = cmbCancha.Text;
            BeCancha cancha = lCancha.Find(x => x.Nombre == aux);
            return cancha;
        }
        private BeCliente ObtenerCliente()
        {
            lCliente = blCliente.Consulta();
            string aux = txtDni.Text;
            BeCliente cliente = lCliente.Find(x => x.DNI == aux);
            return cliente;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Usted está por cancelar la reserva", "Cancelar reserva", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                txtDni.Clear();
                txtHorario.Clear();
                cmbCancha.SelectedIndex = -1;
                LogBitacora.AgregarEvento("Cancelar reserva", 1, SessionManager.getInstance.usuario);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GRegistrarClienteForm gRegistrarC = new GRegistrarClienteForm();
            gRegistrarC.Hide();
            LogBitacora.AgregarEvento("Registrar cliente", 2, SessionManager.getInstance.usuario);
            gRegistrarC.ShowDialog();
            lCliente = blCliente.Consulta();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            Refrescar();
            LogBitacora.AgregarEvento("Ver disponibilidad", 1, SessionManager.getInstance.usuario);
        }
        private BeReserva LlamarReserva()
        {
            return lReserva.Find(x => x.id == dgvReservas.SelectedRows[0].Cells[0].Value.ToString());
        }
        public void Refrescar()
        {
            dgvReservas.Rows.Clear();
            foreach (BeReserva r in lReserva)
            {
                dgvReservas.Rows.Add(r.id, r.Cancha.Nombre, r.Cliente.Nombre, r.Fecha, r.Hora);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0) { MessageBox.Show("Tiene que seleccionar una reserva"); return; }
            CobrarReservaForm cobrarReserva = new CobrarReservaForm(LlamarReserva());
            LanguageManager.Suscribir(cobrarReserva);
            cobrarReserva.Hide();
            LogBitacora.AgregarEvento("Pagar reserva", 3, SessionManager.getInstance.usuario);
            cobrarReserva.ShowDialog();
        }
        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labCancha.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labCancha").Texto;
            labDni.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labDni").Texto;
            labFecha.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labFecha").Texto;
            labHorario.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labHorario").Texto;
            btnDisponibilidad.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnDisponibilidad").Texto;
            btnRegistrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnRegistrar").Texto;
            btnCobrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCobrar").Texto;
            btnReservar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnReservar").Texto;
            ColumnaIdR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaIdR").Texto;
            ColumnaCanchaR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaCanchaR").Texto;
            ColumnaClienteR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaClienteR").Texto;
            ColumnaFechaR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaFechaR").Texto;
            ColumnaHorarioR.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaHorarioR").Texto;
            btnSalirR.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalirR").Texto;
            //btnCancelarReserva.Text = _idioma.lEtiqueta.Find(X => X.ControlT == "btnCancelarReserva").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "GReservasForm").Texto;
        }

        private void btnSalirR_Click(object sender, EventArgs e)
        {
            this.Close();
            LogBitacora.AgregarEvento("Salir de reservas", 1, SessionManager.getInstance.usuario);
        }
    }
}
