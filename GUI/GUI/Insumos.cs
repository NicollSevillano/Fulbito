using Be;
using Bll;
using Interface;
using Microsoft.VisualBasic;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            cmbEstadoInsumo.DropDownStyle = ComboBoxStyle.DropDownList;
            Refrescar();
            CargarProveedores();
        }

        private void Refrescar()
        {
            dgvInsumos.Rows.Clear();
            foreach (BeInsumo item in lInsumo)
            {
                string estado = CalcularEstado(item.Cantidad, item.cantidadActual);
                dgvInsumos.Rows.Add(item.id, item.Nombre, item.Cantidad, item.cantidadActual, item.Proveedor, estado, item.Observaciones);
            }
        }

        private string CalcularEstado(int total, int actual)
        {
            if (actual == total)
                return "Verde";
            else if (actual == total / 2)
                return "Amarillo";
            else
                return "Rojo";
        }

        private bool CargarTxt()
        {
            return string.IsNullOrWhiteSpace(txtNombreInsumo.Text) ||
                   string.IsNullOrWhiteSpace(txtCantidadInsumo.Text) ||
                   string.IsNullOrWhiteSpace(txtCantidadActualInsumo.Text) ||
                   string.IsNullOrWhiteSpace(txtProveedorInsumo.Text) ||
                   string.IsNullOrWhiteSpace(txtObservacioneInsumo.Text);
        }

        private void btnAgregarInsumos_Click(object sender, EventArgs e)
        {
            try
            {
                if (CargarTxt()) throw new Exception("Datos ingresados incorrectos");

                int cantidad = int.Parse(txtCantidadInsumo.Text);
                int cantidadActual = int.Parse(txtCantidadActualInsumo.Text);
                string estado = CalcularEstado(cantidad, cantidadActual);

                var nuevo = new BeInsumo(txtNombreInsumo.Text, cantidad, cantidadActual, txtProveedorInsumo.Text, estado, txtObservacioneInsumo.Text);
                bllInsumo.Alta(nuevo);

                lInsumo = bllInsumo.Consulta();
                Refrescar();
                MessageBox.Show("Insumo ingresado con éxito");
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
                    string idInsumo = item.Cells[0].Value.ToString();
                    bllInsumo.Baja(int.Parse(idInsumo));
                }

                MessageBox.Show("Insumo borrado con éxito");

                lInsumo = bllInsumo.Consulta();
                Refrescar();
            }
        }

        private BeInsumo LllamarInsumo()
        {
            string id = dgvInsumos.SelectedRows[0].Cells[0].Value.ToString();
            return lInsumo.Find(x => x.id == id);
        }

        private void btnModificarInsumos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInsumos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un insumo para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BeInsumo aux = LllamarInsumo();

                string _nombre = Interaction.InputBox("Nombre:", "Modificando insumo...", aux.Nombre);
                int _cantidadActual = int.Parse(Interaction.InputBox("Cantidad actual:", "Modificando insumo...", aux.cantidadActual.ToString()));
                string _proveedor = Interaction.InputBox("Proveedor:", "Modificando insumos...", aux.Proveedor);
                string _observaciones = Interaction.InputBox("Observaciones", "Modificando insumo...", aux.Observaciones);

                aux.Nombre = _nombre;
                aux.cantidadActual = _cantidadActual;
                aux.Proveedor = _proveedor;
                aux.Observaciones = _observaciones;
                aux.Estado = CalcularEstado(aux.Cantidad, _cantidadActual);

                bllInsumo.Modificacion(aux); // ✅ Corrección aquí: solo se pasa el objeto
                lInsumo = bllInsumo.Consulta();
                Refrescar();

                MessageBox.Show("Insumo modificado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInsumos.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvInsumos.SelectedRows[0];
            txtNombreInsumo.Text = row.Cells[1].Value.ToString();
            txtCantidadInsumo.Text = row.Cells[2].Value.ToString();
            txtCantidadActualInsumo.Text = row.Cells[3].Value.ToString();
            txtProveedorInsumo.Text = row.Cells[4].Value.ToString();
            txtObservacioneInsumo.Text = row.Cells[6].Value.ToString();
            txtCantidadInsumo.Enabled = false;
        }

        private void btnFiltrarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                lInsumo = bllInsumo.Consulta();
                List<BeInsumo> c = new List<BeInsumo>(lInsumo);

                if (rbFiltroProveedor.Checked && cmbFiltroProveedorInsumo.SelectedItem != null)
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

        private void txtFiltroNombreInsumo_TextChanged(object sender, EventArgs e)
        {
            filtrarNombreInsumo();
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
                string estado = CalcularEstado(i.Cantidad, i.cantidadActual);
                dgvInsumos.Rows.Add(i.id, i.Nombre, i.Cantidad, i.cantidadActual, i.Proveedor, estado, i.Observaciones);
            }
        }
    }
}
