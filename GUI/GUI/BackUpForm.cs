using Interface;
using Servicios;
using System;
using System.Windows.Forms;
using Mapper;

namespace GUI
{
    public partial class BackUpForm : Form, ITraducible
    {
        private BackUpRestoreMapper backrestore = new BackUpRestoreMapper();

        public BackUpForm()
        {
            InitializeComponent();
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            LanguageManager.Suscribir(this);
            LanguageManager.Actualizar(int.Parse(SessionManager.getInstance.usuario.IdiomaId.id));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBackUp.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void pictureBoxRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Backup Files (*.bak)|*.bak";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRestore.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBackUp.Text))
            {
                try
                {
                    backrestore.RealizarBackUp(txtBackUp.Text);
                    MessageBox.Show(Traductor.ObtenerTexto("backupExito"));
                    txtBackUp.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{Traductor.ObtenerTexto("errorBackup")}: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(Traductor.ObtenerTexto("seleccionarUbicacionBackup"));
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRestore.Text))
            {
                try
                {
                    backrestore.RealizarRestore(txtRestore.Text);
                    MessageBox.Show(Traductor.ObtenerTexto("restoreExito"));
                    txtRestore.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{Traductor.ObtenerTexto("errorRestore")}: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(Traductor.ObtenerTexto("seleccionarArchivoRestore"));
            }
        }

        private void btnVolverBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Actualizar(string pIdioma)
        {
            var idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);

            if (idioma == null) return;

            this.Text = idioma.lEtiqueta.Find(x => x.ControlT == "BackUpForm")?.Texto ?? this.Text;
            labRespaldo.Text = idioma.lEtiqueta.Find(x => x.ControlT == "labRespaldo")?.Texto ?? labRespaldo.Text;
            btnBackUp.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnBackUp")?.Texto ?? btnBackUp.Text;
            lblRestaurar.Text = idioma.lEtiqueta.Find(x => x.ControlT == "lblRestaurar")?.Texto ?? lblRestaurar.Text;
            btnRestore.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnRestore")?.Texto ?? btnRestore.Text;
            btnVolverBack.Text = idioma.lEtiqueta.Find(x => x.ControlT == "btnVolverBack")?.Texto ?? btnVolverBack.Text;
        }
    }
}
