using Be;
using Bll;
using Mapper;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Interface;

namespace GUI
{
    public partial class GUsuariosForm : Form, ITraducible
    {
        List<BelUsuario> lUsuario;
        BllUsuario bllUsuario;
        BelUsuario beUsuario;
        CambiarClaveForm cambiarClave;
        Perfil perfil;

        public GUsuariosForm()
        {
            InitializeComponent();
        }

        private void GUsuarios_Load(object sender, EventArgs e)
        {
            bllUsuario = new BllUsuario();
            lUsuario = bllUsuario.Consulta();
            RefrescarDgv();
            CargarPerfiles();
            cambiarClave = new CambiarClaveForm();
        }
        private bool CargarTxt()
        {
            bool txtValidad = false;
            if (txtDni.Text == string.Empty ||
                txtNombre.Text == string.Empty ||
                txtApellido.Text == string.Empty ||
                txtEmail.Text == string.Empty ||
                txtUsuario.Text == string.Empty ||
                txtContraseña.Text == string.Empty)
            {
                txtValidad = true;
            }
            return txtValidad;

        }
        private void CargarPerfiles()
        {
            cmbPerfiles.Items.Clear();
            List<Perfil> lPerfil = PerfilManager.lPerfil;
            foreach (Perfil p in lPerfil)
            {
                cmbPerfiles.Items.Add(p.Nombre);
                
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CargarTxt())
                {

                    throw new Exception("Error al agregar el usuario");
                }
                
                else
                {
                    perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == cmbPerfiles.Text);
                    bllUsuario.Alta(new BelUsuario(txtDni.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, perfil, txtUsuario.Text, Encriptar.Encrypt(txtContraseña.Text)));
                    lUsuario = bllUsuario.Consulta();
                    LogBitacora.AgregarEvento("Registrar Usuario", 1, SessionManager.getInstance.usuario, "Usuarios");
                    MessageBox.Show("Usuario agregado");
                    RefrescarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsuarios.SelectedRows)
                {
                    int userId = Convert.ToInt32(row.Cells[0].Value);
                    bllUsuario.Baja(userId);
                    lUsuario = bllUsuario.Consulta();
                }
                LogBitacora.AgregarEvento("Borrar Usuario", 3, SessionManager.getInstance.usuario, "Usuarios");
                MessageBox.Show("Usuario eliminado");
            }
            RefrescarDgv();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BelUsuario aux = LlamarUsuario();
                string dni = Interaction.InputBox("DNI:", "Modificando...", aux.DNI);
                string nombre = Interaction.InputBox("Nombre:", "Modificando...", aux.Nombre);
                string apellido = Interaction.InputBox("Apellido:", "Modificando...", aux.Apellido);
                string email = Interaction.InputBox("Email:", "Modificando...", aux.Email);
                string usuario = Interaction.InputBox("Usuario:", "Modificando...", aux.Usuario);
                aux.DNI = dni;
                aux.Nombre = nombre;
                aux.Apellido = apellido;
                aux.Email = email;
                aux.Usuario = usuario;

