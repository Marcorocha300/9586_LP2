using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace AppAlojamentoLocal
{
    public partial class FormFazerReserva : Form
    {
        Customer customer = new Customer();
        Alojamento alojamento = new Alojamento();
        Reserva reserva = new Reserva();
        User users = new User();
        Reserva custo = new Reserva();
        public FormFazerReserva()
        {
            InitializeComponent();
        }
        private void FormFazerReserva_Load(object sender, EventArgs e)
        {
            
        }

        private void labelcheckIn_Click(object sender, EventArgs e)
        {
        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime inDate = new DateTime();
            inDate = dateTimePicker1.Value;
            DateTime dateNow = DateTime.Today;

            int result = DateTime.Compare(inDate, dateNow);

            if (result < 0)
            {
                MessageBox.Show("Data inválida");
                dateTimePicker1.Value = dateNow;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Today;
            DateTime outDate = new DateTime();
            outDate = dateTimePicker2.Value;
            DateTime inDate = dateTimePicker1.Value;
            int result = DateTime.Compare(outDate , inDate);

            if (result <= 0)
            {
                MessageBox.Show("Data de check out tem de ser superior ao checkin");
                dateTimePicker2.Value = dateNow.AddDays(1.0);
            }
        }

        private void textBoxNumBungalow_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void butonConfirmarReserva_Click(object sender, EventArgs e)
        {
            string bnum = textBoxNumBungalow.Text;
            if (bnum != "")
            {
                using (var context = new AlojamentoDbEntities4())
                {
                    Alojamento queryAloj = context.Alojamentoes
                                       .Where(s => s.num == textBoxNumBungalow.Text)
                                       .FirstOrDefault<Alojamento>();

                    Customer queryCustomer = context.Customers
                                       .Where(s => s.id == queryAloj.id) // valor estático tem de se alterar!!!!
                                       .FirstOrDefault<Customer>();

                    Reserva reserva = new Reserva()
                    {
                        idAlojamento = queryAloj.id,
                        dateReserva = DateTime.Now,
                        dateCheckIn = dateTimePicker1.Value,
                        dateCheckOut = dateTimePicker2.Value,
                        custo = queryAloj.custoNoite,
                        idCustomer = queryCustomer.id
                    };
                    context.Reservas.Add(reserva);
                    context.SaveChanges();
                    Close();
                }
            }
            else MessageBox.Show("dados Invalidos");

         }

    }
}

