using Be;
using Interface;
using ServicioClase;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class Ayudaform : Form, ITraducible
    {
        private Dictionary<string, string> preguntas = new Dictionary<string, string>();

        public Ayudaform()
        {
            InitializeComponent();
            Ayuda_Load(null, null);
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            AgregarTitulo();
            CargarPreguntasDesdeBase();

            lstPreguntas.DrawMode = DrawMode.OwnerDrawVariable;
            lstPreguntas.MeasureItem += LstPreguntas_MeasureItem;
            lstPreguntas.DrawItem += LstPreguntas_DrawItem;
            lstPreguntas.SelectedIndexChanged += lstPreguntas_SelectedIndexChanged;

            txtRespuesta.Multiline = true;
            txtRespuesta.ReadOnly = true;
            txtRespuesta.ScrollBars = ScrollBars.Vertical;
            txtRespuesta.Font = new Font("Maiandra GD", 11F, FontStyle.Regular);
            txtRespuesta.BackColor = Color.White;
            txtRespuesta.BorderStyle = BorderStyle.None;

            LanguageManager.Suscribir(this);
            LanguageManager.Actualizar(SessionManager.getInstance.usuario.IdiomaId);
        }

        private void AgregarTitulo()
        {
            Label lblTitulo = new Label();
            lblTitulo.Name = "lblTituloPreguntas";
            lblTitulo.Text = "Preguntas Frecuentes";
            lblTitulo.Font = new Font("Maiandra GD", 10F, FontStyle.Bold | FontStyle.Underline);
            lblTitulo.Location = new Point(5, 5);
            lblTitulo.AutoSize = true;

            panelContenedor.Panel1.Controls.Add(lblTitulo);
            lstPreguntas.Location = new Point(5, 30);
            lstPreguntas.Size = new Size(panelContenedor.Panel1.Width - 10, panelContenedor.Panel1.Height - 35);
            lstPreguntas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void CargarPreguntasDesdeBase()
        {
            preguntas.Clear();
            lstPreguntas.Items.Clear();

            try
            {
                string connectionString = @"Data Source=.;Initial Catalog=SistemaF;Integrated Security=True"; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Pregunta, Respuesta FROM PreguntaAyuda WHERE CodigoIdioma = @Idioma ORDER BY Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Idioma", LanguageManager.CodIdiomaActual);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string pregunta = reader.GetString(0);
                                string respuesta = reader.GetString(1);

                                preguntas[pregunta] = respuesta;
                                lstPreguntas.Items.Add(pregunta);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar preguntas de ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstPreguntas_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstPreguntas.Items.Count) return;

            string text = lstPreguntas.Items[e.Index].ToString();
            Size textSize = TextRenderer.MeasureText(text, lstPreguntas.Font, new Size(lstPreguntas.Width, int.MaxValue), TextFormatFlags.WordBreak);
            e.ItemHeight = textSize.Height;
        }

        private void LstPreguntas_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstPreguntas.Items.Count) return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            string text = lstPreguntas.Items[e.Index].ToString();
            TextRenderer.DrawText(e.Graphics, text, lstPreguntas.Font, e.Bounds, Color.Black, TextFormatFlags.WordBreak);
        }

        private void lstPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPreguntas.SelectedIndex >= 0)
            {
                string pregunta = lstPreguntas.Items[lstPreguntas.SelectedIndex].ToString();
                if (preguntas.ContainsKey(pregunta))
                {
                    txtRespuesta.Text = preguntas[pregunta];
                }
            }
        }

        public void Actualizar(string pIdioma)
        {
            Idioma _idioma = LanguageManager.lIdioma.Find(x => x.id == pIdioma);
            this.Text = _idioma.lEtiqueta.Find(x => x.ControlT == "Ayudaform").Texto;

            CargarPreguntasDesdeBase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogBitacora.AgregarEvento("Salir de cambiar clave", 1, SessionManager.getInstance.usuario, "Cambiar clave");
        }
    }
}