                //aux.Perfil = PerfilManager.ConsultaPerfil().Find(x => x.Nombre == "");
                bllUsuario.Modificacion(aux);
                lUsuario = bllUsuario.Consulta();
                RefrescarDgv();
                LogBitacora.AgregarEvento("Modificar Usuario", 3, SessionManager.getInstance.usuario, "Usuarios");
                MessageBox.Show("Usuario modificado exitosamente");
            }


            catch (Exception)
            {
                throw;
            }
        }
        private void FiltroDgv()
        {
            try
            {
                dgvUsuarios.Rows.Clear();
                foreach (BelUsuario b in lUsuario)
                {
                    dgvUsuarios.Rows.Add(new object[] { b.id, b.DNI, b.Nombre, b.Apellido, b.Email, b.Perfil.id, b.Usuario, b.Contraseña, b.Bloqueado, b.Activo });
                    if (b.Bloqueado)
                    {
                        dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (b.Activo == false)
                    {
                        dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarDgv()
        {
            dgvUsuarios.Rows.Clear();
            foreach (BelUsuario item in lUsuario)
            {
                if(item.Perfil == null) { dgvUsuarios.Rows.Add(item.id, item.DNI, item.Nombre, item.Apellido, item.Email, "", item.Usuario, item.Contraseña, item.Bloqueado, item.Activo); }
                else
                { dgvUsuarios.Rows.Add(item.id, item.DNI, item.Nombre, item.Apellido, item.Email, item.Perfil.Nombre, item.Usuario, item.Contraseña, item.Bloqueado, item.Activo); }
            }
            FiltroDgv();
        }
        private void cbBloqueados_TextChanged(object sender, EventArgs e)
        {
            List<BelUsuario> t = lUsuario;
            if (cbBloqueadosU.Checked) t = lUsuario.Where(x => x.Bloqueado == cbBloqueadosU.Checked).ToList<BelUsuario>();
        }
        private BelUsuario LlamarUsuario()
        {
            return lUsuario.Find(x => x.id == dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            BelUsuario x = LlamarUsuario();
            if (x.Bloqueado)
            {
                x.Bloqueado = false;
            }
            else
            {
                x.Bloqueado = true;
            }
            bllUsuario.Modificacion(x);
            lUsuario = bllUsuario.Consulta();
            LogBitacora.AgregarEvento("Desbloquear usuario", 3, SessionManager.getInstance.usuario, "Usuarios");
            RefrescarDgv();
        }
        private void btnActivar_Click(object sender, EventArgs e)
        {
            BelUsuario x = LlamarUsuario();
            if (x.Activo)
            {
                x.Activo = false;
            }
            else
            {
                x.Activo = true;
            }
            bllUsuario.Modificacion(x);
            lUsuario = bllUsuario.Consulta();
            RefrescarDgv();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();
        }
        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                txtDni.Text = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[2].Value.ToString();
                txtApellido.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtUsuario.Text = row.Cells[6].Value.ToString();
                txtContraseña.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void cbBloqueados_CheckedChanged(object sender, EventArgs e)
        {
            List<BelUsuario> t = lUsuario;
            t = lUsuario.Where(x => x.Bloqueado == cbBloqueadosU.Checked).ToList<BelUsuario>();
            lUsuario = t;
            RefrescarDgv();
        }
        private void btnCambiarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            cambiarClave.beUsuario = LlamarUsuario();
            cambiarClave.ShowDialog();
            this.Show();
            lUsuario = bllUsuario.Consulta();
            LogBitacora.AgregarEvento("Cambiar clave del usuario", 3, SessionManager.getInstance.usuario, "Usuarios");
            RefrescarDgv();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            PerfilesForm perfil = new PerfilesForm(LlamarUsuario());
            //Agregar prop idioma al constructor perfil
            //LanguageManager.Suscribir(perfil);
            //LanguageManager.Actualizar(this);
            perfil.ShowDialog();
            bllUsuario.Consulta();
            this.Show();
            CargarPerfiles();
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            RefrescarDgv();
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            lbDatosU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "lbDatosU").Texto;
            labDniU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labDniU").Texto;
            labNombreU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labNombreU").Texto;
            labApellidoU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labApellidoU").Texto;
            labEmailU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labEmailU").Texto;
            labUsuarioU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labUsuarioU").Texto;
            labContraseñaU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labContraseñaU").Texto;
            btnAgregarU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnAgregarU").Texto;
            btnBorrarU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnBorrarU").Texto;
            btnModificarU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnModificarU").Texto;
            labRol.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labRol").Texto;
            btnCambiarCU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnCambiarCU").Texto;
            labFiltrarU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labFiltrarU").Texto;
            cbBloqueadosU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "cbBloqueadosU").Texto;
            btnDesbloquearU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnDesbloquearU").Texto;
            btnPerfilU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnPerfilU").Texto;
            btnSalirU.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnSalirU").Texto;
            ColumnaIdU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaIdU").Texto;
            ColumnaDniU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaDniU").Texto;
            ColumnaNombreU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaNombreU").Texto;
            ColumnaApellidoU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaApellidoU").Texto;
            ColumnaEmailU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaEmailU").Texto;
            ColumnaPerfilU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaPerfilU").Texto;
            ColumnaUsuarioU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaUsuarioU").Texto;
            ColumnaContraseñaU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaContraseñaU").Texto;
            ColumnaBloqueadoU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaBloqueadoU").Texto;
            ColumnaActivoU.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaActivoU").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "GUsuariosForm").Texto;
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvUsuarios.SelectedRows[0];
            txtDni.Text = row.Cells[1].Value.ToString();
            txtNombre.Text = row.Cells[2].Value.ToString();
            txtApellido.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            cmbPerfiles.Text = row.Cells[5].Value.ToString();
            txtUsuario.Text = row.Cells[6].Value.ToString();
        }
    }
}
