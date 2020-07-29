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

namespace Agenda_OS_Diego
{
    public partial class Form_Empresa : Form
    {
        //instanciando a class crud
        CRUD crud = new CRUD();

        public Form_Empresa()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_empresa_Click(object sender, EventArgs e)
        {
            
            CriarEmpresa();
            crud.Criar_Dados();
        }

        //Pegando os dados dos campos do formulario para inserir no banco
        public void CriarEmpresa() 
        {
            crud.razao = txt_razao.Text;
            crud.fantasia = txt_fantasia.Text;
            crud.cnpj = mtb_cnpj.Text;
            crud.rua = txt_razao.Text;
            crud.bairro = txt_bairro.Text;
            crud.cidade = txt_cidade.Text;
            crud.numero = txt_numero.Text;
            crud.cep = mtb_cep.Text;
            crud.telefone = mtb_telefone.Text;
            crud.celular = mtb_celular.Text;

        }

        public void AlterarEmpresa() 
        {
            crud.razao = txt_razao.Text;
            crud.fantasia = txt_fantasia.Text;
            crud.cnpj = mtb_cnpj.Text;
            crud.rua = txt_razao.Text;
            crud.bairro = txt_bairro.Text;
            crud.cidade = txt_cidade.Text;
            crud.numero = txt_numero.Text;
            crud.cep = mtb_cep.Text;
            crud.telefone = mtb_telefone.Text;
            crud.celular = mtb_celular.Text;

        }

        public void PuxarDados() {
            crud.razao = txt_razao.Text;
            crud.fantasia = txt_fantasia.Text;
            crud.cnpj = mtb_cnpj.Text;
            crud.rua = txt_razao.Text;
            crud.bairro = txt_bairro.Text;
            crud.cidade = txt_cidade.Text;
            crud.numero = txt_numero.Text;
            crud.cep = mtb_cep.Text;
            crud.telefone = mtb_telefone.Text;
            crud.celular = mtb_celular.Text;
        }
    }
}
