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
    public partial class FrmEditarUsuario : Form
    {
        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos de usuario y contraseña están llenos
                if (TxtCedula.Text.Length > 0 && Txtpass.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtApellido.Text.Length > 0 && TxtTelefono.Text.Length > 0 && CbxRol.Text.Length>0)
                {

                    // Realizar la solicitud HTTP POST al servicio de inicio de sesión
                    using (WebClient client = new WebClient())
                    {


                        // Realizar la solicitud HTTP POST
                        string response = client.UploadString("http://soccersoft.somee.com/EditarUsuario?cedula="+TxtCedula.Text+"&password="+Txtpass.Text+"&nombres="+TxtNombre.Text+"&apellidos="+TxtApellido.Text+"&telefono="+TxtTelefono.Text+"&rol="+CbxRol.Text, "PUT" , "");

                        // Procesar la respuesta JSON
                        dynamic jsonResponse = JsonConvert.DeserializeObject(response);


                        if (jsonResponse[0].id == 200)
                        {

                            MessageBox.Show("Se ha editado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmAdministrarUsuarios f = new FrmAdministrarUsuarios();
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
                MessageBox.Show("ha ocurrido un error");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmAdministrarUsuarios f = new FrmAdministrarUsuarios();
            this.Hide();
            f.ShowDialog();
        }

        private void CbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
