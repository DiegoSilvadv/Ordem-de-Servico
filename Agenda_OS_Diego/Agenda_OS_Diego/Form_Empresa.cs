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
            
          
        }

        //Pegando os dados dos campos do formulario para inserir no banco
       
    }
}
