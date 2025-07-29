using Be;
using Bll;
using Mapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class AlquilarInsumos : Form
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

            labTotal.Text = "Total estimado: $0";
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
                new BeCliente { id = "", Nombre = "Seleccione un cliente..." }
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
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
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
                MessageBox.Show("La cantidad debe ser mayor a cero.");
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
                    txtInfoInsumo.AppendText($"Precio por hora: ${precioBase:N0}\r\n");
                    if (adicional > 0)
                        txtInfoInsumo.AppendText($"Adicional por {horas - 1}h extra: +${adicional:N0}/unidad\r\n");

                    txtInfoInsumo.AppendText($"x{cantidad} unidades = ${total:N0}\r\n");
                    txtInfoInsumo.AppendText($"----------------------------\r\n");
                }
            }

            ActualizarTotalEstimado();
        }

        private void ActualizarTotalEstimado()
        {
            decimal total = CalcularTotalInsumos();
            labTotal.Text = $"Total estimado: ${total:N0}";
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
                MessageBox.Show("Seleccione un cliente antes de continuar.");
                return;
            }

            BeCliente cliente = cmbCliente.SelectedItem as BeCliente;
            if (cliente == null || string.IsNullOrEmpty(cliente.id))
            {
                MessageBox.Show("Cliente no válido o sin ID.");
                return;
            }

            int horas = (int)nudHoras.Value;
            if (horas <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de horas.");
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
                MessageBox.Show("Error al registrar el alquiler: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            labTotal.Text = "Total estimado: $0";
        }
    }
}
