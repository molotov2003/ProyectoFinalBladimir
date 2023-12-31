﻿using Newtonsoft.Json;
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
    public partial class FrmEditarCliente : Form
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos de usuario y contraseña están llenos
                if (TxtTelefono.Text.Length > 0 && Txtpass.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtApellido.Text.Length > 0 )
                {

                    // Realizar la solicitud HTTP POST al servicio de inicio de sesión
                    using (WebClient client = new WebClient())
                    {


                        // Realizar la solicitud HTTP POST
                        string response = client.UploadString("http://soccersoft.somee.com/EditarCliente?telefono=" + TxtTelefono.Text+ "&password=" + Txtpass.Text+ "&nombres=" + TxtNombre.Text+ "&apellidos=" + TxtApellido.Text, "PUT" , "");

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

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdministrarCliente f = new FrmAdministrarCliente();
            this.Hide();
            f.ShowDialog();
        }
    }
}
