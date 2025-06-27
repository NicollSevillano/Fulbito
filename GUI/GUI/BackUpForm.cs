using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Mapper;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BackUpForm : Form
    {
        private BackUpRestoreMapper backrestore = new BackUpRestoreMapper();
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if(folderDialog.ShowDialog() == DialogResult.OK) { txtBackUp.Text = folderDialog.SelectedPath; }
            }
        }

        private void pictureBoxRestore_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Backup Files (*.bak)|*.bak";
                if(openFileDialog.ShowDialog() == DialogResult.OK) { txtRestore.Text = openFileDialog.FileName; }
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBackUp.Text))
            {
                try
                {
                    backrestore.RealizarBackUp(txtBackUp.Text);
                    MessageBox.Show("Backup realizado con éxito");
                    txtBackUp.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el Backup: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una ubicación del Backup");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRestore.Text))
            {
                try
                {
                    backrestore.RealizarRestore(txtRestore.Text);
                    MessageBox.Show("Restauración realizada con éxito");
                    txtRestore.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al restaurar la bas base de datos:{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un archivo de restore");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
