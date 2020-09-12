
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS_Diego.OrdemServico
{
    public partial class Frm_listar_empresa : Form
    {
        CRUD crudEmpresa = new CRUD();
        CrudOs crud_os = new CrudOs();
        public int id_empresa { set; get; }
        public string fantasia { set; get; }
        public string cnpj { set; get; }
        public string telefone { set; get; }
        public string celular { set; get; }
       
        public Frm_listar_empresa()
        {
            InitializeComponent();
        }

        public void DadosEmpresa()
        {
            this.id_empresa = Convert.ToInt32(dgv_Empresa_os.CurrentRow.Cells[0].Value.ToString());
            this.fantasia = dgv_Empresa_os.CurrentRow.Cells[1].Value.ToString();
            this.cnpj = dgv_Empresa_os.CurrentRow.Cells[2].Value.ToString();
            //txt_rua.Text = dgv_Empresa_os.CurrentRow.Cells["rua"].Value.ToString();
            //txt_bairro.Text = dgv_Empresa_os.CurrentRow.Cells["bairro"].Value.ToString();
            //txt_cidade.Text = dgv_Empresa_os.CurrentRow.Cells["cidade"].Value.ToString();
            //txt_numero.Text = dgv_Empresa_os.CurrentRow.Cells["numero"].Value.ToString();
            //mtb_cep.Text = dgv_Empresa_os.CurrentRow.Cells["cep"].Value.ToString();
            this.telefone = dgv_Empresa_os.CurrentRow.Cells[8].Value.ToString();
            this.celular = dgv_Empresa_os.CurrentRow.Cells[9].Value.ToString();
        }
        private void Frm_listar_empresa_Load(object sender, EventArgs e)
        {
            crudEmpresa.Listar_Dados(dgv_Empresa_os);
        }
       
        private void dgv_Empresa_os_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Add_OS FRM = new FRM_Add_OS();

            FRM.lbl_id_empresa.Text = this.dgv_Empresa_os.CurrentRow.Cells["id_empresa"].Value.ToString();
            FRM.txt_fantasia.Text = this.dgv_Empresa_os.CurrentRow.Cells["fantasia"].Value.ToString();
            FRM.mtb_cnpj.Text = this.dgv_Empresa_os.CurrentRow.Cells["cnpj"].Value.ToString();
            FRM.mtb_celular.Text = this.dgv_Empresa_os.CurrentRow.Cells[8].Value.ToString();
            FRM.mtb_telefone.Text = this.dgv_Empresa_os.CurrentRow.Cells[9].Value.ToString();
            this.Hide();
            FRM.ShowDialog();
            
        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            //pesquisa em tempo real
            string razao = txt_pesquisa.Text.ToString();
            crudEmpresa.Listar_Dados_Especificos(dgv_Empresa_os, razao);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OrdemServico frmOS = new OrdemServico();
            this.Hide();
            frmOS.Show();
        }
    }
}
