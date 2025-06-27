using Be;
using Bll;
using Interface;
using Servicios;
using ServicioClase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class PerfilesForm : Form, ITraducible
    {
        BelUsuario beUsuario;
        BllUsuario bllUsuario;
        public PerfilesForm(BelUsuario pUsuario)
        {
            InitializeComponent();
            beUsuario = pUsuario;
            bllUsuario = new BllUsuario();
            lbNombrePerfil.Text = pUsuario.Nombre;
            ActualizarPermisos();
            actualizarTree();
            ActualizarPerfiles();
            HabilitarControl();
            LanguageManager.Suscribir(this);
        }
        private void RegistroReservas_Load(object sender, EventArgs e)
        {

        }
        private void actualizarTree()
        {
            treeView1.Nodes.Clear();
            TreeNode node = new TreeNode("Permisos");
            node.Name = "Permisos";
            treeView1.Nodes.Add(node);
            recursivaTreeView(PerfilManager.pCompuestoRaiz, node);
        }
        private void recursivaTreeView(PermisoCompuesto pCompuesto, TreeNode nodo)
        {
            foreach (Permiso p in pCompuesto.lPermiso)
            {
                TreeNode nodoT = new TreeNode(p.Nombre);
                nodoT.Name = p.Nombre;
                nodo.Nodes.Add(nodoT);
                if (p is PermisoCompuesto)
                {
                    nodo = nodoT;
                    recursivaTreeView(p as PermisoCompuesto, nodo);
                    nodo = nodoT.Parent;
                }
            }
        }
        private void ActualizarPermisos()
        {
            listBox2.Items.Clear();
            permisosRecursiva(PerfilManager.pCompuestoRaiz);
        }
        private void permisosRecursiva(PermisoCompuesto pRaiz)
        {
            foreach (Permiso permiso in pRaiz.lPermiso)
            {
                if (permiso is PermisoCompuesto)
                {                    
                    if (!listBox2.Items.Contains(permiso.Nombre))
                    {
                        listBox2.Items.Add(permiso.Nombre.ToString());
                    }
                    permisosRecursiva((PermisoCompuesto)permiso);
                }
            }
        }
        private void ActualizarPerfiles()
        {
            listBox1.Items.Clear();
            foreach (Perfil p in PerfilManager.lPerfil)
            {
                listBox1.Items.Add(p.Nombre);
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Nombre del perfil:");
                Perfil perfil = new Perfil(nombre, null);
                PerfilManager.AltaNombrePerfil(perfil);
                ActualizarPerfiles();
                LogBitacora.AgregarEvento("Crear perfil", 3, SessionManager.getInstance.usuario, "Perfiles");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Perfil aux = PerfilManager.lPerfil.Find(x => x.Nombre == listBox1.Text);
            PerfilManager.BajaPerfil(int.Parse(aux.id));
            List<BelUsuario> listUsuario = bllUsuario.Consulta();
            if(listUsuario.Exists(x => x.Perfil == aux))
            {
                BelUsuario _usuario = listUsuario.Find(x => x.Perfil == aux);
                _usuario.Perfil = PerfilManager.lPerfil.Find(x => x.Nombre == "--");
                bllUsuario.Modificacion(_usuario);
            }
            ActualizarPerfiles();
            HabilitarControl();
            LogBitacora.AgregarEvento("Borrar perfil", 3, SessionManager.getInstance.usuario, "Perfiles");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Perfil aux = PerfilManager.lPerfil.Find(x => x.Nombre == listBox1.Text);
            Permiso permiso = PerfilManager.pCompuestoRaiz.BuscarPermisoNombre(listBox2.Text, PerfilManager.pCompuestoRaiz);
            aux.Permiso = permiso;
            PerfilManager.ModificarPerfil(aux);
            actualizarTree();
            HabilitarControl();
            LogBitacora.AgregarEvento("Agregar permisos al perfil", 3, SessionManager.getInstance.usuario, "Perfiles");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            PerfilManager.ActualizaListaPerfil();
            LogBitacora.AgregarEvento("Salir del form Perfiles", 1, SessionManager.getInstance.usuario, "Perfiles");
        }
        public void HabilitarControl()
        {
            List<Permiso> permiso = new List<Permiso>();
            (SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto).RellenaArrayPermisos(SessionManager.getInstance.usuario.Perfil.Permiso as PermisoCompuesto, permiso);
            foreach (Control c in this.Controls)
            {
                if(c is Button && c.Tag != null)
                {
                    (c as Button).Enabled = false;
                    foreach (Permiso p in permiso)
                    {
                        if(c.Tag.ToString() == p.Nombre)
                        {
                            (c as Button).Enabled = true;
                        }
                    }
                }
            }
        }
        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labPerfil.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labPerfil").Texto;
            lbPerfil.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbPerfil").Texto;
            lbPermiso.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbPermiso").Texto;
            listBox1.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "listBox1").Texto;
            listBox2.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "listBox2").Texto;
            btnCrear.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCrear").Texto;
            btnBorrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnBorrar").Texto;
            btnAgregar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnAgregar").Texto;
            btnCerrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCerrar").Texto;
            btnModificarperfil.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnModificarperfil").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "PerfilesForm").Texto;
        }

        private void btnModificarperfil_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de cambiar el Permiso del perfil actual?", "Modificando perfil actual...", MessageBoxButtons.YesNo); ;
            if(resultado == DialogResult.Yes)
            {
                Perfil aux = PerfilManager.lPerfil.Find(x => x.Nombre == listBox1.Text);
                beUsuario.Perfil = aux;
                bllUsuario.Modificacion(beUsuario);
                LogBitacora.AgregarEvento("Modificar perfil actual", 3, SessionManager.getInstance.usuario, "Perfiles");
                ActualizarPerfiles();
            }
        }
    }
}
