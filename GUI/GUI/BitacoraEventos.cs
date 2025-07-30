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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BitacoraEventosform : Form, ITraducible
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
            LanguageManager.Suscribir(this);
            LanguageManager.Actualizar(int.Parse(SessionManager.getInstance.usuario.IdiomaId.id));
        }

        private void btnFiltrarBEvento_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dateTimePicker1.Value;
                DateTime fechaFinal = dateTimePicker2.Value;
                string usuario = cmbBitacoraEventosUsuarios.SelectedItem?.ToString();
                int criticidad = (int)this.numericCriticidad.Value;

                if (fechaInicio >= fechaFinal)
                    throw new Exception(Traductor.ObtenerTexto("errorFechaFiltroEventos"));

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
                MessageBox.Show(Traductor.ObtenerTexto("errorCargarBitacoraEventos") + ": " + ex.Message);
            }
        }

        public void MostrarUsuarios()
        {
            try
            {
                List<BelUsuario> lUsuario = bllUsuario.Consulta();
                foreach (BelUsuario bUsuario in lUsuario)
                {
                    cmbBitacoraEventosUsuarios.Items.Add(bUsuario.Usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Traductor.ObtenerTexto("errorMostrarUsuarios") + ": " + ex.Message);
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
            if (usu != null)
            {
                txtNombreBE.Text = usu.Nombre;
                txtApellidoBE.Text = usu.Apellido;
            }
        }

        public void Actualizar(string pIdioma)
        {
            Idioma idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);

            this.Text = idioma.lEtiqueta.Find(x => x.ControlT == "BitacoraEventosform").Texto;
            labBitacoraEventos.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labBitacoraEventos").Texto;
            LabNombre.Text = idioma.lEtiqueta.Find(x => x.ControlT == "LabNombre").Texto;
            labApellido.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labApellido").Texto;
            LabBeventosfechaInicio.Text = idioma.lEtiqueta.Find(x => x.ControlT == "LabBeventosfechaInicio").Texto;
            LabBeventosfechaFinal.Text = idioma.lEtiqueta.Find(x => x.ControlT == "LabBeventosfechaFinal").Texto;
            LabBeventosUsuario.Text = idioma.lEtiqueta.Find(x => x.ControlT == "LabBeventosUsuario").Texto;
            btnFiltrarBEvento.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnFiltrarBEvento").Texto;
            btnImprimir.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnImprimir").Texto;
            btnLimpiar.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnLimpiar").Texto;
            btnVolverbEventos.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnVolverbEventos").Texto;

            dgvBitacoraEventos.Columns["FechaBitacoraE"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "FechaBitacoraE").Texto;
            dgvBitacoraEventos.Columns["TextoBitacoraE"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "TextoBitacoraE").Texto;
            dgvBitacoraEventos.Columns["CriticidadBitacoraE"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "CriticidadBitacoraE").Texto;
            dgvBitacoraEventos.Columns["UsuarioBitacoraE"].HeaderText = idioma.lEtiqueta.Find(x => x.ControlT == "UsuarioBitacoraE").Texto;
        }
    }

}
