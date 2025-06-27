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
    public partial class TarjetaForm : Form, ITraducible
    {
        BllReserva bllReserva;
        public TarjetaForm()
        {
            InitializeComponent();
        }
        
        private void Tarjeta_Load(object sender, EventArgs e)
        {
            bllReserva = new BllReserva();
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            string numero = txtnumero.Text;
            if (numero.Length == 16 && numero.All(char.IsDigit))
            {
                if (!debito(numero))
                {
                    MessageBox.Show("Usted está ingresando un número que no corresponde a una tarjeta de débito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnumero.Clear();
                }
            }
            else if (numero.Length > 16 || !numero.All(char.IsDigit))
            {
                MessageBox.Show("El número de tarjeta debe contener 16 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumero.Clear();
            }
        }
        private bool debito(string pNumero)
        {
            string[] _debito = { "4", "5", "6" };
            foreach (string p in _debito)
            {
                if (pNumero.StartsWith(p))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtmes_TextChanged(object sender, EventArgs e)
        {
            string mes = txtmes.Text;
            if(mes.Length > 0 && (!mes.All(char.IsDigit) || int.Parse(mes) < 1 || int.Parse(mes) > 12))
            {
                MessageBox.Show("El mes debe ser entre 01 y 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmes.Clear();
            }
        }

        private void txtano_TextChanged(object sender, EventArgs e)
        {
            string anio = txtano.Text;
            if(anio.Length > 0 && (!anio.All(char.IsDigit) || anio.Length > 2))
            {
                MessageBox.Show("El año debe ser de 2 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtano.Clear();
            }
        }

        private void txtcvc_TextChanged(object sender, EventArgs e)
        {
            string cvc = txtcvc.Text;
            if(cvc.Length > 0 && (!cvc.All(char.IsDigit) || cvc.Length > 3))
            {
                MessageBox.Show("El código de seguridad es de 3 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcvc.Clear();
            }
        }

        private void btnPagarTarjeta_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text.Length == 16 && txtnumero.Text.All(char.IsDigit) &&
            txtmes.Text.Length == 2 && txtmes.Text.All(char.IsDigit) &&
            txtano.Text.Length == 2 && txtano.Text.All(char.IsDigit) &&
            (txtcvc.Text.Length == 3 && txtcvc.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Transacción confirmada");
                LogBitacora.AgregarEvento("Pagar reserva con tarjeta", 2, SessionManager.getInstance.usuario, "Pago: Tarjeta");
                this.Close();
            }
            else
            {
                MessageBox.Show("Uno de los campos es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            lbTarjeta.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbTarjeta").Texto;
            lbMes.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbMes").Texto;
            lbAno.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbAno").Texto;
            btnPagarTarjeta.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnPagarTarjeta").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "Tarjeta").Texto;
        }
    }
}
