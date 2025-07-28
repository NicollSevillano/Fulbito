using Be;
using Bll;
using Interface;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class BitacoraCambiosForm : Form
    {
        public BitacoraCambiosForm()
        {
            InitializeComponent();
        }

        List<BelUsuario> lUsuario;
        BllUsuario bllUsuario;
        BllInsumo bllInsumo;

        private void BitacoraCambiosForm_Load(object sender, EventArgs e)
        {
            bllUsuario = new BllUsuario();
            bllInsumo = new BllInsumo();

            lUsuario = bllUsuario.Consulta();
            MostrarUsuarios();
            RefrescarBitacoraCambios();
        }

        private void RefrescarBitacoraCambios()
        {
            try
            {
                dgvInsumoCambios.Rows.Clear();
                DataTable dt = LogCambios.ConsultaCambio();

                foreach (DataRow dr in dt.Rows)
                {
                    dgvInsumoCambios.Rows.Add(dr.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message);
            }
        }

        private void btnFiltrarBCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioSeleccionado = cmbBitacoraEventosUsuarios.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(usuarioSeleccionado))
                {
                    MessageBox.Show("Seleccione un usuario para filtrar.");
                    return;
                }

                DataTable dt = LogCambios.ConsultaCambio();
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Usuario = '{usuarioSeleccionado}'";

                dgvInsumoCambios.Rows.Clear();
                foreach (DataRowView drv in dv)
                {
                    dgvInsumoCambios.Rows.Add(drv.Row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar cambios: " + ex.Message);
            }
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                DataTable dt = LogCambios.ConsultaCambioPorFecha(desde, hasta);

                dgvInsumoCambios.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvInsumoCambios.Rows.Add(dr.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fecha: " + ex.Message);
            }
        }

        private void MostrarUsuarios()
        {
            try
            {
                cmbBitacoraEventosUsuarios.Items.Clear();
                foreach (BelUsuario user in lUsuario)
                {
                    cmbBitacoraEventosUsuarios.Items.Add(user.Usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar usuarios: " + ex.Message);
            }
        }

        private void btnActivarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInsumoCambios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cambio a activar.");
                    return;
                }

                DataGridViewRow row = dgvInsumoCambios.SelectedRows[0];

                int idCambio = Convert.ToInt32(row.Cells[0].Value);
                int codigoInsumo = Convert.ToInt32(row.Cells[1].Value);

                LogCambios.ActivarCambio(idCambio, codigoInsumo);

                RefrescarBitacoraCambios();
                ActualizarGrillaInsumos();

                MessageBox.Show("Cambio activado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al activar cambio: " + ex.Message);
            }
        }

        private void ActualizarGrillaInsumos()
        {
            try
            {
                if (Application.OpenForms["InsumosForm"] is InsumosForm insumosForm)
                {
                    insumosForm.RefreshDataExternally();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar los insumos: " + ex.Message);
            }
        }

        private void btnLimpiarCambios_Click(object sender, EventArgs e)
        {
            cmbBitacoraEventosUsuarios.SelectedIndex = -1;
            RefrescarBitacoraCambios();
        }

        private void btnVolverbCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
