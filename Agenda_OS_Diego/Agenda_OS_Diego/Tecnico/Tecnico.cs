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
        FrmTecnico frmTecnico = new FrmTecnico();

        public Tecnico()
        {
            InitializeComponent();
            crudtec.ListarTecnico(dgv_tecnico);
        }

        //funções da página
        
        //Função para listar os dados do grid view nos campos
        public void ListarDados()
        {
            if (dgv_tecnico.SelectedRows.Count > 0)
            {
                frmTecnico.lbl_id.Text = dgv_tecnico.CurrentRow.Cells["id_tecnico"].Value.ToString();
                frmTecnico.txt_usuario.Text = dgv_tecnico.CurrentRow.Cells["usuario"].Value.ToString();
                frmTecnico.txt_senha.Text = dgv_tecnico.CurrentRow.Cells["senha"].Value.ToString();
                frmTecnico.txt_nome.Text = dgv_tecnico.CurrentRow.Cells["nome_tecnico"].Value.ToString();
                frmTecnico.mtb_cnh.Text = dgv_tecnico.CurrentRow.Cells["cnh"].Value.ToString();
                frmTecnico.txt_cidade.Text = dgv_tecnico.CurrentRow.Cells["cidade"].Value.ToString();
                frmTecnico.txt_bairro.Text = dgv_tecnico.CurrentRow.Cells["bairro"].Value.ToString();
                frmTecnico.txt_rua.Text = dgv_tecnico.CurrentRow.Cells["rua"].Value.ToString();
                frmTecnico.txt_numero.Text = dgv_tecnico.CurrentRow.Cells["numero"].Value.ToString();
                frmTecnico.mtb_cep.Text = dgv_tecnico.CurrentRow.Cells["cep"].Value.ToString();
                frmTecnico.mtb_celular.Text = dgv_tecnico.CurrentRow.Cells["celular"].Value.ToString();
                frmTecnico.btn_cadastrar_tecnico.Text = "Gravar";
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
       
        //Clicks de botão
        private void btn_editar_Click(object sender, EventArgs e)
        {   
            ListarDados();
            frmTecnico.Show();
            this.Hide();
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


        private void btn_add_Click(object sender, EventArgs e)
        {
            frmTecnico.Show();
            this.Hide();
        }
    }
}
