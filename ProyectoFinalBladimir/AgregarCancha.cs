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
    public partial class AgregarCancha : Form
    {
        public AgregarCancha()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if(rs == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(foto.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmAdministrarcancha1 frmAdministrarcancha1 = new FrmAdministrarcancha1();
                this.Hide();
                frmAdministrarcancha1.ShowDialog();
                
            }
        }
    }
}
