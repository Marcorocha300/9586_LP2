using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace AppAlojamentoLocal
{
    public partial class Form1 : Form
    {
        Thread th;// declaraçaõ da variável do tipo thread
        public  int user;
 
        public Form1()
        {
            InitializeComponent();
        }
        private void PanelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Botão de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Click(object sender, EventArgs e)
        {   
            string userName = textBoxUserNameLogin.Text;
            //byte passWord = Convert.ToByte( texboxPassWordLogin.Text);
            byte[] password = Encoding.ASCII.GetBytes(texboxPassWordLogin.Text);

            if (userName != "")
            {
                using (var context = new AlojamentoDbEntities4())
                {
                    User queryUser = context.Users
                                       .Where(s => s.userName == textBoxUserNameLogin.Text && s.passWord == password)
                                       .FirstOrDefault();

                    if (queryUser != null) 
                    {               
                        //string userName = "user";
                        //string passWord = "1234";
                        this.Close();
                        //Uso de Thread para fechar o form anterior e abrir um novo
                        th = new Thread(OpenForm2);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        //MinhasReservas user = new MinhasReservas();
                        user = queryUser.id;
                        Console.WriteLine(user);
                        MinhasReservas resShow = new MinhasReservas(textBoxUserNameLogin.Text);
                        FormPerfil perfilShow = new FormPerfil(textBoxUserNameLogin.Text);
                    }
                    else
                    {
                        MessageBox.Show("Login Invalido");

                    }
                }
            }
            else 
            {
                MessageBox.Show("preencha login");
            }

        }
        /// <summary>
        /// metodo para abrir a messageBox e iniciar o form2, vai ser utilizado pela Thread
        /// </summary>
        /// <param name="obj"></param>
        private void OpenForm2(object obj)
        {
            MessageBox.Show("login OK");
            Application.Run(new Form2());
        }
        /// <summary>
        /// Botão de criar novo utilizador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            FormRegisto reg = new FormRegisto();
            reg.ShowDialog();
        }
        /// <summary>
        /// Textbox para inderir user name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUserNameLogin_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// TextBox para inserir a password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void texboxPassWordLogin_TextChanged(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Label Da textbox username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void userName_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Label Da textbox password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void passWord_Click(object sender, EventArgs e)
         {
         }
         #region Painel fotos dos Bungalows
         /// <summary>
         /// Painel de visualização das fotos dos Alojamentos
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void panelBungalows_Paint(object sender, PaintEventArgs e)
         {

         }

         private void pictureBoxBung1_Click(object sender, EventArgs e)
         {

         }

         private void pictureBoxBung2_Click(object sender, EventArgs e)
         {

         }

         private void pictureBoxBung3_Click(object sender, EventArgs e)
         {

         }
        private void pictureBoxBung4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
