﻿using System;
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
    public partial class FrmEditarCliente : Form
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            FrmAdministrarCliente f = new FrmAdministrarCliente();
            f.ShowDialog();
            this.Hide();
        }
    }
}
