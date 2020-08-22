

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
            crud_os.id_empresa = Convert.ToInt32(lbl_id_empresa.Text);
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
            PegarDados();
            crud_os.CadastrarOS();
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
            crud_os.ListarProfessor();
            cb_tecnico.DataSource = crud_os.tecnico;
            cb_tecnico.DisplayMember = "nome";
            cb_tecnico.ValueMember = "id_tecnico";
        }


        private void cb_tecnico_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //passando o valor do TextBoxpara lbl id
            lbl_id_tecnico.Text = cb_tecnico.SelectedValue.ToString();
        }
    }
}
