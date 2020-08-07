

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

        public OrdemServico()
        {
            
            
            InitializeComponent();
        }

        
        private void txt_fantasia_TextChanged(object sender, EventArgs e)
        {
            
            crud_os.fantasia = txt_fantasia.Text;
            crud_os.ListarEmpresa();
            txt_fantasia.Text = crud_os.fantasia;
           
        }

        private void OrdemServico_Load(object sender, EventArgs e)
        {
          
        }
    }
}
