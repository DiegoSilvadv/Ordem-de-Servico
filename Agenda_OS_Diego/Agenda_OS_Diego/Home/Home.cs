
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
        public Home()
        { 
            InitializeComponent();
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

        private void timer_tik_Tick(object sender, EventArgs e)
        {
            lbl_data_hora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
