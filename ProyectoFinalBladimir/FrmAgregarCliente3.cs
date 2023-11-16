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
    }
}
