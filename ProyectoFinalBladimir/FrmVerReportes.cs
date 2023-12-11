using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace ProyectoFinalBladimir
{
    public partial class FrmVerReportes : Form
    {
        public FrmVerReportes()
        {
            InitializeComponent();
        }

        private void DGVCanchas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            

            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = $"http://soccersoft.somee.com/ReservasReporte";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);
                var datos = JsonConvert.DeserializeObject<dynamic>(response);

                // Ruta donde se guardará el archivo Excel
                string rutaArchivo = "C:\\Users\\andres carmona\\OneDrive\\Escritorio\\excel\\TuArchivo.xlsx";

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
                            worksheet.Column("D").Width = 20;
                            worksheet.Column("E").Width = 20;
                            worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.Yellow;
                            
                            worksheet.Cell("B1").Style.Fill.BackgroundColor = XLColor.Yellow;
                            worksheet.Cell("C1").Style.Fill.BackgroundColor = XLColor.Yellow;
                            worksheet.Cell("D1").Style.Fill.BackgroundColor = XLColor.Yellow;
                            worksheet.Cell("E1").Style.Fill.BackgroundColor = XLColor.Yellow;
                            worksheet.Cell(fila, columna).Value = propiedad.Value.ToString();

                            worksheet.Cell("A1").Value = "Nombre";
                            worksheet.Cell("B1").Value = "Fecha Reserva";
                            worksheet.Cell("D1").Value = "Nombre del Cliente";
                            worksheet.Cell("E1").Value = "Apellidos del Cliente";
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
       

        private void FrmVerReportes_Load(object sender, EventArgs e)
        {
         
            //grafica de ingresos de canchas
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = "http://soccersoft.somee.com/IngresosCanchas";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                List<DatosPersona> datosList = JsonConvert.DeserializeObject<List<DatosPersona>>(response);

                List<ChartData> chartDataList = datosList.Select(dp => new ChartData { nombreCancha = dp.nombreCancha, ingresos_totales = dp.ingresos_totales }).ToList();
                chart1.Series[0].Points.Clear();

                // Iterar a través de los datos de la lista y agregar puntos al gráfico
                foreach (var item in chartDataList)
                {
                    chart1.Series[0].Points.AddXY(item.nombreCancha, item.ingresos_totales);
                }
            }
            // grafica de canchas mas reservadas
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = "http://soccersoft.somee.com/CanchaMasReservada";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                List<DatosPersona1> datosList = JsonConvert.DeserializeObject<List<DatosPersona1>>(response);

                List<ChartData1> chartDataList = datosList.Select(dp => new ChartData1 { nombreCancha = dp.nombreCancha, total_reservas = dp.total_reservas }).ToList();
                chart2.Series[0].Points.Clear();

                // Iterar a través de los datos de la lista y agregar puntos al gráfico
                foreach (var item in chartDataList)
                {
                    chart2.Series[0].Points.AddXY(item.nombreCancha, item.total_reservas);
                }
            }
            // ver la cantidad de reservas por cancha
            using (WebClient client = new WebClient())
            {
                // Construir la URL con los parámetros de consulta
                string url = "http://soccersoft.somee.com/ReservasCanchas";

                // Realizar la solicitud HTTP GET
                string response = client.DownloadString(url);

                List<DatosPersona2> datosList = JsonConvert.DeserializeObject<List<DatosPersona2>>(response);

                List<ChartData2> chartDataList = datosList.Select(dp => new ChartData2 { nombreCancha = dp.nombreCancha, total_reservas = dp.total_reservas }).ToList();
                chart3.Series[0].Points.Clear();

                // Iterar a través de los datos de la lista y agregar puntos al gráfico
                foreach (var item in chartDataList)
                {
                    chart3.Series[0].Points.AddXY(item.nombreCancha, item.total_reservas);
                    

                }
            }
        } 

        class DatosPersona
        {
            public string nombreCancha { get; set; }
            public int ingresos_totales { get; set; }
           
        }
        public class ChartData
        {
            public string nombreCancha { get; set; }
            public int ingresos_totales { get; set; }
        }

        class DatosPersona1
        {
            public string nombreCancha { get; set; }
            public int total_reservas { get; set; }

        }
        public class ChartData1
        {
            public string nombreCancha { get; set; }
            public int total_reservas { get; set; }
        }
        class DatosPersona2
        {
            public string nombreCancha { get; set; }
            public int total_reservas { get; set; }

        }
        public class ChartData2
        {
            public string nombreCancha { get; set; }
            public int total_reservas { get; set; }
        }
        private void BtnFechas_Click(object sender, EventArgs e)
        {
            FrmReporteFecha f = new FrmReporteFecha();
            f.ShowDialog();
        }
    }
}
