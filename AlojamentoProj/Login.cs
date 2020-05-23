using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AlojamentoProj
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = "user";
            string passWord = "1234";

            if ((textBox1.Text == userName) && (textBox2.Text == passWord))
            {
                MessageBox.Show("login OK");
                MenuTest menu = new MenuTest();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Invalido");
              
            }
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        //internal void Click()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
