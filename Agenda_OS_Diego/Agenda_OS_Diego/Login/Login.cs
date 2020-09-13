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
using System.Drawing;

namespace Agenda_OS_Diego
{
    public partial class Login : Form
    {
        LoginUsuario loginUsuario = new LoginUsuario();
        Home frmHome = new Home();

        public Login()
        {
            InitializeComponent();
        }

        public static string id_tec = "";

        private void Login_Load(object sender, EventArgs e)
        {
            loginUsuario.ListarUsuario();
            cb_usuario.DataSource = loginUsuario.usuarioDT;
            cb_usuario.DisplayMember = "usuario";
            cb_usuario.ValueMember = "id_tecnico";
            id_tec = cb_usuario.SelectedValue.ToString();
        }
        public void ValidarLogin() {
            loginUsuario.usuario = cb_usuario.Text;
            loginUsuario.senha = txt_senha.Text;

            if (txt_senha.Text != "")
            {
                loginUsuario.ConsultarLogin();
                if (loginUsuario.logado == "Logado")
                {
                    frmHome.nome_tecnico.Text = loginUsuario.usuario.ToString(); 
                    this.Hide();
                    frmHome.ShowDialog();

                }
                else
                {
                    DialogResult r2 = MessageBox.Show(this, "Senha incorreta!", "Help Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!");
            }
        }
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            ValidarLogin();

        }
        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidarLogin();
            }
        }

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_tec = cb_usuario.SelectedValue.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
        }
    }
}
