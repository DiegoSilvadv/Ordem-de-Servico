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
using Agenda_OS_Diego.Classes;
using Agenda_OS_Diego;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Agenda_OS_Diego
{
    public partial class Empresa : Form
    {   
        //instanciando a class crud
        CRUD crud = new CRUD();
       
        public Empresa()
        {
            InitializeComponent();
            crud.Listar_Dados(dgv_empresa);
        }

        //funções
        public void PuxarCampos()
        {
            lbl_id.Text = crud.id;
            txt_razao.Text = crud.razao;
            txt_fantasia.Text = crud.fantasia;
            mtb_cnpj.Text = crud.cnpj;
            txt_rua.Text = crud.rua;
            txt_bairro.Text = crud.bairro;
            txt_cidade.Text = crud.cidade;
            txt_numero.Text = crud.numero;
            mtb_cep.Text = crud.cep;
            mtb_telefone.Text = crud.telefone;
            mtb_celular.Text = crud.celular;
        }
        //dados que serão passados para efetuar o cadastro das empresas
        public void CamposDeCadastro()
        {
            crud.id = lbl_id.Text;
            crud.razao = txt_razao.Text;
            crud.fantasia = txt_fantasia.Text;
            crud.cnpj = mtb_cnpj.Text;
            crud.rua = txt_rua.Text;
            crud.bairro = txt_bairro.Text;
            crud.cidade = txt_cidade.Text;
            crud.numero = txt_numero.Text;
            crud.cep = mtb_cep.Text;
            crud.telefone = mtb_telefone.Text;
            crud.celular = mtb_telefone.Text;
        }
        public void LimparCampos()
        {
            lbl_id.Text = "0";
            txt_razao.Text = "";
            txt_fantasia.Text = "";
            mtb_cnpj.Text = "";
            txt_rua.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_numero.Text = "";
            mtb_cep.Text = "";
            mtb_telefone.Text = "";
            mtb_celular.Text = "";
            btn_cadastrar_empresa.Text = "Cadastrar";
        }
        public void PuxarDadosEmpresa()
        {
            if (dgv_empresa.SelectedRows.Count > 0)
            {
                lbl_id.Text = dgv_empresa.CurrentRow.Cells["id"].Value.ToString();
                txt_razao.Text = dgv_empresa.CurrentRow.Cells["razao"].Value.ToString();
                txt_fantasia.Text = dgv_empresa.CurrentRow.Cells["fantasia"].Value.ToString();
                mtb_cnpj.Text = dgv_empresa.CurrentRow.Cells["cnpj"].Value.ToString();
                txt_rua.Text = dgv_empresa.CurrentRow.Cells["rua"].Value.ToString();
                txt_bairro.Text = dgv_empresa.CurrentRow.Cells["bairro"].Value.ToString();
                txt_cidade.Text = dgv_empresa.CurrentRow.Cells["cidade"].Value.ToString();
                txt_numero.Text = dgv_empresa.CurrentRow.Cells["numero"].Value.ToString();
                mtb_cep.Text = dgv_empresa.CurrentRow.Cells["cep"].Value.ToString();
                mtb_telefone.Text = dgv_empresa.CurrentRow.Cells["telefone"].Value.ToString();
                mtb_celular.Text = dgv_empresa.CurrentRow.Cells["celular"].Value.ToString();
                btn_cadastrar_empresa.Text = "Gravar";
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



        //clicks de botão
        //editar uma empresa
        private void btn_editar_Click(object sender, EventArgs e)
        {
            PuxarDadosEmpresa();
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {   
            //id passado para fazer a exclusão
            string id = dgv_empresa.CurrentRow.Cells["id"].Value.ToString();
            crud.Deletar_Dados(id);
        }
        private void img_return_Click(object sender, EventArgs e)
        {
            Home ReturnHome = new Home();
            this.Hide();
            ReturnHome.ShowDialog();
        }
        private void btn_cadastrar_empresa_Click_1(object sender, EventArgs e)
        {
            if (btn_cadastrar_empresa.Text == "Gravar")
            {
                CamposDeCadastro();
                crud.Alterar_Dados();
                LimparCampos();
                crud.Listar_Dados(dgv_empresa);

            }
            else if (btn_cadastrar_empresa.Text == "Cadastrar")
            {
                CamposDeCadastro();
                crud.Criar_Dados();
                LimparCampos();
                crud.Listar_Dados(dgv_empresa);
            }
        }

        //campo de pesquisa
        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            //pesquisa em tempo real
            string razao = txt_pesquisa.Text.ToString();
            crud.Listar_Dados_Especificos(dgv_empresa, razao);

        }
    }
}
