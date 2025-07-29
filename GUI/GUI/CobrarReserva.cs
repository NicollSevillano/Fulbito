using Be;
using Interface;
using Mapper;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class CobrarForm : Form, ITraducible
    {
        private BeReserva reserva;
        private BeAlquiler alquiler;
        private bool esReserva;
        private TarjetaForm tarjeta;
        private MapperReserva mreserva = new MapperReserva();
        private List<InsumoResumen> insumos = new List<InsumoResumen>();

        public CobrarForm(BeReserva _reserva)
        {
            InitializeComponent();
            reserva = _reserva;
            esReserva = true;
            LanguageManager.Suscribir(this);
            this.Load += CobrarForm_Load;
        }

        public CobrarForm(BeAlquiler _alquiler, List<InsumoResumen> _insumos)
        {
            InitializeComponent();
            alquiler = _alquiler;
            insumos = _insumos ?? new List<InsumoResumen>();
            esReserva = false;
            LanguageManager.Suscribir(this);
            this.Actualizar(SessionManager.getInstance.usuario.IdiomaId.ToString());
            this.Load += CobrarForm_Load;
        }

        private void CobrarForm_Load(object sender, EventArgs e)
        {
            tarjeta = new TarjetaForm();
            lbNombreCobrar.Text = esReserva ? reserva.Cliente.Nombre : alquiler.Cliente.Nombre;

            txtCobrar.Clear();

            if (esReserva)
            {
                txtCobrar.AppendText($"Cancha: {reserva.Cancha.Nombre}\r\n");
                txtCobrar.AppendText($"Fecha: {reserva.Fecha:dd/MM/yyyy}\r\n");
                txtCobrar.AppendText($"Hora: {reserva.Hora}\r\n");
                txtCobrar.AppendText($"Precio por 1h: ${reserva.Cancha.Precio:N0}\r\n");
            }
            else
            {
                txtCobrar.AppendText($"Cliente: {alquiler.Cliente.Nombre}\r\n");
                txtCobrar.AppendText($"Horas: {alquiler.Horas}\r\n");
                txtCobrar.AppendText($"Insumos:\r\n\r\n");

                foreach (var insumo in insumos)
                {
                    decimal precioUnitario = insumo.Subtotal / insumo.Cantidad;
                    decimal adicional = alquiler.Horas > 1 ? (alquiler.Horas - 1) * 2000 : 0;
                    decimal baseUnitario = precioUnitario - adicional;

                    txtCobrar.AppendText($"- {insumo.Nombre}\r\n");
                    txtCobrar.AppendText($"  Precio base: ${baseUnitario:N0}\r\n");

                    if (adicional > 0)
                        txtCobrar.AppendText($"  Adicional por {alquiler.Horas - 1}h extra: +${adicional:N0}/unidad\r\n");

                    txtCobrar.AppendText($"  x{insumo.Cantidad} = ${insumo.Subtotal:N0}\r\n");
                    txtCobrar.AppendText("\r\n");
                }

                txtCobrar.AppendText($"Total: ${alquiler.Total:N0}\r\n");
                LanguageManager.Suscribir(this);
                LanguageManager.Actualizar(SessionManager.getInstance.usuario.IdiomaId);
            }
        }

        public void Actualizar(string idioma)
        {
            Idioma i = LanguageManager.lIdioma.Find(x => x.id == idioma);
            this.Text = i.lEtiqueta.Find(x => x.ControlT == "CobrarForm").Texto;
            lbClienteCobrar.Text = i.lEtiqueta.Find(x => x.ControlT == "lbClienteCobrar").Texto;
            gpPago.Text = i.lEtiqueta.Find(x => x.ControlT == "gpPago").Texto;
            rbEfectivo.Text = i.lEtiqueta.Find(x => x.ControlT == "rbEfectivo").Texto;
            rbTransferencia.Text = i.lEtiqueta.Find(x => x.ControlT == "rbTransferencia").Texto;
            rbDebito.Text = i.lEtiqueta.Find(x => x.ControlT == "rbDebito").Texto;
            btncPagar.Text = i.lEtiqueta.Find(x => x.ControlT == "btncPagar").Texto;
            btnVolver.Text = i.lEtiqueta.Find(x => x.ControlT == "btnVolver").Texto;
        }

        private void btncPagar_Click(object sender, EventArgs e)
        {
            if (!(rbEfectivo.Checked || rbTransferencia.Checked || rbDebito.Checked))
            {
                MessageBox.Show("Seleccione un método de pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Pago realizado?", "Confirmar", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (esReserva)
                {
                    mreserva.ActualizarPago(reserva.id, true);
                    FacturaReporte.Reporte(reserva);
                    LogBitacora.AgregarEvento("Pago de reserva", 3, SessionManager.getInstance.usuario, "Cobrar reserva");
                }
                else
                {
                    FacturaReporte.Reporte(alquiler, insumos);
                    LogBitacora.AgregarEvento("Pago de alquiler", 3, SessionManager.getInstance.usuario, "Cobrar alquiler");
                }

                MessageBox.Show("Pago registrado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Owner is GReservasForm fr) fr.Refrescar();

                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LogBitacora.AgregarEvento("Salir de cobrar", 1, SessionManager.getInstance.usuario, "Cobrar");
            this.Close();
        }
    }
}
