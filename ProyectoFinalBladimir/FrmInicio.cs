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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAdministrarUsuarios frmAdministrarUsuarios = new FrmAdministrarUsuarios();
            this.Hide();
            frmAdministrarUsuarios.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAdministrarCliente fr = new FrmAdministrarCliente();
            this.Hide();
            fr.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmVerReservas frmVerReservas = new FrmVerReservas();
            this.Hide();
            frmVerReservas.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmVerReportes FrmVerReportes = new FrmVerReportes();
            this.Hide();
            FrmVerReportes.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmAdministrarcancha1 frmAdministrarcancha1 = new FrmAdministrarcancha1();
            this.Hide();
            frmAdministrarcancha1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAdministrarReserva frmAdministrarReserva = new FrmAdministrarReserva();
            this.Hide();
            frmAdministrarReserva.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
