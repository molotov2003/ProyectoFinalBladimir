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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmAdministrarUsuarios f = new FrmAdministrarUsuarios();
            f.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos de usuario y contraseña están llenos
                if ( TxtCedula.Text.Length > 0 &&  Txtpass.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtApellido.Text.Length > 0 && TxtTelefono.Text.Length > 0 && TxtRol.Text.Length > 0)
                {

                    // Realizar la solicitud HTTP POST al servicio de inicio de sesión
                    using (WebClient client = new WebClient())
                    {


                        // Realizar la solicitud HTTP POST
                        string response = client.UploadString("http://soccersoft.somee.com/CrearUsuario/?cedula="+TxtCedula.Text+"&password="+Txtpass.Text+"&nombres="+TxtNombre.Text+"&apellidos="+TxtApellido.Text+"&telefono="+TxtTelefono.Text+"&rol="+TxtRol.Text+"", "POST");

                        // Procesar la respuesta JSON
                        dynamic jsonResponse = JsonConvert.DeserializeObject(response);


                        if (jsonResponse[0].id == 200)
                        {

                            MessageBox.Show("Se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmAdministrarUsuarios f = new FrmAdministrarUsuarios();
                            this.Hide();
                            f.ShowDialog();

                        }
                        else
                        {

                            MessageBox.Show("la cedula ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
