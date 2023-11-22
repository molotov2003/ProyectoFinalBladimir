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
    public partial class FrmAdministrarUsuarios : Form
    {
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {

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

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/ListarUsuarios";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                // Procesar la respuesta JSON
                DataTable jsonResponse = (DataTable)JsonConvert.DeserializeObject(response, typeof(DataTable));
                DGVUsuarios.DataSource = jsonResponse;



            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario f = new FrmAgregarUsuario();
            f.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string idusuario = DGVUsuarios.CurrentRow.Cells["cedula"].Value.ToString();
           

            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta

                string response = client.UploadString("http://soccersoft.somee.com/BorrarUsuario?cedula="+idusuario, "DELETE", "");

                // Realizar la solicitud HTTP DELETE
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);
                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("Desea Eliminar el Usuario: " + idusuario, "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rpta == DialogResult.OK)
                {
                    // Verificar si el inicio de sesión fue exitoso
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario f = new FrmEditarUsuario();

            f.TxtCedula.Text = DGVUsuarios.CurrentRow.Cells["cedula"].Value.ToString();
            //desencripto la contraseña
            string passdes = ClaseUser.DesEncriptar(DGVUsuarios.CurrentRow.Cells["password"].Value.ToString());
            f.Txtpass.Text = passdes;
            f.TxtNombre.Text = DGVUsuarios.CurrentRow.Cells["nombres"].Value.ToString();
            f.TxtApellido.Text = DGVUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
            f.TxtTelefono.Text = DGVUsuarios.CurrentRow.Cells["telefono"].Value.ToString();
            f.CbxRol.Text = DGVUsuarios.CurrentRow.Cells["rol"].Value.ToString();
            f.ShowDialog();
        }
    }
}
