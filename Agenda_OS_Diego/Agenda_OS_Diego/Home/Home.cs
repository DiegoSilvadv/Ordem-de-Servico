
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS_Diego
{
    public partial class Home : Form
    {
        public Home()
        { 
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            this.Hide();
            empresa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tecnico.Tecnico frmtec = new Tecnico.Tecnico();
            this.Hide();
            frmtec.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
