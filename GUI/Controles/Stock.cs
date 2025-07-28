using System;
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

        public event EventHandler CantidadCambiada;

        public int CantidadSeleccionada
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Value = _stock;
            VerificarBotonMenos();
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
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

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            VerificarBotonMenos();
            CantidadCambiada?.Invoke(this, EventArgs.Empty);
        }
    }
}
