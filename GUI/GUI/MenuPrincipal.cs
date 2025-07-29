using Be;
using Bll;
using Interface;
using ServicioClase;
using Servicios;
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
    public partial class MenuPrincipalForm : Form, ITraducible
    {
        public SessionManager smanager;
        GRegistrarClienteForm registrarCliente;
        GReservasForm reservas;
        GUsuariosForm usuarios;
        CambiarClaveForm cambiarClave;
        PerfilesForm perfiles;
        TarjetaForm tarjeta; 
        List<BelUsuario> lUsuario;
        BllUsuario bUsuario;
        BelUsuario _usuario;
        BitacoraEventosform _bEventos;
        ControlCanchasform _canchas;
        BackUpForm backrestore;
        AlquilarInsumos alquilarInsumos;
        BitacoraCambiosForm _bitacoraCambios;
        InsumosForm insumos;
        ReporteInteligente inteligente;
        Ayudaform ayuda;
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            _usuario = new BelUsuario();
            bUsuario = new BllUsuario();
            lUsuario = bUsuario.Consulta();

            // Suscribirse primero
            LanguageManager.Suscribir(this);

            // Actualizar idioma antes de crear los formularios
            LanguageManager.Actualizar(SessionManager.getInstance.usuario.IdiomaId);

            reservas = new GReservasForm();
            registrarCliente = new GRegistrarClienteForm();
            usuarios = new GUsuariosForm();
            cambiarClave = new CambiarClaveForm();
            tarjeta = new TarjetaForm();
            _bEventos = new BitacoraEventosform();
            _canchas = new ControlCanchasform();
            backrestore = new BackUpForm();
            alquilarInsumos = new AlquilarInsumos();
            insumos = new InsumosForm();
            _bitacoraCambios = new BitacoraCambiosForm();
            inteligente = new ReporteInteligente();
            ayuda = new Ayudaform();

            LanguageManager.Suscribir(reservas);
            LanguageManager.Suscribir(registrarCliente);
            LanguageManager.Suscribir(usuarios);
            LanguageManager.Suscribir(cambiarClave);
            LanguageManager.Suscribir(tarjeta);
            LanguageManager.Suscribir(_bEventos);
            LanguageManager.Suscribir(_canchas);
            LanguageManager.Suscribir(backrestore);
            LanguageManager.Suscribir(alquilarInsumos);
            LanguageManager.Suscribir(insumos);
            LanguageManager.Suscribir(_bitacoraCambios);
            LanguageManager.Suscribir(inteligente);
            LanguageManager.Suscribir(ayuda);

            labUsuarioMp.Text = smanager.usuario.Nombre;
            labPerfilMp.Text = smanager.usuario.Perfil.Nombre;

            habilitarControles();
        }

        private void habilitarControles()
        {
            List<Permiso> lPermiso = new List<Permiso>();
            (SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto).RellenaArrayPermisos(SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto, lPermiso);
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                if (menu.Name != null)
                {
                    menu.Visible = false;
                    foreach (Permiso permiso in lPermiso)
                    {
                        if (menu.Name.ToString() == permiso.Nombre)
                        {
                            menu.Visible = true;
                        }
                    }
                }
                foreach (ToolStripMenuItem item in menu.DropDownItems)
                {
                    if (item.Name != null)
                    {
                        item.Visible = false;
                        foreach (Permiso permiso in lPermiso)
                        {
                            if(item.Name.ToString() == permiso.Nombre)
                            {
                                item.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void verificarIntegridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var inconsistencias = new Inconsistencia())
            {
                inconsistencias.ShowDialog();
            }
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarCliente.ShowDialog();
            this.Show();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            reservas.ShowDialog();
            this.Show();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios.ShowDialog();
            this.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            SessionManager.LogOut();
            this.Close();
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
                MessageBox.Show("Que bueno que te quedas!");
            }
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bEventos.ShowDialog();
            this.Show();
        }

        private void registrarCanchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _canchas.ShowDialog();
            this.Show();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backrestore.ShowDialog();
            this.Show();
        }


        private void insumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alquilarInsumos.ShowDialog();
            this.Show();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insumos.ShowDialog();
            this.Show();
        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bitacoraCambios.ShowDialog();
            this.Show();
        }

        private void reporteInteligenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inteligente.ShowDialog();
            this.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda.ShowDialog();
            this.Show();
        }
    }
}
