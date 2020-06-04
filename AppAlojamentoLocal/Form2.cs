using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlojamentoLocal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormPerfil perfil = new FormPerfil();
            perfil.ShowDialog();
        }

        private void buttonConsultReservas_Click(object sender, EventArgs e)
        {
            MinhasReservas resShow = new MinhasReservas();
            resShow.Show();
        }

        private void buttonFazerReserva_Click(object sender, EventArgs e)
        {
            FormFazerReserva reserv = new FormFazerReserva();
            reserv.ShowDialog();
        }

        private void buttonCustomerPanelExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Pictures & labels
        private void panelBungalows_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxBung1_Click(object sender, EventArgs e)
        {

        }

        private void labelBungalow1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBung2_Click(object sender, EventArgs e)
        {

        }

        private void labelbungalow2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBung3_Click(object sender, EventArgs e)
        {

        }

        private void labelBungalow3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBung4_Click(object sender, EventArgs e)
        {

        }

        private void labelBungalow4_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
