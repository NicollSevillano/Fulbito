using Be;
using Bll;
using Interface;
using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class InsumosForm : Form, ITraducible
    {
        public InsumosForm()
        {
            InitializeComponent();
        }
        List<BeInsumo> lInsumo;
        BllInsumo bllInsumo;
        public void Actualizar(string pIdioma)
        {
            throw new NotImplementedException();
        }

        private void InsumosForm_Load(object sender, EventArgs e)
        {
            bllInsumo = new BllInsumo();
            lInsumo = bllInsumo.Consulta();
            cmbEstadoInsumo.Items.Add("Verde");
            cmbEstadoInsumo.Items.Add("Amarillo");
            cmbEstadoInsumo.Items.Add("Rojo");
            cmbEstadoInsumo.DropDownStyle = ComboBoxStyle.DropDownList;
            Refrescar();
            CargarProveedores();
        }
        private void Refrescar()
        {
            dgvInsumos.Rows.Clear();
            foreach (BeInsumo item in lInsumo)
            {
                dgvInsumos.Rows.Add(item.id, item.fechaHora, item.Nombre, item.Cantidad, item.cantidadActual, item.Proveedor, item.Estado, item.Observaciones);
            }
        }
        private bool CargarTxt()
        {
            bool cargar = false;
            if(txtNombreInsumo.Text == string.Empty ||
                txtCantidadInsumo.Text == string.Empty ||
                txtCantidadActualInsumo.Text == string.Empty ||
                txtProveedorInsumo.Text == string.Empty ||
                txtObservacioneInsumo.Text == string.Empty)
            {
                cargar = true;
            }
            return cargar;
        }
        private void btnAgregarInsumos_Click(object sender, EventArgs e)
        {
            try
            {
                if(CargarTxt()) throw new Exception("Datos ingresados incorrectos");
                else
                {
                    bllInsumo.Alta(new BeInsumo(DateTime.Now, txtNombreInsumo.Text, int.Parse(txtCantidadInsumo.Text), int.Parse(txtCantidadActualInsumo.Text), txtProveedorInsumo.Text, cmbEstadoInsumo.SelectedItem.ToString(), txtObservacioneInsumo.Text));
                    lInsumo = bllInsumo.Consulta();
                    Refrescar();
                    MessageBox.Show("Insumo ingresado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarInsumos_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvInsumos.SelectedRows)
                {
                    int idInsumo = Convert.ToInt32(item.Cells[0].Value);
                    bllInsumo.Baja(idInsumo);
                    bllInsumo.Consulta();
                }
                MessageBox.Show("Cancha borrada con éxito");
                Refrescar();
            }
        }
        private BeInsumo LllamarInsumo()
        {
            return lInsumo.Find(x => x.id == dgvInsumos.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void btnModificarInsumos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInsumos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un insumo para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BeInsumo aux = LllamarInsumo();
                DateTime _fecha = DateTime.Now;
                string _nombre = Interaction.InputBox("Nombre:", "Modificando insumo...", aux.Nombre);
                int _cantActual = int.Parse(Interaction.InputBox("Cantidad Actual:", "Modificando insumo...", aux.cantidadActual.ToString()));
                string _proveedor = Interaction.InputBox("Proveedor:", "Modificando insumos...", aux.Proveedor);
                string _observaciones = Interaction.InputBox("Observaciones", "Modificando cancha...", aux.Observaciones);
                aux.fechaHora = _fecha;
                aux.Nombre = _nombre;
                aux.cantidadActual = _cantActual;
                aux.Proveedor = _proveedor;
                aux.Observaciones = _observaciones;

                bllInsumo.Modificacion(aux);
                lInsumo = bllInsumo.Consulta();
                MessageBox.Show("Cancha modificada exitosamente");
                LogCambios.AgregarCambio(aux, SessionManager.getInstance.usuario);
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiarEstadoInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un insumo cambiar el estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BeInsumo aux = LllamarInsumo();
            aux.Estado = cmbEstadoInsumo.SelectedItem.ToString();
            bllInsumo.CambiarEstado(aux);
            bllInsumo.Consulta();
            Refrescar();
        }

        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvInsumos.SelectedRows[0];
            txtNombreInsumo.Text = row.Cells[2].Value.ToString();
            txtCantidadInsumo.Text = row.Cells[3].Value.ToString();
            txtCantidadActualInsumo.Text = row.Cells[4].Value.ToString();
            txtProveedorInsumo.Text = row.Cells[5].Value.ToString();
            cmbEstadoInsumo.SelectedIndex.ToString();
            txtObservacioneInsumo.Text = row.Cells[7].Value.ToString();
            txtCantidadInsumo.Enabled = false;
        }

        private void btnFiltrarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                lInsumo = bllInsumo.Consulta();
                List<BeInsumo> c = new List<BeInsumo>(lInsumo);

                if(rbFiltroProveedor.Checked && cmbFiltroProveedorInsumo.SelectedItem != null)
                {
                    string proveedor = cmbFiltroProveedorInsumo.SelectedItem.ToString();
                    c = lInsumo.Where(x => x.Proveedor == proveedor).ToList();
                }
                else
                {
                    string estado = cmbFiltroEstadoInsumo.SelectedItem.ToString();
                    c = lInsumo.Where(x => x.Estado == estado).ToList();
                }
                lInsumo = c;
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<string> ObtenerProveedores()
        {
            return lInsumo.Select(x => x.Proveedor).Distinct().ToList();
        }
        private void CargarProveedores()
        {
            try
            {
                List<string> proveedores = ObtenerProveedores(); 

                cmbFiltroProveedorInsumo.DataSource = proveedores;
                cmbFiltroProveedorInsumo.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void rbFiltroProveedor_CheckedChanged(object sender, EventArgs e)
        {
            cmbFiltroProveedorInsumo.Enabled = rbFiltroProveedor.Checked;
            cmbFiltroEstadoInsumo.Enabled = !rbFiltroProveedor.Checked;
        }

        private void rbFiltroEstado_CheckedChanged(object sender, EventArgs e)
        {
            cmbFiltroEstadoInsumo.Enabled = rbFiltroEstado.Checked;
            cmbFiltroProveedorInsumo.Enabled = !rbFiltroEstado.Checked;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbFiltroProveedorInsumo.SelectedIndex = -1;
            cmbFiltroEstadoInsumo.SelectedIndex = -1;

            rbFiltroProveedor.Checked = false;
            rbFiltroEstado.Checked = false;

            cmbFiltroProveedorInsumo.Enabled = false;
            cmbFiltroEstadoInsumo.Enabled = false;

            lInsumo = bllInsumo.Consulta(); 
            Refrescar(); 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void filtrarNombreInsumo()
        {
            List<BeInsumo> insumoFiltrado = lInsumo
                .Where(x => x.Nombre != null && x.Nombre.StartsWith(txtFiltroNombreInsumo.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            AgregarDataGridView(insumoFiltrado);
        }
        private void AgregarDataGridView(List<BeInsumo> pLinsumo)
        {
            dgvInsumos.Rows.Clear();
            foreach (BeInsumo i in pLinsumo)
            {
                dgvInsumos.Rows.Add(new object[] { i.id, i.fechaHora, i.Nombre, i.Cantidad, i.cantidadActual, i.Proveedor, i.Estado, i.Observaciones });
            }
        }

        private void txtFiltroNombreInsumo_TextChanged(object sender, EventArgs e)
        {
            filtrarNombreInsumo();
        }
    }
}
