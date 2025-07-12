using Be;
using Bll;
using Interface;
using Mapper;
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
    public partial class CobrarReservaForm : Form, ITraducible
    {
        BllReserva bllReserva;
        BeReserva bReserva;
        TarjetaForm tarjeta;
        MapperReserva mreserva;
        
        public CobrarReservaForm(BeReserva reserva)
        {
            InitializeComponent();
            bReserva = reserva;
            bllReserva = new BllReserva();
            LanguageManager.Suscribir(this);
            mreserva = new MapperReserva();
            
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
        private void CobrarReservaForm_Load(object sender, EventArgs e)
        {
            listbCobrar.Items.Clear();
            lbNombreCobrar.Text = bReserva.Cliente.Nombre;
            tarjeta = new TarjetaForm();
            listbox();
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
            if (!(rbEfectivo.Checked || rbTransferencia.Checked || rbDebito.Checked))
            {
                MessageBox.Show("Seleccione un método de pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Pago realizado?", "Confirmar", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                mreserva.ActualizarPago(bReserva.id, true);

                MessageBox.Show("Reserva confirmada");
                LogBitacora.AgregarEvento("Pago de reserva", 3, SessionManager.getInstance.usuario, "Cobrar reserva");
                FacturaReporte.Reporte(bReserva);

                if (Owner is GReservasForm formReservas)
                {
                    formReservas.Refrescar();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, pagar la reserva");
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
            LogBitacora.AgregarEvento("Salir de cobrar reserva", 1, SessionManager.getInstance.usuario, "Cobrar");
        }
    }
}
