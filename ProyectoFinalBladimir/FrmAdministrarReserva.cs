using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBladimir
{
    public partial class FrmAdministrarReserva : Form
    {
        public FrmAdministrarReserva()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inicio inicio = new Inicio();
                this.Hide();
                inicio.ShowDialog();
            
            }
        }
        public class Cancha
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public override string ToString()
            {
                return Nombre; // Esto es lo que se mostrará en el ComboBox
            }
        }

        public class date
        {
            public int Id { get; set; }
            public string Hora { get; set; }
            public override string ToString()
            {
                return Hora; // Esto es lo que se mostrará en el ComboBox
            }
        }
        private int idSeleccionadoGlobal;
        private int idhoraSeleccionadoGlobal;
        private string fecha;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            DateTime fechaSeleccionada = DtpFecha.Value;
            DateTime fechaActual = DateTime.Now;
            if (fechaSeleccionada > fechaActual)
            {
                try
                {
                    //valido si los campos para reservar la cancha estan llenos
                    if (TxtCedula.Text.Length > 0 && CbxCancha.Text.Length > 0 && CbxHora.Text.Length > 0 && DtpFecha.Text.Length > 0)
                    {

                        // Realizar la solicitud HTTP POST al servicio de reservar
                        using (WebClient client = new WebClient())
                        {


                            // Realizar la solicitud HTTP POST
                            string response = client.UploadString("http://soccersoft.somee.com/Reservar?telefonoClientes=" + TxtCedula.Text + "&idCancha=" + idSeleccionadoGlobal + "&idHorario=" + idhoraSeleccionadoGlobal + "&fecha=" + Convert.ToDateTime(fecha) + "", "POST");

                            // Procesar la respuesta JSON
                            dynamic jsonResponse = JsonConvert.DeserializeObject(response);


                            if (jsonResponse[0].id == 200)
                            {

                                MessageBox.Show("Se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmAdministrarReserva f = new FrmAdministrarReserva();
                                this.Hide();
                                f.ShowDialog();

                            }
                            else
                            {

                                MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("debe llenar todos los campos");
                }
            }
            else
            {
                MessageBox.Show("La fecha seleccionada en menor a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CbxCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
       

        private void FrmAdministrarReserva_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = "http://soccersoft.somee.com/ListarCanchas";           
                string response = client.DownloadString(url);
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);
                if (jsonResponse != null && jsonResponse.Count > 0)
                {
                    CbxCancha.Items.Clear();             
                    List<Cancha> canchas = new List<Cancha>();

                    foreach (var cancha in jsonResponse)
                    {
                        Cancha nuevaCancha = new Cancha
                        {
                            Id = cancha.idCanchas,
                            Nombre = cancha.nombreCancha
                        };                  
                        canchas.Add(nuevaCancha);
                        CbxCancha.Items.Add(nuevaCancha);
                    }            
                    CbxCancha.SelectedIndexChanged += (s, eventArgs) =>
                    {
                        int indiceSeleccionado = CbxCancha.SelectedIndex;
                        
                 
                        if (indiceSeleccionado >= 0 && indiceSeleccionado < canchas.Count)
                        {
                            int idSeleccionado = canchas[indiceSeleccionado].Id;
                            idSeleccionadoGlobal = idSeleccionado;
                           
                        }
                    };
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
        public class Date
        {
            public int Id { get; set; }
            public string Hora { get; set; }

            public override string ToString()
            {
                return Hora; // Esto es lo que se mostrará en el ComboBox
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DtpFecha.Value;

            // Convertir a formato "año mes día"
            string formatoAnioMesDia = fechaSeleccionada.ToString("yyyy-MM-dd");

            fecha = formatoAnioMesDia;


            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = "http://soccersoft.somee.com/VerHoras?fecha=" + formatoAnioMesDia + "&idCancha=" + idSeleccionadoGlobal;

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                if (jsonResponse != null && jsonResponse.Count > 0)
                {
                    CbxHora.Items.Clear();
                    List<Date> dates = new List<Date>();

                    foreach (var horario in jsonResponse)
                    {
                        Date nuevoHorario = new Date
                        {
                            Id = horario.idHorarios,
                            Hora = horario.hora
                        };
                        dates.Add(nuevoHorario);
                        CbxHora.Items.Add(nuevoHorario);
                    }

                    CbxHora.SelectedIndexChanged += (s, eventArgs) =>
                    {
                        int indiceSeleccionado = CbxHora.SelectedIndex;

                        if (indiceSeleccionado >= 0 && indiceSeleccionado < dates.Count)
                        {
                            int idSeleccionado = dates[indiceSeleccionado].Id;
                            idhoraSeleccionadoGlobal = idSeleccionado;
                        }
                    };
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}
