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
        private bool CargarTxt()
        {
            bool txtValido = false;
            if (txtTipoCancha.ToString() == string.Empty ||
                txtPrecioCancha.ToString() == string.Empty||
                txtCapacidadCancha.ToString() == string.Empty)
            {
                txtValido = true;
            }
            return txtValido;
        }
        private void btnAltaCancha_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CargarTxt())
                {
                    BeCancha nuevaCancha;
                    nuevaCancha = new BeCancha(txtTipoCancha.Text, txtPrecioCancha.Text, int.Parse(txtCapacidadCancha.Text), null, null);
                    bllCancha.Alta(nuevaCancha);
                    lCancha = bllCancha.Consulta();
                    RefrescarCancha();
                    //LogBitacora.AgregarEvento("Agregar cancha", 1, SessionManager.getInstance.usuario, "Canchas");
                    MessageBox.Show("Cancha agregada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede dar de alta la cancha " + ex.Message);
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
            BeCancha _cancha = ObtenerCancha();
            BllReserva blReserva = new BllReserva();
            List<BeReserva> lReservas = blReserva.Consulta();
            List<BeReserva> reserva = lReservas.FindAll(x => x.Cancha.id == _cancha.id);
            foreach (BeReserva r in reserva)
            {
                blReserva.Baja(int.Parse(r.id));
            }
            bllCancha.Baja(int.Parse(_cancha.id));
            lCancha = bllCancha.Consulta();
            //LogBitacora.AgregarEvento("Eliminar cancha", 2, SessionManager.getInstance.usuario, "Cancha");
            MessageBox.Show("Cancha eliminada");
            RefrescarCancha();
        }
        private BeCancha ObtenerCancha()
        {
            return lCancha.Find(x => x.id == dgvCanchas.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnModificarCancha_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvCanchas.SelectedRows[0];
                string cancha = dgv.Cells[0].Value.ToString();

                BeCancha modificarCancha = lCancha.Find(x => x.id == cancha);

                if (!CargarTxt())
                {
                    modificarCancha.Nombre = txtTipoCancha.Text;
                    modificarCancha.Precio = txtPrecioCancha.Text;
                    modificarCancha.Estado = cmbEstadoCancha.SelectedItem.ToString();
                    bllCancha.Modificacion(modificarCancha);
                    lCancha = bllCancha.Consulta();
                    RefrescarCancha();
                    MessageBox.Show("Cancha modificada");
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

        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
