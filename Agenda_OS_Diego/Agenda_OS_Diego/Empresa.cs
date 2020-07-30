using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        Form_Empresa frmempresa = new Form_Empresa();

        public Empresa()
        {
            InitializeComponent();
        }
        //adicionar uma empresa
        private void btn_novo_Click(object sender, EventArgs e)
        {
            Form_Empresa frm_empresa = new Form_Empresa();
            this.Hide();
            frm_empresa.ShowDialog();
        }
        //editar uma empresa
        private void btn_editar_Click(object sender, EventArgs e)
        {
            PuxarDadosEmpresa();  
        }
        
        //metodo para listar uma empresa
        public void ListarEmpresa() 
        {
            dgv_empresa.DataSource = null;
            crud.Listar_Dados(dgv_empresa);
            dgv_empresa.DataSource = crud.dt;
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            crud.Listar_Dados(dgv_empresa);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string id = crud.id;
            crud.Deletar_Dados(id);

            
        }

        public void PuxarDadosEmpresa() {
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

        public void PuxarCampos() {
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

        private void btn_cadastrar_empresa_Click(object sender, EventArgs e)
        {
            if (btn_cadastrar_empresa.Text == "Gravar")
            {
                PuxarCampos();
                crud.Alterar_Dados(lbl_id.Text);
            }
            else {
                PuxarCampos();
                crud.Criar_Dados();
            }
        }
    }
}
