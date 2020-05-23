/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using System.Configuration;

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
            SqlConnection sql = new SqlConnection();
            SqlCommand command = new SqlCommand("insert into Customer(id, nome, address, phone, email) values(@id, @nome, @address, @phone, @email", sql );

            ////Login
            //Session s = new Session();
            //s.Login();

            ////Menu
            ////if (true)
            ////{
            ////    Menu m = new Menu();
            ////    int userInput = 0;
            ////    do
            ////    {
            ////        userInput = m.DisplayMenu();
            ////    } while (userInput != 5);
            ////}

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new Nenu1());

            //Customer user = new Customer();
            //user.Nome = "tone";

            //Login log = new Login();
            //log.Close();
            //Console.WriteLine(log);



            Application.Run(new FormMenu1());
            //Application.Run(new Login());
            //Application.Run(new MenuTest());

            //Customer customer = new Customer();

            ////Reserva reserva = new Reserva(customer, new DateTime(2020,5,1), new DateTime(2020,5,8), Alojamento );

            //Alojamento aloj1 = new Alojamento("bungalow1");
            //Alojamento aloj2 = new Alojamento("bungalow2");
            //Alojamento aloj3 = new Alojamento("bungalow3");
            //Alojamento aloj4 = new Alojamento("bungalow4");

            //List<Alojamento> alojaList= new List<Alojamento>();

            //alojaList.Add(aloj1);
            //alojaList.Add(aloj2);
            //alojaList.Add(aloj3);


            //Alojamentos alojamentos = new Alojamentos(alojaList);

            //Reserva reserva = new Reserva(customer ,new DateTime(2020,5,1), new DateTime(2020,5,8), aloj1 );


            //alojamentos.AddAlojamento(aloj4);

            ////Console.WriteLine(data);

            //Console.WriteLine("Nome: " +customer.Nome + "\n"+"Morada: " + customer.Address);
            //Console.WriteLine("Data da Reserva: " + reserva.DateReserva.ToString()+ "\n"+"CheckIN: "+ reserva.DateCheckin.ToString()+"\n"+"CheckOut: " + reserva.DateCheckout.ToString());

            //using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Customer"].ConnectionString))
            //{
            //    cnn.Open();
            //    string hashedPassword = BCrypt.Net.BCrypt.HashPassword("asdsa");
            //    SqlCommand s = new SqlCommand("INSERT INTO Users(userName,passWord,idCustomer,idStaff) VALUES ('cabalo',convert(binary,'" + hashedPassword + "'),null,null)", cnn);
            //    s.ExecuteNonQuery();
            //}




            //Session sess = new Session();

            //string table = "[Users]";
            //List<string> columns = new List<string>();
            //columns.Add("*");

            //IDictionary<string, Tuple<SqlDbType, string>> filters = new Dictionary<string, Tuple<SqlDbType, string>>();

            //string query = DB.SelectBuilderSQL(table, columns, null, null);

            //foreach (IDataRecord row in DB.ExecuteSQL(sess, DB.TYPE.SELECT, query, null, null))
            //{
            //    if (row != null)
            //        Console.WriteLine(row["id"]);
            //}

            Console.ReadKey();
        }
    }
}
 