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
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace GUI
{
    public partial class GRegistrarClienteForm : Form, ITraducible
    {
        List<BeCliente> lCliente;
        BllCliente blCliente;
        GReservasForm reservas;

        public GRegistrarClienteForm()
        {
            InitializeComponent();
            cmbSerializacion.Items.Add("XML");
            cmbSerializacion.Items.Add("JSON");
            cmbSerializacion.SelectedIndex = 0;
        }

        private void GRegistrarCliente_Load(object sender, EventArgs e)
        {
            blCliente = new BllCliente();
            reservas = new GReservasForm();
            lCliente = blCliente.Consulta();
            Refrescar();
        }
        private bool Cargartxt()
        {
            bool txtValidado = false;
            if (txtDni.ToString() == string.Empty ||
                txtNombre.ToString() == string.Empty ||
                txtTelefono.ToString() == string.Empty ||
                txtDireccion.ToString() == string.Empty)
            {
                txtValidado = true;
            }
            return txtValidado;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Cargartxt())
                {
                    BeCliente nuevoCliente;
                    nuevoCliente = new BeCliente(txtDni.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text);
                    blCliente.Alta(nuevoCliente);
                    lCliente = blCliente.Consulta();
                    LogBitacora.AgregarEvento("Registrar cliente", 2, SessionManager.getInstance.usuario, "Clientes");
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow d in dgvCliente.SelectedRows)
                {
                    int id = Convert.ToInt32(d.Cells[0].Value);
                    blCliente.Baja(id);
                    lCliente = blCliente.Consulta();
                }
                LogBitacora.AgregarEvento("Eliminar cliente", 2, SessionManager.getInstance.usuario, "Clientes");
                MessageBox.Show("Usuario eliminado"); 
            }
            Refrescar();
        }
        private void Refrescar()
        {
            dgvCliente.Rows.Clear();
            foreach (BeCliente item in lCliente)
            {
                dgvCliente.Rows.Add(item.id, item.DNI, item.Nombre, item.Telefono, item.Direccion);
            }
        }

        private void dgvCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridViewRow row = dgvCliente.SelectedRows[0];
                //txtDni.Text = row.Cells[1].Value.ToString();
                //txtNombre.Text = row.Cells[2].Value.ToString();
                //txtTelefono.Text = row.Cells[3].Value.ToString();
            }
            catch 
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvCliente.Rows.Count > 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DataGridViewRow dgr = dgvCliente.SelectedRows[0];
                string cliente = dgr.Cells[0].Value.ToString();

                BeCliente clienteModificar = lCliente.Find(x => x.id == cliente);

                if (!Cargartxt())
                {
                    clienteModificar.DNI = txtDni.Text;
                    clienteModificar.Nombre = txtNombre.Text;
                    clienteModificar.Telefono = txtTelefono.Text;
                    clienteModificar.Direccion = txtDireccion.Text;

                    blCliente.Modificacion(clienteModificar);
                    lCliente = blCliente.Consulta();
                    Refrescar();
                    LogBitacora.AgregarEvento("Modificar cliente", 3, SessionManager.getInstance.usuario, "Clientes");
                    MessageBox.Show("Usuario modificado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            LogBitacora.AgregarEvento("Salir de registrar cliente", 1, SessionManager.getInstance.usuario, "Clientes");
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            labTitulo.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labTitulo").Texto;
            labDNI.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labDNI").Texto;
            labNombre.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labNombre").Texto;
            labTelefono.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "labTelefono").Texto;
            btnAgregar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnAgregar").Texto;
            btnBorrar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnBorrar").Texto;
            btnModificar.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnModificar").Texto;
            btnVolver.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "btnVolver").Texto;
            ColumnaId.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaId").Texto;
            ColumnaDni.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaDni").Texto;
            ColumnaNombre.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaNombre").Texto;
            ColumnaTelefono.HeaderText = _idioma.lEtiqueta.Find(x => x.ControlT == "ColumnaTelefono").Texto;
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "GRegistrarClienteForm").Texto;
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCliente.SelectedRows[0];
            txtDni.Text = row.Cells[1].Value.ToString();
            txtNombre.Text = row.Cells[2].Value.ToString();
            txtTelefono.Text = row.Cells[3].Value.ToString();
            txtDireccion.Text = row.Cells[4].Value.ToString();
        }
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                listArchivoDeserializado.Items.Clear();
                

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = $"{cmbSerializacion.SelectedItem} Files|*.{cmbSerializacion.SelectedItem.ToString().ToLower()}";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string formato = cmbSerializacion.SelectedItem.ToString();

                    switch (formato)
                    {
                        case "XML":
                            SerializarXML(lCliente, saveFileDialog.FileName);
                            MostrarSerializado(saveFileDialog.FileName);
                            break;
                        case "JSON":
                            SerializarJson(lCliente, saveFileDialog.FileName);
                            MostrarSerializado(saveFileDialog.FileName);
                            break;
                    }
                    MessageBox.Show($"Serialización en formato {formato} con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al serialziar: {ex.Message}");
            }
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = $"{cmbSerializacion.SelectedItem} Files|*.{cmbSerializacion.SelectedItem.ToString().ToLower()}";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string formato = cmbSerializacion.SelectedItem.ToString();
                List<BeCliente> cliente = null;

                listArchivoDeserializado.Items.Clear();

                switch (formato)
                {
                    case "XML":
                        cliente = DeserializarXML(openFileDialog.FileName);
                        break;
                    case "JSON":
                        cliente = DeserializarJson(openFileDialog.FileName);
                        break;
                }
                MostrarDeserializado(cliente);
            }
        }
        private void SerializarXML(List<BeCliente> pCliente, string pPath)
        {
            using(FileStream fs = new FileStream(pPath, FileMode.Create))
            {
                XmlSerializer serilizar = new XmlSerializer(typeof(List<BeCliente>));
                serilizar.Serialize(fs, pCliente);
            }
        }
        private void SerializarJson(List<BeCliente> pCliente, string pPath)
        {
            string json = JsonConvert.SerializeObject(pCliente, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(pPath, json);
        }
        private List<BeCliente> DeserializarXML(string pPath)
        {
            using(FileStream fs = new FileStream(pPath, FileMode.Open))
            {
                XmlSerializer serializar = new XmlSerializer(typeof(List<BeCliente>));
                return (List<BeCliente>)serializar.Deserialize(fs);
            }
        }
        private List<BeCliente> DeserializarJson(string pPath)
        {
            string json = File.ReadAllText(pPath);
            return JsonConvert.DeserializeObject<List<BeCliente>>(json);
        }
        private void MostrarSerializado(string path)
        {
            listArchivoSerializado.Items.Clear();

            string[] lineas = File.ReadAllLines(path);

            foreach (string linea in lineas)
            {
                listArchivoSerializado.Items.Add(linea);
            }
        }
        private void MostrarDeserializado(List<BeCliente> pLCliente)
        {
            listArchivoDeserializado.Items.Clear();

            foreach (BeCliente cliente in pLCliente)
            {
                listArchivoDeserializado.Items.Add($"DNI: {cliente.DNI}");
                listArchivoDeserializado.Items.Add($"Nombre: {cliente.Nombre}");
                listArchivoDeserializado.Items.Add($"Telefono: {cliente.Telefono}");
                listArchivoDeserializado.Items.Add($"Direccion: {cliente.Direccion}");
                listArchivoDeserializado.Items.Add("");
            }
        }
    }
}
