using Be;
using Bll;
using Interface;
using Mapper;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class AlquilarInsumos : Form, ITraducible
    {
        BllInsumo blInsumo;
        List<BeInsumo> lInsumo;
        BllCliente bllCliente;
        List<BeCliente> lCliente;

        Dictionary<string, int> resumenInsumos = new Dictionary<string, int>();

        public AlquilarInsumos()
        {
            InitializeComponent();
        }

        private void AlquilarInsumos_Load(object sender, EventArgs e)
        {
            blInsumo = new BllInsumo();
            lInsumo = blInsumo.Consulta();
            bllCliente = new BllCliente();
            lCliente = bllCliente.Consulta();

            CargarComboInsumos();
            CargarComboClientes();

            nudHoras.Minimum = 1;
            nudHoras.Maximum = 24;
            nudHoras.Value = 1;
            nudHoras.ValueChanged += nudHoras_ValueChanged;

            labTotal.Text = $"{Traductor.ObtenerTexto("totalEstimado")}: $0";

            LanguageManager.Suscribir(this);
            LanguageManager.Actualizar(int.Parse(SessionManager.getInstance.usuario.IdiomaId.id));
        }

        private void CargarComboInsumos()
        {
            cmbInsumo.Items.Clear();
            foreach (BeInsumo i in lInsumo)
            {
                cmbInsumo.Items.Add(i.Nombre);
            }
            cmbInsumo.SelectedIndexChanged += cmbInsumo_SelectedIndexChanged;
        }

        public void CargarComboClientes()
        {
            cmbCliente.DataSource = null;

            var listaConPlaceholder = new List<BeCliente>
            {
                new BeCliente { id = "", Nombre = Traductor.ObtenerTexto("placeholderCliente") }
            };
            listaConPlaceholder.AddRange(lCliente);

            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = listaConPlaceholder;

            cmbCliente.SelectedIndex = 0;
        }

        private void cmbInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInsumo.SelectedItem == null) return;
            string nombreSeleccionado = cmbInsumo.SelectedItem.ToString();
            BeInsumo insumo = lInsumo.FirstOrDefault(i => i.Nombre == nombreSeleccionado);
            if (insumo != null) CargarImagen(insumo.Nombre);
        }

        private void CargarImagen(string nombreInsumo)
        {
            try
            {
                string nombreArchivo = nombreInsumo.Replace(" ", "").Replace("\u00B0", "").Replace("\u00BA", "").ToLower();
                string rutaBase = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Img"));
                string rutaJpg = Path.Combine(rutaBase, nombreArchivo + ".jpg");
                string rutaPng = Path.Combine(rutaBase, nombreArchivo + ".png");

                if (File.Exists(rutaJpg)) pbInsumo.Image = Image.FromFile(rutaJpg);
                else if (File.Exists(rutaPng)) pbInsumo.Image = Image.FromFile(rutaPng);
                else pbInsumo.Image = null;

                pbInsumo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Traductor.ObtenerTexto("errorImagen") + ": " + ex.Message);
                pbInsumo.Image = null;
            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            if (cmbInsumo.SelectedItem == null) return;

            string nombre = cmbInsumo.SelectedItem.ToString();
            int cantidad = stock1.CantidadSeleccionada;
            BeInsumo be = lInsumo.FirstOrDefault(i => i.Nombre == nombre);

            if (cantidad <= 0)
            {
                MessageBox.Show(Traductor.ObtenerTexto("cantidadMayorCero"));
                return;
            }

            if (resumenInsumos.ContainsKey(nombre)) resumenInsumos[nombre] += cantidad;
            else resumenInsumos[nombre] = cantidad;

            stock1.CantidadSeleccionada = 0;
            ActualizarResumen();
        }

        private void ActualizarResumen()
        {
            txtInfoInsumo.Clear();
            int horas = (int)nudHoras.Value;

            foreach (var item in resumenInsumos)
            {
                string nombre = item.Key;
                int cantidad = item.Value;
                BeInsumo insumo = lInsumo.FirstOrDefault(i => i.Nombre == nombre);

                if (insumo != null)
                {
                    decimal precioBase = insumo.Precio;
                    decimal adicional = horas > 1 ? (horas - 1) * 2000 : 0;
                    decimal precioConAdicional = precioBase + adicional;
                    decimal total = precioConAdicional * cantidad;

                    txtInfoInsumo.AppendText($"{nombre}\r\n");
                    txtInfoInsumo.AppendText($"{Traductor.ObtenerTexto("precioHora")}: ${precioBase:N0}\r\n");
                    if (adicional > 0)
                        txtInfoInsumo.AppendText($"{Traductor.ObtenerTexto("adicionalPorHoras")} {horas - 1}h: +${adicional:N0}/unidad\r\n");

                    txtInfoInsumo.AppendText($"x{cantidad} = ${total:N0}\r\n");
                    txtInfoInsumo.AppendText($"----------------------------\r\n");
                }
            }

            ActualizarTotalEstimado();
        }

        private void ActualizarTotalEstimado()
        {
            decimal total = CalcularTotalInsumos();
            labTotal.Text = $"{Traductor.ObtenerTexto("totalEstimado")}: ${total:N0}";
        }

        private decimal CalcularTotalInsumos()
        {
            int horas = (int)nudHoras.Value;
            decimal total = 0;

            foreach (var item in resumenInsumos)
            {
                string nombre = item.Key;
                int cantidad = item.Value;
                BeInsumo insumo = lInsumo.FirstOrDefault(i => i.Nombre == nombre);

                if (insumo != null)
                {
                    decimal adicional = horas > 1 ? (horas - 1) * 2000 : 0;
                    decimal precioFinal = (insumo.Precio + adicional) * cantidad;
                    total += precioFinal;
                }
            }

            return total;
        }

        private void nudHoras_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotalEstimado();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show(Traductor.ObtenerTexto("seleccioneCliente"));
                return;
            }

            BeCliente cliente = cmbCliente.SelectedItem as BeCliente;
            if (cliente == null || string.IsNullOrEmpty(cliente.id))
            {
                MessageBox.Show(Traductor.ObtenerTexto("clienteInvalido"));
                return;
            }

            int horas = (int)nudHoras.Value;
            if (horas <= 0)
            {
                MessageBox.Show(Traductor.ObtenerTexto("horasInvalidas"));
                return;
            }

            decimal total = CalcularTotalInsumos();

            BeAlquiler alquiler = new BeAlquiler
            {
                Cliente = cliente,
                Horas = horas,
                Total = total,
                Fecha = DateTime.Now
            };

            alquiler.Detalle = new List<AlquilerInsumoDetalle>();

            foreach (var item in resumenInsumos)
            {
                BeInsumo insumo = lInsumo.FirstOrDefault(i => i.Nombre == item.Key);
                if (insumo != null)
                {
                    alquiler.Detalle.Add(new AlquilerInsumoDetalle
                    {
                        CodigoInsumo = int.Parse(insumo.id),
                        Cantidad = item.Value
                    });
                }
            }

            try
            {
                BllAlquiler bllAlquiler = new BllAlquiler();
                bllAlquiler.Alta(alquiler);

                List<InsumoResumen> resumen = new List<InsumoResumen>();

                foreach (var item in resumenInsumos)
                {
                    BeInsumo insumo = lInsumo.FirstOrDefault(i => i.Nombre == item.Key);
                    if (insumo != null)
                    {
                        decimal adicional = horas > 1 ? (horas - 1) * 2000 : 0;
                        decimal precioUnitario = insumo.Precio + adicional;
                        resumen.Add(new InsumoResumen
                        {
                            Nombre = insumo.Nombre,
                            Cantidad = item.Value,
                            Subtotal = precioUnitario * item.Value
                        });
                    }
                }

                CobrarForm cobrarForm = new CobrarForm(alquiler, resumen);
                cobrarForm.ShowDialog();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Traductor.ObtenerTexto("errorAlRegistrar") + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            resumenInsumos.Clear();
            txtInfoInsumo.Clear();
            stock1.CantidadSeleccionada = 0;
            cmbInsumo.SelectedIndex = -1;
            pbInsumo.Image = null;
            nudHoras.Value = 1;
            labTotal.Text = $"{Traductor.ObtenerTexto("totalEstimado")}: $0";
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "AlquilarInsumos").Texto;
            labTitulo.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labTitulo").Texto;
            labInsumo.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labInsumo").Texto;
            labInfo.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labInfo").Texto;
            labCliente.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labCliente").Texto;
            labHoras.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labHoras").Texto;
            btnAgregarInsumo.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnAgregarInsumo").Texto;
            btnAlquilar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnAlquilar").Texto;
            btnVolverAlquilar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnVolverAlquilar").Texto;

            ActualizarTotalEstimado();
        }

        private void btnVolverAlquilar_Click(object sender, EventArgs e)
        {
            this.Close();
            LogBitacora.AgregarEvento("Salir de Alquiler", 1, SessionManager.getInstance.usuario, "AlquilarInsumos");
        }
    }
}
