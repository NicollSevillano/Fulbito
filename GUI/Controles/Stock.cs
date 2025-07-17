using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }
        private int _stock;

        private void Stock_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Value = _stock;
            VerificarBotonMenos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value++;
            VerificarBotonMenos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown1.Minimum)
            {
                numericUpDown1.Value--;
                VerificarBotonMenos();
            }
        }

        private void VerificarBotonMenos()
        {
            button2.Enabled = numericUpDown1.Value > numericUpDown1.Minimum;
        }
    }

}
