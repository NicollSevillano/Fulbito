using Be;
using Bll;
using Servicios;
using Interface;
using ServicioClase;
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
    public partial class CobrarReservaForm : Form, ITraducible
    {
        BllReserva bllReserva;
        BeReserva bReserva;
        TarjetaForm tarjeta;
        public CobrarReservaForm(BeReserva reserva)
        {
            InitializeComponent();
            bReserva = reserva;
            bllReserva = new BllReserva();
            LanguageManager.Suscribir(this);
        }

        private void CobrarReserva_Load(object sender, EventArgs e)
        {
            listbCobrar.Items.Clear();
            lbNombreCobrar.Text = bReserva.Cliente.Nombre;
            tarjeta = new TarjetaForm();
            listbox();
        }
        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            lbClienteCobrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbClienteCobrar").Texto;
            gpPago.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "gpPago").Texto;
            rbEfectivo.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "rbEfectivo").Texto;
            rbTransferencia.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "rbTransferencia").Texto;
            rbDebito.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "rbDebito").Texto;
            btncPagar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btncPagar").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "CobrarReservaForm").Texto;
        }
        private void listbox()
        {
            listbCobrar.Items.Clear();
            listbCobrar.Items.Add($"{bReserva.Cancha.Nombre}");
            listbCobrar.Items.Add($"{bReserva.Fecha.ToString("dd/MM/yyyy")}");
            listbCobrar.Items.Add($"{bReserva.Hora}");
            listbCobrar.Items.Add($"El precio por 1h es:");
            listbCobrar.Items.Add($"${bReserva.Cancha.Precio}");
        }

        private void btncPagar_Click(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked == true)
            {
                DialogResult resultado = MessageBox.Show("¿Pago realizado?", "Confirmar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show("Reserva confirmada");
                    List<BeReserva> lreserva = bllReserva.Consulta();
                    LogBitacora.AgregarEvento("Pago de reserva en efectivo", 3, SessionManager.getInstance.usuario);
                    FacturaReporte.Reporte(bReserva);
                }
                else if (resultado == DialogResult.Cancel)
                {
                    MessageBox.Show("Por favor, pagar la reserva");
                }
            }
            else if (rbTransferencia.Checked == true)
            {
                string alias = Alias();
                string mensaje = $"Realizar la transferencia al siguiente Alias o CBU:\n\nAlias: {alias}\nCBU: {Cbu()}";

                DialogResult resultado = MessageBox.Show(mensaje, "Información de Transferencia", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show("Reserva confirmada");
                    List<BeReserva> lreserva = bllReserva.Consulta();
                    LogBitacora.AgregarEvento("Pago de reserva con transferencia", 3, SessionManager.getInstance.usuario);
                    FacturaReporte.Reporte(bReserva);
                }
                else if (resultado == DialogResult.Cancel)
                {
                    MessageBox.Show("Por favor, pagar la reserva");
                }
            }
            else if (rbDebito.Checked == true)
            {
                tarjeta.Hide();
                tarjeta.ShowDialog();
                List<BeReserva> lreserva = bllReserva.Consulta();
                LogBitacora.AgregarEvento("Formulario de pago con tarjeta", 3, SessionManager.getInstance.usuario);
                FacturaReporte.Reporte(bReserva);
            }
        }
        private string Alias()
        {
            string[] alias = { "alias1", "alias2", "alias3" };
            Random random = new Random();
            int index = random.Next(alias.Length);
            return alias[index];
        }

        private string Cbu()
        {
            Random rnd = new Random();
            return rnd.Next(10000000, 99999999).ToString() + rnd.Next(10000000, 99999999).ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            LogBitacora.AgregarEvento("Salir de cobrar reserva", 1, SessionManager.getInstance.usuario);
        }
    }
}
