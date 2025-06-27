using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using System.CodeDom.Compiler;

namespace Controles
{
    public partial class ComboIdioma: UserControl
    {
        public ComboIdioma()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.Items.AddRange(
                Enumerable.Repeat<string>("", imageList1.Images.Count).ToArray()
            );
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            string[] items = new string[] { "Español", "Inglés" };
            if (e.Index >= 0)
            {
                if (e.Index < imageList1.Images.Count)
                {
                    Image img = new Bitmap(imageList1.Images[e.Index], new Size(15, 15));
                    e.Graphics.DrawImage(img, new PointF(e.Bounds.Left, e.Bounds.Top));
                }
                e.Graphics.DrawString(string.Format(items[e.Index], e.Index + 1)
                , e.Font, new SolidBrush(e.ForeColor)
                , e.Bounds.Left + 32, e.Bounds.Top);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex >= 0)
            {
                pictureBox1.Image = imageList1.Images[comboBox.SelectedIndex];
                LanguageManager.Actualizar(comboBox1.SelectedIndex + 1);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        public ComboBox retornacmBox()
        {
            return comboBox1;
        }
    }
}
