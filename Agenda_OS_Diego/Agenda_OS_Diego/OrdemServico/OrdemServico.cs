

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



namespace Agenda_OS_Diego.OrdemServico
{
    public partial class OrdemServico : Form
    {
        CrudOs crud_os = new CrudOs();
        public void Colorir() {
            foreach (DataGridViewRow row in dgv_os.Rows)
            {
                

            }
        }
        

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
            string fantasia = txt_fantasia.Text;
            crud_os.ListarEmpresa(fantasia);
            txt_fantasia.Text = crud_os.fantasia;
            mtb_cnpj.Text = crud_os.cnpj;
        }

        private void txt_assunto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtb_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtb_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtb_celular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_solicitante_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
