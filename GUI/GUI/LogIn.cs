using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles;
using Be;
using Bll;
using ServicioClase;
using Servicios;
using Mapper;
using Microsoft.VisualBasic.ApplicationServices;
using Interface;

namespace GUI
{
    public partial class InicioSesionForm : Form, ITraducible
    {
        List<BelUsuario> lUsuario;
        BllUsuario bUsuario;
        private bool mostrar = false;

        public InicioSesionForm()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            bUsuario = new BllUsuario();
            lUsuario = bUsuario.Consulta();
            LanguageManager.Iniciarlizar();
            LanguageManager.Suscribir(this);
            //foreach (BelUsuario usuario in lUsuario)
            //{
            //    string hashedPassword = Encriptar.Encrypt(usuario.Contraseña);
            //    usuario.Contraseña = hashedPassword;
            //    bUsuario.Modificacion(usuario);
            //}
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lUsuario = bUsuario.Consulta();
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            
            if (lUsuario.Exists(x => x.Usuario == usuario))
            {
                BelUsuario _usuario = lUsuario.Find(x => x.Usuario == usuario);
                bool error = false;
                if (error)
                {
                    if (_usuario.Intentos >= 3 && Encriptar.Encrypt(_usuario.Contraseña) != _usuario.Contraseña)
                    {
                        _usuario.Bloqueado = true;
                        _usuario.Intentos = 0;
                        bUsuario.Modificacion(_usuario);
                        throw new Exception("Usuario bloqueado");
                    }
                    string aux = Encriptar.Encrypt(contraseña);
                    if (aux != _usuario.Contraseña)
                    {
                        _usuario.Intentos++;
                        bUsuario.Modificacion(_usuario);
                        throw new Exception("Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Inicio correcto");
                    Login();
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }
                void Login()
                {
                    MenuPrincipalForm mp = new MenuPrincipalForm();
                    SessionManager.LogIn(_usuario);
                    mp.smanager = SessionManager.getInstance;
                    _usuario.Intentos = 0;
                    bUsuario.Modificacion(_usuario);
                    this.Hide();
                    LogBitacora.AgregarEvento("Inicio de sesión", 1, _usuario, "LogIn");
                    mp.ShowDialog();
                    this.Show();
                }
            }
        }
        private void pMostrar_Click(object sender, EventArgs e)
        {
            mostrar = !mostrar;
            if (mostrar)
            {
                txtContraseña.PasswordChar = '\0';
                pMostrar.Image = GUI.Properties.Resources.oculto;
            }
            else
            {
                txtContraseña.PasswordChar = '*';
                pMostrar.Image = GUI.Properties.Resources.ver;
            }
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            lblInicioSesion.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lblInicioSesion").Texto;
            lblUsuario.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lblUsuario").Texto;
            lblContraseña.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lblContraseña").Texto;
            btnIngresar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnIngresar").Texto;
            btnSalirLogin.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalirLogin").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "InicioSesionForm").Texto;
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Por favor iniciar sesión");
            }
        }
    }
}
