using Agenda_OS_Diego.Tecnico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS_Diego.Tecnico
{

    public partial class Tecnico : Form
    {   //instancia da class crud para poder ficar acessivel
        CrudTec crudtec = new CrudTec();
       
        public Tecnico()
        {
            InitializeComponent();
            crudtec.ListarTecnico(dgv_tecnico);
        }

        //funções da página
        //Pegando valores dos campos e atribuindo nas strings da class CRUD
        public void PegarCampos()
        {
            crudtec.id = lbl_id.Text;
            crudtec.usuario = txt_usuario.Text;
            crudtec.senha = txt_senha.Text;
            crudtec.nome = txt_nome.Text;
            crudtec.cnh = mtb_cnh.Text;
            crudtec.cidade = txt_cidade.Text;
            crudtec.bairro = txt_bairro.Text;
            crudtec.rua = txt_rua.Text;
            crudtec.numero = txt_numero.Text;
            crudtec.cep = mtb_cep.Text;
            crudtec.celular = mtb_celular.Text;
            crudtec.data_nascimento = dtp_nascimento.Value;
        }
        //Função para listar os dados do grid view nos campos
        public void ListarDados()
        {
            if (dgv_tecnico.SelectedRows.Count > 0)
            {
                lbl_id.Text = dgv_tecnico.CurrentRow.Cells["id_tecnico"].Value.ToString();
                txt_usuario.Text = dgv_tecnico.CurrentRow.Cells["usuario"].Value.ToString();
                txt_senha.Text = dgv_tecnico.CurrentRow.Cells["senha"].Value.ToString();
                txt_nome.Text = dgv_tecnico.CurrentRow.Cells["nome"].Value.ToString();
                mtb_cnh.Text = dgv_tecnico.CurrentRow.Cells["cnh"].Value.ToString();
                txt_cidade.Text = dgv_tecnico.CurrentRow.Cells["cidade"].Value.ToString();
                txt_bairro.Text = dgv_tecnico.CurrentRow.Cells["bairro"].Value.ToString();
                txt_rua.Text = dgv_tecnico.CurrentRow.Cells["rua"].Value.ToString();
                txt_numero.Text = dgv_tecnico.CurrentRow.Cells["numero"].Value.ToString();
                mtb_cep.Text = dgv_tecnico.CurrentRow.Cells["cep"].Value.ToString();
                mtb_celular.Text = dgv_tecnico.CurrentRow.Cells["celular"].Value.ToString();
                btn_cadastrar_tecnico.Text = "Gravar";
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
        public void LimparCampos()
        {
            lbl_id.Text = "0";
            txt_usuario.Text = "";
            txt_senha.Text = "";
            txt_nome.Text = "";
            mtb_cnh.Text = "";
            txt_cidade.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";
            txt_numero.Text = "";
            mtb_cep.Text = "";
            mtb_celular.Text = "";
            btn_cadastrar_tecnico.Text = "Cadastrar";
        }
        


        //Clicks de botão
        private void btn_editar_Click(object sender, EventArgs e)
        {
            ListarDados();
        }

        //Botão de cadastrar Técnico
        private void btn_cadastrar_tecnico_Click_1(object sender, EventArgs e)
        {
            if (btn_cadastrar_tecnico.Text == "Cadastrar")
            {
                PegarCampos();
                crudtec.CriarDados();
                crudtec.ListarTecnico(dgv_tecnico);
                LimparCampos();
            }
            else if (btn_cadastrar_tecnico.Text == "Gravar")
            {
                PegarCampos();
                crudtec.Alterar_Dados();
                crudtec.ListarTecnico(dgv_tecnico);
                LimparCampos();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //id passado para fazer a exclusão
            crudtec.id = dgv_tecnico.CurrentRow.Cells["id_tecnico"].Value.ToString();
            crudtec.DeletarTecnico();
            crudtec.ListarTecnico(dgv_tecnico);
        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            crudtec.nome = txt_pesquisa.Text;
            crudtec.Listar_Dados_Especificos(dgv_tecnico);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home ReturnHome = new Home();
            this.Hide();
            ReturnHome.ShowDialog();
        }

    }
}
