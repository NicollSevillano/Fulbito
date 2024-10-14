using Be;
using Bll;
using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Servicios;

namespace GUI
{
    public partial class CanchasForm : Form, ITraducible
    {
        public CanchasForm()
        {
            InitializeComponent();
        }
        List<BeCancha> lCancha;
        BllCancha bllCancha;
        public void Actualizar(string pIdioma)
        {
            throw new NotImplementedException();
        }

        private void CanchasForm_Load(object sender, EventArgs e)
        {
            cmbEstadoCancha.Items.Add("Disponible");
            cmbEstadoCancha.Items.Add("En mantenimiento");
            cmbEstadoCancha.Items.Add("No disponible");
            bllCancha = new BllCancha();
            lCancha = bllCancha.Consulta();
            Refrescar();
        }
        private bool CargarTxt()
        {
            bool habilitar = false;
            if(txtNombreCancha.Text == string.Empty ||
                txtPrecioCancha.Text == string.Empty ||
                txtCapacidadCancha.Text == string.Empty ||
                txtObservacionesCancha.Text == string.Empty)
            {
                habilitar = true;
            }
            return habilitar;
        }
        private void Refrescar()
        {
            dgvCanchas.Rows.Clear();
            foreach (BeCancha item in lCancha)
            {
                dgvCanchas.Rows.Add(item.id, item.Nombre, item.Precio, item.Capacidad, item.Estado, item.Observaciones);
            }
        }
        private void btnAltaCancha_Click(object sender, EventArgs e)
        {
            try
            {
                if(CargarTxt()) { throw new Exception("Error en la alta de cancha"); }
                else
                {
                    bllCancha.Alta(new BeCancha(txtNombreCancha.Text, decimal.Parse(txtPrecioCancha.Text), int.Parse(txtCapacidadCancha.Text), cmbEstadoCancha.SelectedItem.ToString(), txtObservacionesCancha.Text));
                    lCancha = bllCancha.Consulta();
                    Refrescar();
                    MessageBox.Show("Cancha nueva ingresada con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBajaCancha_Click(object sender, EventArgs e)
        {
            if(dgvCanchas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvCanchas.SelectedRows)
                {
                    int idCancha = Convert.ToInt32(item.Cells[0].Value);
                    bllCancha.Baja(idCancha);
                    bllCancha.Consulta();
                }
                MessageBox.Show("Cancha borrada con éxito");
                Refrescar();
            }
        }
        private BeCancha LlamarCancha()
        {
            return lCancha.Find(x => x.id == dgvCanchas.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnModificarCancha_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvCanchas.SelectedRows.Count == 0) 
                { 
                    MessageBox.Show("Seleccione un usuario para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
                BeCancha aux = LlamarCancha();
                string _nombre = Interaction.InputBox("Nombre:", "Modificando cancha...", aux.Nombre);
                decimal _precio = decimal.Parse(Interaction.InputBox("Precio:", "Modificando cancha...", aux.Precio.ToString()));
                int _capacidad = int.Parse(Interaction.InputBox("Capacidad:", "Modificando cancha...", aux.Capacidad.ToString()));
                string _observaciones = Interaction.InputBox("Observaciones", "Modificando cancha...", aux.Observaciones);
                aux.Nombre = _nombre;
                aux.Precio = _precio;
                aux.Capacidad = _capacidad;
                aux.Observaciones= _observaciones;

                bllCancha.Modificacion(aux);
                lCancha = bllCancha.Consulta();
                Refrescar();
                MessageBox.Show("Cancha modificada exitosamente");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnEstadoCancha_Click(object sender, EventArgs e)
        {
            if (dgvCanchas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BeCancha aux = LlamarCancha();
            aux.Estado = cmbEstadoCancha.SelectedItem.ToString();
            bllCancha.CambiarEstado(aux);
            bllCancha.Consulta();
            Refrescar();
        }

        private void btnFiltrarEstado_Click(object sender, EventArgs e)
        {
            lCancha = bllCancha.Consulta();
            List<BeCancha> c = lCancha;
            c = lCancha.Where(x => x.Estado == cmbFiltroEstadoCancha.SelectedItem.ToString()).ToList<BeCancha>();
            lCancha = c;
            Refrescar();
        }

        private void dgvCanchas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCanchas.SelectedRows[0];
            txtNombreCancha.Text = row.Cells[1].Value.ToString();
            txtPrecioCancha.Text = row.Cells[2].Value.ToString();
            txtCapacidadCancha.Text = row.Cells[3].Value.ToString();
            cmbEstadoCancha.SelectedIndex.ToString();
            txtObservacionesCancha.Text = row.Cells[5].Value.ToString();
        }

        private void btnLimpiarCancha_Click(object sender, EventArgs e)
        {
            Refrescar();
            cmbFiltroEstadoCancha.SelectedIndex = -1;
        }

        private void btnVolverCanchas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
