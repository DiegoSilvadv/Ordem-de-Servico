
using Agenda_OS_Diego.LoginUsuarios;
using Agenda_OS_Diego.Tecnico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public static string nome;

        //Botões laterais
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Hide();
            frmLogin.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void UsuarioLogado()
        {
            CrudTec crud_tec = new CrudTec();
            crud_tec.ListarTeclogado(Login.id_tec);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            nome = nome_tecnico.Text;
            UsuarioLogado();
        }
    }
}
