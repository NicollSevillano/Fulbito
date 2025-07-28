using Be;
using Bll;
using ClosedXML.Excel;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GUI
{
    public partial class ReporteInteligente : Form
    {
        List<BeAlquiler> listaAlquileres = new List<BeAlquiler>();
        List<BeClienteHistorico> clientesHistorico = new List<BeClienteHistorico>();

        public ReporteInteligente()
        {
            InitializeComponent();
        }

        private void ReporteInteligente_Load(object sender, EventArgs e)
        {
            BllAlquiler bll = new BllAlquiler();
            listaAlquileres = bll.Consulta();

            MostrarEnGrilla(listaAlquileres);
            MostrarGraficoGanancias(listaAlquileres);
            MostrarHistoricoClientes(listaAlquileres);
            MostrarGraficoTopClientes(clientesHistorico.Take(3).ToList());

            cmbFormato.Items.Add("Excel");
            cmbFormato.Items.Add("PDF");
            cmbFormato.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

            var filtrados = listaAlquileres
                .Where(a => a.Fecha >= desde && a.Fecha <= hasta)
                .ToList();

            MostrarEnGrilla(filtrados);
            MostrarGraficoGanancias(filtrados);
            MostrarHistoricoClientes(filtrados);
            MostrarGraficoTopClientes(clientesHistorico.Take(3).ToList());
        }

        private void MostrarEnGrilla(List<BeAlquiler> alquileres)
        {
            dgvAlquileres.Rows.Clear();
            foreach (var a in alquileres)
            {
                dgvAlquileres.Rows.Add(a.id, a.Cliente?.Nombre, a.Fecha.ToString("dd/MM/yyyy HH:mm"), $"${a.Total:N0}");
            }
        }

        private void MostrarGraficoGanancias(List<BeAlquiler> lista)
        {
            var agrupado = lista
                .GroupBy(a => a.Fecha.ToString("MMMM yyyy"))
                .OrderBy(g => DateTime.Parse("01 " + g.Key))
                .Select(g => new { Mes = g.Key, Total = g.Sum(x => x.Total) })
                .ToList();

            chartGanancias.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Ganancia",
                    Values = new ChartValues<decimal>(agrupado.Select(x => x.Total)),
                    Fill = System.Windows.Media.Brushes.DarkGreen
                }
            };

            chartGanancias.AxisX.Clear();
            chartGanancias.AxisX.Add(new Axis
            {
                Title = "Mes",
                Labels = agrupado.Select(x => x.Mes).ToList(),
                LabelsRotation = 0,
                Foreground = System.Windows.Media.Brushes.Black
            });

            chartGanancias.AxisY.Clear();
            chartGanancias.AxisY.Add(new Axis
            {
                Title = "Total ($)",
                LabelFormatter = value => $"${value:N0}",
                Foreground = System.Windows.Media.Brushes.Black
            });
        }

        private void MostrarHistoricoClientes(List<BeAlquiler> lista)
        {
            dgvClientes.Rows.Clear();

            clientesHistorico = lista
                .GroupBy(a => new { a.Cliente.id, a.Cliente.Nombre, Mes = new DateTime(a.Fecha.Year, a.Fecha.Month, 1) })
                .Select(g => new BeClienteHistorico
                {
                    Id = g.Key.id,
                    Nombre = g.Key.Nombre,
                    Mes = g.Key.Mes.ToString("MMMM yyyy"),
                    Total = g.Sum(x => x.Total),
                    Frecuencia = g.Count()
                })
                .OrderBy(x => x.Nombre)
                .ThenBy(x => x.Mes)
                .ToList();

            foreach (var c in clientesHistorico)
            {
                dgvClientes.Rows.Add(c.Id, c.Nombre, c.Mes, $"${c.Total:N0}");
            }
        }

        private void MostrarGraficoTopClientes(List<BeClienteHistorico> lista)
        {
            var top = lista
                .GroupBy(c => c.Nombre)
                .Select(g => new { Cliente = g.Key, Total = g.Sum(x => x.Total) })
                .OrderByDescending(x => x.Total)
                .Take(3)
                .ToList();

            chartClientes.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Total por Cliente",
                    Values = new ChartValues<decimal>(top.Select(x => x.Total)),
                    Fill = System.Windows.Media.Brushes.SteelBlue
                }
            };

            chartClientes.AxisX.Clear();
            chartClientes.AxisX.Add(new Axis
            {
                Title = "Cliente",
                Labels = top.Select(x => x.Cliente).ToList(),
                LabelsRotation = 0,
                Foreground = System.Windows.Media.Brushes.Black
            });

            chartClientes.AxisY.Clear();
            chartClientes.AxisY.Add(new Axis
            {
                Title = "Total ($)",
                LabelFormatter = value => $"${value:N0}",
                Foreground = System.Windows.Media.Brushes.Black
            });
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Checked ? dtpDesde.Value.Date : DateTime.MinValue;
            DateTime hasta = dtpHasta.Checked ? dtpHasta.Value.Date.AddDays(1).AddTicks(-1) : DateTime.MaxValue;

            var filtrados = listaAlquileres
                .Where(a => a.Fecha >= desde && a.Fecha <= hasta)
                .ToList();

            string formato = cmbFormato.SelectedItem.ToString();
            string baseName = "ReporteAlquileres_" + DateTime.Now.ToString("yyyyMMdd");
            string extension = formato == "PDF" ? ".pdf" : ".xlsx";
            string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(carpeta, baseName + extension);
            int i = 1;

            while (File.Exists(path))
            {
                path = Path.Combine(carpeta, baseName + "-" + i + extension);
                i++;
            }

            if (formato == "Excel")
                GenerarExcel(path, filtrados);
            else
                GenerarPDF(path, filtrados, desde, hasta);

            MessageBox.Show("Reporte generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerarExcel(string ruta, List<BeAlquiler> datos)
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Alquileres");

                ws.Cell("A1").Value = "ID";
                ws.Cell("B1").Value = "Cliente";
                ws.Cell("C1").Value = "Fecha y Hora";
                ws.Cell("D1").Value = "Total";

                ws.Range("A1:D1").Style
                    .Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.LightGray)
                    .Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                int row = 2;
                foreach (var a in datos)
                {
                    ws.Cell(row, 1).Value = a.id;
                    ws.Cell(row, 2).Value = a.Cliente?.Nombre;
                    ws.Cell(row, 3).Value = a.Fecha.ToString("dd/MM/yyyy HH:mm");
                    ws.Cell(row, 4).Value = a.Total;
                    ws.Cell(row, 4).Style.NumberFormat.Format = "$ #,##0.00";
                    row++;
                }

                var rango = ws.Range("A1:D" + (row - 1));
                rango.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rango.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                ws.Columns().AdjustToContents();
                wb.SaveAs(ruta);
            }
        }

        private void GenerarPDF(string ruta, List<BeAlquiler> datos, DateTime desde, DateTime hasta)
        {
            var doc = new Document(PageSize.A4, 40, 40, 80, 40);
            using (var fs = new FileStream(ruta, FileMode.Create))
            {
                var writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.png");
                if (File.Exists(logoPath))
                {
                    var logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.SetAbsolutePosition(150, 250);
                    logo.ScaleAbsolute(300, 300);
                    logo.Alignment = Element.ALIGN_CENTER;
                    logo.RotationDegrees = 45;
                    logo.Transparency = new int[] { 0x0F, 0x10 };
                    doc.Add(logo);
                }

                var titulo = new Paragraph($"Reporte de Alquileres - Desde {desde:dd/MM/yyyy} hasta {hasta:dd/MM/yyyy}",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14))
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20f
                };
                doc.Add(titulo);

                var table = new PdfPTable(4)
                {
                    WidthPercentage = 100
                };
                table.SetWidths(new float[] { 1, 3, 3, 2 });

                string[] headers = { "ID", "Cliente", "Fecha y Hora", "Total" };
                foreach (var h in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(h))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    table.AddCell(cell);
                }

                foreach (var a in datos)
                {
                    table.AddCell(a.id.ToString());
                    table.AddCell(a.Cliente?.Nombre);
                    table.AddCell(a.Fecha.ToString("dd/MM/yyyy HH:mm"));
                    table.AddCell("$" + a.Total.ToString("N2"));
                }

                doc.Add(table);
                doc.Close();
            }
        }
    }
}
