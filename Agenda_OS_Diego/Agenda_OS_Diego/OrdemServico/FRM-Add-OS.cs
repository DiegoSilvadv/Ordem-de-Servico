using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS_Diego.OrdemServico
{
    public partial class FRM_Add_OS : Form
    {

        CrudOs crud_os = new CrudOs();

        public FRM_Add_OS()
        {
            InitializeComponent();
        }

        private void btn_abrir_os_Click(object sender, EventArgs e)
        {

        }
















        public void PegarDados()
        {
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











        public void limparCampos()
        {
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
            //txt_info_extra.Text = "";
            txt_solucao.Text = "";
            dtp_abertura.Format = DateTimePickerFormat.Time;
            dtp_conclusao.Format = DateTimePickerFormat.Time;
            cb_status.SelectedIndex = 0;
            cb_sistema.SelectedIndex = 0;
        }

        private void cb_tecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_id_tecnico.Text = cb_tecnico.SelectedValue.ToString();
        }

        private void FRM_Add_OS_Load(object sender, EventArgs e)
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

            dtp_abertura.Format = DateTimePickerFormat.Custom;
            dtp_abertura.CustomFormat = "dd MM yyyy H m s";
        }
    }
}
