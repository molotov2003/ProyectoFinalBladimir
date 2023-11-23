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
        private void ActualizarDGV()
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
            //abro el el formulario para aregar la cancha
            FrmAgregarCancha f = new FrmAgregarCancha();
            f.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEditarCancha f = new FrmEditarCancha();
            string idcancha = DGVCanchas.CurrentRow.Cells["idCanchas"].Value.ToString();
            string Nombre = DGVCanchas.CurrentRow.Cells["nombreCancha"].Value.ToString();
            string dis = "";
            dis = DGVCanchas.CurrentRow.Cells["disponibilidad"].Value.ToString();
            if(dis == "0")
            {
                dis = "1";
            }
            else
            {
                if (dis == "1")
                {
                    dis = "0";

                }
            }
            
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta

                string response = client.UploadString("http://soccersoft.somee.com/EditarDisponibilidad?idCancha="+idcancha+"&disponibilidad="+dis, "PUT", "");

                // Realizar la solicitud HTTP DELETE
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("Desea Cambiar la disponibilidad de: " + Nombre, "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Verificar si el inicio de sesión fue exitoso
                if (rpta == DialogResult.OK)
                {
                    if (jsonResponse[0].id == 200)
                    {

                        MessageBox.Show("Se ha cambiado la disponibilidad");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }


            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //llamo el formulario para editar y capturo todas las variables de la cancha seleccionada
            FrmEditarCancha f = new FrmEditarCancha();
            f.TxtIdcancha.Text = DGVCanchas.CurrentRow.Cells["idCanchas"].Value.ToString();
            f.TxtNombreCancha.Text = DGVCanchas.CurrentRow.Cells["nombreCancha"].Value.ToString();
            f.Txtdes.Text = DGVCanchas.CurrentRow.Cells["descripcionCancha"].Value.ToString();
            f.Txtimagen.Text = DGVCanchas.CurrentRow.Cells["imagen"].Value.ToString();
            f.Txtprecio.Text = DGVCanchas.CurrentRow.Cells["precio"].Value.ToString();
            f.CbxRol.Text = DGVCanchas.CurrentRow.Cells["disponibilidad"].Value.ToString();
            f.ShowDialog();
        }


      
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //capturo el id de la cancha en el datagrid
            string idcancha = DGVCanchas.CurrentRow.Cells["idCanchas"].Value.ToString();
            MessageBox.Show("has seleccionado el id" + idcancha);

            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta

                string response = client.UploadString("http://soccersoft.somee.com/BorrarCancha?idCancha=" + idcancha, "DELETE", "");

                // Realizar la solicitud HTTP DELETE
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("Desea Eliminar la cancha: " + idcancha, "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Verificar si el inicio de sesión fue exitoso
                if (rpta == DialogResult.OK)
                {
                    if (jsonResponse[0].id == 200)
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
}
