using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Agenda_OS_Diego;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Agenda_OS_Diego
{
    public partial class Empresa : Form
    {
        
        FrmEmpresa frmempresa = new FrmEmpresa();
        CRUD crud = new CRUD();
        public Empresa()
        {
            InitializeComponent();
            crud.Listar_Dados(dgv_empresa);
        }

        //funções
        
        //dados que serão passados para efetuar o cadastro das empresas
        public void PuxarDadosEmpresa()
        {
            if (dgv_empresa.SelectedRows.Count > 0)
            {
                frmempresa.lbl_id.Text = dgv_empresa.CurrentRow.Cells["id_empresa"].Value.ToString();
                frmempresa.txt_razao.Text = dgv_empresa.CurrentRow.Cells["razao"].Value.ToString();
                frmempresa.txt_fantasia.Text = dgv_empresa.CurrentRow.Cells["fantasia"].Value.ToString();
                frmempresa.mtb_cnpj.Text = dgv_empresa.CurrentRow.Cells["cnpj"].Value.ToString();
                frmempresa.txt_rua.Text = dgv_empresa.CurrentRow.Cells["rua"].Value.ToString();
                frmempresa.txt_bairro.Text = dgv_empresa.CurrentRow.Cells["bairro"].Value.ToString();
                frmempresa.txt_cidade.Text = dgv_empresa.CurrentRow.Cells["cidade"].Value.ToString();
                frmempresa.txt_numero.Text = dgv_empresa.CurrentRow.Cells["numero"].Value.ToString();
                frmempresa.mtb_cep.Text = dgv_empresa.CurrentRow.Cells["cep"].Value.ToString();
                frmempresa.cb_estado.SelectedItem = dgv_empresa.CurrentRow.Cells["uf"].Value.ToString();
                frmempresa.mtb_telefone.Text = dgv_empresa.CurrentRow.Cells["telefone"].Value.ToString();
                frmempresa.mtb_celular.Text = dgv_empresa.CurrentRow.Cells["celular"].Value.ToString();
                frmempresa.txt_email_escritorio.Text = dgv_empresa.CurrentRow.Cells["email_contador"].Value.ToString();
                frmempresa.txt_email_empresa.Text = dgv_empresa.CurrentRow.Cells["email"].Value.ToString();
                frmempresa.cb_inativar.Checked = Convert.ToBoolean(dgv_empresa.CurrentRow.Cells["inativado"].Value);
                frmempresa.btn_cadastrar_empresa.Text = "Gravar";
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
        //metodo para listar uma empresa
        public void ListarEmpresa()
        {
            dgv_empresa.DataSource = null;
            crud.Listar_Dados(dgv_empresa);
            dgv_empresa.DataSource = crud.dt;
        }
        


        //botões
        private void btn_editar_Click(object sender, EventArgs e)
        {   
            PuxarDadosEmpresa();
            frmempresa.Show();
            this.Hide();
        }
        //campo de pesquisa
        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            //pesquisa em tempo real
            string razao = txt_pesquisa.Text.ToString();
            crud.Listar_Dados_Especificos(dgv_empresa, razao);
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            frmempresa.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home ReturnHome = new Home();
            this.Hide();
            ReturnHome.UsuarioLogado();
            ReturnHome.Show();

        }
    }
}
