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
    public partial class FormPerfil : Form
    {
        string usernamelog;

        public FormPerfil()
        {
            InitializeComponent();

        }
        public FormPerfil(string username)
        {
            InitializeComponent();
            textBox1.Text = username;
            usernamelog = username;
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alojamentoDbDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.alojamentoDbDataSet.Customer);
            textBox1.Text = usernamelog;
            //using (var context = new AlojamentoDbEntities4())
            //{

        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                //using (var context = new AlojamentoDbEntities4())
                //{
                //    Customer queryCustomer = context.Customers
                //                       .Where(s => s.id ==   1) // valor estático tem de se alterar!!!!
                //                       .FirstOrDefault<Customer>();

                //    Customer customer = new Customer()
                //    {
                //        nome = queryCustomer.nome,
                //        sobreNome = queryCustomer.sobreNome,
                //        address = queryCustomer.address,
                //        phone = queryCustomer.phone,
                //        email = queryCustomer.email,

                //    };

                //    //context.Users.Add(customer);
                //    context.SaveChanges();
                //    Close();
                //}
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

