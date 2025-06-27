using Be;
using Bll;
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
    public partial class BitacoraEventosform : Form
    {
        public BitacoraEventosform()
        {
            InitializeComponent();
        }
        BelUsuario beUsuario;
        BllUsuario bllUsuario;
        List<BelUsuario> lUsuario;

        private void BitacoraEventos_Load(object sender, EventArgs e)
        {
            beUsuario = new BelUsuario();
            bllUsuario = new BllUsuario();
            lUsuario = bllUsuario.Consulta();
            MostrarUsuarios();
            RefrecarBitacoraEvento();
        }
        private void btnFiltrarBEvento_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dateTimePicker1.Value;
                DateTime fechaFinal = dateTimePicker2.Value;
                string usuario = cmbBitacoraEventosUsuarios.SelectedItem?.ToString();
                int criticidad = (int)this.numericCriticidad.Value;
                if (fechaInicio >= fechaFinal) throw new Exception("La fecha Inicial no puede ser menor que la fecha actual");
                dgvBitacoraEventos.Rows.Clear();
                DataTable dt = LogBitacora.ConsultaBitacora();
                foreach (DataRow dr in dt.Rows)
                {
                    DateTime Fechas = DateTime.Parse(dr[1].ToString());
                    int Criticidad = Convert.ToInt32(dr["Criticidad"]);
                    string Usuario = dr[4].ToString();

                    bool filtroFechas = Fechas >= fechaInicio && Fechas <= fechaFinal;
                    bool filtroCriticidad = criticidad == 0 || Criticidad == criticidad;
                    bool filtroUsuario = string.IsNullOrEmpty(usuario) || Usuario == usuario;
                    if (filtroFechas && filtroCriticidad && filtroUsuario)
                    {
                        dgvBitacoraEventos.Rows.Add(dr.ItemArray);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefrecarBitacoraEvento()
        {
            try
            {
                dgvBitacoraEventos.Rows.Clear(); 
                DataTable dt = LogBitacora.ConsultaBitacora();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvBitacoraEventos.Rows.Add(dr.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MostrarUsuarios()
        {
            List<BelUsuario> lUsuario = bllUsuario.Consulta();
            foreach (BelUsuario bUsuario in lUsuario)
            {
                cmbBitacoraEventosUsuarios.Items.Add(bUsuario.Usuario);
            }
        }

        private void btnVolverbEventos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            RefrecarBitacoraEvento();
            txtNombreBE.Clear();
            txtApellidoBE.Clear();
            numericCriticidad.Value = numericCriticidad.Minimum;
            cmbBitacoraEventosUsuarios.SelectedIndex = -1;
        }
        private BelUsuario ObtenerUsuario()
        {
            string _usuario = "";
            if (dgvBitacoraEventos.SelectedRows.Count > 0)
            {
                _usuario = dgvBitacoraEventos.SelectedRows[0].Cells[4].Value.ToString();
            }
            return lUsuario.Find(x => x.Usuario == _usuario);
        }

        private void dgvBitacoraEventos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            BelUsuario usu = ObtenerUsuario();
            if(usu != null)
            {
                txtNombreBE.Text = usu.Nombre;
                txtApellidoBE.Text = usu.Apellido;
            }
        }
    }
}
