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
    public partial class FrmAgregarCancha : Form
    {
        public FrmAgregarCancha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos de usuario y contraseña están llenos
                if (TxtNombreCancha.Text.Length > 0 && Txtdes.Text.Length > 0 && Txtimagen.Text.Length > 0 && Txtprecio.Text.Length > 0 && Txtdis.Text  .Length > 0)
                {

                    // Realizar la solicitud HTTP POST al servicio de inicio de sesión
                    using (WebClient client = new WebClient())
                    {


                        // Realizar la solicitud HTTP POST
                        string response = client.UploadString("http://soccersoft.somee.com/CrearCancha?nombreCancha="+TxtNombreCancha.Text+"&descripcionCancha="+Txtdes.Text+"&imagen="+Txtimagen.Text+"&precio="+Convert.ToInt64(Txtprecio.Text)+"&disponibilidad="+Convert.ToInt64(Txtdis.Text),"POST");

                        // Procesar la respuesta JSON
                        dynamic jsonResponse = JsonConvert.DeserializeObject(response);


                        if (jsonResponse != null)
                        {

                            MessageBox.Show("Se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmAdministrarcancha1 f = new FrmAdministrarcancha1();
                            this.Hide();
                            f.ShowDialog();
                           

                        }
                        else
                        {

                            MessageBox.Show(". Verifica tus credenciales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (WarningException ex)
            {
                MessageBox.Show("debe llenar todos los campos");
            }
        }
    }
}
