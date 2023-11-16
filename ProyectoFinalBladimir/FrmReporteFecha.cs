using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
