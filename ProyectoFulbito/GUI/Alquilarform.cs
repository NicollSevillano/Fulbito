using Be;
using Bll;
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
    public partial class Alquilarform : Form
    {
        public Alquilarform()
        {
            InitializeComponent();
        }
        List<BeCliente> lCliente;
        BllCliente blCliente;
        List<BeInsumo> lInsumo;
        BllInsumo blInsumo;

        private void Alquilarform_Load(object sender, EventArgs e)
        {
            blCliente = new BllCliente();
            lCliente = blCliente.Consulta();
            blInsumo = new BllInsumo();
            lInsumo = blInsumo.Consulta();
            ObtenerCliente();
            ObtenerInsumo();
        }
        public void ObtenerCliente()
        {
            foreach (BeCliente c in lCliente)
            {
                cmbClienteAlquiler.Items.Add(c.Nombre);
            }
        }
        private void ObtenerInsumo()
        {
            foreach (BeInsumo c in lInsumo)
            {
                cmbInsumoAlquiler.Items.Add(c.Nombre);
            }
        }
        private bool ValidarTxt()
        {
            bool valido = false;
            if(txtCantidadAlquiler.Text == string.Empty)
            {
                valido = true;
            }
            return valido;
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
