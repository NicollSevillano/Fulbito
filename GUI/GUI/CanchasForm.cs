using Be;
using Bll;
using Interface;
using Mapper;
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
    public partial class ControlCanchasform : Form, ITraducible
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
            mReserva = new MapperReserva();
            lCancha = bllCancha.Consulta();
            RefrescarCancha();
            LanguageManager.Suscribir(this);
            LanguageManager.Actualizar(int.Parse(SessionManager.getInstance.usuario.IdiomaId.id));
        }

        private bool DatosCompletos()
        {
            return !string.IsNullOrWhiteSpace(txtTipoCancha.Text)
                && !string.IsNullOrWhiteSpace(txtPrecioCancha.Text)
                && !string.IsNullOrWhiteSpace(txtCapacidadCancha.Text);
        }

        private void RefrescarCancha()
        {
            dgvCanchas.Rows.Clear();
            foreach (BeCancha cancha in lCancha)
            {
                dgvCanchas.Rows.Add(cancha.id, cancha.Nombre, cancha.Precio, cancha.Capacidad, cancha.Estado, cancha.Observaciones);
            }
        }

        private BeCancha ObtenerCancha()
        {
            if (dgvCanchas.SelectedRows.Count == 0) return null;
            string id = dgvCanchas.SelectedRows[0].Cells[0].Value.ToString();
            return lCancha.Find(x => x.id == id);
        }

        private void btnAltaCancha_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DatosCompletos())
                {
                    MessageBox.Show("Complete todos los campos obligatorios.");
                    return;
                }

                if (!decimal.TryParse(txtPrecioCancha.Text, out decimal precio))
                {
                    MessageBox.Show("Precio inválido.");
                    return;
                }

                if (!int.TryParse(txtCapacidadCancha.Text, out int capacidad))
                {
                    MessageBox.Show("Capacidad inválida.");
                    return;
                }

                BeCancha nuevaCancha = new BeCancha(
                    txtTipoCancha.Text,
                    precio,
                    capacidad,
                    cmbEstadoCancha.SelectedItem?.ToString() ?? "Disponible",
                    txtObservacionesCancha.Text
                );

                bllCancha.Alta(nuevaCancha);
                new DigitoVerificador().RecalcularTablaVertical("Cancha");
                lCancha = bllCancha.Consulta();
                RefrescarCancha();
                LogBitacora.AgregarEvento("Agregar cancha", 1, SessionManager.getInstance.usuario, "Canchas");
                MessageBox.Show("Cancha agregada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede dar de alta la cancha. " + ex.Message);
            }
        }

        private void btnBajaCancha_Click(object sender, EventArgs e)
        {
            try
            {
                BeCancha cancha = ObtenerCancha();
                if (cancha == null)
                {
                    MessageBox.Show("Seleccione una cancha.");
                    return;
                }

                BllReserva blReserva = new BllReserva();
                var reservas = blReserva.Consulta().FindAll(x => x.Cancha.id == cancha.id);
                reservas.ForEach(r => blReserva.Baja(int.Parse(r.id)));

                bllCancha.Baja(int.Parse(cancha.id));
                new DigitoVerificador().RecalcularTablaVertical("Cancha");
                lCancha = bllCancha.Consulta();
                RefrescarCancha();
                LogBitacora.AgregarEvento("Eliminar cancha", 2, SessionManager.getInstance.usuario, "Canchas");
                MessageBox.Show("Cancha eliminada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la cancha. " + ex.Message);
            }
        }

        private void btnModificarCancha_Click(object sender, EventArgs e)
        {
            try
            {
                BeCancha cancha = ObtenerCancha();
                if (cancha == null)
                {
                    MessageBox.Show("Seleccione una cancha.");
                    return;
                }

                if (!DatosCompletos())
                {
                    MessageBox.Show("Complete todos los campos obligatorios.");
                    return;
                }

                if (!decimal.TryParse(txtPrecioCancha.Text, out decimal precio))
                {
                    MessageBox.Show("Precio inválido.");
                    return;
                }

                if (!int.TryParse(txtCapacidadCancha.Text, out int capacidad))
                {
                    MessageBox.Show("Capacidad inválida.");
                    return;
                }

                cancha.Nombre = txtTipoCancha.Text;
                cancha.Precio = precio;
                cancha.Capacidad = capacidad;
                cancha.Estado = cmbEstadoCancha.SelectedItem?.ToString() ?? "Disponible";
                cancha.Observaciones = txtObservacionesCancha.Text;

                bllCancha.Modificacion(cancha);
                new DigitoVerificador().RecalcularTablaVertical("Cancha");
                lCancha = bllCancha.Consulta();
                RefrescarCancha();
                MessageBox.Show("Cancha modificada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la cancha. " + ex.Message);
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
                if (cancha == null)
                {
                    MessageBox.Show("Seleccione una cancha.");
                    return;
                }

                bllCancha.CambiarObservaciones(int.Parse(cancha.id), txtObservacionesCancha.Text);
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
                txtObservacionesCancha.Text = row.Cells[5].Value?.ToString();
            }
        }

        private void btnFiltrarEstado_Click(object sender, EventArgs e)
        {
            string estadoSeleccionado = cmbEstadoCancha.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(estadoSeleccionado))
            {
                MessageBox.Show("Seleccione un estado para filtrar.");
                return;
            }

            dgvCanchas.Rows.Clear();
            foreach (BeCancha c in lCancha.Where(c => c.Estado == estadoSeleccionado))
            {
                dgvCanchas.Rows.Add(c.id, c.Nombre, c.Precio, c.Capacidad, c.Estado, c.Observaciones);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogBitacora.AgregarEvento("Salir de ControlCanchas", 1, SessionManager.getInstance.usuario, "Canchas");
        }

        public void Actualizar(string pIdioma)
        {
            Idioma idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);

            this.Text = idioma.lEtiqueta.Find(x => x.ControlT == "ControlCanchasform").Texto;
            btnFiltrarEstado.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnFiltrarEstado").Texto;
            btnEstadoCancha.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnEstadoCancha").Texto;
            labObservacionesCanchas.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labObservacionesCanchas").Texto;
            btnObservaciones.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnObservaciones").Texto;
            labDatosCanchas.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labDatosCanchas").Texto;
            labTcancha.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labTcancha").Texto;
            labPrecioCancha.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labPrecioCancha").Texto;
            labCapacidadCancha.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labCapacidadCancha").Texto;
            btnAltaCancha.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnAltaCancha").Texto;
            btnBajaCancha.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnBajaCancha").Texto;
            btnModificarCancha.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnModificarCancha").Texto;
            button1.Text = idioma.lEtiqueta.Find(x => x.ControlT == "button1").Texto;

            dgvCanchas.Columns["TipoCancha"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "TipoCancha").Texto;
            dgvCanchas.Columns["PrecioCancha"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "PrecioCancha").Texto;
            dgvCanchas.Columns["CapacidadCancha"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "CapacidadCancha").Texto;
            dgvCanchas.Columns["EstadoCancha"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "EstadoCancha").Texto;
            dgvCanchas.Columns["ObservacionesCancha"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "ObservacionesCancha").Texto;
        }
    }
}
