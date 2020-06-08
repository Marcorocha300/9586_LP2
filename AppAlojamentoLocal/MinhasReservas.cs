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
    public partial class MinhasReservas : Form
    {
        string user;
        public MinhasReservas()
        {
            InitializeComponent();
        }
        public MinhasReservas(string userName)
        {
            InitializeComponent();
            user = userName;
            MessageBox.Show(user);
        }

        private void MinhasReservas_Load(object sender, EventArgs e)
        {
            MessageBox.Show(user);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             using (var context = new AlojamentoDbEntities3())
            {
                Customer queryCustomer = context.Customers
                                   .Where(s => s.nome == user) 
                                   .FirstOrDefault<Customer>();

                Reserva queryReser = context.Reservas
                                   .Where(s => s.id == queryCustomer.id)
                                   .FirstOrDefault<Reserva>();

                Reserva reserva = new Reserva()
                {
                    idAlojamento = queryReser.idAlojamento,
                    dateReserva = queryReser.dateReserva,
                    dateCheckIn = queryReser.dateCheckIn,
                    dateCheckOut = queryReser.dateCheckOut,
                    custo = queryReser.custo,
                    idCustomer = queryCustomer.id
                };

                dataGridView1.DataSource = reserva; 
                context.Reservas.Attach(reserva);

                //context.SaveChanges();
                Close();
            }
        }
    }
}
