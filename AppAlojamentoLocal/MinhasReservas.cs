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
        //int idUser = Form1.
        
        public MinhasReservas()
        {
            InitializeComponent();
        }
        public MinhasReservas(string username)
        {
            InitializeComponent();
            textBox1.Text = username;
            MessageBox.Show(username);
        }

        private void MinhasReservas_Load(object sender, EventArgs e)
        {
            using (AlojamentoDbEntities4 context = new AlojamentoDbEntities4())
            {
                var reservas = context.Reservas
                                 .Where(s => s.idCustomer == 3);

                foreach (var reserva in reservas)
                {
                    this.dataGridView1.Refresh();
                    Console.WriteLine(reserva.dateReserva);
           
                }
            }
            //AlojamentoDbEntities4 entities = new AlojamentoDbEntities4();

            //using (AlojamentoDbEntities4 context = new AlojamentoDbEntities4())
            //{
            //    var queryCustomer = context.Reservas
            //                     .Where(s => s.idCustomer == Form1.User)
            //                     .FirstOrDefault<Customer>();


            //}   

            //var reserva = from p in entities.Reservas
            //              select new
            //              {
            //                  dateCheckIn = p.dateCheckIn,
            //                  dateCheckOut = p.dateCheckOut,

            //                   = p.ContactName,
            //                  aís = p.Country
            //              };
            //dataGridView1.DataSource = reserva.ToList();
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             using (var context = new AlojamentoDbEntities4())
            {
                Customer queryCustomer = context.Customers
                                   .Where(s => s.nome == "lol")
                                   .FirstOrDefault<Customer>();

                //Reserva queryReser = context.Reservas
                //                   .Where(s => s.id == queryCustomer.id)
                //                   .FirstOrDefault<Reserva>();

                Reserva reserva = new Reserva();
                {
                    //numAlojamento = queryCustomer.idAlojamento,
                    //dateReserva = queryReser.dateReserva,
                    //dateCheckIn = queryReser.dateCheckIn,
                    //dateCheckOut = queryReser.dateCheckOut,
                    //custo = queryReser.custo,
                    ////idCustomer = queryCustomer.id
                };

                dataGridView1.DataSource = reserva; 
                context.Reservas.Attach(reserva);

                //context.SaveChanges();
                Close();
            }
        }

        private void buttonActualizarRes_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    int rservID = Convert.ToInt32(textBoxReservId.Text);
            //    int clientID = Convert.ToInt32(textBoxClientID.Text);
            //    int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            //    DateTime dateIn = dateTimePickerIN.Value;
            //    DateTime dateOut = dateTimePickerOUT.Value;

            //    // date in must be = or > today date
            //    // date out must be = or > date in
            //    if (dateIn < DateTime.Now)
            //    {
            //        MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else if (dateOut < dateIn)
            //    {
            //        MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        //rservId
            //        if (reservation.editReserv(rservID, roomNumber, clientID, dateIn, dateOut))
            //        {
            //            // set the room free column to NO
            //            // you can add a message if the room is edited
            //            room.setRoomFree(roomNumber, "No");
            //            dataGridView1.DataSource = reservation.getAllReserv();
            //            MessageBox.Show("Reservation Data Updated", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Reservation NOT Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExitMinhasRes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
