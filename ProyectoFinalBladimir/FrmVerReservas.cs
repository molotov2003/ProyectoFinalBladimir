using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBladimir
{
    public partial class FrmVerReservas : Form
    {
        public FrmVerReservas()
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

        private void FrmVerReservas_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/ListarReservas";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                DataTable jsonResponse = (DataTable)JsonConvert.DeserializeObject(response, typeof(DataTable));
                DGVReservas.DataSource = jsonResponse;

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //capturo el id de la cancha en el datagrid
            string idR = DGVReservas.CurrentRow.Cells["idReservas"].Value.ToString();
            string estado = DGVReservas.CurrentRow.Cells["estado"].Value.ToString();
          

            using (WebClient client = new WebClient())
            {
               
                if(Convert.ToInt64(estado) == 1)
                {
                    MessageBox.Show("EL estado ya se ha confirmado", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Construir la URL con los parámetros de consulta

                    string response = client.UploadString("http://soccersoft.somee.com/CancelarReserva?idReservas=" + idR, "PUT", "");

                    // Realizar la solicitud HTTP DELETE
                    dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                    DialogResult rpta = new DialogResult();
                    rpta = MessageBox.Show("Desea Cancelar la reserva: " + idR, "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    // Verificar si el inicio de sesión fue exitoso
                    if (rpta == DialogResult.OK)
                    {
                        if (jsonResponse[0].id == 200)
                        {

                            MessageBox.Show("Se ha Cancelado correctamente");
                            MessageBox.Show(estado);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error");
                        }
                    }
                }
              
            }
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/ListarReservas";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                DataTable jsonResponse = (DataTable)JsonConvert.DeserializeObject(response, typeof(DataTable));
                DGVReservas.DataSource = jsonResponse;

            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //capturo el id de la cancha en el datagrid
            string idR = DGVReservas.CurrentRow.Cells["idReservas"].Value.ToString();
            string estado = DGVReservas.CurrentRow.Cells["estado"].Value.ToString();

            if (Convert.ToInt64(estado) == 2)
            {
                MessageBox.Show("EL estado ya se ha Cancelado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (WebClient client = new WebClient())
                {
                    // Construir la URL con los parámetros de consulta

                    string response = client.UploadString("http://soccersoft.somee.com/ConfirmarReserva?idReservas=" + idR, "PUT", "");

                    // Realizar la solicitud HTTP DELETE
                    dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                    DialogResult rpta = new DialogResult();
                    rpta = MessageBox.Show("Desea confirmar la reserva: " + idR, "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    // Verificar si el inicio de sesión fue exitoso
                    if (rpta == DialogResult.OK)
                    {
                        if (jsonResponse[0].id == 200)
                        {

                            MessageBox.Show("Se ha Confirmado correctamente");

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error");
                        }
                    }
                }
            }
           
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/ListarReservas";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                DataTable jsonResponse = (DataTable)JsonConvert.DeserializeObject(response, typeof(DataTable));
                DGVReservas.DataSource = jsonResponse;

            }
        }
    }
}
