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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GReservasForm : Form, ITraducible
    {
        public SessionManager smanager;
        List<BeCliente> lCliente;
        List<BeCancha> lCancha;
        List<BeReserva> lReserva;
        BeReserva breserva = new BeReserva();
        BllReserva blReserva;
        BllCliente blCliente;
        PerfilesForm registroReservas;
        GRegistrarClienteForm regisCliente;
        HorasReservas hReservas;

        BllHorarios blHorarios;
        List<BeHorarios> lHora;
        public GReservasForm()
        {
            InitializeComponent();
        }
        private void GReservas_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;
            dateTimePicker1.MinDate = fechaActual;
            lCancha = new List<BeCancha>();
            blCliente = new BllCliente();
            blReserva = new BllReserva();
            lReserva = blReserva.Consulta();
            lCliente = blCliente.Consulta();
            regisCliente = new GRegistrarClienteForm();
            lCliente = blCliente.Consulta();
            ValidarCliente();
            Canchas();
            Clientes();
            blHorarios = new BllHorarios();
            lHora = blHorarios.Consulta();
            Refrescar();
        }
        private bool ValidarCliente()
        {
            if (cmbClientes.SelectedItem == null)
            {
                btnRegistrar.Enabled = true;
                return false;
            }

            BeCliente aux = cmbClientes.SelectedItem as BeCliente;

            if (aux != null && lCliente.Exists(x => x.id == aux.id))
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
        private void Clientes()
        {
            cmbClientes.Items.Clear();
            BllCliente aux = new BllCliente();
            lCliente = aux.Consulta();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "id";
            foreach (BeCliente cliente in lCliente)
            {
                cmbClientes.Items.Add(cliente); 
            }
        }
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            BeCliente aux = (BeCliente)cmbClientes.SelectedItem;
            txtInformacion.Text = $"Nombre: {aux.Nombre}{Environment.NewLine}" +
                                  $"DNI: {aux.DNI}{Environment.NewLine}" +
                                  $"Teléfono: {aux.Telefono}{Environment.NewLine}" +
                                  $"Dirección: {aux.Direccion}";
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
            cmbClientes.Refresh();
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado ningún cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCliente())
            {
                MessageBox.Show("Debe registrar al cliente para reservar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un horario de la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BeCancha bcancha1 = ObtenerCancha();
            BeCliente bcliente1 = ObtenerCliente();
            List<BeReserva> reservas = new List<BeReserva>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                TimeSpan horarioEntrada = TimeSpan.Parse(row.Cells[1].Value.ToString());
                BeReserva nuevaReserva = new BeReserva(bcancha1, bcliente1, dateTimePicker1.Value.Date, horarioEntrada, false);
                reservas.Add(nuevaReserva);
            }

            if (reservas.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un horario para reservar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (BeReserva reserva in reservas)
            {
                bool yaExiste = dgvReservas.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells[1].Value.ToString() == reserva.Cancha.Nombre &&
                                row.Cells[3].Value.ToString() == reserva.Fecha.ToShortDateString() &&
                                row.Cells[4].Value.ToString() == reserva.Hora.ToString());

                if (!yaExiste)
                {
                    blReserva.Alta(reserva); 
                    dgvReservas.Rows.Add(reserva.id, reserva.Cancha.Nombre, reserva.Cliente.Nombre, reserva.Fecha.ToShortDateString(), reserva.Hora.ToString(), reserva.Pagado ? "Sí" : "No");
                }
            }

            lReserva = blReserva.Consulta();
            Refrescar();
            AplicarColoresPagado();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows.Cast<DataGridViewRow>().ToList())
            {
                dataGridView1.Rows.Remove(row);
            }

            LogBitacora.AgregarEvento("Reserva de cancha", 3, SessionManager.getInstance.usuario, "Reservas");
            MessageBox.Show("¡Reserva realizada con éxito! No se olvide de pagar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AplicarColoresPagado()
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "Sí")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
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
            if (cmbClientes.SelectedItem == null)
                return null;

            return cmbClientes.SelectedItem as BeCliente;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado =  MessageBox.Show("¿Desea cancelar la reserva?","Salir", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GRegistrarClienteForm gRegistrarC = new GRegistrarClienteForm();
            gRegistrarC.Hide();
            LogBitacora.AgregarEvento("Registrar cliente", 2, SessionManager.getInstance.usuario, "Registrar reservas");
            gRegistrarC.ShowDialog();
            lCliente = blCliente.Consulta();
        }
        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string canchaSeleccionada = cmbCancha.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(canchaSeleccionada))
            {
                MessageBox.Show("Seleccione una cancha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

            List<BeHorarios> horarios = blHorarios.Consulta();
            if (horarios.Count == 0)
            {
                MessageBox.Show("No hay horarios disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<BeReserva> reservasExistentes = blReserva.Consulta()
                .Where(r => r.Cancha.Nombre == canchaSeleccionada && r.Fecha.Date == fechaSeleccionada)
                .ToList();

            List<BeHorarios> horariosDisponibles = horarios
                .Where(h => !reservasExistentes.Any(r => r.Hora == h.HoraEntrada))
                .ToList();

            foreach (BeHorarios h in horariosDisponibles)
            {
                dataGridView1.Rows.Add(h.id, h.HoraEntrada, h.HoraSalida);
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay horarios disponibles para la cancha seleccionada en esta fecha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private BeReserva LlamarReserva()
        {
            return lReserva.Find(x => x.id == dgvReservas.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Refrescar()
        {
            dgvReservas.Rows.Clear();

            foreach (BeReserva r in lReserva)
            {
                dgvReservas.Rows.Add(r.id, r.Cancha.Nombre, r.Cliente.Nombre, r.Fecha.ToShortDateString(), r.Hora.ToString(), r.Pagado ? "Sí" : "No");
            }

            AplicarColoresPagado(); 
        }
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0) { MessageBox.Show("Tiene que seleccionar una reserva"); return; }
            CobrarReservaForm cobrarReserva = new CobrarReservaForm(LlamarReserva());
            LanguageManager.Suscribir(cobrarReserva);
            cobrarReserva.Hide();
            LogBitacora.AgregarEvento("Pagar reserva", 3, SessionManager.getInstance.usuario, "Cobrar reserva");
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
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "GReservasForm").Texto;
        }
        private void btnSalirR_Click(object sender, EventArgs e)
        {
            this.Close();
            LogBitacora.AgregarEvento("Salir de reservas", 1, SessionManager.getInstance.usuario, "Salir de las reservas");
        }
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Usted está por cancelar la reserva", "Cancelar reserva", MessageBoxButtons.YesNo);
            if (resultado != DialogResult.Yes) return;

            string id = dgvReservas.SelectedRows[0].Cells[0].Value.ToString();
            BeReserva aux = blReserva.Consulta().Find(x => x.id == id);

            if (aux != null)
            {
                foreach (DataGridViewCell cell in dgvReservas.SelectedRows[0].Cells)
                {
                    cell.Style.BackColor = Color.Yellow;
                    cell.Style.ForeColor = Color.Black;
                }

                MessageBox.Show("Color cambiado a amarillo.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCobrar_Click_1(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tiene que seleccionar una reserva");
                return;
            }
            CobrarReservaForm cobrarReserva = new CobrarReservaForm(LlamarReserva())
            {
                Owner = this 
            };
            LanguageManager.Suscribir(cobrarReserva);
            LogBitacora.AgregarEvento("Pagar reserva", 3, SessionManager.getInstance.usuario, "Pagar reservas");

            cobrarReserva.ShowDialog(); 
        }
        public void ActualizarGrilla()
        {
            dgvReservas.DataSource = null;  

            if (dgvReservas.Columns.Count > 0)
            {
                dgvReservas.Columns.Clear();
            }
            dgvReservas.DataSource = blReserva.Consulta();
            dgvReservas.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hReservas = new HorasReservas();
            this.Hide();
            hReservas.ShowDialog();
            this.Show();
        }
    }
}
