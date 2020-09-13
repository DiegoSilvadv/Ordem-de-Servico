
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
using System.IO;

namespace Agenda_OS_Diego
{
    public partial class Home : Form
    {
        public static string nome;

        public Home()
        { 
            InitializeComponent();
        }

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

        public void UsuarioLogado()
        {
            CrudTec crud_tec = new CrudTec();
            crud_tec.ListarTeclogado(Login.id_tec);
            nome_tecnico.Text = crud_tec.tec_logado;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            nome = nome_tecnico.Text;
            UsuarioLogado();
            Log(" usuario logado: " + nome);
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        }

        private void minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Hide();
            frmLogin.Show();
        }

        private void sair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            Log("Usuario " + nome + " saiu do sistema");
        }

        private void Log(string mensagem) 
        {
            string ficheiro = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logs.txt";
            StreamWriter arquivo = new StreamWriter(ficheiro, true, Encoding.Default);
            arquivo.WriteLine(DateTime.Now + " > " + mensagem);
            arquivo.Dispose();
        }
    }
}
