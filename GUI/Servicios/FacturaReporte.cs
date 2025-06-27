using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            float widthInCM = 6f; // ancho en centímetros
            float heightInCM = 12f; // alto en centímetros

            float widthInPoints = widthInCM * 28.35f; // ancho en puntos
            float heightInPoints = heightInCM * 28.35f; // alto en punto

            SaveFileDialog path = new SaveFileDialog();
            path.Filter = "PDF Files|*.pdf";
            path.FileName = "";
            path.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

            if (path.ShowDialog() == DialogResult.OK)
            {
                var document = new Document(new iTextSharp.text.Rectangle(widthInPoints, heightInPoints), 15, 15, 15, 15);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path.FileName, FileMode.Create));
                document.Open();

                //Fuente
                BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1250, true);
                iTextSharp.text.Font couFont = new iTextSharp.text.Font(bf, 12f, iTextSharp.text.Font.NORMAL, new BaseColor(100, 94, 92));
                document.Add(new Paragraph($"Id: {pReserva.id}", couFont));
                document.Add(new Paragraph($"Cancha: {pReserva.Cancha.Nombre}", couFont));
                document.Add(new Paragraph($"Cliente: {pReserva.Cliente.Nombre}", couFont));
                document.Add(new Paragraph($"Fecha y hora: {pReserva.Fecha.ToString("dd/MM/yyyy")}, {pReserva.Hora}", couFont));
                document.Add(new Paragraph($"Total por hora: ${pReserva.Cancha.Precio}", couFont));

                //Marcos
                PdfContentByte canva = writer.DirectContent;
                canva.SetLineWidth(2f);
                canva.Stroke();

                //Marca de agua
                string marcaAgua = @"C:\Users\nicol\Escritorio\ProyectoFulbito\img\logo.png";
                if (File.Exists(marcaAgua))
                {
                    Image img = Image.GetInstance(marcaAgua);
                    img.SetAbsolutePosition(0, 0);
                    img.ScaleToFit(widthInPoints, heightInPoints);
                    img.Alignment = Image.UNDERLYING;

                    PdfContentByte cb = writer.DirectContentUnder;
                    cb.SaveState();
                    PdfGState gstate = new PdfGState { FillOpacity = 0.2f };
                    cb.SetGState(gstate);
                    cb.AddImage(img);
                    cb.RestoreState();
                    document.Add(img);
                }

                document.Close();
                Process.Start(path.FileName);
            }
        }
    }
}