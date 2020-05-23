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
    public partial class FormMenu1 : Form
    {
        public FormMenu1()
        {
            InitializeComponent();
        }

        private void LabelTitulo1_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void btnGoToRegist_Click(object sender, EventArgs e)
        //{
        //    Registo regis = new Registo();
        //    regis.Show();
        //    panelMenuGuest.Controls.Clear();
        //    panelRegisto.Show();
        //    panelBungalows.Visible = false;
        //    panelLogin.Visible = false;
        //}

        #region painel Registo
        private void panelRegisto_Paint(object sender, PaintEventArgs e)
        {

        }
        private void labelRegisto_Click(object sender, EventArgs e)
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
        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
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
            panelBungalows.Visible = false;
            panelLogin.Visible = false;
        }
        private void buttonCancelReg_Click(object sender, EventArgs e)
        {
            Close();
            panelBungalows.Visible = false;
            panelLogin.Visible = false;
        }

        #endregion


        #region Painel Bungalows
        private void panelBungalows_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBoxBung1_Click(object sender, EventArgs e)
        {
        }
        private void buttonReservaBung1_Click(object sender, EventArgs e)
        {
            MenuTest menuReg = new MenuTest();
            menuReg.Show();
        }
        private void pictureBoxBung2_Click(object sender, EventArgs e)
        {
        }
        private void buttonReservaBung2_Click(object sender, EventArgs e)
        {
            MenuTest menuReg = new MenuTest();
            menuReg.Show();
        }
        private void pictureBoxBung3_Click(object sender, EventArgs e)
        {
        }
        private void buttonReservaBung3_Click(object sender, EventArgs e)
        {
            MenuTest menuReg = new MenuTest();
            menuReg.Show();
        }
        private void pictureBoxBung4_Click(object sender, EventArgs e)
        {
        }
        private void buttonReservaBung4_Click(object sender, EventArgs e)
        {
            MenuTest menuReg = new MenuTest();
            menuReg.Show();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            panelBungalows.Visible = false;
            
        }

        private void buttonRegist_Click(object sender, EventArgs e)
        {
            Registo regis = new Registo();
            regis.Show();

        }

        private void panelMenuGuest_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        #region Painel Customer
        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void labelCustomerConsulta_Click(object sender, EventArgs e)
        {

        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsultReservas_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustomerPanelExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Panel Admin
        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void labelAdmin_Click(object sender, EventArgs e)
        {

        }
        private void btnReservasAdmin_Click(object sender, EventArgs e)
        {

        }
        private void btnCustomersAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffAdmin_Click(object sender, EventArgs e)
        {

        }
        private void btnAdminExit_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Panel Staff
        private void panelStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelStaff_Click(object sender, EventArgs e)
        {

        }
        private void buttonReservasStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomersStaff_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitStaff_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
