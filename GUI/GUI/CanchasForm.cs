using Be;
using Bll;
using Mapper;
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
    public partial class ControlCanchasform : Form
    {
        List<BeCancha> lCancha;
        BllCancha bllCancha;
        MapperReserva mReserva;
        public ControlCanchasform()
        {
            InitializeComponent();
            cmbEstadoCancha.Items.Add("Disponible");
            cmbEstadoCancha.Items.Add("En mantenimiento");
            cmbEstadoCancha.Items.Add("No disponible");
        }
        private void ControlCanchasform_Load(object sender, EventArgs e)
        {
            bllCancha = new BllCancha();
            lCancha = bllCancha.Consulta();
            mReserva = new MapperReserva();
            RefrescarCancha();
        }
        private bool DatosCompletos()
        {
            return !string.IsNullOrWhiteSpace(txtTipoCancha.Text) &&
                   !string.IsNullOrWhiteSpace(txtPrecioCancha.Text) &&
                   !string.IsNullOrWhiteSpace(txtCapacidadCancha.Text);
        }
        private void btnAltaCancha_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatosCompletos())
                {
                    decimal precio;
                    int capacidad;
                    if (!decimal.TryParse(txtPrecioCancha.Text, out precio))
                    {
                        MessageBox.Show("Precio inválido");
                        return;
                    }
                    if (!int.TryParse(txtCapacidadCancha.Text, out capacidad))
                    {
                        MessageBox.Show("Capacidad inválida");
                        return;
                    }
                    var nuevaCancha = new BeCancha(
                        txtTipoCancha.Text,
                        precio,
                        capacidad,
                        cmbEstadoCancha.SelectedItem?.ToString() ?? "Disponible",
                        textBox5.Text
                    );
                    bllCancha.Alta(nuevaCancha);
                    new DigitoVerificador().RecalcularTablaVertical("Cancha");
                    lCancha = bllCancha.Consulta();
                    RefrescarCancha();
                    LogBitacora.AgregarEvento("Agregar cancha", 1, SessionManager.getInstance.usuario, "Canchas");
                    MessageBox.Show("Cancha agregada");
                }
                else
                {
                    MessageBox.Show("Complete todos los campos obligatorios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede dar de alta la cancha. " + ex.Message);
            }
        }
        private void RefrescarCancha()
        {
            dgvCanchas.Rows.Clear();
            foreach (BeCancha cancha in lCancha)
            {
                dgvCanchas.Rows.Add(cancha.id, cancha.Nombre, cancha.Precio, cancha.Capacidad, cancha.Estado, cancha.Observaciones);
            }
        }
        private void btnBajaCancha_Click(object sender, EventArgs e)
        {
            try
            {
                BeCancha _cancha = ObtenerCancha();
                if (_cancha == null) { MessageBox.Show("Seleccione una cancha."); return; }

                BllReserva blReserva = new BllReserva();
                List<BeReserva> lReservas = blReserva.Consulta();
                List<BeReserva> reservas = lReservas.FindAll(x => x.Cancha.id == _cancha.id);
                foreach (BeReserva r in reservas)
                {
                    blReserva.Baja(int.Parse(r.id));
                }
                bllCancha.Baja(int.Parse(_cancha.id));
                new DigitoVerificador().RecalcularTablaVertical("Cancha");
                lCancha = bllCancha.Consulta();
                LogBitacora.AgregarEvento("Eliminar cancha", 2, SessionManager.getInstance.usuario, "Cancha");
                MessageBox.Show("Cancha eliminada");
                RefrescarCancha();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la cancha. " + ex.Message);
            }
        }
        private BeCancha ObtenerCancha()
        {
            if (dgvCanchas.SelectedRows.Count == 0) return null;
            var id = dgvCanchas.SelectedRows[0].Cells[0].Value.ToString();
            return lCancha.Find(x => x.id == id);
        }
        private void btnModificarCancha_Click(object sender, EventArgs e)
        {
            try
            {
                BeCancha modificarCancha = ObtenerCancha();
                if (modificarCancha == null) { MessageBox.Show("Seleccione una cancha."); return; }

                if (DatosCompletos())
                {
                    decimal precio;
                    int capacidad;
                    if (!decimal.TryParse(txtPrecioCancha.Text, out precio))
                    {
                        MessageBox.Show("Precio inválido");
                        return;
                    }
                    if (!int.TryParse(txtCapacidadCancha.Text, out capacidad))
                    {
                        MessageBox.Show("Capacidad inválida");
                        return;
                    }
                    modificarCancha.Nombre = txtTipoCancha.Text;
                    modificarCancha.Precio = precio;
                    modificarCancha.Capacidad = capacidad;
                    modificarCancha.Estado = cmbEstadoCancha.SelectedItem?.ToString() ?? "Disponible";
                    modificarCancha.Observaciones = textBox5.Text;

                    bllCancha.Modificacion(modificarCancha);
                    new DigitoVerificador().RecalcularTablaVertical("Cancha");
                    lCancha = bllCancha.Consulta();
                    RefrescarCancha();
                    MessageBox.Show("Cancha modificada");
                }
                else
                {
                    MessageBox.Show("Complete todos los campos obligatorios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnFiltrarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                string filtroCombo = cmbEstadoCancha.SelectedItem?.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de filtrado " + ex.Message);
            }
        }
        private void FiltroEstado()
        {
            try
            {
                dgvCanchas.Rows.Clear();
                foreach (BeCancha c in lCancha)
                {
                    dgvCanchas.Rows.Add(new object[] { c.id, c.Nombre, c.Precio, c.Capacidad, c.Estado, c.Observaciones });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de filtrado " + ex.Message);
            }
        }

        private void btnEstadoCancha_Click(object sender, EventArgs e)
        {
            BeCancha cancha = ObtenerCancha();
            if (cancha == null)
            {
                MessageBox.Show("Seleccione una cancha para cambiar su estado.");
                return;
            }
            string nuevoEstado = cmbEstadoCancha.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nuevoEstado))
            {
                MessageBox.Show("Seleccione un estado nuevo.");
                return;
            }
            bllCancha.CambiarEstado(int.Parse(cancha.id), nuevoEstado);
            lCancha = bllCancha.Consulta();
            RefrescarCancha();
            MessageBox.Show("Estado actualizado.");
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            try
            {
                BeCancha cancha = ObtenerCancha();
                if (cancha == null) { MessageBox.Show("Seleccione una cancha."); return; }

                bllCancha.CambiarObservaciones(int.Parse(cancha.id), textBox5.Text);
                lCancha = bllCancha.Consulta();
                RefrescarCancha();
                MessageBox.Show("Observaciones actualizadas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la observación: " + ex.Message);
            }
        }

        private void dgvCanchas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCanchas.Rows[e.RowIndex];
                txtTipoCancha.Text = row.Cells[1].Value?.ToString();
                txtPrecioCancha.Text = row.Cells[2].Value?.ToString();
                txtCapacidadCancha.Text = row.Cells[3].Value?.ToString();
                cmbEstadoCancha.SelectedItem = row.Cells[4].Value?.ToString();
                textBox5.Text = row.Cells[5].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
