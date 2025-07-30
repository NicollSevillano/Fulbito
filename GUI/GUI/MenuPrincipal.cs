using Be;
using Bll;
using Interface;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuPrincipalForm : Form, ITraducible
    {
        public SessionManager smanager;

        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LanguageManager.Suscribir(this); 
            LanguageManager.Actualizar(int.Parse(SessionManager.getInstance.usuario.IdiomaId.id));

            habilitarControles();
            labUsuarioMp.Text = smanager.usuario.Nombre;
            labPerfilMp.Text = smanager.usuario.Perfil.Nombre;
        }

        private void habilitarControles()
        {
            List<Permiso> lPermiso = new List<Permiso>();
            (SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto).RellenaArrayPermisos(SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto, lPermiso);

            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                menu.Visible = false;
                foreach (Permiso permiso in lPermiso)
                {
                    if (menu.Name == permiso.Nombre)
                        menu.Visible = true;
                }

                foreach (ToolStripMenuItem item in menu.DropDownItems)
                {
                    item.Visible = false;
                    foreach (Permiso permiso in lPermiso)
                    {
                        if (item.Name == permiso.Nombre)
                            item.Visible = true;
                    }
                }
            }
        }


        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new GRegistrarClienteForm();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var f = new GReservasForm();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new GUsuariosForm();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void registrarCanchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ControlCanchasform();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new BackUpForm();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void insumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new AlquilarInsumos();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new InsumosForm();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new BitacoraCambiosForm();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new BitacoraEventosform();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void reporteInteligenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ReporteInteligente();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Ayudaform();
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void verificarIntegridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Inconsistencia(LanguageManager.CodIdiomaActual);
            LanguageManager.Suscribir(f);
            f.ShowDialog();
        }

        private void btnSalirm_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                SessionManager.LogOut();
                this.Close();
                MessageBox.Show("Salió con éxito");
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("¡Qué bueno que te quedás!");
            }
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);

            labNombreMp.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labNombreMp").Texto;
            labRolMp.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labRolMp").Texto;
            labPerfilMp.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labPerfilMp").Texto;

            administradorToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "administradorToolStripMenuItem").Texto;
            reservaToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "reservaToolStripMenuItem").Texto;
            toolStripMenuItem2.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "toolStripMenuItem2").Texto;
            clientesToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "clientesToolStripMenuItem").Texto;
            registrarClienteToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "registrarClienteToolStripMenuItem").Texto;

            bitácoraToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "bitácoraToolStripMenuItem").Texto;
            eventosToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "eventosToolStripMenuItem").Texto;
            cambiosToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "cambiosToolStripMenuItem").Texto;
            usuariosToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "usuariosToolStripMenuItem").Texto;

            canchasToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "canchasToolStripMenuItem").Texto;
            registrarCanchaToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "registrarCanchaToolStripMenuItem").Texto;

            insumosToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "insumosToolStripMenuItem").Texto;
            insumosToolStripMenuItem1.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "insumosToolStripMenuItem1").Texto;

            backUpToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "backUpToolStripMenuItem").Texto;
            reporteInteligenteToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "reporteInteligenteToolStripMenuItem").Texto;

            ayudaToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "ayudaToolStripMenuItem").Texto;
            btnSalirm.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalirm").Texto;

            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "MenuPrincipalForm").Texto;
        }
    }
}
