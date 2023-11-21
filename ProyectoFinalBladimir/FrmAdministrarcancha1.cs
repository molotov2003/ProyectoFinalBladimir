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
    public partial class FrmAdministrarcancha1 : Form
    {
        public FrmAdministrarcancha1()
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

        private void FrmAdministrarcancha1_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/ListarCanchas";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                DataTable jsonResponse = (DataTable)JsonConvert.DeserializeObject(response, typeof(DataTable));
                DGVCanchas.DataSource = jsonResponse;



            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCancha f = new FrmAgregarCancha();
            f.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string idcancha = DGVCanchas.CurrentRow.Cells["idCanchas"].Value.ToString();
            MessageBox.Show("has seleccionado el id" + idcancha);

            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta

                string response = client.UploadString("http://soccersoft.somee.com/BorrarCancha?idCancha=" + idcancha, "DELETE", "");

                // Realizar la solicitud HTTP DELETE
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);


                // Verificar si el inicio de sesión fue exitoso
                if (jsonResponse != null)
                {

                    MessageBox.Show("Se ha eliminado correctamente");

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }




            }
        }
    }
}
