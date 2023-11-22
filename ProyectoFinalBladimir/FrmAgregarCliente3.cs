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
    public partial class FrmAgregarCliente3 : Form
    {
        public FrmAgregarCliente3()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmAdministrarCliente frmAdministrarCliente = new FrmAdministrarCliente();
                this.Hide();
                frmAdministrarCliente.ShowDialog();
                
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar si los campos de usuario y contraseña están llenos
                if ( Txtpass.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtApellido.Text.Length > 0 && TxtTelefono.Text.Length > 0)
                {

                    // Realizar la solicitud HTTP POST al servicio de inicio de sesión
                    using (WebClient client = new WebClient())
                    {


                        // Realizar la solicitud HTTP POST
                        string response = client.UploadString("http://soccersoft.somee.com/CrearCliente/?telefono="+Convert.ToInt64(TxtTelefono.Text)+"&password="+Txtpass.Text+"&nombres="+TxtNombre.Text+"&apellidos="+TxtApellido.Text, "POST");

                        // Procesar la respuesta JSON
                        dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                        
                        if (jsonResponse[0].id == 200)
                        {

                            MessageBox.Show("Se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmAdministrarCliente frmAdministrarCliente = new FrmAdministrarCliente();
                            this.Hide();
                            frmAdministrarCliente.ShowDialog();

                        }
                        else
                        {
                           
                            MessageBox.Show("Este numero de telefono ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
               
            }
            catch(WarningException ex)
            {
                MessageBox.Show("debe llenar todos los campos");
            }
        }
    }
}
