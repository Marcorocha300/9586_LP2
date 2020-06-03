using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryCustomer;

namespace AppAlojamentoLocal
{
    public partial class FormRegisto : Form
    {
        public FormRegisto()
        {
            InitializeComponent();
        }
        private void panelRegisto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelSobrenome_Click(object sender, EventArgs e)
        {
        }

        private void textBoxSobrenome_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {
        }

        private void labelPhone_Click(object sender, EventArgs e)
        {
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddReg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Registo.Registar(textUserName.Text, textPassword.Text, textNome.Text, textBoxSobrenome.Text, textBoxAddress.Text, textPhone.Text, textEmail.Text));
            Close();
        }

        private void buttonCancelReg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRegisto_Load(object sender, EventArgs e)
        {

        }
    }
}
