

using Agenda_OS_Diego.OrdemServico;
using Agenda_OS_Diego.Classes;
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
        public void limparCampos() {
            lbl_id_empresa.Text = "";
            lbl_id_os.Text = "";
            lbl_id_tecnico.Text = "";
            cb_tecnico.SelectedIndex = 0;
            txt_solicitante.Text = "";
            txt_fantasia.Text = "";
            mtb_cnpj.Text = "";
            mtb_telefone.Text = "";
            mtb_celular.Text = "";
            txt_assunto.Text = "";
            txt_descricao.Text = "";
            txt_info_extra.Text = "";
            txt_solucao.Text = "";
            dtp_abertura.Format = DateTimePickerFormat.Time;
            dtp_conclusao.Format = DateTimePickerFormat.Time;
            cb_status.SelectedIndex = 0;
            cb_sistema.SelectedIndex = 0;
        }

        private void img_return_Click(object sender, EventArgs e)
        {
            Home return_home = new Home();
            this.Hide();
            return_home.ShowDialog();
        }

        private void txt_fantasia_TextChanged(object sender, EventArgs e)
        {
            crud_os.fantasia = txt_fantasia.Text;

            crud_os.ListarEmpresa();
            lbl_id_empresa.Text = crud_os.id_empresa.ToString();
            txt_fantasia.Text = crud_os.fantasia;
            mtb_cnpj.Text = crud_os.cnpj;
            mtb_celular.Text = crud_os.celular;
            mtb_telefone.Text = crud_os.telefone;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home ReturnHome = new Home();
            this.Hide();
            ReturnHome.ShowDialog();
        }

        public void PegarDados() {
            crud_os.id_ordemServico = Convert.ToInt32(lbl_id_os.Text);
            crud_os.id_empresa = Convert.ToInt32(lbl_id_empresa.Text);
            crud_os.id_tecnico = Convert.ToInt32(lbl_id_tecnico.Text);
            crud_os.solicitante = txt_solicitante.Text;
            crud_os.informação_extra = txt_info_extra.Text;
            crud_os.assunto = txt_assunto.Text;
            crud_os.descricao = txt_descricao.Text;
            crud_os.atendimento = cb_atendimento.Text;
            crud_os.sistema = cb_sistema.Text;
            crud_os.solucao = txt_solucao.Text;
            crud_os.abertura = dtp_abertura.Value;
            crud_os.conclusao = dtp_conclusao.Value;
            crud_os.status = cb_status.Text;
        }
        
        private void btn_abrir_os_Click(object sender, EventArgs e)
        {
            if (btn_abrir_os.Text == "Abrir OS")
            {
                PegarDados();
                crud_os.CadastrarOS();
            }
            else if (btn_abrir_os.Text == "Gravar") {
                PegarDados();
                crud_os.AlterarDados();
            }
            
        }
        
        public void ListarDados()
        {
            if (dgv_os.SelectedRows.Count > 0)
            {
                lbl_id_os.Text = dgv_os.CurrentRow.Cells["id_os"].Value.ToString();
                lbl_id_empresa.Text = dgv_os.CurrentRow.Cells["fk_empresa"].Value.ToString();
                lbl_id_tecnico.Text = dgv_os.CurrentRow.Cells["fk_tecnico"].Value.ToString();
                cb_tecnico.Text = dgv_os.CurrentRow.Cells["nome_tecnico"].Value.ToString();
                txt_solicitante.Text = dgv_os.CurrentRow.Cells["solicitante"].Value.ToString();
                txt_fantasia.Text = dgv_os.CurrentRow.Cells["fantasia"].Value.ToString();
                mtb_cnpj.Text = dgv_os.CurrentRow.Cells["cnpj"].Value.ToString();
                mtb_telefone.Text = dgv_os.CurrentRow.Cells["telefone"].Value.ToString();
                mtb_celular.Text = dgv_os.CurrentRow.Cells["celular"].Value.ToString();
                txt_info_extra.Text = dgv_os.CurrentRow.Cells["info_extra"].Value.ToString();
                txt_assunto.Text = dgv_os.CurrentRow.Cells["assunto"].Value.ToString();
                txt_descricao.Text = dgv_os.CurrentRow.Cells["descricao"].Value.ToString();
                cb_atendimento.Text = dgv_os.CurrentRow.Cells["atendimento"].Value.ToString();
                cb_sistema.Text = dgv_os.CurrentRow.Cells["sistema"].Value.ToString();
                txt_solucao.Text = dgv_os.CurrentRow.Cells["solucao"].Value.ToString();
                dtp_abertura.Text = dgv_os.CurrentRow.Cells["abertura"].Value.ToString();
                dtp_conclusao.Text = dgv_os.CurrentRow.Cells["conclusao"].Value.ToString();
                cb_status.Text = dgv_os.CurrentRow.Cells["status_os"].Value.ToString();
                btn_abrir_os.Text = "Gravar";
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
            crud_os.ListarTecnico();
            cb_tecnico.DataSource = crud_os.tecnico;
            cb_tecnico.DisplayMember = "nome_tecnico";
            cb_tecnico.ValueMember = "id_tecnico";
        }

        private void cb_tecnico_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //passando o valor do TextBoxpara lbl id
            lbl_id_tecnico.Text = cb_tecnico.SelectedValue.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ListarDados();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void mtb_cnpj_TextChanged(object sender, EventArgs e)
        {
            mtb_cnpj.Mask = "";
            crud_os.cnpj = mtb_cnpj.Text;

            crud_os.ListarEmpresa();
            lbl_id_empresa.Text = crud_os.id_empresa.ToString();
            txt_fantasia.Text = crud_os.fantasia;
            mtb_cnpj.Text = crud_os.cnpj;
            mtb_celular.Text = crud_os.celular;
            mtb_telefone.Text = crud_os.telefone;
        }
    }
}
