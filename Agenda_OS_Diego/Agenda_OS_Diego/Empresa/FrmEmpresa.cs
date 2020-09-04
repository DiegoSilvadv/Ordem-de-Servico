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
    public partial class FrmEmpresa : Form
    {
        CRUD crud = new CRUD();
        string validar = "";
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        //funções
        public void LimparCampos()
        {
            lbl_id.Text = "0";
            txt_razao.Text = "";
            txt_fantasia.Text = "";
            mtb_cnpj.Text = default;
            txt_rua.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_numero.Text = "";
            mtb_cep.Text = default;
            mtb_telefone.Text = default;
            mtb_telefone.Text = default;
            mtb_IE.Text = default;
            txt_email_empresa.Text = "";
            txt_email_escritorio.Text = "";
            cb_estado.SelectedIndex = 0;
            cb_inativar.Checked = false;
            btn_cadastrar_empresa.Text = "Cadastrar";
        }
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
            crud.inscricao_estadual = mtb_IE.Text;
            crud.email = txt_email_empresa.Text;
            crud.email_contador = txt_email_escritorio.Text;
            crud.uf = cb_estado.Text;
            crud.inativado = cb_inativar.Checked;
        }
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

        public void ValidarCampos() {
            if (cb_estado.SelectedItem == null || txt_razao.Text == "" || txt_fantasia.Text == "" ||
            mtb_cnpj.Text == "" || mtb_cep.Text == "" || mtb_telefone.Text == "" || mtb_celular.Text == "")
            {
                MessageBox.Show("Preencha todos os campos por favor!");
                validar = "Negado";
            }
            else {
                validar = "Cadastrar";
            }
            
        }

        private void btn_cadastrar_empresa_Click(object sender, EventArgs e)
        {
            if (btn_cadastrar_empresa.Text == "Gravar")
            {
                CamposDeCadastro();
                crud.Alterar_Dados();
                LimparCampos();
            }
            else if (btn_cadastrar_empresa.Text == "Cadastrar")
            {
                ValidarCampos();
                if(validar == "Cadastrar"){
                    //pegando valores para inserir no banco de dados
                    CamposDeCadastro();
                    crud.Criar_Dados();
                    LimparCampos();
                }
                    
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Empresa frmEmpresa = new Empresa();
            this.Hide();
            frmEmpresa.Show();
        }

        private void btn_nova_empresa_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
