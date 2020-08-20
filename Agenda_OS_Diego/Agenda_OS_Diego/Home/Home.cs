﻿
using Agenda_OS_Diego.LoginUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS_Diego
{
    public partial class Home : Form
    {
        LoginUsuario loginUsuario = new LoginUsuario();
        public Home()
        { 
            InitializeComponent();
            MessageBox.Show("ola" + loginUsuario.usuario);
            lbl_tecnico.Text = loginUsuario.usuario;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            this.Hide();
            empresa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tecnico.Tecnico frmtec = new Tecnico.Tecnico();
            this.Hide();
            frmtec.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OrdemServico.OrdemServico os = new OrdemServico.OrdemServico();
            this.Hide();
            os.ShowDialog();
        }
    }
}
