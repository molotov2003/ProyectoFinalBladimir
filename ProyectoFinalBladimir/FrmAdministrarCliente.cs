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
    public partial class FrmAdministrarCliente : Form
    {
        public FrmAdministrarCliente()
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente3 f = new FrmAgregarCliente3();
            f.ShowDialog();
        }

        private void FrmAdministrarCliente_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/ListarClientes";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                DataTable jsonResponse = (DataTable)JsonConvert.DeserializeObject(response, typeof(DataTable));
                DGVClientes.DataSource = jsonResponse;



            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
           FrmEditarCliente f = new FrmEditarCliente();
           f.TxtTelefono.Text = DGVClientes.CurrentRow.Cells["telefonoClientes"].Value.ToString();
           string passdes = ClaseUser.DesEncriptar(DGVClientes.CurrentRow.Cells["password"].Value.ToString());
           f.Txtpass.Text = passdes;
           f.TxtNombre.Text = DGVClientes.CurrentRow.Cells["nombres"].Value.ToString();       
           f.TxtApellido.Text = DGVClientes.CurrentRow.Cells["apellidos"].Value.ToString();
           f.ShowDialog();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string idcliente = DGVClientes.CurrentRow.Cells["telefonoClientes"].Value.ToString();
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                
                string response = client.UploadString("http://soccersoft.somee.com/BorrarCliente?telefono="+idcliente,"DELETE","");

                // Realizar la solicitud HTTP DELETE
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);
                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("Desea Eliminar el cliente: " + idcliente, "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rpta == DialogResult.OK)
                {
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
}
