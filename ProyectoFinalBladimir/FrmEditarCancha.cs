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
    public partial class FrmEditarCancha : Form
    {
        public FrmEditarCancha()
        {
            InitializeComponent();
        }

        private void AgregarCancha_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos de usuario y contraseña están llenos
                if (TxtNombreCancha.Text.Length > 0 && Txtdes.Text.Length > 0 && Txtimagen.Text.Length > 0 && Txtprecio.Text.Length > 0 && Txtdis.Text.Length > 0)
                {

                    // Realizar la solicitud HTTP POST al servicio de inicio de sesión
                    using (WebClient client = new WebClient())
                    {


                        // Realizar la solicitud HTTP POST
                        string response = client.UploadString("http://soccersoft.somee.com/EditarCancha?idCancha=" + TxtIdcancha.Text+ "&nombreCancha=" + TxtNombreCancha.Text+ "&descripcionCancha=" + Txtdes.Text+ "&imagen=" + Txtimagen.Text+ "&precio=" + Txtimagen.Text+ "&disponibilidad=" + Txtdis.Text, "PUT", "");

                        // Procesar la respuesta JSON
                        dynamic jsonResponse = JsonConvert.DeserializeObject(response);


                        if (jsonResponse[0].id == 200)
                        {

                            MessageBox.Show("Se ha editado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmAdministrarCliente f = new FrmAdministrarCliente();
                            this.Hide();
                            f.ShowDialog();
                            this.Hide();

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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdministrarcancha1 f = new FrmAdministrarcancha1();
            this.Hide();
            f.ShowDialog();
        }
    }
}
