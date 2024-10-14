using Interface;
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
    public partial class InsumosForm : Form, ITraducible
    {
        public InsumosForm()
        {
            InitializeComponent();
        }

        public void Actualizar(string pIdioma)
        {
            throw new NotImplementedException();
        }

        private void InsumosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
