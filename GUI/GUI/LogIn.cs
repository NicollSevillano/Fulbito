using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controles;
using Be;
using Bll;
using ServicioClase;
using Servicios;
using Mapper;
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

            LanguageManager.Suscribir(this);
            this.Actualizar(LanguageManager.CodIdiomaActual.ToString());
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lUsuario = bUsuario.Consulta();
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (lUsuario.Exists(x => x.Usuario == usuario))
            {
                BelUsuario _usuario = lUsuario.Find(x => x.Usuario == usuario);

                if (_usuario.Bloqueado)
                {
                    MessageBox.Show("Cuenta bloqueada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string passEncriptada = Encriptar.Encrypt(contraseña);
                if (passEncriptada != _usuario.Contraseña)
                {
                    _usuario.Intentos++;
                    bUsuario.Modificacion(_usuario);

                    if (_usuario.Intentos >= 3)
                    {
                        _usuario.Bloqueado = true;
                        bUsuario.Modificacion(_usuario);
                        MessageBox.Show("Cuenta bloqueada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                _usuario.Intentos = 0;
                bUsuario.Modificacion(_usuario);

                SessionManager.LogIn(_usuario);

                LanguageManager.CodIdiomaActual = int.Parse(_usuario.IdiomaId.id);
                LanguageManager.Actualizar(int.Parse(_usuario.IdiomaId.id));

                bool hayInconsistencia = !IntegridadOk();
                bool esAdmin = _usuario.Perfil != null &&
                               _usuario.Perfil.Nombre.Equals("Administrador", StringComparison.OrdinalIgnoreCase);

                if (hayInconsistencia && !esAdmin)
                {
                    MessageBox.Show("Se ha detectado una inconsistencia en la BD, comuníquese con el Administrador.",
                        "Inconsistencia de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    return;
                }

                if (hayInconsistencia && esAdmin)
                {
                    using (var incForm = new Inconsistencia(int.Parse(_usuario.IdiomaId.id)))
                    {
                        incForm.ShowDialog();
                    }
                }

                LogBitacora.AgregarEvento("Inicio de sesión", 1, _usuario, "LogIn");

                MenuPrincipalForm mp = new MenuPrincipalForm();
                LanguageManager.Suscribir(mp);
                mp.smanager = SessionManager.getInstance;

                this.Hide();
                mp.ShowDialog();
                this.Show();

                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login(BelUsuario _usuario)
        {
            SessionManager.LogIn(_usuario);

            LanguageManager.CodIdiomaActual = int.Parse(_usuario.IdiomaId.id);
            LanguageManager.Actualizar(int.Parse(_usuario.IdiomaId.id));

            MenuPrincipalForm mp = new MenuPrincipalForm();
            LanguageManager.Suscribir(mp);
            mp.smanager = SessionManager.getInstance;

            LogBitacora.AgregarEvento("Inicio de sesión", 1, _usuario, "LogIn");

            this.Hide();
            mp.ShowDialog();
            this.Show();
        }

        private bool IntegridadOk()
        {
            DigitoVerificador dv = new DigitoVerificador();
            string[] tablas = { "Cliente", "Cancha", "Reserva" };

            foreach (var tabla in tablas)
            {
                var errores = dv.VerificarTabla(tabla);
                if (errores.Count > 0)
                    return false;
            }
            return true;
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
