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
    public partial class FrmTecnico : Form
    {
        CrudTec crudtec = new CrudTec();
        public FrmTecnico()
        {
            InitializeComponent();
        }

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



        private void btn_cadastrar_tecnico_Click(object sender, EventArgs e)
        {
            if (btn_cadastrar_tecnico.Text == "Cadastrar")
            {
                PegarCampos();
                crudtec.CriarDados();                
                LimparCampos();
            }
            else if (btn_cadastrar_tecnico.Text == "Gravar")
            {
                PegarCampos();
                crudtec.Alterar_Dados();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tecnico frmTecnico = new Tecnico();
            this.Hide();
            frmTecnico.Show();
        }
    }
}
