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
    public partial class MenuTest : Form
    {
        public MenuTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer reg = new Customer();
            reg.Registo("Marco", "Braga", "Admin", "user");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void  CheckOut_Click(object sender, EventArgs e)
        {

        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuTest_Load(object sender, EventArgs e)
        {

        }

        private void MenuRegisto_Click(object sender, EventArgs e)
        {

        }
    }
}
