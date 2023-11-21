using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalBladimir
{

    public partial class Inicio_sesion : Form
    {
        ClaseUsuarios ClaseUsuarios = new ClaseUsuarios();
        public Inicio_sesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Crimson;
            this.BackColor = Color.Crimson;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();

        }

        private void Inicio_sesion_Activated(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Realizar la solicitud HTTP GET al servicio de inicio de sesión
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/Login?cedula={TxtCedula.Text}&password={Txtpass.Text}";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                // Verificar si el inicio de sesión fue exitoso
                if (jsonResponse != null)
                {
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Usuario o contrasena incorrecta");
                }

            }
        }
    }
}
