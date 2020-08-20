using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using Agenda_OS_Diego.LoginUsuarios;
using MySqlX.XDevAPI.Common;

namespace Agenda_OS_Diego
{
    public partial class Login : Form
    {
        LoginUsuario loginUsuario = new LoginUsuario();
        
        public Login()
        {
            InitializeComponent();
        }
  
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            loginUsuario.usuario = txt_usuario.Text;           
            loginUsuario.senha = txt_senha.Text;

            if (txt_usuario.Text != "" || txt_senha.Text != "")
            {
                loginUsuario.ConsultarLogin();
                if (loginUsuario.logado == "Logado")
                {
                    Home frmHome = new Home();
                    this.Hide();
                    frmHome.ShowDialog();
                    MessageBox.Show("Bem vindo " + loginUsuario.usuario);
                }
                else {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!");
            }
            
           
        }

    }
}
