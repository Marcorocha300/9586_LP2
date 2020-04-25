using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace AlojamentoProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conection to data base
            string connetionString;
            SqlConnection cnn;
            //connetionString = @"Data Source=DJMIKEROCKS\MSSQLSERVER01;Initial Catalog=AlojamentoDb;Integrated Security=SSPI;";
            connetionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=AlojamentoDb;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            Console.WriteLine("Connection Open  !");
            cnn.Close();

          
            Customer customer = new Customer();

            //Reserva reserva = new Reserva(customer, new DateTime(2020,5,1), new DateTime(2020,5,8), Alojamento );

            Alojamento aloj1 = new Alojamento("bungalow1");
            Alojamento aloj2 = new Alojamento("bungalow2");
            Alojamento aloj3 = new Alojamento("bungalow3");
            Alojamento aloj4 = new Alojamento("bungalow4");

            List<Alojamento> alojaList= new List<Alojamento>();
            
            alojaList.Add(aloj1);
            alojaList.Add(aloj2);
            alojaList.Add(aloj3);

            
            Alojamentos alojamentos = new Alojamentos(alojaList);
            
            Reserva reserva = new Reserva(customer, new DateTime(2020,5,1), new DateTime(2020,5,8), aloj1 );
 

            alojamentos.AddAlojamento(aloj4);
           
            Console.WriteLine("Nome: " +customer.Nome + "\n"+"Morada: " + customer.Address);
            Console.WriteLine("CheckIN: "+ reserva.DateCheckin.ToString()+"\n"+"CheckOut: " + reserva.DateCheckout.ToString());

            Console.ReadKey();
        }
    }
}
 