

using Agenda_OS_Diego.OrdemServico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace Agenda_OS_Diego.OrdemServico
{
    public partial class OrdemServico : Form
    {
        CrudOs crud_os = new CrudOs();
        FRM_Add_OS FRM = new FRM_Add_OS();


        public OrdemServico()
        {
            InitializeComponent();
            crud_os.Listar_Dados(dgv_os);
            EsconderColunas();
        }

        public void EsconderColunas() 
        {
            dgv_os.Columns["fk_empresa"].Visible = false;
            dgv_os.Columns["fk_tecnico"].Visible = false;
        }
        
        private void img_return_Click(object sender, EventArgs e)
        {
            Home return_home = new Home();
            this.Hide();
            return_home.ShowDialog();
        }

        private void txt_fantasia_TextChanged(object sender, EventArgs e)
        {   
            crud_os.fantasia = FRM.txt_fantasia.Text;

            crud_os.ListarEmpresa();
            FRM.lbl_id_empresa.Text = crud_os.id_empresa.ToString();
            FRM.txt_fantasia.Text = crud_os.fantasia;
            FRM.mtb_cnpj.Text = crud_os.cnpj;
            FRM.mtb_celular.Text = crud_os.celular;
            FRM.mtb_telefone.Text = crud_os.telefone;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home ReturnHome = new Home();
            this.Hide();
            ReturnHome.ShowDialog();
        }
        
        public void ListarDados()
        {
            if (dgv_os.SelectedRows.Count > 0)
            {
                FRM.lbl_id_os.Text = dgv_os.CurrentRow.Cells["id_os"].Value.ToString();
                FRM.lbl_id_empresa.Text = dgv_os.CurrentRow.Cells["fk_empresa"].Value.ToString();
                FRM.lbl_id_tecnico.Text = dgv_os.CurrentRow.Cells["fk_tecnico"].Value.ToString();
                FRM.cb_tecnico.Text = dgv_os.CurrentRow.Cells["nome_tecnico"].Value.ToString();
                FRM.txt_solicitante.Text = dgv_os.CurrentRow.Cells["solicitante"].Value.ToString();
                FRM.txt_fantasia.Text = dgv_os.CurrentRow.Cells["fantasia"].Value.ToString();
                FRM.mtb_cnpj.Text = dgv_os.CurrentRow.Cells["cnpj"].Value.ToString();
                FRM.mtb_telefone.Text = dgv_os.CurrentRow.Cells["telefone"].Value.ToString();
                FRM.mtb_celular.Text = dgv_os.CurrentRow.Cells["celular"].Value.ToString();
                //FRM.txt_info_extra.Text = dgv_os.CurrentRow.Cells["info_extra"].Value.ToString();
                FRM.txt_assunto.Text = dgv_os.CurrentRow.Cells["assunto"].Value.ToString();
                FRM.txt_descricao.Text = dgv_os.CurrentRow.Cells["descricao"].Value.ToString();
                FRM.cb_atendimento.Text = dgv_os.CurrentRow.Cells["atendimento"].Value.ToString();
                FRM.cb_sistema.Text = dgv_os.CurrentRow.Cells["sistema"].Value.ToString();
                FRM.txt_solucao.Text = dgv_os.CurrentRow.Cells["solucao"].Value.ToString();
                FRM.dtp_abertura.Text = dgv_os.CurrentRow.Cells["abertura"].Value.ToString();
                FRM.dtp_conclusao.Text = dgv_os.CurrentRow.Cells["conclusao"].Value.ToString();
                FRM.cb_status.Text = dgv_os.CurrentRow.Cells["status_os"].Value.ToString();
                FRM.btn_abrir_os.Text = "Gravar";
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            crud_os.ListarOSPendente(dgv_os);

            if (cb_pendentes.Checked == false) {
                crud_os.Listar_Dados(dgv_os);
            }
        }

        private void OrdemServico_Load(object sender, EventArgs e)
        {

            //VERIFICA SE ESTÁ COM ALGUMA LINHA SELECIONADA
            if (dgv_os.SelectedRows.Count > 0)
            {
                int index = dgv_os.SelectedRows[0].Index;

                if (index >= 0)
                    dgv_os.Rows[index].Selected = false;
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Frm_listar_empresa frmListar = new Frm_listar_empresa();
            this.Hide();
            frmListar.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }
    }
}
