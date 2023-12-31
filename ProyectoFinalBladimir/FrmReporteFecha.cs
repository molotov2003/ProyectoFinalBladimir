﻿using ClosedXML.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBladimir
{
    public partial class FrmReporteFecha : Form
    {
        public FrmReporteFecha()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmVerReportes frmVerReportes = new FrmVerReportes();
                this.Hide();
                frmVerReportes.ShowDialog();
           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DtpFechainicio.Value;

            // Convertir a formato "año mes día"
            string formatoAnioMesDiaInicio = fechaSeleccionada.ToString("yyyy-MM-dd");

            DateTime fechaSeleccionada1 = DtpFechaFin.Value;

            // Convertir a formato "año mes día"
            string formatoAnioMesDiaInicio1 = fechaSeleccionada1.ToString("yyyy-MM-dd");

            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/IngresosFecha?fechaInicio="+formatoAnioMesDiaInicio+"&fechaFin="+formatoAnioMesDiaInicio1;

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);
                var datos = JsonConvert.DeserializeObject<dynamic>(response);

                // Ruta donde se guardará el archivo Excel
                string rutaArchivo = "C:\\Users\\andres carmona\\OneDrive\\Escritorio\\excel\\TuArchivo1.xlsx";

                using (var workbook = new XLWorkbook())
                {
                    // Agregar una hoja al libro de Excel
                    var worksheet = workbook.Worksheets.Add("Hoja1");

                    // Agregar encabezados
                    int columna = 1;
                    foreach (var propiedad in datos[0].Properties())
                    {
                        worksheet.Cell(1, columna).Value = propiedad.Name;
                        columna++;
                    }

                    // Agregar datos desde el JSON
                    int fila = 2;
                    foreach (var filaJson in datos)
                    {
                        columna = 1;
                        foreach (var propiedad in filaJson.Properties())
                        {
                            // doy espacio a la columna
                            worksheet.Column("A").Width = 20;
                            worksheet.Column("B").Width = 20;
                           
                            worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.Yellow;

                            worksheet.Cell("B1").Style.Fill.BackgroundColor = XLColor.Yellow;
                           
                            
                            worksheet.Cell(fila, columna).Value = propiedad.Value.ToString();

                            worksheet.Cell("A1").Value = "Nombre";
                            worksheet.Cell("B1").Value = "Ingreso por fecha";
                            
                            columna++;
                        }
                        fila++;
                    }

                    // Guardar el archivo Excel en la ruta especificada
                    workbook.SaveAs(rutaArchivo);

                    if (File.Exists(rutaArchivo))
                    {
                        Process.Start(rutaArchivo);
                    }
                    else
                    {
                        MessageBox.Show("El archivo no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
