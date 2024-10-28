using Be;
using Bll;
using Interface;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BitacoraCambiosForm : Form
    {
        public BitacoraCambiosForm()
        {
            InitializeComponent();
        }
        List<BeInsumo> lInsumo;
        BllInsumo bllInsumo; BelUsuario beUsuario;
        BllUsuario bllUsuario;
        List<BelUsuario> lUsuario;
        private void BitacoraCambiosForm_Load(object sender, EventArgs e)
        {
            bllInsumo = new BllInsumo();
            lInsumo = bllInsumo.Consulta();
            beUsuario = new BelUsuario();
            bllUsuario = new BllUsuario();
            lUsuario = bllUsuario.Consulta();
            RefrecarBitacoraCambio();
            MostrarUsuarios();
        }

        private void btnFiltrarBCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnActivarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgvInsumoCambios.SelectedRows[0];
                string _insumo = dgv.Cells[1].Value.ToString();
                BeInsumo insumo = lInsumo.Find(x => x.id == _insumo);
                insumo.Nombre = dgv.Cells[3].Value.ToString();
                insumo.cantidadActual = int.Parse(dgv.Cells[4].Value.ToString());
                insumo.Observaciones = dgv.Cells[5].Value.ToString();
                foreach (DataGridViewRow row in dgvInsumoCambios.Rows)
                {
                    LogCambios.ActivarCambio(row.Cells[0].Value.ToString(), false);
                }
                LogCambios.ActivarCambio(dgv.Cells[0].Value.ToString(), true);
                lInsumo = bllInsumo.Consulta();
                RefrecarBitacoraCambio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefrecarBitacoraCambio()
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolverbCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MostrarUsuarios()
        {
            List<BelUsuario> lUsuario = bllUsuario.Consulta();
            foreach (BelUsuario bUsuario in lUsuario)
            {
                cmbBitacoraEventosUsuarios.Items.Add(bUsuario.Usuario);
            }
        }
    }
}
