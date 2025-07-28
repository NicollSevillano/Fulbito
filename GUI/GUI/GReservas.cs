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
            lCliente = blCliente.Consulta();
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

            if (cmbCancha.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna cancha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un horario de la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BeCancha bcancha = ObtenerCancha();
            BeCliente bcliente = ObtenerCliente();

            if (bcancha == null)
            {
                MessageBox.Show("No se encontró la cancha seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bcliente == null)
            {
                MessageBox.Show("No se encontró el cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<BeReserva> reservas = new List<BeReserva>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var horaCell = row.Cells[1].Value;
                if (horaCell == null || string.IsNullOrEmpty(horaCell.ToString()))
                {
                    MessageBox.Show("La hora seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                TimeSpan horarioEntrada;
                if (!TimeSpan.TryParse(horaCell.ToString(), out horarioEntrada))
                {
                    MessageBox.Show("El formato de la hora no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                BeReserva nuevaReserva = new BeReserva(bcancha, bcliente, dateTimePicker1.Value.Date, horarioEntrada, false);
                reservas.Add(nuevaReserva);
                var dv = new DigitoVerificador();
                dv.RecalcularTablaVertical("Reserva");
            }

            if (reservas.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un horario válido para reservar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (BeReserva reserva in reservas)
                {
                    blReserva.Alta(reserva);
                }

                lReserva = blReserva.Consulta();
                Refrescar();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows.Cast<DataGridViewRow>().ToList())
                {
                    dataGridView1.Rows.Remove(row);
                }

                LogBitacora.AgregarEvento("Reserva de cancha", 3, SessionManager.getInstance.usuario, "Reservas");
                MessageBox.Show("¡Reserva realizada con éxito! No se olvide de pagar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarColoresPagado()
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                bool pagado = row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "Sí";
                bool cancelada = row.Cells[6].Value != null && row.Cells[6].Value.ToString() == "Sí";

                if (cancelada)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (pagado)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private BeCancha ObtenerCancha()
        {
            string aux = cmbCancha.Text;
            return lCancha.Find(x => x.Nombre == aux);
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
                .Where(r => r.Cancha.Nombre == canchaSeleccionada
                    && r.Fecha.Date == fechaSeleccionada
                    && !r.Cancelada) 
                .ToList();

            List<BeHorarios> horariosDisponibles = horarios
                .Where(h => !reservasExistentes.Any(r => r.Hora.Equals(h.HoraEntrada)))
                .ToList();

            foreach (BeHorarios h in horariosDisponibles)
            {
                dataGridView1.Rows.Add(h.id, h.HoraEntrada.ToString(@"hh\:mm\:ss"), h.HoraSalida.ToString(@"hh\:mm\:ss"));
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

            if (!dgvReservas.Columns.Contains("Cancelada"))
            {
                DataGridViewTextBoxColumn colCancelada = new DataGridViewTextBoxColumn();
                colCancelada.Name = "Cancelada";
                colCancelada.HeaderText = "Cancelada";
                colCancelada.Visible = false; 
                dgvReservas.Columns.Add(colCancelada);
            }

            lReserva = blReserva.Consulta();

            foreach (BeReserva r in lReserva)
            {
                dgvReservas.Rows.Add(
                    r.id,
                    r.Cancha != null ? r.Cancha.Nombre : "[Cancha nula]",
                    r.Cliente != null ? r.Cliente.Nombre : "[Cliente nulo]",
                    r.Fecha.ToShortDateString(),
                    r.Hora.ToString(),
                    r.Pagado ? "Sí" : "No",
                    r.Cancelada ? "Sí" : "No"
                );
            }

            AplicarColoresPagado();
        }


        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0) { MessageBox.Show("Tiene que seleccionar una reserva"); return; }
            CobrarForm cobrarReserva = new CobrarForm(LlamarReserva());
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

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cancelar la reserva?", "Cancelar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            int id = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells[0].Value);

            blReserva.Cancelar(id);

            lReserva = blReserva.Consulta();
            Refrescar();
            btnDisponibilidad_Click(null, null);

            MessageBox.Show("Reserva cancelada y horario liberado.");
        }


        private void btnCobrar_Click_1(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tiene que seleccionar una reserva");
                return;
            }
            CobrarForm cobrarReserva = new CobrarForm(LlamarReserva())
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
