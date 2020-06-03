using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.CodeDom;
using ClassLibraryCustomer;

namespace AppAlojamentoLocal
{
    class Registo
    {

        public static string Registar(string userName, string passWord, string nome, string sobreNome, string address, string phone, string email)
        {
            //ConnectDb connect = new ConnectDb();
            //SqlCommand cmd = new SqlCommand();
            //SqlCommand cmd1 = new SqlCommand();
            //SqlCommand cmd2 = new SqlCommand();
            //string mensagem;
            //int customerId = 0;

            ////comandos sql - insert, update, delete
            //cmd.CommandText = "insert into customer (nome, sobreNome, address, phone, email) values(@nome, @sobreNome, @address, @phone, @email)";
            //cmd2.CommandText = "select id from customer where email = @email";
            //cmd1.CommandText = "insert into Users (username, passWord) values(@userName, @passWord)";

            ////parametros Customer
            //cmd.Parameters.AddWithValue("@nome", nome);
            //cmd.Parameters.AddWithValue("@sobreNome", sobreNome);
            //cmd.Parameters.AddWithValue("@address", address);
            //cmd.Parameters.AddWithValue("@phone", phone);
            //cmd.Parameters.AddWithValue("@email", email);

            //cmd2.Parameters.AddWithValue("@email", email);//add do select id from customer usando o email

            ////parametros Users
            //cmd1.Parameters.AddWithValue("@userName", userName);
            //cmd1.Parameters.AddWithValue("@passWord", passWord);

            ////connectar com a db - classe connect
            //cmd.Connection = connect.Connect();
            //cmd2.Connection = connect.Connect();
            //cmd1.Connection = connect.Connect();
            //try
            //{
            //    //cmd.Connection = connect.Connect();
            //    //cmd2.Connection = connect.Connect();
            //    //cmd1.Connection = connect.Connect();

            //    //executar
            //    cmd.ExecuteNonQuery();
            //    using (SqlDataReader reader = cmd1.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            customerId = reader.GetInt32(0);                  
            //        }
            //    }

            //    cmd1.ExecuteNonQueryAsync();

            //    //Desconectar db
            //    connect.Disconnect();

            //    //mostrar msg de erro ou sucesso
            //    mensagem = "Registo ok";
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine(e);
            //    mensagem =  e.ToString();
            //}
            using (AlojamentoDbEntities4 db = new AlojamentoDbEntities4())
            {
                using (var context = new AlojamentoDbEntities4())
                {
                    //Customer queryCustomer = context.Customer
                    //                   .Where(s => s.nome == user)
                    //                   .FirstOrDefault<Customer>();


                    Cliente customer = new Cliente(userName, passWord, nome, sobreNome, address, phone, email);
                    byte[] pass = Encoding.ASCII.GetBytes(passWord);
                    Customer newcustomer = new Customer()
                    {
                        nome = customer.Nome,
                        sobreNome = customer.Sobrenome,
                        address = customer.Address,
                        phone = customer.Phone,
                        email = customer.Email
                    };
                    context.Customers.Add(newcustomer);
                    context.SaveChanges();

                    User user = new User()
                    {
                        userName = customer.Username,
                        passWord = pass,
                        idCustomer = newcustomer.id,
                        idStaff = null
                    };
     
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            return (userName);
        }
    }
}
