using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlojamentoProj
{
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddReg_Click(object sender, EventArgs e)
        {
            //Conection to data base
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=AlojamentoDb;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            Console.WriteLine("Connection Open  !");
            cnn.Close();

            SqlCommand command = new SqlCommand("insert into Customer(nome, address, phone, email) values(@nome, @address, @phone, @email)", cnn);
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = textNome.Text;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = textAddress.Text;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = textPhone.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = textEmail.Text;

            if (textNome.Text != "" & textAddress.Text != "" & textPhone.Text != "" & textEmail.Text != "")
            {
                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registo ok", "REGISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textNome.Text = "";
                    textAddress.Text = "";
                    textPhone.Text = "";
                    textEmail.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnn.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Registo Incompleto");
            }
            }

        private void Registo_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

