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
using Agenda_OS_Diego;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Agenda_OS_Diego
{
    public partial class Empresa : Form
    {   
        //instanciando a class crud
        CRUD crud = new CRUD();

        public Empresa()
        {
            InitializeComponent();
            Form_Empresa frmempresa = new Form_Empresa();
            frmempresa.PuxarDados();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Form_Empresa frm_empresa = new Form_Empresa();
            this.Hide();
            frm_empresa.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Form_Empresa frm_empresa = new Form_Empresa();
            this.Hide();
            frm_empresa.ShowDialog();
        }
        
        
        //listar
        public void ListarEmpresa() 
        {
            dgv_empresa.DataSource = null;
            crud.Listar_Dados(dgv_empresa);
            dgv_empresa.DataSource = crud.dt;
        }

        private void dgv_empresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView enviarAoGrid = (DataGridView) sender;
            try
            {
                if (dgv_empresa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    
                }
            }
            catch 
            {

            }
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            crud.Listar_Dados(dgv_empresa);
        }

        //deletar empresa


    }
}
