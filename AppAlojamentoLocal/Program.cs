using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlojamentoLocal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            using (AlojamentoDbEntities4 context = new AlojamentoDbEntities4())
            {
                var reservas = context.Reservas
                                 .Where(s => s.idCustomer == 3);

                foreach (var reserva in reservas)
                {
                    Console.WriteLine(reserva.dateReserva);
                }
            }
                //db.Context.SaveChanges();

                //Reserva res = new Reserva();
                //List<Reserva> reservas = new List<Reserva>();

                //AlojamentoDbEntities4 entities = new AlojamentoDbEntities4();

                //var reserva = from p in entities.Reservas
                //              select new
                //             {
                //                 dateCheckIn = p.dateCheckIn,
                //                 dateCheckOut = p.dateCheckOut,
                //             };
                //foreach ( in reserva.ToList()
                // {

                // }


        }
    }   
}
