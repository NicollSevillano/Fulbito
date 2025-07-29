using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Be;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Servicios
{
    public class FacturaReporte
    {
        public static void Reporte(BeReserva pReserva)
        {
            float widthInPoints = 7f * 28.35f;
            float heightInPoints = 10f * 28.35f;

            SaveFileDialog path = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                FileName = $"Reserva_{pReserva.id}.pdf",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads"
            };

            if (path.ShowDialog() == DialogResult.OK)
            {
                var document = new Document(new Rectangle(widthInPoints, heightInPoints), 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path.FileName, FileMode.Create));
                document.Open();

                DibujarBorde(document, writer);

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font normalFont = new Font(bf, 10.5f, Font.NORMAL, BaseColor.BLACK);
                Font boldFont = new Font(bf, 10.5f, Font.BOLD, BaseColor.BLACK);
                Font titleFont = new Font(bf, 12f, Font.BOLD | Font.UNDERLINE, BaseColor.BLACK);

                document.Add(new Paragraph("[Factura - Reserva]", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 15f
                });

                AgregarLinea(document, $"ID: {pReserva.id}", boldFont);
                AgregarLinea(document, $"Cancha: {pReserva.Cancha.Nombre}", boldFont);
                AgregarLinea(document, $"Cliente: {pReserva.Cliente.Nombre}", boldFont);
                AgregarLinea(document, $"Fecha y hora: {pReserva.Fecha:dd/MM/yyyy} {pReserva.Hora}", boldFont);
                AgregarLinea(document, $"Total por hora: ${pReserva.Cancha.Precio:N0}", boldFont);

                AgregarImagenFinal(writer, widthInPoints, 80f);
                document.Close();
                Process.Start(path.FileName);
            }
        }

        public static void Reporte(BeAlquiler alquiler, List<InsumoResumen> insumos)
        {
            float widthInPoints = 7f * 28.35f;
            float baseHeight = 10f * 28.35f;
            float extraHeight = insumos.Count * 20f;
            float heightInPoints = baseHeight + extraHeight;

            SaveFileDialog path = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                FileName = $"Alquiler_{alquiler.id}.pdf",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads"
            };

            if (path.ShowDialog() == DialogResult.OK)
            {
                var document = new Document(new Rectangle(widthInPoints, heightInPoints), 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path.FileName, FileMode.Create));
                document.Open();

                DibujarBorde(document, writer);

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font normalFont = new Font(bf, 10.5f, Font.NORMAL, BaseColor.BLACK);
                Font boldFont = new Font(bf, 10.5f, Font.BOLD, BaseColor.BLACK);
                Font titleFont = new Font(bf, 12f, Font.BOLD | Font.UNDERLINE, BaseColor.BLACK);

                document.Add(new Paragraph("[Factura - Alquiler]", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 15f
                });

                AgregarLinea(document, $"ID: {alquiler.id}", boldFont);
                AgregarLinea(document, $"Cliente: {alquiler.Cliente.Nombre}", boldFont);
                AgregarLinea(document, $"Horas: {alquiler.Horas} hora{(alquiler.Horas > 1 ? "s" : "")}", boldFont);

                document.Add(new Paragraph("Insumos:", boldFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingBefore = 10f,
                    SpacingAfter = 5f
                });

                foreach (var insumo in insumos)
                {
                    string detalle = $"- {insumo.Nombre} x{insumo.Cantidad}: ${insumo.Subtotal:N0}";
                    document.Add(new Paragraph(detalle, normalFont) { Alignment = Element.ALIGN_CENTER });
                }

                document.Add(new Paragraph("Total:", boldFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingBefore = 12f
                });

                document.Add(new Paragraph($"${alquiler.Total:N0}", normalFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20f
                });

                AgregarImagenFinal(writer, widthInPoints, 80f);
                document.Close();
                Process.Start(path.FileName);
            }
        }

        private static void AgregarLinea(Document doc, string texto, Font font)
        {
            doc.Add(new Paragraph(texto, font)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 3f
            });
        }

        private static void DibujarBorde(Document doc, PdfWriter writer)
        {
            PdfContentByte canvas = writer.DirectContent;
            canvas.SetLineWidth(0.5f);
            canvas.SetGrayStroke(0.7f);
            canvas.Rectangle(
                doc.LeftMargin - 10,
                doc.BottomMargin - 10,
                doc.PageSize.Width - doc.LeftMargin - doc.RightMargin + 20,
                doc.PageSize.Height - doc.TopMargin - doc.BottomMargin + 20
            );
            canvas.Stroke();
        }

        private static void AgregarImagenFinal(PdfWriter writer, float width, float imageHeight)
        {
            string logoPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Servicios\img\logo.png"));

            if (File.Exists(logoPath))
            {
                var img = iTextSharp.text.Image.GetInstance(logoPath);
                img.ScaleToFit(width * 0.5f, imageHeight);

                float x = (width - img.ScaledWidth) / 2;
                float y = 25f;
                img.SetAbsolutePosition(x, y);

                PdfGState gState = new PdfGState();
                gState.FillOpacity = 0.3f; 

                PdfContentByte cb = writer.DirectContentUnder;
                cb.SaveState();
                cb.SetGState(gState);
                cb.AddImage(img);
                cb.RestoreState();
            }
        }

    }
}
