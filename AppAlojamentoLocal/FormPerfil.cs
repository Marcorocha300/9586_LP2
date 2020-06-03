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
        Registo meuRegisto = new Registo();
       
        
        public FormPerfil()
        {
            InitializeComponent();
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alojamentoDbDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.alojamentoDbDataSet.Customer);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new AlojamentoDbEntities4())
            {
                Customer queryCustomer = context.Customers
                                   .Where(s => s.id ==   1) // valor estático tem de se alterar!!!!
                                   .FirstOrDefault<Customer>();

                Customer customer = new Customer()
                {
                    nome = queryCustomer.nome,
                    sobreNome = queryCustomer.sobreNome,
                    address = queryCustomer.address,
                    phone = queryCustomer.phone,
                    email = queryCustomer.email,

                };

                //context.Users.Add(customer);
                context.SaveChanges();
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 user = new Form1();
            //MessageBox.Show(user);
        }
    }
}
