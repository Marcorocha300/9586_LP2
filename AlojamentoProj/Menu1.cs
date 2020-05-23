using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlojamentoProj
{
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {   
            Form log = new Login();
            log.ShowDialog();
                      
        }

        private void btnGoToRegist_Click(object sender, EventArgs e)
        {
            //Application.Run(new Registo());
            Form reg = new Registo();
            reg.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu1_Load(object sender, EventArgs e)
        {

        }
    }
}
