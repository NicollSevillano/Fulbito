﻿using Be;
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
        TarjetaForm tarjeta;
        List<BelUsuario> lUsuario;
        BllUsuario bUsuario;
        BelUsuario _usuario;
        BitacoraEventosForm _bEventos;
        CanchasForm _canchas;
        BackUpForm backrestore;
        InsumosForm insumos;
        BitacoraCambiosForm cambios;
        Alquilarform alquilar;
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            habilitarControles();
            _usuario = new BelUsuario();
            bUsuario = new BllUsuario();
            lUsuario = bUsuario.Consulta();
            reservas = new GReservasForm();
            registrarCliente = new GRegistrarClienteForm();
            usuarios = new GUsuariosForm();
            cambiarClave = new CambiarClaveForm();
            tarjeta = new TarjetaForm();
            _bEventos = new BitacoraEventosForm();
            LanguageManager.Suscribir(reservas);
            LanguageManager.Suscribir(registrarCliente);
            LanguageManager.Suscribir(usuarios);
            LanguageManager.Suscribir(cambiarClave);
            LanguageManager.Suscribir(tarjeta);
            labUsuarioMp.Text = smanager.usuario.Nombre;
            labPerfilMp.Text = smanager.usuario.Perfil.Nombre;
            LanguageManager.Suscribir(this);
            _canchas = new CanchasForm();
            backrestore = new BackUpForm();
            insumos = new InsumosForm();
            cambios = new BitacoraCambiosForm();
            alquilar = new Alquilarform();
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
                            if (item.Name.ToString() == permiso.Nombre)
                            {
                                item.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrarCliente.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservas.ShowDialog();
            this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuarios.ShowDialog();
            this.Show();
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
        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labNombreMp.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labNombreMp").Texto;
            labRolMp.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labRolMp").Texto;
            administradorToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "administradorToolStripMenuItem").Texto;
            reservaToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "reservaToolStripMenuItem").Texto;
            clientesToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "clientesToolStripMenuItem").Texto;
            toolStripMenuItem2.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "toolStripMenuItem2").Texto;
            registrarClienteToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "registrarClienteToolStripMenuItem").Texto;
            usuariosToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "usuariosToolStripMenuItem").Texto;
            ayudaToolStripMenuItem.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "ayudaToolStripMenuItem").Texto;
            btnSalirm.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalirm").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "MenuPrincipalForm").Texto;
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _bEventos.ShowDialog();
            this.Show();
        }

        private void registrarCanchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _canchas.ShowDialog();
            this.Show();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            backrestore.ShowDialog();
            this.Show();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            insumos.ShowDialog();
            this.Show();
        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cambios.ShowDialog();
            this.Show();
        }

        private void alquilarInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            alquilar.ShowDialog();
            this.Show();
        }
    }
}
