
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agenda_OS_Diego.OrdemServico
{
    public partial class FRM_Add_OS : Form
    {

        CrudOs crud_os = new CrudOs();
        string campos = "";

        public FRM_Add_OS()
        {
            InitializeComponent();
            ListarTecnico();
            MaskaraDateTime();
        }

        public void PegarDados()
        {
            crud_os.id_ordemServico = Convert.ToInt32(lbl_id_os.Text);
            crud_os.id_empresa = Convert.ToInt32(lbl_id_empresa.Text);
            crud_os.id_tecnico = Convert.ToInt32(lbl_id_tecnico.Text);
            crud_os.solicitante = txt_solicitante.Text;
            //crud_os.informação_extra = txt_info_extra.Text;
            crud_os.assunto = txt_assunto.Text;
            crud_os.descricao = txt_descricao.Text;
            crud_os.atendimento = cb_atendimento.Text;
            crud_os.sistema = cb_sistema.Text;
            crud_os.solucao = txt_solucao.Text;
            crud_os.abertura = dtp_abertura.Value;
            crud_os.conclusao = dtp_conclusao.Value;
            crud_os.status = cb_status.Text;
            crud_os.inativado = cb_inativar_OS.Checked;
        }

        public void ValidarCampos() {
            if (txt_descricao.Text == "" || txt_fantasia.Text == "" || txt_solicitante.Text == "" || txt_descricao.Text == "" ||
                mtb_cnpj.Text == "" || mtb_telefone.Text == "" || mtb_celular.Text == "" || cb_atendimento.SelectedItem == null ||
                cb_status.SelectedItem == null || cb_tecnico.SelectedItem == null
                )
            {
                MessageBox.Show("Preencha todos os campos para abrir a OS!");
                campos = "faltando campos";
            }
            else {
                campos = "OK";
            }   
        }

        private void btn_abrir_os_Click(object sender, EventArgs e)
        {
            if (btn_abrir_os.Text == "Abrir OS")
            {
                ValidarCampos();
                if (campos == "OK") {
                    PegarDados();
                    crud_os.CadastrarOS();

                    OrdemServico frmOrdemServico = new OrdemServico();
                    this.Hide();
                    frmOrdemServico.Show();
                    Log("Ordem de serviço aberta por usuario: " + Home.nome + " para o tecnico " + cb_tecnico.Text);
                }
                
            }
            else if (btn_abrir_os.Text == "Gravar")
            {
                PegarDados();
                crud_os.AlterarDados();
                Log("Ordem de serviço alterada pelo usuario: " + Home.nome);

            }
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
            txt_solucao.Text = "";
            dtp_abertura.Format = default;
            dtp_conclusao.Format = default;
            cb_status.SelectedIndex = 0;
            cb_sistema.SelectedIndex = 0;
        }
        public void ListarTecnico() {
            crud_os.ListarTecnico();
            cb_tecnico.DataSource = crud_os.tecnico;
            cb_tecnico.DisplayMember = "nome_tecnico";
            cb_tecnico.ValueMember = "id_tecnico";
            lbl_id_tecnico.Text = cb_tecnico.SelectedValue.ToString();

        }

        public void MaskaraDateTime() {
            dtp_abertura.Format = DateTimePickerFormat.Custom;
            dtp_abertura.CustomFormat = "dd/MM/yyyy 'as' H:m";
            dtp_conclusao.Format = DateTimePickerFormat.Custom;
            dtp_conclusao.CustomFormat = "dd/MM/yyyy 'as' H:m";
        }
        

        private void img_pesquisar_Click(object sender, EventArgs e)
        {
            Frm_listar_empresa frmListarEmpresa = new Frm_listar_empresa();
            frmListarEmpresa.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OrdemServico frmOrdemServico = new OrdemServico();
            this.Hide();
            frmOrdemServico.Show();
        }

        private void cb_tecnico_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbl_id_tecnico.Text = cb_tecnico.SelectedValue.ToString();
        }

        private void btn_selecionar_empresa_Click(object sender, EventArgs e)
        {
            Frm_listar_empresa frmListarEmpresa = new Frm_listar_empresa();
            frmListarEmpresa.Show();
            this.Hide();
        }

        private void FRM_Add_OS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OrdemServico frmOrdemServico = new OrdemServico();
                this.Hide();
                frmOrdemServico.Show();
            }
        }

        private void Log(string mensagem)
        {
            string ficheiro = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logs.txt";
            StreamWriter arquivo = new StreamWriter(ficheiro, true, Encoding.Default);
            arquivo.WriteLine(DateTime.Now + " > " + mensagem);
            arquivo.Dispose();
        }
    }
}
